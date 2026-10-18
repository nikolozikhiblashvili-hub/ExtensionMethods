using System;
using System.Collections.Generic;
using System.Text;

namespace leason3.Moduls
{
    abstract class Person
    {
       
            public string Name;
            public int Age;

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            
            public abstract void ShowInfo();
        
    }
}
