using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211004_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat11();
            //feladat12();
            //feladat13();
            feladat14();

            Console.ReadLine();

        }
        static void feladat11()
        {
            /*int i = -30;
            while (i<31)
            {
                Console.WriteLine(i);
                i=i+5;
            }
            */
            for (int i = -30; i < 31; i = i + 5)
            {
                Console.WriteLine(i);


            }

            Console.WriteLine("Enter");
            Console.ReadLine();
        }
        static void feladat12()
        {
            for (int i = 0; i <= 17; i = i + 1)
            {
                Console.Write(" {0} ", i * 3);
            }
            /*double i = 0;
            while (i<=17)
            {
                Console.Write(" {0} ", i*3);
                i = i + 1;
            }
            Console.WriteLine("Enter");*/
        }
        static void feladat13()
        {
            for (int i = 0; i <= 16; i = i + 1)
            {
                Console.Write(" {0} ", Math.Pow(2, i));
            }
            /*int i = 0;
            while (i<=16)
            {
                Console.Write(" {0} ", Math.Pow(2,i));
                i = i +1 ;*/
        }
        static void feladat14()
        {
            for (int i = 0; i <= 25; i = i + 1)
            {
                Console.Write(" {0} ", i = i * 7);
                i = i % 4;
            }
        }

    }





}
