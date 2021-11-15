using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211108_kosar
{
    class Program
    {

        class Palya
        {

            public string csapat, települes, csarnok;
            public int befogadokepesseg;
            public Palya(string egysor)
            {

                string[] darabok = egysor.Split(';');
                csapat = darabok[0];
                települes = darabok[1];
                csarnok = darabok[2];
                befogadokepesseg = int.Parse(darabok[3]);

            }

        }

        static void Main(string[] args)
        {


            string[] beolvas = File.ReadAllLines("palyak.txt", Encoding.UTF8);

            List<Palya> palyak = new List<Palya>();
            for (int i = 0; i < beolvas.Length; i++)
            {

                palyak.Add(new Palya(beolvas[i]));

            }

            //tömb
            Palya[] palyak1 = new Palya[beolvas.Length];
            for (int i = 0; i < palyak1.Length; i++)
            {

                palyak1[i] = new Palya(beolvas[i]);

            }


            Console.WriteLine("2. feladat: Magyarorszagnak {0} kosárlabda csarnoka van.", palyak1.Length);

            //3. feladat
            
            int befogadas = 0;

            for (int i = 0; i < palyak1.Length; i++)
            {

                befogadas = befogadas + palyak1[i].befogadokepesseg;

            }

            Console.WriteLine("3. feladat: összesen {0} néző fér el a sportcsarnokokban.", befogadas);


            //4. feladat

            int atlag = befogadas / palyak1.Length;

            Console.WriteLine("4. feladat: Átlagosan {0} ember fér el a sportcsarnokokban.", atlag);

            //5. feladat

            int budapest = 0;


            for (int i = 0; i < palyak1.Length; i++)
            {

                if (palyak1[i].települes == " Budapest")
                {

                    budapest++;

                }

            }

            Console.WriteLine("Budapesten {0} csarnok található.", budapest);



            //6. feladat

            int kissebb = 100000000;

            string nev1 = Convert.ToString(budapest);
            

            for (int i = 0; i < palyak1.Length; i++)
            {

                if (palyak1[i].befogadokepesseg < kissebb)
                {

                    kissebb = palyak1[i].befogadokepesseg;
                    nev1 = palyak1[i].csarnok;

                }

            }

            Console.WriteLine("A legkissebb csarnok a {0}, {1} fővel.", nev1, kissebb);

            //7. feladat

            int nagyobb = 0;
            string nev = Convert.ToString(budapest);

            for (int i = 0; i < palyak1.Length; i++)
            {

                if (palyak1[i].befogadokepesseg > nagyobb)
                {

                    nagyobb = palyak1[i].befogadokepesseg;
                    nev = palyak1[i].csarnok;

                }

            }

            Console.WriteLine("A(z) {0} csarnokban nézhetik a legtöbben, {1} fővel", nev, nagyobb);



            //8. feladat

            for (int i = 0; i < palyak1.Length; i++)
            {

                if (palyak1[i].befogadokepesseg < atlag)
                {

                    File.AppendAllText("kispalyak.txt", palyak1[i].csapat + ";" + palyak1[i].települes + ";" + palyak1[i].csarnok + ";" + palyak1[i].befogadokepesseg + "\n");
                    
                }

            }














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
