using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("exercicio 1:");
            Console.WriteLine("calcular media entre 5 valores");
            float media = 0;
            float mf = 0;
            int[] notas = { 7, 6, 9, 10, 4 };
            for (int i = 0; i < notas.Length; i++)
            {
                mf = notas[i] + mf;
            }
            media = mf / notas.Length;
            //  Console.WriteLine(mf);
            Console.WriteLine(media);
            Console.ReadLine();
            Batata();

        }
        public static void Batata() {

            Console.WriteLine("exercicio 2:");
            Console.WriteLine("exibir quantos valores são maiores que 20");

            int[] numeros = { 5, 8, 9, 10, 50, 21, 20, 18, 70, 4 };
            int contador = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 20)
                {
                    Console.WriteLine("o numero " + numeros[i] + " é maior que 20");
                    contador++;
                }
                else
                {
                    Console.WriteLine("o numero " + numeros[i] + " é menor que 20");
                }
            }
            Console.WriteLine(contador + " numeros são maiores que 20");
            Console.ReadLine();


        }
    }
}
