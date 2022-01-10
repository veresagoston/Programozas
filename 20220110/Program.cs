using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20220110
{
    class tarsalgo
    {
        public int ora, perc, szemely;
        public string athaladas;
        public tarsalgo(string egysor)
        {
            string[] darabok = egysor.Split(' ');
            ora = int.Parse(darabok[0]);
            perc = int.Parse(darabok[1]);
            szemely = int.Parse(darabok[2]);
            athaladas = darabok[3];



        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("ajto.txt", Encoding.Default);
            List<tarsalgo> szemely = new List<tarsalgo>();
            for (int i = 0; i < beolvas.Length; i++)
            {

                szemely.Add(new tarsalgo(beolvas[i]));
            }
            Console.WriteLine("2.feladat:");
            Console.WriteLine(" Az első belépő:{0} ílletve Az utolsó belépő:{1} indexű személy volt. ", szemely[0].szemely, szemely[szemely.Count - 1].szemely);
            Console.ReadLine();
            
        }
    }
}


