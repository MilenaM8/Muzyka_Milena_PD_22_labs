//Muzyka_Milena_PD-22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class DiskPhone
    {
         public bool calls = true;
         public int numOfDigits = 10;

        public virtual void Call()
        {
            Console.WriteLine("Hi! I'm calling using cable and disk!");
        }

        public virtual void RingTone()
        {
            Console.WriteLine("*diiing-diiing-diiing*");
        }
    }
}
