using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211206
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();
            //feladat6();
            //feladat7();
            //feladat8();
            //feladat9();
            //feladat10();
            //feladat11();
            //feladat12();
            feladat13();
            Console.ReadLine();
        }
        static void feladat1()
        {
            string szoveg;
        }
        static void feladat2()
        {
            char karakter;
        }
        static void feladat3()
        {
            int szamtipus;
        }
        static void feladat4()
        {
            double valósszam;
        }
        static void feladat5()
        {
            bool logikai;
        }
        static void feladat6()
        {
            Console.WriteLine("Kérek egy szót!");
            string szo = Console.ReadLine();
            Console.WriteLine(szo);
            Console.ReadLine();
        }
        static void feladat7()
        {
            Console.WriteLine("Kérek egy mondatot!");
            string mondat = Console.ReadLine();
            Console.WriteLine(mondat);
            Console.ReadLine();
        }
        static void feladat8()
        {
            Console.WriteLine("Kérek egy karaktert!");
            char karakter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(karakter);
            Console.ReadLine();
        }
        static void feladat9()
        {
            Console.WriteLine("Kérek egy egész számot!");
            int egesz = int.Parse(Console.ReadLine());
            Console.ReadLine();
        }
        static void feladat10()
        {
            Console.WriteLine("Kérek egy valósszámot");
            Double valos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kétszerese.");
            Console.WriteLine(valos*2);
            Console.WriteLine("Pi értéke.");
            Console.WriteLine(Math.PI);
            Console.WriteLine("Harmadik hatványa.");
            Console.WriteLine(Math.Pow(valos, 3));
            Console.WriteLine("Gyökvonása.");
            Console.WriteLine(Math.Sqrt(valos));
            Console.WriteLine("Gyökvonása kettőtizedes értékre kerekítve.");
            Console.WriteLine(Math.Round(valos)); 

        }
        static void feladat11()
        {
            Random rnd = new Random();
            Console.WriteLine("A véletlenszám:");
            Console.WriteLine(rnd.Next(10,51));
            Console.ReadLine();
        }
        static void feladat12()
        {
            Console.WriteLine("Kérek egy egész számot!");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine("A szám Páros/Páratlan.");
            Console.WriteLine(szam/2);
            

        }
        static void feladat13()
        {
            Console.WriteLine("Kérek egy egész számot!");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine("Pozitiv");
            Console.WriteLine(szam>0);
            Console.WriteLine("Nulla");
            Console.WriteLine(szam=0);
            Console.WriteLine("Negativ");
            Console.WriteLine(szam<0);
        }
        
        



    }
}
