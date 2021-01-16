using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Abstract;
using EMarket.Entity.Concrete;

namespace EMarket.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
       
    }
}
