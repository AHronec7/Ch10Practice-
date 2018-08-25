using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Car
    {
        string make;
        string model;
        int mileage;
        decimal price;

        public Car()
        {
            make = "";
            model = "";
            mileage = 0;
            price = 0;
        }

        public string Make
        {
            get { return make; }
            set    { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Mileage
        {
            get { return mileage;}
            set { mileage = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        
        

        
    }
}
