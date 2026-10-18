using System;
using System.Collections.Generic;
using System.Text;

namespace Leson2.Moduls;

internal class Car
{

    public string Brand { get; set; }
    public string Model { get; set; }

    

    public int _year;
    public int Year
    {
        get { return _year; }
        set
        {
            if (value < 0 )
            {
               Console.WriteLine("Year must be between 1886 and the current year.");
            }
            else
            {
                _year = value;
            }
        }

    }

    public double _engineVolume;

    public double EngineVolume
    {
        get { return _engineVolume; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Engine volume is not valid");
            }
            else
            {
                _engineVolume = value;
            }
        }
    }
    
    public CarColor Color { get; set; }

    public enum CarColor
    {
        Red,
        Blue,
        Green,
        Black,
        White
    }
   public void SetYear(int year)
    {
       int currentYear = DateTime.Now.Year;
        Console.WriteLine("car currentYear" + currentYear);
        
       
    }
    public void PrintInfo()
    {
        Console.WriteLine("ბრენდი: " + Brand);
        Console.WriteLine("მოდელი: " + Model);
        Console.WriteLine("წლოვანება: " + _year);
        Console.WriteLine("ძრავის მოცულობა: " + EngineVolume + " ლ");
        Console.WriteLine("ფერი: " + Color);
        Console.WriteLine("გამოშვების წელი: " + Year);
    }

    public override string ToString()
    {
        return $"ბრენდი: {Brand}, მოდელი: {Model}, წლოვანება: {_year}, ძრავის მოცულობა: {EngineVolume} ლ, ფერი: {Color}, გამოშვების წელი: {Year}";
    }

}
