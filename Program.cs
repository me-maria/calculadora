using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetocalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";
            Console.WriteLine("--------------------Calculadora--------------------");//imprime mensagem entre aspas 

            // variaveis
            double valor1 = 0, valor2 = 0, resultado, numero;
            string operador, valorDigitado;
            bool numero_inteiro;

            // solicita ao usuário que digite um valor, em seguida, lê o valor digitado pelo usuário.
            Console.WriteLine("Digite o primeiro valor, em seguida tecle enter:");
            valorDigitado = Console.ReadLine();//armazena valor digitado na variável "valorDigitado".

            numero_inteiro = double.TryParse(valorDigitado, out numero);//converte o valor digitado em um número de ponto flutuante (double)

            // condicional que verifica se a conversão do valor digitado foi bem-sucedida.
            if (numero_inteiro)//se sim:
            {
                valor1 = Math.Round(double.Parse(valorDigitado), 3);//valor convertido é armazenado na variável "valor1". Função Math.Round() é utilizada para arredondar o valor convertido para 3 casas decimais
            }
            else//senão:
            {
                Console.WriteLine("Digite um número válido.");//imprime mensagem
            }

            // solicita ao usuário que digite o operador matemático desejado (+, -, *, / ou %) e armazena o operador digitado na variável operador
            Console.WriteLine("Digite a operação matemática desejada: ( /= divisão , * = multiplicação, + = soma, - = subtração e % = MOD resto ): ");
            operador = Console.ReadLine();

            //linhas abaixo solicitam ao usuário que digite o segundo valor a ser utilizado e realizam a mesma lógica de conversão e armazenamento:
            Console.WriteLine("Digite o segundo valor e tecle enter novamente.");
            valorDigitado = Console.ReadLine();
            numero_inteiro = double.TryParse(valorDigitado, out numero);
            if (numero_inteiro)
            {
                valor2 = Math.Round(double.Parse(valorDigitado), 3);
            }
            else
            {
                Console.WriteLine("Digite um número válido");
            }

            //De acordo com o operador escolhido será executado a operação correspondente.
            switch (operador)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 3);
                    Console.WriteLine($"{valor1} {'+'} {valor2} = {resultado}");
                    break;
                case "-":
                    resultado = Math.Round(valor1 - valor2, 3);
                    Console.WriteLine($"{valor1} {'-'} {valor2} = {resultado}");
                    break;
                case "*":
                    resultado = Math.Round(valor1 * valor2, 3);
                    Console.WriteLine($"{valor1} {'*'} {valor2} = {resultado}");
                    break;
                case "/":
                    resultado = Math.Round(valor1 / valor2, 3);
                    Console.WriteLine($"{valor1} {'/'} {valor2} = {resultado}");
                    break;
                case "%":
                    resultado = Math.Round(valor1 % valor2, 3);
                    Console.WriteLine($"{valor1} {'%'} {valor2} = {resultado}");
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida");//Se o operador digitado não corresponder a nenhum dos casos definidos, imprime mensagem. 
                    break;
            }

            Console.ReadKey();//faz com que o programa aguarde a pressionar qualquer tecla antes de encerrar a execução, para que o usuário possa visualizar o resultado.
        }
    }
}
