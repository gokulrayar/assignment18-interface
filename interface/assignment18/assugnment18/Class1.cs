using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assugnment18
{
 
    
        internal class Laptop : IConnectable, IRechargeable, IDisplayable
        {
            string Os;
            int Generation;
            int battery;

            public Laptop(string os, int generation)
            {
                Os = os;
                Generation = generation;
                this.battery = 100;
            }

            public void Charge(int minutes)
            {
                if (battery < 100)
                {
                    battery += minutes;
                    Console.WriteLine($"minutes to charging{minutes}");
                }
                else
                {
                    Console.WriteLine("Battery full");
                }

            }

            public bool Connect()
            {
                Console.WriteLine("connect as charging");
                return true;
            }

            public string Display()
            {
                return $"{Os}\t{Generation}\t{battery}";
            }
        }
}
