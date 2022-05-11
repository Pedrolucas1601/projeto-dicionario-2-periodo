using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_dicionario
{
    class Dicionario
    {
        string palavra { get; set; }

        


        public void PortuguesIngles(string palavra)
        {
            string linha = "",palavra1 = "";
            bool ok = false;


            StreamReader ler = new StreamReader("VerbosPortugues.txt");
            


            while (!ler.EndOfStream)
            {
                linha = ler.ReadLine();
                string[] item = linha.Split(' ');
                palavra1 = item[0];

                if (palavra1.ToUpper() == palavra.ToUpper())
                {
                    Console.WriteLine($" Tradução: {item[1]}");
                    ok = true;
                    break;
                }

            }
            ler.Close();
            Console.WriteLine();
            Console.WriteLine(ok ? "Palavra encontrada!" : "Palavra não encontrada... Digite novamente!");
            Console.ReadKey();
            


        }

        public void InglesPortugues(string palavra)
        {
            string linha = "", palavra1 = "";
            bool ok = false;


            StreamReader ler = new StreamReader("VerbosIngles.txt");



            while (!ler.EndOfStream)
            {
                linha = ler.ReadLine();
                string[] item = linha.Split(' ');
                palavra1 = item[0];

                if (palavra1.ToUpper() == palavra.ToUpper())
                {
                    Console.WriteLine($" Tradução: {item[1]} ");
                    ok = true;
                    break;
                }

            }
            ler.Close();
            Console.WriteLine();
            Console.WriteLine(ok ? "Palavra encontrada!" : "Palavra não encontrada... Digite novamente!");
            Console.ReadKey();

        }
    }
}
