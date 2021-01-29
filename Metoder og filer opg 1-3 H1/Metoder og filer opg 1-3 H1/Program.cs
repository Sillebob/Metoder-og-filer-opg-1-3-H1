using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metoder_og_filer_opg_1_3_H1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1 Skriv til fil: 

            File.WriteAllText(@".\StarWars.txt", "Han skød først");

            //Opgave 2 læs en tekstfil:

            string content = File.ReadAllText(@".\StarWars.txt");//Udskriver teksten der står i tekstfilen
            Console.WriteLine(content);

            //Opgave 3 slet en fil:

            File.Delete(@".\StarWats.txt");

            Console.ReadKey();

        }
    }
}
