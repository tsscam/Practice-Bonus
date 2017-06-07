using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventoryBonus18
{
    class Car
    {   
        //identifiers of the Car object
        private string make;
        private string model;
        private int year;
        private double price;

        //Properties of the Car class with Getters & Setters.....
        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        //this constructor initiates a value for each property
        public Car()
        {
            make = "";
            model = "";
            year = 0;
            price = 0.0;


        }

        //this constructor enables the user to input the value of the property
        public Car(string CarMake, string CarModel, int CarYear, double CarPrice)
        {
            make = CarMake;
            model = CarModel;
            year = CarYear;
            price = CarPrice;
        }
    }
}
