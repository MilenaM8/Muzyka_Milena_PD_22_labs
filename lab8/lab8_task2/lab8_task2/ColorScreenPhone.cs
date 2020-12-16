//Muzyka_Milena_PD-22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class ColorScreenPhone : BlackWhitePhone
    {
        public bool wifi = true;
        public override void Call()
        {
            Console.WriteLine("Yeap! I’m calling the one you click on.");
        }
        public override void RingTone()
        {
            Console.WriteLine("*plays a song downloaded from the Internet*");
        }
        public virtual void SurfTheNet()
        {
            Console.WriteLine("He-hey, wazap? I can surf the internet using wi-fi");
        }

    }
}
