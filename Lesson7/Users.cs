using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    internal class Users
    {
        public string Name { get; set; }
        public string Password { get; set; }




        public override bool Equals(object? obj)
        {
            return Name == (obj as Users)?.Name && Password == (obj as Users)?.Password;
        }
    }
}
