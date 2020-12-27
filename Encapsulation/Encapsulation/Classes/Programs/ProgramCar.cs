using Encapsulation.Classes.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Classes.Programs
{
    class ProgramCar
    {
        private static BusinessCar bnsCar = new BusinessCar();

        public static void ExecuteProgram()
        {
            try
            {
                string txtAux = "Inicializado programa de Carros.";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(txtAux);

                Console.ForegroundColor = ConsoleColor.Blue;
                txtAux = "Listando carros.";
                Console.WriteLine(txtAux);

                ListAllCars();

                string newCar = "Toro";
                txtAux = "Adicionando o novo carro: {0} e retornando a lista atualizada.";
                Console.WriteLine(string.Format(txtAux, newCar));
                Console.WriteLine();

                bnsCar.JustAddCar(
                    new Car(){
                        Model = newCar,
                        Brand = "FIAT",
                        Color = "Red",
                        //Price = "0000"
                    });

                ListAllCars();

                newCar = "Kombi";
                Console.WriteLine(string.Format(txtAux, newCar));
                Console.WriteLine();

                bnsCar.AddAndReturnList(
                    new Car(){
                        Model = newCar,
                        Brand = "Wolkswagem",
                        Color = "Green",
                        //Price = "0000"
                    })
                    //.Where(p => p.GetProductName() == "Kombi").ToList()
                    .ForEach(
                        (item) => {
                            PrintProductDetails(item);
                        }
                );

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Console.ResetColor();
            }
        }

        private static void ListAllCars()
        {
            bnsCar.ListAllCars().ForEach(
                (item) =>
                {
                    PrintProductDetails(item);
                }
            );
        }

        private static void PrintProductDetails(Car pCar)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            string txtModelo = $" Modelo do Carro: {pCar.Model} ";
            string txtFabricante = $" Fabricante do Carro: {pCar.Brand}";
            string txtCor = $" Cor do Carro: {pCar.Color}";
            string txtPreco = $" Preco do Carro: {pCar.Price}";
            Console.WriteLine(txtModelo);
            Console.WriteLine(txtFabricante);
            Console.WriteLine(txtCor);
            Console.WriteLine(txtPreco);
            Console.WriteLine(Environment.NewLine);
            Console.ResetColor();
        }
    }

}
