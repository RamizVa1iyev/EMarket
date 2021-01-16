using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Concrete.EntityFramework;
using EMarket.DataAccess.Abstract;
using EMarket.DataAccess.Concrete.EntityFramework.Contexts;
using EMarket.Entity.Concrete;

namespace EMarket.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,EMarketContext>,ICategoryDal
    {
        
    }
}
