using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Make bool, string, and int variales (with values)
            bool b1 = true;
            string s1 = "Jose";
            int i1 = 0;

            // Change their values to something else
            // CW shortcut for Console.WriteLine
            
            b1 = false;
            s1 = "Nicolas";
            i1 = 1;

            // Print their values with Console

            Console.WriteLine(b1 + s1 + i1);

            // do something in a for loop

            for(int i = 0; i <  5; i++)
            {
                Console.WriteLine(s1);
            }
            // do something in a while loop
            while(i1 < 5)
            {
                Console.WriteLine("While loop testing");
                i1++;
            }
            // do something with a switch statement
            switch(i1)
            {
                case 0:
                    Console.WriteLine("Case 0");
                    break;
                case 1:
                    Console.WriteLine("Case 1");
                    break;                
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
            }
            // do soemthing with if, else if, else

            if(i1 < 5)
            {
                Console.WriteLine("Integer is less than 5" + s1);
            }
            else if (i1 == 5) {
                Console.WriteLine("Integer is 5");
            }
            else{
                Console.WriteLine("Integer is greater than 5");
            }

            // figure out how to make multi-line comments in c#

            /* Multi-line
            Comments
            done
            like
            this */

            // figure out how to format your document in VS Code

           
            // extra: make a new static method to do something and call it
            //static int Method1 (int value){
             //   int i2 = value + 2
             //   Console.WriteLine(i2);
           // }
           // Method1(i1);

            // extra: learn what "var" means in C# and try it out.
           var x = "hi";
           Console.WriteLine(x);
        }
    }
}
