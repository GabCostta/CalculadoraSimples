using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Calculadora Simples ===");
        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1. Soma");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Divisão");
        Console.Write("Digite a opção (1-4): ");
        
        int opcao = int.Parse(Console.ReadLine());

        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch (opcao)
        {
            case 1:
                resultado = numero1 + numero2;
                Console.WriteLine($"Resultado da soma: {resultado}");
                break;
            case 2:
                resultado = numero1 - numero2;
                Console.WriteLine($"Resultado da subtração: {resultado}");
                break;
            case 3:
                resultado = numero1 * numero2;
                Console.WriteLine($"Resultado da multiplicação: {resultado}");
                break;
            case 4:
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine($"Resultado da divisão: {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
