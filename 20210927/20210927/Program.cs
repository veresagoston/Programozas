using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210927
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat12();
            //feladat13();
            //feladat14();
            //feladat16();
            //feladat15();
            //ciklus1();
            //ciklus2();
            //ciklus3();
            //ciklus4();
            //ciklus5();
            //ciklus6();
            //ciklus7();
            //ciklus8();
            //ciklus9();
            ciklus10();

            Console.ReadLine();
        }
        static void feladat12()
        {
            Console.WriteLine("Kérek egy számot 1-12-ig");
            int szam = Convert.ToInt32(Console.ReadLine());
            switch (szam)
            {
                case 1:
                    Console.WriteLine("Január");
                    break;
                case 2:
                    Console.WriteLine("Február");
                    break;
                case 3:
                    Console.WriteLine("Március");
                    break;
                case 4:
                    Console.WriteLine("Április");
                    break;
                case 5:
                    Console.WriteLine("Május");
                    break;
                case 6:
                    Console.WriteLine("Június");
                    break;
                case 7:
                    Console.WriteLine("Július");
                    break;
                case 8:
                    Console.WriteLine("Augusztus");
                    break;
                case 9:
                    Console.WriteLine("Szeptember");
                    break;
                case 10:
                    Console.WriteLine("Október");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Rossz számot adtál meg");
                    break;

            }
        }
        static void feladat13()
        {
            Console.WriteLine("Kérek egy számot 1-12-ig");
            int szam = Convert.ToInt32(Console.ReadLine());
            int honap = szam;
            switch (honap)
            {
                case 1:
                    Console.WriteLine("Tél");
                    break;
                case 2:
                    Console.WriteLine("Tél");
                    break;
                case 3:
                    Console.WriteLine("Tavasz");
                    break;
                case 4:
                    Console.WriteLine("Tavasz");
                    break;
                case 5:
                    Console.WriteLine("Tavasz");
                    break;
                case 6:
                    Console.WriteLine("Nyár");
                    break;
                case 7:
                    Console.WriteLine("Nyár");
                    break;
                case 8:
                    Console.WriteLine("Nyár");
                    break;
                case 9:
                    Console.WriteLine("Ősz");
                    break;
                case 10:
                    Console.WriteLine("Ősz");
                    break;
                case 11:
                    Console.WriteLine("Ősz");
                    break;
                case 12:
                    Console.WriteLine("Tél");
                    break;
                default:
                    Console.WriteLine("Rossz számot adtál meg");
                    break;
            }
        }
        static void feladat14()
        {
            Console.WriteLine("Kérek egy számot ");
            long szam = Convert.ToInt64(Console.ReadLine());
            while (szam > 2000000000)
            {
                Console.WriteLine("Nem jó számot adtál meg");
                Console.WriteLine("Kérek egy számot ");
                szam = Convert.ToInt64(Console.ReadLine());
            }

            switch (Convert.ToString(szam).Length)
            {
                case 1:
                    Console.WriteLine("egyjegyű");
                    break;
                case 2:
                    Console.WriteLine("kétjegyű");
                    break;
                case 3:
                    Console.WriteLine("háromjegyű");
                    break;
                case 4:
                    Console.WriteLine("Négyjegyű");
                    break;
                case 5:
                    Console.WriteLine("őtjegyű");
                    break;
                case 6:
                    Console.WriteLine("hat vagy többjegyű");
                    break;
            }
        }
        static void feladat16()
        {
            Console.WriteLine("Kérek egy osztályzatot");
            int szam = Convert.ToInt32(Console.ReadLine());
            while (szam > 5)
            {
                Console.WriteLine("Nemlétező érdemjegyet adtál meg");
                Console.WriteLine("Kérek egy osztályzatot ");
                szam = Convert.ToInt32(Console.ReadLine());
            }
            switch (szam)
            {
                case 1:
                    Console.WriteLine("Elégtelen");
                    break;
                case 2:
                    Console.WriteLine("Elégséges");
                    break;
                case 3:
                    Console.WriteLine("Közepes");
                    break;
                case 4:
                    Console.WriteLine("Jó");
                    break;
                case 5:
                    Console.WriteLine("Jeles");
                    break;
            }
        }
        static void feladat15()
        {
            Console.WriteLine("Kérek egy osztályzatot");
            double szam = Convert.ToDouble(Console.ReadLine());
            if (szam > 1.49 && szam <= 5)
            {
                Console.WriteLine("Átment");
            }
            else if (szam > 5)
            {
                Console.WriteLine("Nem létező osztályzatot adtál meg");
            }
            else
            {
                Console.WriteLine("Nem ment át");
            }
        }
        static void ciklus1()
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 20; i++)
            {
                Console.Write(i + " ");
            }
        }
        static void ciklus2()
        {
            for (int i = 15; i <= 92; i++)
            {
                Console.Write(i + " ");
            }
        }
        static void ciklus3()
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");


                }

            }
            Console.WriteLine();
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);


                }

            }


        }
        static void ciklus4()
        {
            Console.WriteLine("Kérek egy pozítiv egész számot");
            int szam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= szam; i++)
            {
                Console.Write(i + " ");
            }
        }
        static void ciklus5()
        {
            Console.WriteLine("Kérek egy pozítiv egész számot");
            int szam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= szam; i++)
            {
                Console.WriteLine();
            }
        }
        static void ciklus6()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
        }
        static void ciklus7()
        {
            for (int i = 100; i <= 400; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }

            }



        }
        static void ciklus8()
        {
            for (int i = 30; i <= 100; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void ciklus9()
        {
            for (int i = 150; i >= 40;)
            {
                Console.WriteLine(i);
                i = i - 12;
            }
        }
        static void ciklus10()
        {
            for (double i = 100; i >= -100;)
            {
                
                if (i%9==0)
                {
                    Console.WriteLine(i);
                    
                }
                i = i - 1;
            }
        }
    }
}
