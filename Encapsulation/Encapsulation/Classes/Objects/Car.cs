using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car
    {
        private double price;
        public string Model{ get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price {

            get => price;

            private set {
                price = value;
            }
        }

        public Car()
        {
            Price = new Random().NextDouble();
        }
    }
}
