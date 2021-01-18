using HotelRegister1.Business.Abstract;
using HotelRegister1.Business.Concrete;
using HotelRegister1.DataAccess.Abstract;
using HotelRegister1.DataAccess.Concrete.ADONET;
using HotelRegister1.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelRegister1.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {

            Bind<IHotelService>().To<HotelManager>().InSingletonScope();
            Bind<IHotelDal>().To<EfHotelDal>().InSingletonScope();
        }

        /*IOC ile bağımlılıkların en aza indirgenmesi amaçlanır.
         * Inversion of Control’ün getirdiği avantajlar;
        Bir methodun implementasyonundan izole bir şekilde çalıştırılabilmesini sağlar.
        Farklı implementasyonlar arasında, kolayca geçiş yapabilmenizi sağlar.
        Program modülerliğini artırır.
        Bağımlılıklar en aza indiği için test etmeyi/yazmayı kolaylaştırır.*/

    }
}
