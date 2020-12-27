using Encapsulation.Classes.Programs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bem vindos ao #Encapsulation's project#.");

            try
            {
                ProgramProduct.ExecuteProgram();
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            finally
            {
                Console.ResetColor();
            }


            Console.ReadKey();
        }
    }
}
