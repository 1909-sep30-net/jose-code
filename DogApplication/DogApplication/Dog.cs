using System;
using System.Collections.Generic;
using System.Text;

namespace DogApplication
{
    internal class Dog
    {
        public Dog(string name, int age)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            this.name = name;
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("age");
            }
            this.age = age;
        }

        public string name;
        public int age;

    }
}
