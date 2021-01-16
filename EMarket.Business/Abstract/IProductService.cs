using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMarket.Entity.Concrete;

namespace EMarket.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByName(string name);
        List<Product> GetByCategoryId(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
