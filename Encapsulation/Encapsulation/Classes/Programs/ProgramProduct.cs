using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Classes.Programs
{
    public class ProgramProduct
    {
        private static BusinessProduct bnsProduct = new BusinessProduct();

        public static void ExecuteProgram()
        {
            try
            {
                string txtAux = "Inicializado programa de Produtos.";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(txtAux);

                Console.ForegroundColor = ConsoleColor.Blue;
                txtAux = "Listando produtos.";
                Console.WriteLine(txtAux);

                ListAllProducts();

                string newProduct = "Geladeira";

                txtAux = "Adicionando o novo produto: {0} e retornando a lista atualizada.";
                Console.WriteLine(string.Format(txtAux, newProduct));
                Console.WriteLine();

                bnsProduct.JustAddProcut(newProduct);

                ListAllProducts();

                newProduct = "Perfum";
                Console.WriteLine(string.Format(txtAux, newProduct));
                Console.WriteLine();

                bnsProduct.AddAndReturnList(newProduct)
                    //.Where(p => p.GetProductName() == "Geladeira").ToList()
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

        private static void ListAllProducts()
        {
            bnsProduct.ListAllProducts().ForEach(
                (item) =>
                {
                    PrintProductDetails(item);
                }
            );
        }

        private static void PrintProductDetails(Product pProduct)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            string txtCodigo = $" Código do Produto: {pProduct.GetProductCode()} ";
            string txtNome = $" Nome do Produto: {pProduct.GetProductName()}";
            Console.WriteLine(txtCodigo);
            Console.WriteLine(txtNome.PadRight(txtCodigo.Length, ' '));
            Console.WriteLine(string.Empty.PadLeft(txtCodigo.Length, ' '));

            Console.ResetColor();
        }
    }
}
