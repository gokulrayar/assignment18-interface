using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assugnment18
{
   
    
        internal class Smartphone : IConnectable, IRechargeable, IDisplayable
        {

            string model;
            int Rate;
            int battery;

            public Smartphone(string model, int rate)
            {
                this.model = model;
                this.Rate = rate;
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
                return $"{model}\t{Rate}\t{battery}";
            }
        }

    
}
