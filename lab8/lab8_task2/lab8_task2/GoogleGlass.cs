//Muzyka_Milena_PD-22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class GoogleGlass : ColorScreenPhone
    {
        public int lenses = 2;

        public override void Call()
        {
            Console.WriteLine("Just say \"Ok, Glass, let's call to this fool\".\n Easy-breezy!");
        }
        public override void RingTone()
        {
            Console.WriteLine("R u kidding me? Im the glass, how can I play something??? What? Sounds through vibrations? K, guys!");
        }
        public override void SurfTheNet()
        {
            Console.WriteLine("Yeah, you have a browser right in front of you!");
        }

    }
}
