using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class BusinessProduct
    {
        private List<Product> products;

        public BusinessProduct()
        {
            LoadProductsFromDataBase();
        }

        private void LoadProductsFromDataBase()
        {
            products = new List<Product>();

            products.Add(new Product("Television"));
            products.Add(new Product("Wallet"));
            products.Add(new Product("Led Lights"));
            products.Add(new Product("USB-C Cable"));
            products.Add(new Product("iPhone 12 Pro Max"));
            products.Add(new Product("PlayStation 5"));
            products.Add(new Product("Xbox S"));
            products.Add(new Product("Dualsene"));
            products.Add(new Product("Computer Keyboard"));
        }

        public List<Product> ListAllProducts()
        {
            return products;
        }

        public List<Product> AddAndReturnList(string pProductName)
        {
            products.Add(new Product(pProductName));

            return ListAllProducts();
        }

        public void JustAddProcut(string pProductName)
        {
            products.Add(new Product(pProductName));
        }
    }
}
