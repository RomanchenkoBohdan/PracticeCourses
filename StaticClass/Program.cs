using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Config.Path = "test.txt";

            var tesla = new Car() { Name = "Model S", Price = 65000, Count = 137 };
            var ford = new Car() { Name = "Model T", Price = 165000, Count = 3 };
            var BMW = new Car() { Name = "M 7", Price = 105000, Count = 33 };

            List<Car> listCars = new List<Car>() { tesla, ford, BMW };

            //string jsonCar = JsonConvert.SerializeObject(listCars);

            //Config.Text = jsonCar;
            //Config.WriteLine();

            ////////////////////////////////////////

            var newResource = JsonConvert.DeserializeObject<Car>(Config.ReadLine());
            
            Car audi = newResource;
            audi.Name = "RS 6";
            audi.Price = 63000;
            audi.Count = 64;

            listCars.Add(audi);
            
            foreach (var item in listCars)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
