using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays();
            Lists();
        }

        static void Arrays()
        {
            int[] Array1 = new int[4];
            Array1[0] = 3;
            Array1[1] = 5;

            int[] Array2 = new int [] { 1, 2, 3, 4, 12};
            string input = Console.ReadLine();
            int length = int.Parse(input);
            int[] array3 = new int (length);


        }

        static void Lists(){
            ArrayList list = new ArrayList();
            list.Add(3);
            list.Add(3.1);

            Console.WriteLine(list[0]);

            //int number = list[0]; //unsafe since the type of the items in arraylist is Object, it is not specified
            int number = (int)list[0]; //safe way since we are type casting.

            Lists<int> intList = new Lists<int>();
            list.Add(1);
            int num = list[0];

        }

        static void OtherCollections()
        {
            var set = new HashSet<string> { "a", "b", "a"};
            Console.WriteLine(setCount);

            var dict = new Dictionary<int, int>
            {
                [1] = 1;
                [3] = 2;
                [2] = 3;
                [10] = 100;
    
            };
            var hundred = dict[10];
            var dict2 = new Dictionary<string,string>
            {
                ["abc"] = "def"
                ["def"] = "qwe"
            };
            var qwe = dict2["def"];
        }
    }
}
