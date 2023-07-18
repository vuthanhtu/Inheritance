using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuThanhTu.Csharp.P1.P001.Excercise3
{
    public class MyOwnAutoShop
    {
        static void Main(string[] args)
        {
            
            Car car = new Car(150.5m,480000d,"red");
            Console.Write("Car Get Sale Price: ");
            Console.WriteLine(car.GetSalePrice());
            Truck truck = new Truck(130m, 350000d, "blue", 3000);
            Console.Write("Truck Get Sale Price: ");
            Console.WriteLine(truck.GetSalePrice());
            Ford ford = new Ford(120m, 320000d, "green", 10, 15000);
            Console.WriteLine($"Ford Get Sale Price: {ford.GetSalePrice()}");
            Sedan sedan = new Sedan(110m, 150000d, "yellow", 25);
            Console.WriteLine("Sedan Get Sale Price: {0}",sedan.GetSalePrice());
        }
    }
}
