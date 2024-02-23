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