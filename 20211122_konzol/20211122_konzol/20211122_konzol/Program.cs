using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211122_konzol
{
    class Pros
    {
        public string nev, datum;
        public int helyezes, pont;
        public Pros(string egysor)
        {
            string[] darabok =egysor.Split('\t');
            datum = darabok[0];
            nev = darabok[1];
            helyezes = int.Parse(darabok[2]);
            pont = int.Parse(darabok[3]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("Prost.csv", Encoding.UTF8);
            Pros[] verseny = new Pros[beolvas.Length -1]; 
            for (int i = 0; i < verseny.Length; i++)
            {
                verseny[i] = new Pros(beolvas[i+1]);
            }
            int db_2 = 0;
            for (int i = 0; i < verseny.Length; i++)
            {
                if (verseny[i].helyezes!=1)
                {
                    db_2++;
                }
            }
            Console.WriteLine("3. feladat: {0}/{1}", db_2, verseny);
            Console.WriteLine("4. feladat:");
            for (int i = 0; i < verseny.Length; i++)
            {
                if (verseny[i].datum.Contains("1998"))
                {
                    Console.WriteLine("\t{0}", verseny[i].helyezes);
                }
            }
            List<Pros> SanMariano = new List<Pros>();
            List<int> helyezes = new List<int>();
            for (int i = 0; i < verseny.Length; i++)
            {
                if (verseny[i].nev=="San Marino Grand Prix")
                {
                    SanMariano.Add(verseny[i]);
                    helyezes.Add(verseny[i].helyezes);
                }
            }
            int legjobbhelyezes = helyezes.Min();
            for (int i = 0; i < SanMariano.Count; i++)
            {

            }
            Console.ReadLine();
        }
    }
}
