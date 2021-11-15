using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210920
{
    class Program
    {

        static void feladat1()
        {
            Console.WriteLine("1. feladat");
            Console.WriteLine();
            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {

                Console.WriteLine("A szám páros!");

            }
            else
            {

                Console.WriteLine("A szám páratlam!");

            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void feladat2()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine();

            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {

                Console.WriteLine("A szám negatív!");

            }
            else if (a == 0)
            {

                Console.WriteLine("A szám eggyenlő 0-val");

            }
            else
            {

                Console.WriteLine("a szám pozitív!");

            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void feladat3()
        {
            Console.WriteLine("3. feladat");
            Console.WriteLine();
            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {

                Console.WriteLine("Odakint fagy van!");

            }
            else if (a == 0)
            {

                Console.WriteLine("Fagypont van");

            }
            else
            {

                Console.WriteLine("Nincs fagy odakint");

            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void feladat4()
        {
            Console.WriteLine("4. feladat");
            Console.WriteLine();
            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 40 && a > -30)
            {

                Console.WriteLine("a szám -30 és 40 között van!");

            }
            else
            {

                Console.WriteLine("A szám kívül esik a -30 és 40-es inter vallumon!");

            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void feladat5()
        {
            Console.WriteLine("5. feladat");
            Console.WriteLine();
            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 16)
            {

                a = a * 10;
                Console.WriteLine(a);

            }
            else if (a >= 16)
            {

                a = a / 3;
                Console.WriteLine(a);

            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void feladat6()
        {
            Console.WriteLine("6. feladat");
            Console.WriteLine();
            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 10 && a < 20)
            {

                Console.WriteLine("tizesek");

            }
            else if (a > 20 && a <30)
            {

                Console.WriteLine("huszasok");

            }
            else if (a > 30 && a < 40)
            {

                Console.WriteLine("harmincasok");

            }
            else if (a > 40 && a < 50)
            {

                Console.WriteLine("negyvenesek");

            }
            else if (a < 10 )
            {

                Console.WriteLine("a szám nem tartozik bele a 10-50-es intervallumba");

            }
            else if (a > 50)
            {

                Console.WriteLine("a szám nem tartozik bele a 10-50-es intervallumba");

            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void feladat7()
        {
            Console.WriteLine("7. feladat");
            Console.WriteLine();
            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 12 && a < 25 && a % 2 == 0)
            {

                Console.WriteLine(a);

            }
            else
            {

                Console.WriteLine("A szám nem osztható 2-vel vagy nincs benne a 12-25-ös intervallumban!");

            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void feladat8()
        {
            Console.WriteLine("8. feladat");
            Console.WriteLine();
            Console.WriteLine("kérem a víz hőmérsékletét");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {

                Console.WriteLine("a víz szilárd halmazállapotú");

            }
            else if (a >= 0)
            {

                a = a / 3;
                Console.WriteLine("a víz folyékony halmazállapotú!");

            }
            else if (a > 100)
            {

                Console.WriteLine("a víz légnemü halmazállapotú!");

            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void feladat9()
        {

            Console.WriteLine("9. feladat");
            Console.WriteLine();
            Console.WriteLine("kérem a számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0 && a % 4 == 0 && a % 9 == 0)
            {

                Console.WriteLine("a szám 3-mal, 9-el és 4-el osztható");

            }
            else if ( a % 9 == 0 && a % 4 == 0)
            {

                Console.WriteLine("a szám 4-el, és 9-el osztható");

            }
            else if (a % 3 == 0 && a % 9 == 0)
            {

                Console.WriteLine("a szám 3-mal és 9-el osztható");

            }
            else if (a % 3 == 0 && a % 4 == 0)
            {

                Console.WriteLine("a szám 3-mal és 4-el osztható");

            }
            else if (a % 4 == 0)
            {

                Console.WriteLine("a szám 4-el osztható");

            }
            else if (a % 9 == 0)
            {

                Console.WriteLine("a szám 9-el osztható");

            }
            else if (a % 3 == 0)
            {

                Console.WriteLine("a szám 3-mal osztható");

            }
            else
            {

                Console.WriteLine("ez a szám sem 3-mal sem 4-el, sem pedig 9-el nem osztható!");

            }
            Console.WriteLine();
            Console.WriteLine();

        }

        static void feladat10()
        {

            Console.WriteLine("10. feladat");
            Console.WriteLine();
            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 4 == 0)
            {

                Console.WriteLine("A {0} év szökőév", a);

            }
            else
            {

                Console.WriteLine("A {0} nem szökőév", a);

            }
            Console.WriteLine();
            Console.WriteLine();

        }

        static void feladat11()
        {

            Console.WriteLine("11. feladat");
            Console.WriteLine();
            Console.WriteLine("kérem az 1. szakasz hosszát!");
            int aszakasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kérem a 2. szakasz hosszát!");
            int bszakasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kérem a 3. szakasz hosszát!");
            int cszakasz = Convert.ToInt32(Console.ReadLine());

            if (aszakasz + bszakasz > cszakasz && bszakasz + cszakasz > aszakasz && cszakasz + aszakasz > bszakasz)
            {

                Console.WriteLine("a szakaszokból lehet egy háromszöget csinálni");

            }
            else
            {

                Console.WriteLine("nem lehet ebből a háromszöget csinálni");

            }



            Console.WriteLine();
            Console.WriteLine();

        }
        static void Main(string[] args)
        {

            feladat1();

            feladat2();

            feladat3();

            feladat4();

            feladat5();

            feladat6();

            feladat7();

            feladat8();

            feladat9();

            feladat10();

            feladat11();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("nyomjon enter-t!");
            Console.ReadLine();
        }
    }
}
