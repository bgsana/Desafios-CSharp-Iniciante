using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDevs.CSharpIniciante.Desafios
{
    internal class Desafios
    {
        static void Main()
        { 
            Desafio1();
            Desafio2();
            Desafio3();
        }

        static void Desafio1()
        {
            Console.WriteLine("Iniciando o primeiro desafio!");

            int soma = 0;

            for (int i = 0; i <= 10; i++)
            {
                soma += i;
            }

            Console.WriteLine("A soma dos números de 1 a 10 é: " + soma );
            Console.WriteLine("____________________________\n");
        }

        static void Desafio2()
        {
            Console.WriteLine("Iniciando o segundo desafio!");
            
            double peso = 0;
            double altura = 0;
            double imc = 0;

            Console.Write("Insira o seu peso (em quilogramas): ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o sua altura (em metros): ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é de: " + imc);

            if (imc < 18.5) 
            { 
                Console.WriteLine("Você está abaixo do peso");
            } 
            else if (imc >= 18.5) 
            {
                Console.WriteLine("Você está em seu peso normal");
            } 
            else if (imc <= 25)
            {
                Console.WriteLine("Você está em sobrepeso");
            }
            else if (imc <= 30)
            {
                Console.WriteLine("Você está com Obesidade Grau I");
            }
            else if (imc <= 35)
            {
                Console.WriteLine("Você está com Obesidade Grau II");
            }
            else
            {
                Console.WriteLine("Você está com Obesidade Grau III");
            }
            Console.WriteLine("____________________________\n");
        }

        static void Desafio3()
        {
            Console.WriteLine("Iniciando o terceiro e último desafio!");

            double num1 = 0;
            double num2 = 0;
            double operacao = 0;

            Console.Write("Insira o 1º número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o 2º número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("- - - - - - - - - - -");
            Console.WriteLine("Estes são os operadores: \nAdição: +\nDivisão: /\nMultiplicação: *\nSubtração: -");
            Console.WriteLine("- - - - - - - - - - -");

            Console.Write("Digite o operador desejado: ");
            var operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    operacao = num1 + num2;
                    Console.WriteLine("Resultado: " + operacao);
                    break;

                case "-":
                    operacao = num1 - num2;
                    Console.WriteLine("Resultado: " + operacao);
                    break;

                case "*":
                    operacao = num1 * num2;
                    Console.WriteLine("Resultado: " + operacao);
                    break;

                case "/":
                    operacao = num1 / num2;
                    Console.WriteLine("Resultado: " + operacao);
                    break;

                default:
                    Console.WriteLine("Operador inválida");
                    break;

            }

        }

    }
}