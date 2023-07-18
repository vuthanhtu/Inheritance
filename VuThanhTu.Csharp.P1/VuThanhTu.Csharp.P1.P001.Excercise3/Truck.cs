using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuThanhTu.Csharp.P1.P001.Excercise3
{
    public class Truck:Car
    {
        public int Weight { get; set; }
        public Truck():base() 
        {

        }
        public Truck(decimal speed,double regularPrice,string color,int weight) 
            : base(speed,regularPrice,color)
        {  
            this.Weight = weight; 
        }
        public override double GetSalePrice()
        {
            return base.GetSalePrice()*((this.Weight>2000)?0.9:0.8);
        }
    }
}
