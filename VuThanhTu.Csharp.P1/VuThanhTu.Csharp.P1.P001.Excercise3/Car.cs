using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuThanhTu.Csharp.P1.P001.Excercise3
{
    public class Car
    {
        public decimal Speed { get; set; }
        public double RegularPrice { get; set; }
        public string Color { get;set; }
        public Car()
        {

        }
        public Car(decimal speed, double regularPrice, string color)
        {
            this.Speed = speed;
            this.RegularPrice = regularPrice;
            this.Color = color;
        }
        public virtual double GetSalePrice()
        {
            return (double)RegularPrice;
        }
    }
}
