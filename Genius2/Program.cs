using System;
using System.Threading;

namespace Genius2
{
    class Program
    {
        
        static void Main(string[] args)
        {



          //  int faze = 0;

            Apoio apoio = new Apoio();

        volta:
            Console.WriteLine("entre com 0 pra começar a sequência");
            int num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                Console.Clear();
                Console.Beep();
                goto volta;

            }


      

            Console.WriteLine("iniciando sequencia\n");

            while (true)
            {
               // faze++;
                apoio.Laco(num);
                Console.Clear();
                Console.WriteLine("Entre com a sequencia das letras\n");


                char[] numeroEscolha = new char[4];
                for (int i = 0; i <= 3; i++)
                {

                    numeroEscolha[i] = Console.ReadKey().KeyChar;
                    Console.WriteLine("\n");
                    apoio.Som(numeroEscolha[i]);
                    if (numeroEscolha[0] == apoio.coleta[0] && i == 0)
                    {

                        Console.WriteLine("---------------OK");

                    }
                    else if (numeroEscolha[1] == apoio.coleta[1] && i == 1)
                    {
                        Console.WriteLine("---------------OK");

                    }
                    else if (numeroEscolha[2] == apoio.coleta[2] && i == 2)
                    {
                        Console.WriteLine("---------------OK");


                    }
                    else if (numeroEscolha[3] == apoio.coleta[3] && i == 3)
                    {
                        Console.WriteLine("---------------OK");

                    }



                    else
                    {
                        Console.WriteLine("------------ERRO");
                        Console.Beep(400, 1900);
                        break;
                    }

                }

            }
        }
    }
}
