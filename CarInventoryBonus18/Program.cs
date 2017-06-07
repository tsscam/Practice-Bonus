using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventoryBonus18
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            

            //Message displayed to user
            Console.WriteLine("Enter the Make of the Vehicle : ");
            //Converts the user input into a string
            string CarMake = Console.ReadLine();

            Console.WriteLine("Enter the Model of the Vehicle : ");
            string CarModel = Console.ReadLine();

            Console.WriteLine("Enter the Year of the Vehicle : ");
            string CarYear = Console.ReadLine();

            Console.WriteLine("Enter the Price of the Vehicle : ");
            string CarPrice = (Console.ReadLine());



            //Converts the String by Parsing the data and returning a double and storing in the object.
            Car1.Make = CarMake;
            Car1.Model = CarModel;
            Car1.Year = int.Parse(CarYear);
            Car1.Price = Double.Parse(CarPrice);

            //Moved from here to the bottom, to display the inputed info and the Current List
            //Console.WriteLine("The Car You Chose is {0}, {1}, {2}, {3}.", Car1.Make, Car1.Model, Car1.Year, Car1.Price);

            //Created List for CARS added in and what is to be added
            List<Car> CarList = new List<Car>();
            
            //Code used to ADD new CARS to the LIST
            CarList.Add(Car1);

            //Adding a CAR "Ford, Escort, 2012, 65000" to the list
            CarList.Add(new Car("Ford", "Escort", 2012, 65000));

            //for (int i = 0; i < CarList.Count; i++)
            //{
            //    Console.WriteLine(CarList[i]);
            //}
            //Used a foreach to display the NewCars in the Carlist
            foreach (var NewCar in CarList)
            {
                Console.WriteLine("The Inventory shows {0}, {1}, {2}, {3}.", NewCar.Make, NewCar.Model, NewCar.Year, NewCar.Price);

            }
        }
    }
}