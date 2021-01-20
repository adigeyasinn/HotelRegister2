using HotelRegister1.DataAccess.Abstract;
using HotelRegister1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HotelRegister1.DataAccess.Concrete.ADONET
{
    public class AdoHotelDal :IHotelDal
    {
        public void Add(Hotel hotel)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Books(HotelName,FeePerNight,Stars) VALUES (@HotelName,@FeePerNight,@Stars)");
            cmd.Parameters.AddWithValue("HotelName", hotel.HotelName);
            cmd.Parameters.AddWithValue("FeePerNight", hotel.FeePerNight);
            cmd.Parameters.AddWithValue("Stars", hotel.Stars);
            DBMS.SqlExecuteNonQuery(cmd);
        }

        public void Delete(Hotel hotel)
        {
            using (SqlCommand cmd =
                new SqlCommand("DELETE FROM Hotels where HotelId = @HotelId"))
            {
                cmd.Parameters.AddWithValue("HotelId",hotel.HotelId);
                DBMS.SqlExecuteNonQuery(cmd);
            }
        }

        public Hotel Get(Expression<Func<Hotel, bool>> filter)
        {
            var hotelList = new List<Hotel>();
            SqlCommand cmd = new SqlCommand("Select * from Hotels");
            

            SqlDataReader reader = DBMS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Hotel  hotel = new Hotel
                {
                    HotelId = Convert.ToInt32(reader[0]),
                    HotelName = reader[1].ToString(),
                    FeePerNight = Convert.ToDecimal(reader[2]),
                    Stars = Convert.ToInt32(reader[3])
                };

                
            }
            var list = hotelList.Where(filter.Compile()).ToList();
            return list[0];
        }

        public List<Hotel> GetAll(Expression<Func<Hotel, bool>> filter = null)
        {
            var list = new List<Hotel>();
            var cmd = new SqlCommand("Select * from Hotels");
            var reader = DBMS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                var hotel = new Hotel()
                {
                    HotelId = Convert.ToInt32(reader[0]),
                    HotelName = reader[1].ToString(),
                    FeePerNight = Convert.ToDecimal(reader[2]),
                    Stars = Convert.ToInt32(reader[3])
                };
                list.Add(hotel);
            }
            return list;
        }

    

        public void Update(Hotel hotel)
        {
            using (SqlCommand cmd =
               new SqlCommand("UPDATE Hotels set HotelName = @HotelName, FeePerNight = @FeePerNight, Stars = @Stars where HotelId = @HotelId"))
            {
                cmd.Parameters.AddWithValue("HotelId",hotel.HotelId);
                cmd.Parameters.AddWithValue("HotelName", hotel.HotelName);
                cmd.Parameters.AddWithValue("FeePerNight", hotel.FeePerNight);
                cmd.Parameters.AddWithValue("Stars", hotel.Stars);

                DBMS.SqlExecuteNonQuery(cmd);
            }
        }
    }
}
