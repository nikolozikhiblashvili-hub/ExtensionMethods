using Leson2.Moduls;
using System;
using System.Text;

using System.Text;

namespace Leson2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Car car = new Car();

                car.Brand = "BMW";
                car.Model = "M5";
                car.Year = 2020;
                car.EngineVolume = 4.4;
                car.Color = Car.CarColor.Black;

                car.PrintInfo();
            
        }
    }
}
