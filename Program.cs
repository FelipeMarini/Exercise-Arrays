using System;

namespace Exercise_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listadecompras = {"maçã","batata","cenoura","melancia","carne","banana","leite","biscoito"};

            Console.WriteLine(listadecompras[7]);

            Console.WriteLine("Trocar biscoito por qual item da lista de compras?");

            Console.WriteLine();
            
            listadecompras[7] = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine(listadecompras[7]);

            Console.WriteLine();

            Console.WriteLine(listadecompras.Length);

            for (int i = 0; i < listadecompras.Length; i++)
            {
                
                Console.WriteLine(i);
                Console.WriteLine(listadecompras[i]);
            
            
            }
            

        }
    }
}
