//Muzyka_Milena_PD-22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class BlackWhitePhone : ButtonPhone
    {
        public bool display = true;
        public override void Call()
        {
            Console.WriteLine("Hi-hi! Personally I can call to someone using display!");
        }

        public override void RingTone()
        {
            Console.WriteLine("*plays Nokia 3310 ringtone*");
        }
    }
}
