using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuThanhTu.Csharp.P1.P001.Excercise3
{
    public class Sedan:Car
    {
        public int Length { get; set; }
        public Sedan() :base() { }
        public Sedan(decimal speed,double regularPrice,string color,int length)
            : base(speed, regularPrice, color)
        {
            this.Length = length;
        }
        public override double GetSalePrice()
        {
            return base.GetSalePrice()*((this.Length>20)?0.95:0.9);
        }
    }
}
