using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Classes.Business
{
    class BusinessCar
    {
        private List<Car> cars;

        public BusinessCar()
        {
            LoadCarsFromDataBase();
        }

        private void LoadCarsFromDataBase()
        {
            cars = new List<Car>();

            cars.Add(
                new Car()
                {
                    Model = "Argo",
                    Brand = "Fiat",
                    Color = "Black",
                    //Price = "12121"
                }
            );

            cars.Add(
                 new Car()
                 {
                     Model = "Onix",
                     Brand = "Chevrolet",
                     Color = "White",
                     //Price = "12121"
                 }
             );
        }

        public List<Car> ListAllCars()
        {
            return cars;
        }

        public List<Car> AddAndReturnList(Car pCar)
        {
            cars.Add(pCar);

            return ListAllCars();
        }

        public void JustAddCar(Car pCar)
        {
            cars.Add(pCar);
        }
    }
}
