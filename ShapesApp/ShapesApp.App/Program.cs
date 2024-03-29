﻿using System;
using ShapesApp.Library;

namespace ShapesApp.App
{
    public static class Program
    {
        static void Main(string[] args)
        {

            double length;
            string input;
            do
            {
                Console.WriteLine("Enter a length:");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out length));
            double width;
            do
            {
                Console.WriteLine("Enter a width:");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out width));

            //Property initializer way of setting Length and Width. Similar to collection initializer.

            var r = new Rectangle()
            {
                Length = length,
                Width = width
            };
            //r.Length = length;
            //r.Width = width;

            // C# has something called "out" parameters
            // an out parameter cannot have a value before you pass it
            // the method gets that exact variable and fills in its value
            PrintRectangle(r);
        }

        //extension method
        // this are used very frequently with a library called LINQ
        public static void PrintRectangle(this Rectangle r)
        {
           Console.WriteLine("rectangle");
        }

        public static int Triple(this int number)
        {
            return 3 * number;
        }

        // we're not using this method, but if we didn't have double.TryParse,
        // this is how we would write it.
        static bool TryParse(string input, out double result)
        {
            try
            {
                result = double.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                result = 0;
                return false;
            }
        }
    }
}