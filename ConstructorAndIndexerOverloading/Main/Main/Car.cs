using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Car
    {
        public string Brand, Number, Color;

        public Car()
        {
            this.Brand = "unknown";
            this.Number = "А000АА";
            this.Color = "white";
        }
        public Car(Car obj)
        {
            this.Brand = obj.Brand;
            this.Number = obj.Number;
            this.Color = obj.Color;
        }

        public Car(string Brand) : this()
        {
            this.Brand = Brand;
        }
        public Car(string Brand, string Number)
        {
            this.Brand = Brand;
            this.Number = Number;
            this.Color = "white";
        }
        public Car(string Brand, string Number, string Color)
        {
            this.Brand = Brand;
            this.Number = Number;
            this.Color = Color;
        }
    }
}
