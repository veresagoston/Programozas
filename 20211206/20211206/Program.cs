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
            //feladat13();
            //feladat14();
            //feladat15();
            //feladat16();
            //feladat17();
            //feladat18();
            //feladat19();
            //feladat20();
            feladat21();
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
            if (szam > 0)
            {
                Console.WriteLine("Pozitiv");
            }
           else if(szam==0)
            {
                Console.WriteLine("nulla");
            }
            else
            {
                Console.WriteLine("negatív");
            }
        }
        static void feladat14()
        {
            Console.WriteLine("Kérek egy egész számot!");
            int szam = int.Parse(Console.ReadLine());
            if (szam>=30)
            {
                Console.WriteLine("Nagyobb mint 30");
            }
            else 
            {
                Console.WriteLine("Kisebb mint 30");
            }
        }
        static void feladat15()
        {
            Console.WriteLine("Kérek egy egész számot!");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérek egy másik számot!");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam>szam2)
            {
                Console.WriteLine($"{szam}nagyobb mint {szam2}");
            }
            else
            {
                Console.WriteLine($"{szam2} nagyobb mint {szam}");
            }
        }
        static void feladat16()
        {
            Console.WriteLine("Kérek egy egész számot");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérek egy másik egész számot!");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam<szam2)
            {
                Console.WriteLine($"{szam} kisebb mint {szam2}");
            }
            else
            {
                Console.WriteLine($"{szam2} kisebb mint {szam}");
            }
        }
        static void feladat17()
        {
            Console.WriteLine("Kérek egy szót!");
            string szo = Console.ReadLine();
            int darab = 0;
            for (int i = 0; i < szo.Length; i++)
            {
                darab = i + 1;
            }
            Console.WriteLine($"{darab} karakterből áll.");
        }
        static void feladat18()
        {
            Console.WriteLine("Kérek egy szót");
            string szo = Console.ReadLine();
            int darab = 0;
            for (int i = 0; i < szo.Length; i++)
            {
                if (szo[i]=='e')
                {
                    darab++;
                }
            }
            Console.WriteLine($"{darab} e betű van a szóban.");
        }
        static void feladat19()
        {
            Console.WriteLine("Kérek egy szót!");
            string szo = Console.ReadLine();
            int darab = 0;
            for (int i = 0; i < szo.Length; i++)

            {
                if (szo[i] == ('a'))
                {
                    darab = darab + 1;
                    
                }
                else if (szo[i] == ('á'))
                {
                    darab = darab + 1;
                    
                }
                else if (szo[i] == ('e'))
                {
                    darab = darab + 1;
                    
                }
                else if (szo[i] == ('é'))
                {
                    darab = darab + 1;
                    
                }
                else if (szo[i] == ('o'))
                {
                    darab = darab + 1;
                    
                }
                else if (szo[i] == ('ó'))
                {
                    darab = darab + 1;
                    
                }
                else if (szo[i] == ('u'))
                {
                    darab = darab + 1;
                    
                }
                else if (szo[i] == ('ú'))
                {
                    darab = darab + 1;
                    
                }
                else if (szo[i] == ('ü'))
                {
                    darab = darab + 1;
                    
                }
                else if (szo[i] == ('ű'))
                {
                    darab = darab + 1;
                    
                }
            }
            Console.WriteLine($"{darab} magánhangzó van benne.");
        }
        static void feladat20()
        {
            Console.WriteLine("Írj be egy mondatot!");
            string mondat = Console.ReadLine();
            int darab = 0;
            for (int i = 0; i < mondat.Length; i++)
            {
                darab = darab + 1;
                
            }
            Console.WriteLine($"{darab} karakterből áll a mondat.");
        }
        static void feladat21()
        {
            Console.WriteLine("Írj be egy mondatot!");
            string mondat = Console.ReadLine();
            int darab = 0;
            for (int i = 0; i < mondat.Length; i++)
            {
                if(mondat[i]==(' '))
                {
                    darab = darab + 1;
                }
            }
            Console.WriteLine($"{darab} szóköz völt a mondatban.");
        }



    }
}
