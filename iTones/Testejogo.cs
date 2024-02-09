using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_de_Caô
{
    public class Testejogo
    {

        public void Joguinho()
        {
            Random aleatorio = new Random();
            int numeroSecreto = aleatorio.Next(1, 101);

            do
            {
                Console.Write("Digite um número entre 1 e 100: ");
                int chute = int.Parse(Console.ReadLine());

                if (chute == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você acertou o número.");
                    break;
                }
                else if (chute < numeroSecreto)
                {
                    Console.WriteLine("O número é maior.");
                }
                else
                {
                    Console.WriteLine("O número é menor.");
                }

            } while (true);
            Joguinho();
        }
    }
}