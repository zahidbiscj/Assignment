using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfC_Sharp
{
    class StringBuilderAndString
    {
        static void Main(string[] args)
        {
                   // String
                   
            string name = "Zahid, Ahmed,";
            Console.WriteLine(name.Replace("sw", "ah"));
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Substring(6, 5));
            Console.WriteLine(name.Remove(3,3));
            Console.WriteLine(name.Trim(','));
            //only leading ar trailing e kono char remove korte pare 
            Console.WriteLine(name.Contains("Zahid"));
            Console.WriteLine(name.EndsWith(','));
            Console.WriteLine(name.Insert(2,"has"));
            Console.WriteLine(name.IndexOf("hid"));
            Console.WriteLine(name.LastIndexOf("d"));
            Console.WriteLine(name.PadRight(15,'*'));
            Console.WriteLine(name.ToString());
            Console.WriteLine(name.StartsWith('Z'));
            string text = "Hello , you ; have a,. jksa;.";
            Console.WriteLine(text.LastIndexOfAny(new char[] { ',', '.', ';' }));


            //String Builder

            string s1 = "Ashraful";
            string s2 = " Islam"; 
            StringBuilder sb = new StringBuilder(s1);
            sb[1] = 'c';
            sb.Append(s2);
            Console.WriteLine(sb);
        }
    }
}
