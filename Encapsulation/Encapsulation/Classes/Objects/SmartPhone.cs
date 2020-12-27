using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class SmartPhone
    {
        string name;
        string model;
        string color;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public string Color
        {
            get => color;
            set { color = value; }
        }
    }
}
