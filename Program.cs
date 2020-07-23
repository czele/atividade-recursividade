using System;

namespace atividadeRecursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que numero deseja adicionar?");
            int number = Convert.ToInt32(Console.ReadLine());

            int resultado = new Recursivo().Add(number);
            Console.WriteLine($"A soma é: {resultado}.");



            //int soma = 0;

            //for (int i = 1; i <= number; i++)
            //{ 
            //    soma += i;
            //}

            //Console.WriteLine($"A soma é: {soma});
        }
    }

    public class Recursivo
    {
        public int Add(int n)
        {
            int soma;
            if (n == 0)
                return 0;
            else
                soma = n + Add(n - 1);
            
            return soma;

        }







    }
}
