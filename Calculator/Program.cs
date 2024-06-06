using System;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {

        Console.WriteLine("-----");
        Console.WriteLine("Selecione a operação que deseja realizar.");
        Console.WriteLine("1 - Soma; 2 - Subtracao; 3 - Multiplicacao; 4 - Divisao; 5 - Sair");
        short operacao = short.Parse(Console.ReadLine());
        Console.WriteLine("-----");

        if (operacao == 5)
        {
            System.Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            switch (operacao)
            {

                case 1:
                    float soma = Somar(v1, v2);
                    Console.WriteLine("A soma dos valores é: " + soma);
                    Menu();
                    break;

                case 2:
                    float subtracao = Subtrair(v1, v2);
                    Console.WriteLine("A subtracao dos valores é: " + subtracao);
                    Menu();
                    break;

                case 3:
                    float multiplicacao = Multiplicar(v1, v2);
                    Console.WriteLine("A multiplicacao dos valores é: " + multiplicacao);
                    Menu();
                    break;

                case 4:
                    float divisao = Dividir(v1, v2);
                    Console.WriteLine("A divisao dos valores é: " + divisao);
                    Menu();
                    break;

                default:
                    Menu();
                    break;
            }

        }
    }

    static float Somar(float v1, float v2)
    {

        float soma = (v1 + v2);
        return soma;
    }

    static float Subtrair(float v1, float v2)
    {
        float subtracao = (v1 - v2);
        return subtracao;
    }

    static float Multiplicar(float v1, float v2)
    {
        float multiplicacao = (v1 * v2);
        return multiplicacao;
    }

    static float Dividir(float v1, float v2)
    {
        float divisao = (v1 / v2);
        return divisao;
    }
}
