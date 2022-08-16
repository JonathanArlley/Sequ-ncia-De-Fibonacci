using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaDeFibonnaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sequência de que cada número é a soma dos seus antecessores

            int a = 0, b = 1, c = 0;

            Console.WriteLine("Quatos valores: ");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequência de Fibonacci com " + valores + " valores");

            for (int i = 0; i < valores; i++)
            {
                if (i < valores - 1)
                {
                    Console.Write(a + ", ");//Vai estar em a pq antes de fazer a operação eu vou manipular a posição
                                                //Pra o último valor não ter , coloca um if
                }
                else
                {
                    Console.Write(a);
                }
               
                c = a + b;
                //vamos colocar uma posição pra frente
                a = b;
                b = c;
            }

            Console.ReadKey();
        }
    }
}
