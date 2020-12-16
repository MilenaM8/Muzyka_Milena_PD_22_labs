//Muzyka_Milena_PD-22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class iPhone : ColorScreenPhone
    {
        public override void Call()
        {
            Console.WriteLine("Well, put on your airpods and call someone :D");
        }
        public override void RingTone()
        {
            Console.WriteLine("*plays a song downloaded from the Apple Music(cool I know)*");
        }
        public override void SurfTheNet()
        {
            Console.WriteLine("We're using wi-fi and 4g. Do you want to watch something on YouTube?");
        }
    }
}
