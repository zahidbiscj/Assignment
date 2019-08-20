using System;
using Engineering;

namespace BasicsOfC_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // For namespace call 
            Namespace n = new Namespace();
            n.Employee();

            //For Struct vs class Example 
            StructVsClass sc = new StructVsClass();
            sc.Implement();

            // For Explicit and Implicit 
            int x; double y; short s; // Explicit variable
            //Implicit 
            var a = 3.5m;
            var b = "Zahid";
            var c = new { FirstName = "zahid", Age = 21 };


            // Anonymous type
            var Person = new
            {
                FirstName = "Mansur",
                LastName = "Ahmed"
            };
            Console.WriteLine("Name = {0} ",Person.FirstName+Person.LastName);

            // Dynamic 
            dynamic something = 100;
            something = "Ahmed";
            something = 2.9m;
            something = new { Name = "Emon", Age = 23 };

            // Abstract class And Interface 
            var cart = new ShoppingCart();
            for (int i = 0; i < cart.items.Length; i++)
            {
                Console.WriteLine(cart.items[i]);
            }

            //Operators
            int xo = 1, yo = 2;
            int zo = xo % yo;
            zo = xo << yo;
            zo = xo >> yo;
            zo = xo & yo;
            zo = xo | yo;
            bool joy = true;
            zo = xo ^ yo;
            joy = !true;
            string zoo = "za";
            string ss= (zoo==null) ? "yes":"no";

            //Switch case 
           string name = "no";

            switch(name) {
                case "yes":
                    Console.WriteLine("yes found");
                    break;
                case "no":
                    Console.WriteLine("no found");
                    break;
                default:
                    Console.WriteLine("No match");
                    break;
            }

            //for and foreach loop 
            for (int i = 0; i < 5; i++)
            {
                if (i == 2) { continue; }
                Console.WriteLine(i);   
            }
            string[] names = new string[10];
            
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }

            //property
            Property prop = new Property();
            prop.setName("");


            //Array with Debugging

            double[] ages = new double[16];
            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = double.Parse(Console.ReadLine());
            }



        }
    }
}
