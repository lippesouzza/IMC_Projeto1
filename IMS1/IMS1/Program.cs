using System;
using System.Globalization;

namespace Ex___IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Índice de Massa Corporal (IMC) --");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            string idade = Console.ReadLine();
            Console.Write("Digite sua altura: ");
            float altura = (float) Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite seu peso: ");
            float peso = (float) Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            float CalculoIMC = (peso / (altura * altura));

            if(CalculoIMC >= 0 && CalculoIMC < 18.5)
            {
                Console.WriteLine($"Seu IMC é: {CalculoIMC.ToString("F1", CultureInfo.InvariantCulture)} - Abaixo do peso \nNome: {nome}\nIdade: {idade} anos");
            }
            if(CalculoIMC >= 18.5 && CalculoIMC < 24.9)
            {
                Console.WriteLine($"Seu IMC é: {CalculoIMC.ToString("F1", CultureInfo.InvariantCulture)} - Normal \nNome: {nome}\nIdade: {idade} anos");
            }else if(CalculoIMC >= 24.9 && CalculoIMC < 29.9)
            {
                Console.WriteLine($"Seu IMC é: {CalculoIMC.ToString("F1", CultureInfo.InvariantCulture)} - Sobrepeso \nNome: {nome}\nIdade: {idade} anos");
            }else if(CalculoIMC >= 30.0 && CalculoIMC < 35.9)
            {
                Console.WriteLine($"Seu IMC é: {CalculoIMC.ToString("F1", CultureInfo.InvariantCulture)} - Obesidade Grau I \nNome: {nome}\nIdade: {idade} anos");
            }if (CalculoIMC >= 35.9 && CalculoIMC < 39.9) 
            {
                Console.WriteLine($"Seu IMC é: {CalculoIMC.ToString("F1", CultureInfo.InvariantCulture)} - Obesidade Grau II \nNome: {nome}\nIdade: {idade} anos");
            }
            else if (CalculoIMC > 40)
            {
                Console.WriteLine($"Seu IMC é: {CalculoIMC.ToString("F1", CultureInfo.InvariantCulture)} - Obesidade Grau III \nNome: {nome}\nIdade: {idade} anos");
            }
        }
    }
