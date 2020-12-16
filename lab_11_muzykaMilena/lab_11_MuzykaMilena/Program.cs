using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11_muzykaMilena
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK #1
            Product prod = new Product();

            Fabric fabric = new Fabric();


            fabric.SharpAndDrill(prod);
            fabric.DisplayInfo(prod);
            Console.WriteLine();
            fabric.CompleteProduct(prod);
            fabric.DisplayInfo(prod);

            //TASK #2
            List<Muzyka> pd22Group = new List<Muzyka>();

            pd22Group.Add(new Student("Marta", "Xmel", 16));
            pd22Group.Add(new Student("Daniel", "Bilodid", 21));
            pd22Group.Add(new Student("Dana", "Prokopets", 19));
            pd22Group.Add(new Student("Dima", "Vdovin", 23));
            pd22Group.Add(new Student("Vlad", "Osymak", 17));
            pd22Group.Add(new Student("Valera", "Bilous", 18));
            pd22Group.Add(new Student("Artem", "Iluchenko", 24));
            pd22Group.Add(new Student("Vitalik", "Woloshyn", 15));
            pd22Group.Add(new Student("Edik", "Petrenko", 13));
            pd22Group.Add(new Student("Bohdan", "Student", 44));

            
            List<Muzyka> adults = new List<Muzyka>();
            StudentPredicateDelegate spd;

            //task 8
            Console.WriteLine("\nONLY ADULT PEOPLE HERE");
            spd = Student.Adult;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            Console.WriteLine("\nSTUDENTS WHO HAVE 'A' AS THE FIRST LETTER IN FIRS NAME");
            spd = Student.FirstSymbolIsA;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            Console.WriteLine("\nSTUDENTS WHO HAVE LAST NAME LONGER THAN 3 SYMBOLS ");
            spd = Student.LongLastName;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            //using anonymous methods - task 9
            Console.WriteLine("\n\nHERE I USE ANONIMOUS METHODS");
            Console.WriteLine("\nADULTS");
            spd = student => student.Age >= 18 ? true : false;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            Console.WriteLine("\nFIRST LETTER IS 'A'");
            spd = student => student.FirstName[0] == 'A' ? true : false;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            Console.WriteLine("\nLAST NAME > 3");
            spd = student => student.LastName.Length > 3 ? true : false;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();


            //task 10 - finding students among 20 and 25 y.o.
            Console.WriteLine("\n\nGRANDFATHERS 20 - 25 YEARS OLD");
            spd = student => student.Age > 20 && student.Age < 25 ? true : false;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            //task 11
            Console.WriteLine("\nWE'RE FINDING ANDREW HERE");
            spd = student => student.FirstName == "Andrew" ? true : false;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

            //task 12
            Console.WriteLine("\nWHERE IS THE TROELSEN???");
            spd = student => student.LastName == "Troelsen" ? true : false;
            adults = pd22Group.FindStudent(spd);
            adults.DisplayList();

        }
    }
}
