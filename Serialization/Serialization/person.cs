using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    //This is called a POCO (plained old clr object)
    //Its just a class with just get-set properties and a default constructor
    //A lot of frameworks like to work on POCO's
    //AKA "DTO": Data transfer Object. Used specifically for deserialization.
    class person
    {
        []
        //prop tab tab for quick properties
        public int id { get; set; }
        public string Name { get; set; }
        //control and click on Address to take me to the file where the class is Address is being defined
        public Address Address { get; set; }
    }
}
