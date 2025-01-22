using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Calculadora Simples ===");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");
            Console.Write("Digite a opção (1-5): ");

            string opcao = Console.ReadLine();

            if (opcao == "5")
            {
                Console.WriteLine("Encerrando o programa...");
                continuar = false;
                break;
            }

            // Valida e lê os números do usuário
            double numero1 = LerNumero("Digite o primeiro número: ");
            double numero2 = LerNumero("Digite o segundo número: ");

            // Calcula e exibe o resultado com base na opção
            switch (opcao)
            {
                case "1":
                    ExibirResultado("soma", numero1, numero2, Soma(numero1, numero2));
                    break;
                case "2":
                    ExibirResultado("subtração", numero1, numero2, Subtracao(numero1, numero2));
                    break;
                case "3":
                    ExibirResultado("multiplicação", numero1, numero2, Multiplicacao(numero1, numero2));
                    break;
                case "4":
                    if (numero2 != 0)
                    {
                        ExibirResultado("divisão", numero1, numero2, Divisao(numero1, numero2));
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    // Métodos para as operações matemáticas
    static double Soma(double a, double b) => a + b;

    static double Subtracao(double a, double b) => a - b;

    static double Multiplicacao(double a, double b) => a * b;

    static double Divisao(double a, double b) => a / b;

    // Método para ler números com validação
    static double LerNumero(string mensagem)
    {
        double numero;
        while (true)
        {
            Console.Write(mensagem);
            string entrada = Console.ReadLine();
            if (double.TryParse(entrada, out numero))
            {
                return numero;
            }
            Console.WriteLine("Entrada inválida! Digite um número válido.");
        }
    }

    // Método para exibir o resultado
    static void ExibirResultado(string operacao, double num1, double num2, double resultado)
    {
        Console.WriteLine($"\nResultado da {operacao}: {num1} e {num2} = {resultado}");
    }
}
