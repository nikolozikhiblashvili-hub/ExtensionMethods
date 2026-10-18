using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace leason3.Moduls
{
    internal class Director : Person
    {
        public string Movie;

        public Director(string name, int age, string movie)
            : base(name, age)
        {
            Movie = movie;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Director");
            Console.WriteLine("სახელი: " + Name);
            Console.WriteLine("ასაკი: " + Age);
            Console.WriteLine("ფილმი: " + Movie);
        }
    }
}
