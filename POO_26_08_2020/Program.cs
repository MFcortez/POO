using System;

namespace POO_26_08_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            Console.Write("Entre com o nome da 1ª pessoa: ");
            x.nome = Console.ReadLine();

            Console.Write("Entre com a idade da 1ª pessoa: ");
            x.idade = Int32.Parse(Console.ReadLine());

            Console.Write("Entre com o salário da 1ª pessoa: ");
            x.salario = double.Parse(Console.ReadLine());

            Console.Write("Entre com o nome da 2ª pessoa: ");
            y.nome = Console.ReadLine();

            Console.Write("Entre com a idade da 2ª pessoa: ");
            y.idade = Int32.Parse(Console.ReadLine());

            Console.Write("Entre com o salário da 2ª pessoa: ");
            y.salario = double.Parse(Console.ReadLine());

            if(x.idade > y.idade)
            {
                Console.WriteLine(x.nome + " é mais velho que " + y.nome + "!");
            }
            else if (y.idade > x.idade)
            {
                Console.WriteLine(y.nome + " é mais velho que " + x.nome + "!");
            }
            else
            {
                Console.WriteLine("Resultado inesperado!");
            }

            double media = (y.salario + x.salario) / 2;

            Console.WriteLine("A média entre os salários dos dois é de: " + media);

        }
    }
}
