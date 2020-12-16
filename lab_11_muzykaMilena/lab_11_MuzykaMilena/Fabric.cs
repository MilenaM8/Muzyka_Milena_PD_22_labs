using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11_muzykaMilena
{
    public delegate void ProduceCompletely(Product p);
    public delegate void SharpAndDrill(Product p);
    

    class Fabric
    {        
        public void CompleteProduct(Product p)
        {
            ProduceCompletely MakeAllOperations;
            MakeAllOperations = TakeSizes;
            MakeAllOperations += ToCutOff;
            MakeAllOperations += ToSharp;
            MakeAllOperations += ToDrill;
            MakeAllOperations += ToThread;
            MakeAllOperations += ToPaint;
            MakeAllOperations += ToTest;
            MakeAllOperations += ToPack;
            MakeAllOperations.Invoke(p);
        }

        public void SharpAndDrill(Product p)
        {
            SharpAndDrill SharpDrill;
            SharpDrill = ToSharp;
            SharpDrill += ToDrill;
            SharpDrill.Invoke(p);
        }

        public void DisplayInfo(Product p)
        {
            Console.WriteLine("~~~ INFORMATION ~~~");
            Console.WriteLine("Sizes taken: {0}", p.SizesTaken);
            Console.WriteLine("Cut off: {0}", p.CutOff);
            Console.WriteLine("Sharpened: {0}", p.Sharpened);
            Console.WriteLine("Thread: {0}", p.Thread);
            Console.WriteLine("Drilled: {0}", p.Drilled);
            Console.WriteLine("Painted: {0}", p.Painted);
            Console.WriteLine("Tested: {0}", p.Tested);
            Console.WriteLine("Packed: {0}", p.Packed);
        }

        public void TakeSizes(Product p)
        {
            p.SizesTaken = true;
        }
        public void ToCutOff(Product p)
        {
            p.CutOff = true;
        }
        public void ToSharp(Product p)
        {
            p.Sharpened = true;
        }
        public void ToThread(Product p)
        {
            p.Thread = true;
        }
        public void ToDrill(Product p)
        {
            p.Drilled = true;
        }
        public void ToPaint(Product p)
        {
            p.Painted = true;
        }
        public void ToTest(Product p)
        {
            p.Tested = true;
        }
        public void ToPack(Product p)
        {
            p.Packed = true;
        }

    }
}
