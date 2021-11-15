using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211004
{
    class Program
    {


        static void feladat1()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("for ciklus:");
            Console.WriteLine();

            for (int i = -30; i < 31; i=i+5)
            {

                Console.Write("{0}, ", i);

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("while ciklus:");
            Console.WriteLine();
            int szamlalo = -30;
            while (szamlalo<=30)
            {

                Console.Write("{0}, ", szamlalo);
                szamlalo = szamlalo + 5;

            }

        }


        static void feladat2()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("for ciklus:");
            Console.WriteLine();

            int szorzando = 3;
            for (int i = 1; i <= 17; i++)
            {

                Console.WriteLine(szorzando*i);
                

            }



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("while ciklus:");
            Console.WriteLine();


            szorzando = 3;
            int szamlalo = 1;
            while (szamlalo<=17)
            {

                Console.WriteLine(szorzando * szamlalo);
                szamlalo++;


            }
        }


        static void feladat3()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("for ciklus:");
            Console.WriteLine();

            double hatvany = 2;
            for (int i = 1; i <= 16; i++)
            {

                Console.WriteLine(Math.Pow(hatvany, i));

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("while ciklus:");
            Console.WriteLine();
            hatvany = 2;
            int szamlalo = 1;
            while (szamlalo <= 16)
            {

                Console.WriteLine(Math.Pow(hatvany, szamlalo));
                szamlalo++;

            }

        }


        static void feladat4()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("for ciklus:");
            Console.WriteLine();
            //a 7-es szorzótábla; 25 eleméből;  4-gyel oszthatók.

            int szam = 7;
            int osztas;

            for (int i = 1; i <= 25; i++)
            {

                osztas = szam * i;

                if (osztas % 4 == 0)
                {

                    Console.Write("{0}, ", osztas);

                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("while ciklus:");
            Console.WriteLine();

            
            int szamlalo = 1;
            osztas = 0;

            while (szamlalo <= 25)
            {

                osztas = szam * szamlalo;
                if (osztas % 4 == 0)
                {

                    Console.Write("{0}, ", osztas);

                }

                szamlalo++;

            }




        }


        static void feladat5()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("for ciklus:");
            Console.WriteLine();

            int szam = 144;


            for (int i = 1
                ; i <= 144; i++)
            {

                if (szam % i == 0)
                {

                    Console.Write("{0}, ", i);

                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("while ciklus:");
            Console.WriteLine();

            int szamlalo = 1;


            while (szamlalo <= 144)
            {

                if (szam % szamlalo == 0)
                {

                    Console.Write("{0}, ", szamlalo);

                }

                szamlalo++;
            }

        }


        static void feladat6()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("for ciklus:");
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("while ciklus:");
            Console.WriteLine();



        }


        static void feladat7()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("for ciklus:");
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("while ciklus:");
            Console.WriteLine();



        }


        static void feladat8()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("for ciklus:");
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("while ciklus:");
            Console.WriteLine();



        }


        static void feladat9()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("for ciklus:");
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("while ciklus:");
            Console.WriteLine();



        }


        static void feladat10()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("for ciklus:");
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("while ciklus:");
            Console.WriteLine();



        }

        static void Main(string[] args)
        {

            /*
             * 
            Console.WriteLine("1.feladat");
            Console.WriteLine("kérek egy entert!");
            Console.ReadLine();
            feladat1();

            Console.WriteLine();
            Console.WriteLine("2.feladat");
            Console.WriteLine("kérek egy entert!");
            Console.ReadLine();
            feladat2();

            Console.WriteLine();
            Console.WriteLine("3.feladat");
            Console.WriteLine("kérek egy entert!");
            Console.ReadLine();
            feladat3();

            Console.WriteLine();
            Console.WriteLine("4.feladat");
            Console.WriteLine("kérek egy entert!");
            Console.ReadLine();
            feladat4();*/

            Console.WriteLine();
            Console.WriteLine("5.feladat");
            Console.WriteLine("kérek egy entert!");
            Console.ReadLine();
            feladat5();

            Console.WriteLine();
            Console.WriteLine("6.feladat");
            Console.WriteLine("kérek egy entert!");
            Console.ReadLine();
            feladat6();

            Console.WriteLine();
            Console.WriteLine("7.feladat");
            Console.WriteLine("kérek egy entert!");
            Console.ReadLine();
            feladat7();

            Console.WriteLine();
            Console.WriteLine("8.feladat");
            Console.WriteLine("kérek egy entert!");
            Console.ReadLine();
            feladat8();

            Console.WriteLine();
            Console.WriteLine("9.feladat");
            Console.WriteLine("kérek egy entert!");
            Console.ReadLine();
            feladat9();

            Console.WriteLine();
            Console.WriteLine("10.feladat");
            Console.WriteLine("kérek egy entert!");
            Console.ReadLine();
            feladat10();























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
            Console.WriteLine("kérek egy entert!");
            Console.ReadLine();
        }
    }
}
