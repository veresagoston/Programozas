using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210927
{
    class Program
    {

        static void feladat1()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat1");
            Console.WriteLine();
            Console.WriteLine("Kérek egy számot!");


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
                    Console.WriteLine("túl nagy számot adtál meg");
                    break;

            }

        }

        static void feladat2()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat2");
            Console.WriteLine();
            Console.WriteLine("Kérek egy számot!");


            int honap = Convert.ToInt32(Console.ReadLine());

            switch (honap)
            {

                case 1:
                    Console.WriteLine("Tél");
                    break;
                case 2:
                    Console.WriteLine("Tél");
                    break;
                case 3:
                    Console.WriteLine("tavasz");
                    break;
                case 4:
                    Console.WriteLine("tavasz");
                    break;
                case 5:
                    Console.WriteLine("tavasz");
                    break;
                case 6:
                    Console.WriteLine("nyár");
                    break;
                case 7:
                    Console.WriteLine("nyár");
                    break;
                case 8:
                    Console.WriteLine("nyár");
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
                    Console.WriteLine("nincs ilyen szám!");
                    break;
            }

        }

        static void feladat3()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat3");
            Console.WriteLine();
            Console.WriteLine("Kérek egy számot!");

            //2 000 000 000
            int szam = Convert.ToInt32(Console.ReadLine());
            while (szam >
                
                2000000000)
            {

                Console.WriteLine("nem jó számot adtál meg");
                Console.WriteLine("kérek egy számot!");
                szam = Convert.ToInt32(Console.ReadLine());

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
                    Console.WriteLine("négyjegyű");
                    break;

                case 5:
                    Console.WriteLine("ötjegyű");
                    break;
                    
                case 6:
                    Console.WriteLine("hatjegyű");
                    break;





                default:
                    Console.WriteLine("hét vagy többjegyű");
                    break;

            }

        }


















        static void feladat4()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat4");
            Console.WriteLine();
            Console.WriteLine("Kérek egy számot!");

            double atlag = Convert.ToInt32(Console.ReadLine());
            if (atlag > 1.4 && atlag <= 5)
            {

                Console.WriteLine("Átment");

            }
            else if (atlag > 5)
            {

                Console.WriteLine("Ilyen osztályzat nincs!");

            }
            else
            {

                Console.WriteLine("megbukott");

            }




        }





        static void feladat5()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat5");
            Console.WriteLine();
            Console.WriteLine("Kérem az osztályzatot");

            int jegy = Convert.ToInt32(Console.ReadLine());
            switch (jegy)
            {

                case 1:
                    Console.WriteLine("elégtelen");
                    break;

                case 2:
                    Console.WriteLine("elégséges");
                    break;

                case 3:
                    Console.WriteLine("közepes");
                    break;

                case 4:
                    Console.WriteLine("jó");
                    break;

                case 5:
                    Console.WriteLine("jeles");
                    break;



                default:
                    Console.WriteLine("Ilyen osztályzat nincs!");
                    break;
            }

        }


        static void feladat6()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat6 a");
            Console.WriteLine();
            


            int szamlalo = 1;

            for (int i = 0; i < 20; i++)
            {

                Console.Write("{0}, ", szamlalo);
                szamlalo++;


            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat6 b");
            
            Console.WriteLine();

            int szamlalo2 = 1;

                for (int i = 0; i < 20; i++)
                {

                    Console.WriteLine("{0}, ", szamlalo2);
                    szamlalo2++;


                }
        }

        static void feladat7()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat7");
            Console.WriteLine();
            Console.WriteLine("kérek entert");
            Console.ReadLine();
            int szamlalo2 = 15;

            for (int i = 0; i < 78; i++)
            {

                Console.Write("{0}, ", szamlalo2);
                szamlalo2++;


            }

        }

        static void feladat8()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat8 a");
            Console.WriteLine();
            Console.WriteLine("kérek entert");
            Console.ReadLine();
            int szamlalo2 = 1;

            for (int i = 0; i < 31; i++)
            {
                if (szamlalo2 % 2 == 0)
                {

                    Console.Write("{0}, ", szamlalo2);

                }
                
                szamlalo2++;


            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat8 b");
            Console.WriteLine();
            Console.WriteLine("kérek entert");
            Console.ReadLine();

            int szamlalo = 1;

            for (int i = 0; szamlalo < 31; i++)
            {
                if (szamlalo % 2 == 0)
                {

                    Console.WriteLine("{0}, ", szamlalo);

                }

                szamlalo++;


            }

        }

        static void feladat9()
        {
           // Console.WriteLine("kérek egy számot");
         /*   int szam = Convert.ToInt32(Console.ReadLine());
            int szamlalo = 1;

            while (szam < 0)
            {

                Console.WriteLine("nem pozitív számot adtál meg! kérek egy új számot.");
                szam = Convert.ToInt32(Console.ReadLine());

            }

                for (int i = 0; i < szam; i++)
                {
                    

                        Console.Write("{0}, ", szamlalo);

                    

                    szamlalo++;


                }

            */
            

        }

        static void feladat10()
        {
            /*
            Console.WriteLine("kérek egy számot");
            int szam = Convert.ToInt32(Console.ReadLine());
            int szamlalo = 1;

            while (szam < 0)
            {

                Console.WriteLine("nem pozitív számot adtál meg! kérek egy új számot.");
                szam = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < szam; i++)
            {


                Console.WriteLine("{0}, ", szamlalo);



                szamlalo++;


            }
            */
        }

        static void feladat11()
        {

            double szam = 2;
            for (int i = 0; szam < 15; i++)
            {
                Console.WriteLine(szam);
                szam = Math.Pow(szam, 2);

            }

        }

        static void feladat12() 
        {
            
            int szamlalo = 100;

            for (int i = 0; szamlalo < 401; i++)
			{

                if (szamlalo % 4 == 0)
	            {
                    
                    Console.Write("{0}, ", szamlalo);

	            }

			}
            
        }

        static void feladat13() 
        {
            
            int szamlalo = 30;

            for (int i = 0; szamlalo < 101; i++)
			{

                Console.Write("{0}, ", szamlalo);

                szamlalo = szamlalo + 9;

			}
            
        }

        static void feladat14() 
        {
            
            int szamlalo = 150;

            for (int i = 0; szamlalo > 40; i++)
			{

                Console.Write("{0}, ", szamlalo);

                szamlalo=szamlalo - 12;

			}
            
        }

        static void feladat15()
        {
            
            int szamlalo = 100; 

            for (int i = 0; szamlalo  > -100; i++)
			{

                if (szamlalo % 9 == 0)
	            {

                    Console.Write("{0}, ", szamlalo);
                    szamlalo--;
	            }

			}
            
        }








        static void Main(string[] args)
        {

           // feladat1();

            //feladat2();

            //feladat3();

            //feladat4();

            //feladat5();

            Console.WriteLine("Ciklusos feladatok");
            Console.WriteLine("kérek entert");
            Console.ReadLine();

            //feladat6();

            //feladat7();

            feladat8();

            feladat9();

            feladat10();

            feladat11();

            feladat12();

            feladat13();

            feladat14();

            feladat15();


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
            Console.WriteLine("Nyomjon enter-t");
            Console.ReadLine();
        }
    }
}
