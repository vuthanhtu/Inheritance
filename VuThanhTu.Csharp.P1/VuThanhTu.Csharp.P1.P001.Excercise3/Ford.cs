using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuThanhTu.Csharp.P1.P001.Excercise3
{
    public class Ford:Car
    {
        public int Year { get; set; }
        public int ManufacturerDiscount { get; set; }
        public Ford() : base()
        {

        }
        public Ford(decimal speed,double regularPrice,string color,int year,int manufacturerDiscount)
            :base(speed,regularPrice,color)
        {
            this.Year = year;
            this.ManufacturerDiscount = manufacturerDiscount;
        }
        public override double GetSalePrice()
        {
            return base.GetSalePrice() - this.ManufacturerDiscount ;
        }
    }
}
