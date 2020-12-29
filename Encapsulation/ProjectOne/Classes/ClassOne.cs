using ProjectOne.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectTwo")]
namespace ProjectOne
{
    internal class ClassOne : ClassProtected
    {
        public int PropOne { get; set; }
        public int PropTwo { get; set; }
        protected int PropThree { get; set; }
        protected int PropFour { get; set; }

        private int SumOneAndTwo()
        {
            return PropOne + PropTwo;
        }

        private int GetPropTwo()
        {
            return PropTwo;
        }

        protected int SumThreeAndFour()
        {
            PropThree = 300;
            PropFour = 400;

            return PropThree + PropFour;
        }

        public int ReturnProtectedProp()
        {
            return Props;
        }        
    }
}
