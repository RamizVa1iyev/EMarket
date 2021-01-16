using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMarket.Business.Abstract;
using EMarket.Business.Concrete;
using EMarket.DataAccess.Abstract;
using EMarket.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace EMarket.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
            Bind<IProductService>().To<ProductManager>().InSingletonScope();

            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();

            Bind<ICartService>().To<CartManager>().InSingletonScope();
        }
    }
}
