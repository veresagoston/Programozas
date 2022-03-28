using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Egyszamjatek
{
    class egyszam
    {
        private string nev;
        //public int elsofordulo, masodikfordulo, harmadikfordulo, negyedikfordulo;
        List<int> Fordulok = new List<int>();
        public egyszam(string egysor)
        {
            string[] darabok = egysor.Split(' ');
            nev = darabok[0];
            for (int i = 1; i < darabok.Length; i++)
            {
                Fordulok.Add(int.Parse(darabok[i]));
            }
        }

        public string Nev { get => nev; set => nev = value; }
        public List<int> Fordulok1 { get => Fordulok; set => Fordulok = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("egyszamjatek1.txt", Encoding.UTF8);
            List<egyszam> Jatek = new List<egyszam>();
            for (int i = 0; i < beolvas.Length; i++)
            {
                Jatek.Add(new egyszam(beolvas[i]));
            }
            Console.WriteLine("3. feladat: Játékosok száma: {0} fő.", beolvas.Length);
            Console.WriteLine("4.feladat:");
            Console.Write("Kérem a forduló sorszámát:");
            int sorszam = int.Parse(Console.ReadLine());
            int Tipposzeg = 0;
            for (int i = 0; i < Jatek.Count; i++)
            {
                Tipposzeg += Jatek[i].Fordulok1[sorszam - 1];
            }
            Double Tippatlag = (double)Tipposzeg / Jatek.Count;
            Console.WriteLine("Megadott fordulónak a átlaga: {0}", Math.Round(Tippatlag,2));

            Console.ReadLine();
        }
    }
}
