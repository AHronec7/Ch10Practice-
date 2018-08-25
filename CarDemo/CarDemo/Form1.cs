using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Getcardata(Cars car)
        {
            int mileage;
            decimal price;
            int doors;

            //get the car make
            car.Make = MakeTextBox.Text;

            // get the car model
            car.Model = ModelTextBox.Text;

            // get the car mileage
            if (int.TryParse(MileageTextBox.Text, out mileage))
            {
                car.Mileage = mileage;

                // get the car price
                if (decimal.TryParse(PriceTextBox.Text, out price))
                {
                    car.Price = price;

                    // get the cars number of doors

                    if (int.TryParse(DoorsTextBox.Text, out doors))
                    {
                        car.Doors = doors;
                    }
                    else
                    {
                        MessageBox.Show("invalid number of doors");
                    }
                }
                else
                {
                    MessageBox.Show("invalid price");
                }
            }
            else
            {
                MessageBox.Show("invalid miles");
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Cars mcar = new Cars();
            // get the car data

            Getcardata(mcar);

            MakeLabel.Text = mcar.Make;
            ModelLabel.Text = mcar.Model;
            MileageLabel.Text = mcar.Mileage.ToString("n");
            PriceLabel.Text = mcar.Price.ToString("c");
            DoorsLabel.Text = mcar.Doors.ToString();
            
          

        }
    }
}
