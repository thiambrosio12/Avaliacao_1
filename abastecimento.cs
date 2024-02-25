using System;

class Program
{
    static void Main()
    {
        string tipoCarro = "";
        double valorEtanol = 0.0;
        double valorGasolina = 0.0;
        double consumoEtanol = 0.0;
        double consumoGasolina = 0.0;

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Calcular combustível");
            Console.WriteLine("2 - Editar dados");
            Console.WriteLine("3 - Sair do programa");

            int opcao = Convert.ToInt32(Console.ReadLine());
        }
    }
}
        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Calcular combustível");
            Console.WriteLine("2 - Editar dados");
            Console.WriteLine("3 - Sair do programa");

            int opcao;

            string s = Console.ReadLine();

            bool result = int.TryParse(s, out opcao);


            switch (opcao)
            {
                case 1:
                    CalcularCombustivel(ref tipoCarro, ref valorEtanol, ref valorGasolina, ref consumoEtanol, ref consumoGasolina);
                    break;
                case 2:
                    EditarDados(ref tipoCarro, ref valorEtanol, ref valorGasolina, ref consumoEtanol, ref consumoGasolina);// implementar
                    break;
                case 3:
                    Console.WriteLine("Deseja realmente sair do programa? (S/N)");
                    char confirmacao = Console.ReadLine().ToUpper()[0];
                    if (confirmacao == 'S')
                    {
                        Console.WriteLine("Programa encerrado.");
                        Environment.Exit(0);
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    private static void CalcularCombustivel(ref string tipoCarro, ref double valorEtanol, ref double valorGasolina, ref double consumoEtanol, ref double consumoGasolina)
    {
        if (string.IsNullOrEmpty(tipoCarro))
        {
            Console.WriteLine("Informe o tipo do carro (etanol, gasolina, flex): ");
            tipoCarro = Console.ReadLine();
        }

        if (valorEtanol <= 0)
        {
            Console.WriteLine("Informe o valor do litro do etanol: ");



            while (true)
            {
                string s;
                s = Console.ReadLine();
                bool result1 = double.TryParse(s, out valorEtanol);
                if (result1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite apenas valores numericos");
                }
            }
        }

        if (valorGasolina <= 0)
        {
            Console.WriteLine("Informe o valor do litro da gasolina: ");
            while (true)
            {
                string s;
                s = Console.ReadLine();
                bool result1 = double.TryParse(s, out valorGasolina);
                if (result1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite apenas valores numericos");
                }
            }
        }

        if (consumoEtanol <= 0)
        {
            Console.WriteLine("Informe o consumo do carro com etanol (Km/L): ");

            while (true)
            {
                string s;
                s = Console.ReadLine();
                bool result1 = double.TryParse(s, out consumoEtanol);
                if (result1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite apenas valores numericos");
                }
            }
        }

        if (consumoGasolina <= 0)
        {
            Console.WriteLine("Informe o consumo do carro com gasolina (Km/L): ");

            while (true)
            {
                string s;
                s = Console.ReadLine();
                bool result1 = double.TryParse(s, out consumoGasolina);
                if (result1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite apenas valores numericos");
                }
            }
        }

        double proporcao = consumoEtanol / consumoGasolina;
    }