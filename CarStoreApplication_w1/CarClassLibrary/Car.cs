using System;
using System.Collections.Generic;
using System.Text;

namespace CarShopGUI
{
    public class Car
    {
        public string make = "";
        public string model = "";
        public decimal price = 0;
        public string color = "";
        public int year = 2021;

        public Car()
        {

        }

        public Car(string make, string model, int year, decimal price, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.color = color;
        }

        public void setMake(string make)
        {
            this.make = make;
        }

        public string getMake()
        {
            return this.make;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public string getModel()
        {
            return this.model;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public int getYear()
        {
            return this.year;
        }

        public void setPrice(decimal price)
        {
            this.price = price;
        }

        public decimal getPrice()
        {
            return this.price;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return this.color;
        }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} {2} ${3} {4}", make, model, year, price, color);
            }
        }
    }
}
