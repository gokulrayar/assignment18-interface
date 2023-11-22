using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assugnment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone s = new Smartphone("apple", 2500);
            Laptop pc = new Laptop("macbook", 11);
            Console.WriteLine($"Smartphone connect{s.Connect()}");
            Console.WriteLine($"Laptop connect{pc.Connect()}");
            s.Charge(70);
            pc.Charge(40);
            Console.WriteLine($"Smartphone info:{s.Display()}");
            Console.WriteLine($"Laptop info:{pc.Display()}");
            Console.ReadKey();
        }
    }
}
