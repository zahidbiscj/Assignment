using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfC_Sharp
{
    public class List
    {
        static void Main(string[] args)
        {
            string[] str = new string[10];
            str[0] = "Ashraful";
            str[1] = "Islam";
            string x = str[2];
            Console.WriteLine(x);

            List<string> list = new List<string>();
            list.Add("Ashraful");
            list.Add("Islam");
            ///string y = list[2]; //Invalid
 
            list.RemoveAt(1);
            int p = list.FindIndex(0,z => z.Equals("Ashraful"));
            list.FindIndex(p, z => z.Equals(""));

            Console.WriteLine(list.Count);
            if (list.Contains("Ashraful")) {
                Console.WriteLine("Found");
            }


            //ArrayList

            ArrayList array = new ArrayList();
            array.Add("Ashraful");
            array.Add(2.721);
            array.Add(2);
            array.Add(true);
             array.Reverse();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            var get = (bool)array[3];
            Console.WriteLine(get);

        }
    }
}
