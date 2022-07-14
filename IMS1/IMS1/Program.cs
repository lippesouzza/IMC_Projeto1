using System;

namespace IMS1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com peso");
            float peso = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com sua altura");
            float altura = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com sua idade");
            string idade = Console.ReadLine();
        }
    }
}
