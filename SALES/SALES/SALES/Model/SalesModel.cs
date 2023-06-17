using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALES.Model
{
    public class SalesModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public bool Imported { get; set; }
        public string Object { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }

        public SalesModel() { }
    }
}
