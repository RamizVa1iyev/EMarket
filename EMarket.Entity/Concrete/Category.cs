using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace EMarket.Entity.Concrete
{ 
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
