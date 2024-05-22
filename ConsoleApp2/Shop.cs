using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Shop
    {
        public Guid ShopId { get; set; }
        public String City { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
