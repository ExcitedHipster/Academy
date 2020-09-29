using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    public class Cars
    {
        public Cars(int Model, string brand, int year, decimal price)
        {
            this.NumberModel = Model;
            this.Brand = brand;
            this.Year = year;
            this.Price = price;
        }
        public int NumberModel { set; get; }
        public string Brand { set; get; }
        public int Year { set; get; }
        public decimal Price{ set; get; }
    }
}
