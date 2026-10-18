using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace leason3.Moduls
{
    internal class Producer : Person
    {
        public string Company;

        public Producer(string name, int age, string company)
            : base(name, age)
        {
            Company = company;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Producer");
            Console.WriteLine("სახელი: " + Name);
            Console.WriteLine("ასაკი: " + Age);
            Console.WriteLine("კომპანია: " + Company);
        }
    }
}
