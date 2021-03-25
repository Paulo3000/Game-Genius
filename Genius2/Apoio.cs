using System;
using System.Threading;

namespace Genius2
{
    class Apoio
    {
       // public string mesagem1 = "Digite os números da sequência";
        private int duracao = 300;
        public char[] coleta = new char[4];
        public int velocidade = 600;

        public int Laco(int num2)
        {

            

            Random random = new Random();
            char[] letras = new char[] { 'Y', 'G', 'B', 'R' };

            for (int i = 0; i <letras.Length; i++)
            {
                int numero = random.Next(0, 3);
                Console.Write(letras[numero] + " ");
                coleta[i] = letras[numero];
                switch (letras[numero])
                {
                    case 'Y':
                        Console.Beep(700, duracao);
                        break;
                    case 'G':
                        Console.Beep(900, duracao);
                        break;
                    case 'B':
                        Console.Beep(600, duracao);
                        break;
                    case 'R':
                        Console.Beep(400, duracao);
                        break;

                }
                Thread.Sleep(velocidade);
            }
            Console.WriteLine("\n\n");
            return num2;
            // configração do beep  Console.Beep(tom,duração);
        }


        public char Som(char som)
        {
            switch (som)
            {
                case 'Y':
                    Console.Beep(700, duracao);
                    break;
                case 'G':
                    Console.Beep(900, duracao);
                    break;
                case 'B':
                    Console.Beep(600, duracao);
                    break;
                case 'R':
                    Console.Beep(400, duracao);
                    break;
                default:
                    Console.Beep(400, 1900);
                    break;
            }
            return som;
            
        }





    }
}
