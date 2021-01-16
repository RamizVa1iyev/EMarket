using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity.Abstract;
using EMarket.Entity.Concrete;

namespace EMarket.Entity.Domain_Models
{
    public class CartItem:IDomainModel
    {
        public Product Product { get; set; }
        public short Quantity { get; set; }
    }
}
