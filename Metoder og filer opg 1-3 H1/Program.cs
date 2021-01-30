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

            WriteToFile("StarWars", "Han skød først");

            //Opgave 2 læs en tekstfil:

            ReadFile("StarWars");

            //Opgave 3 slet en fil:

            DeleteFile("StarWars");

            Console.ReadKey();

        }
        //Opretter metode til at skrive filer
        public static void WriteToFile(string filename, string text)
        {
            File.WriteAllText(@".\filename.txt", text);
        }
        //Opretter metode til at læse en tekstfil
        public static void ReadFile(string filename)
        {
            string content = File.ReadAllText(@".\StarWars.txt");//Udskriver teksten der står i tekstfilen
            Console.WriteLine(content);
        }
        //Opretter metode der slettern en fil
        public static void DeleteFile(string filename)
        {
            File.Delete(@".\StarWats.txt");
        }
    }
}
