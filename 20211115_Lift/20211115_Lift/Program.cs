using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _20211115_Lift
{
    class lift
    {

        public string datum;
        public int ev, honap, nap, kartya, indulas, vege;
        public lift(string egysor)
        {

            string[] darabok = egysor.Split(' ');
            datum = darabok[0];
            kartya = int.Parse(darabok[1]);
            indulas = int.Parse(darabok[2]);
            vege = int.Parse(darabok[3]);

            string[] darabok1 = datum.Split('.');
            ev = int.Parse(darabok1[0]);
            honap = int.Parse(darabok1[1]);
            nap = int.Parse(darabok1[2]);

        }

        


        static void Main(string[] args)
        {

            string[] beolvas = File.ReadAllLines("lift.txt");

            lift[] liftek = new lift[beolvas.Length];
            for (int i = 0; i < liftek.Length; i++)
            {

                liftek[i] = new lift(beolvas[i]);

            }


            //2. feladat

            Console.WriteLine("3. feladat: A vizsgált időpontban {0} alkalommal használták a liftet.", beolvas.Length);

            //4. feladat

            int kisev = 200000;
            int nagyev = 0;

            int kishonap = 20;
            int nagyhonap = 0;

            int legkissebb = 60;
            int legnagy = 0;


            for (int i = 0; i < liftek.Length; i++)
            {

                if (legkissebb > liftek[i].nap && kisev >= liftek[i].ev && kishonap >= liftek[i].honap)
                {

                    legkissebb = liftek[i].nap;
                    kishonap = liftek[i].honap;
                    kisev = liftek[i].ev;

                }

            }


            for (int i = 0; i < liftek.Length; i++)
            {

                if (legnagy < liftek[i].nap && nagyev <= liftek[i].ev && nagyhonap <= liftek[i].honap)
                {

                    legnagy = liftek[i].nap;
                    nagyev = liftek[i].ev;
                    nagyhonap = liftek[i].honap;

                }

            }

            Console.WriteLine("4. feladat: időszak: " + kisev + "." + kishonap + "." + legkissebb + " - " + nagyev + "." + nagyhonap + "." + legnagy);

            //5. feladat

            int legnagyobb = 0;

            for (int i = 0; i < liftek.Length; i++)
            {

                if (legnagyobb < liftek[i].vege)
                {

                    legnagyobb = liftek[i].vege;

                }

            }

            Console.WriteLine("5. feladat: legnagyobb szint: {0}", legnagyobb);

            //6. feladat

            Console.WriteLine("6. feladat: Kérem a kártya számát!");
            string kartya = Console.ReadLine();

            Console.WriteLine("Kérem a célszintet!");
            string szint = Console.ReadLine();

            try
            {

                int szamkartya = Convert.ToInt32(kartya);

                int szamszint = Convert.ToInt32(szint);

                Console.WriteLine("Kártya száma: {0}", szamkartya);
                Console.WriteLine("Célszint száma: {0}", szamszint);

            }
            catch (Exception)
            {

                Console.WriteLine("Kártya száma: 5");
                Console.WriteLine("Célszint száma: 5");

            }

            //7. feladat

            int kartyaszam = Convert.ToInt32(kartya);

            int szintszam = Convert.ToInt32(szint);


            for (int i = 0; i < liftek.Length; i++)
            {

                if (liftek[i].kartya == kartyaszam && liftek[i].vege == szintszam)
                {

                    Console.WriteLine("A(z) {0} kártyával utaztak a(z) {1} emeletre.", kartyaszam, szintszam);
                    break;
                }
                else
                {

                    Console.WriteLine("A(z) {0} kártyával nem utaztak a(z) {1} emeletre.", kartyaszam, szintszam);

                }

            }

            //8. feladat












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
