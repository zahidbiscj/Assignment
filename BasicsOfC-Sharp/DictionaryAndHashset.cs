using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfC_Sharp
{
    class DictionaryAndHashset
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();

            d["Ashraful"] = 23;
            d["sabbir"] = 22;
            d["Farhan"] = 23;

            Console.WriteLine(d["sabbir"]);

            foreach (var item in d)
            {
                Console.WriteLine(item.Key + " - "+item.Value);
            }

            HashSet<string> h = new HashSet<string>();

            h.Add("hello");
            h.Add("hello");
            if (!h.Contains("hello")) { h.Add("hello"); }

            Console.WriteLine(h.Count);
            
        }
    }
}
