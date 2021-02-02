using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva seu nome: ");
            String n = Convert.ToString(Console.ReadLine());
            Console.Write("Escreva sua idade: ");
            String i = Convert.ToString(Console.ReadLine());
            Console.Write("Escreva a cidade onde você mora: ");
            String c = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nome: " + n);
            Console.WriteLine("Idade: " + i + " anos");
            Console.WriteLine("Cidade: " + c);
            Console.ReadKey();
        }
    }
}
