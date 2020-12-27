using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {
        private string code;
        private string name;

        /// <summary>
        /// Constructor for starting the instance with a name by parameter.
        /// </summary>
        /// <param name="pProductName"></param>
        public Product(string pProductName)
        {
            StartProduct( pProductName);
        }

        /// <summary>
        /// Constructor for overloading with no parameters.
        /// </summary>
        public Product()
        {
            code = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Start a new product by the received name.
        /// </summary>
        /// <param name="pProductName"></param>
        private void StartProduct(string pProductName)
        {
            SetProductCode();
            SetProductName(pProductName);
        }

        /// <summary>
        /// Set the product's name.
        /// </summary>
        /// <param name="pProductName"></param>
        public void SetProductName(string pProductName)
        {
            name = pProductName;
        }

        /// <summary>
        /// Gets and return the product's name.
        /// </summary>
        /// <returns></returns>
        public string GetProductName()
        {
            return name;
        }

        /// <summary>
        /// Sets the product's code.
        /// </summary>
        public void SetProductCode()
        {
            code = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Gets and returns the product's code.
        /// </summary>
        /// <returns></returns>
        public string GetProductCode()
        {
            return code;
        }
    }
}
