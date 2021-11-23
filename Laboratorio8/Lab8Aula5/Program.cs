using System;

namespace Lab8Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(); Pessoa[] lista2 = 
           {
            new Pessoa("Jose", 25),
            new Pessoa("Ana", 28),
            new Pessoa("Paulo", 20)
            };

            Array.Sort(lista2);

            Console.WriteLine("Array depois da ordenacao"); for (int i = 0; i < lista2.Length; i++)
            {
                Console.Write(lista2[i].Nome + " ");
            }

        }
    }
}
