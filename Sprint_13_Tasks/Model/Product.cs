using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint_13_Tasks.Model
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get ; set ; }

        public Product() { }
    }
}
