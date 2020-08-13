using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint_13_Tasks.Model
{
  public  interface IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
