using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.WindowsFormUI.Entity
{
    public class WindowsFormCart
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short StockAmount { get; set; }
        public short Quantity { get; set; }
    }
}
