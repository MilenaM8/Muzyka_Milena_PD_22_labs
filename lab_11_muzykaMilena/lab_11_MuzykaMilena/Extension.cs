using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11_muzykaMilena
{
    static class Extension
    {
        public static List<Muzyka> FindMuzyka(this List<Muzyka> list, MuzykaPredicateDelegate spd)
        {
            List<Muzyka> reqList = new List<Muzyka>();
            foreach (Muzyka st in list)
            {
                if (spd.Invoke(st))
                    reqList.Add(st);
            }
            return reqList;
        }

        public static void DisplayList(this List<Muzyka> list)
        {
            Console.WriteLine("~~~ INFORMATION ~~~");

            foreach (Muzyka st in list)
            {
                Console.WriteLine("First Name: {0}", st.FirstName);
                Console.WriteLine("Last Name: {0}", st.LastName);
                Console.WriteLine("Age: {0}", st.Age);
            }
        }
    }
}
