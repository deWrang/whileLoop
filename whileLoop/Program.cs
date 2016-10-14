using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning1
            /*
            int n = 1;

            while (n++<=100)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
            */
            //Övning2
            /*
            string s = "";
            while (s != "password")
            {
                
                Console.WriteLine("Skriv in lösenord: ");
                s = Console.ReadLine();
            }
            Console.WriteLine("korrekt lösenord! ");
            Console.ReadKey();
            */
            //Övning1:2
            /*
            int n = 1;

            while (n++ <= 100)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
            */
            //Övning2:2
            /*
            int n = 10;

            while (n-- >= 0)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
            */
            //Övning3:2
            /*
            int n = 0;
            while (true)
            {
                Console.WriteLine(n = n + 1);
            }
            */
            //Övning4:2
            /*
            Console.WriteLine("Gissa ett tal mellan 1 och 100: ");

            var x = int.Parse(Console.ReadLine());
            var tal = 42;
            var z = 0;
            while (x != tal)
            {
                Console.WriteLine("Gissa igen");
                if (x < tal)
                {
                    Console.WriteLine("För lågt");

                }
                else if (x > tal)
                {
                    Console.WriteLine("För stort");
                }
                    
            
                   x = int.Parse(Console.ReadLine());
                   z++;
            }
            
            Console.WriteLine("Rätt tal!!!!!!!!!");
            Console.WriteLine(z + " Gissningar");
            Console.ReadKey();
            */
            //Övning5:2
            /*
           
            int fib = 1;
            int fib2 = 0;
            
            
                
                while(fib <=1346269 )
                
                {

                    Console.WriteLine(fib);
                    fib += fib2;
                    fib2 = fib - fib2;

                }
            Console.ReadKey();
            */
            //Övning2:6
            Console.WriteLine("Ange saldo (Kr): ");
            var saldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ränta (%): ");
            var ränta = int.Parse(Console.ReadLine());
            Console.WriteLine("Slutmål (Kr)");
            var slutmål = int.Parse(Console.ReadLine());

            while ()

                Console.ReadKey();
        }
    }
}
