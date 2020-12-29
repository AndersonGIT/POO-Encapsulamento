using ProjectOne.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClassOne one = new ClassOne();

            one.PropOne = 100;
            one.PropTwo = 200;

            one.ReturnProtectedProp();
        }
    }
}
