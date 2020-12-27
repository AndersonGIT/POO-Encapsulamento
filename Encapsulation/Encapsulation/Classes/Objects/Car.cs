using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car
    {
        private string price;
        public string Model{ get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Price {

            get => price;

            private set {
                price = value;
            }
        }
    }
}
