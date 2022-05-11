using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto_dicionario
{
    class Program
    {
        static void Main()
        {
            int op = 0;
            string palavra = "";
            bool ok = false;

            do
            {
                Console.Clear();
                Console.WriteLine("***** Dicionário de Verbos Irregulares *****");
                Console.WriteLine("*****     Escolha uma das opções       *****");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" 1. Procurar: português - inglês");
                Console.WriteLine(" 2. Procurar: inglês - português");
                Console.WriteLine(" 3. sair ");

                
                do
                {
                    op = int.Parse(Console.ReadLine());
                } while (op < 0 || op > 3);

                Dicionario dicionario = new Dicionario();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite uma palavra em português para ser traduzida em inglês");
                        palavra = Console.ReadLine();
                        dicionario.PortuguesIngles(palavra);
                        
                        break;
                    case 2:
                        Console.WriteLine("Digite uma palavra em inglês para ser traduzida para o português");
                        palavra = Console.ReadLine();
                        dicionario.InglesPortugues(palavra);
                        break;
                    case 3:
                        break;
                    
                }









            } while (op != 3);


            Console.ReadKey();

        }
    }
}
