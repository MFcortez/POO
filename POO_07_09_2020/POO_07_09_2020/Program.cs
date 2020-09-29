using System;

namespace POO_07_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o programa a executar");
            int x = Int32.Parse(Console.ReadLine());

            if(x == 1)
            {
                Classes.Retangulo r;
                r = new Classes.Retangulo();

                Console.Write("Declare a largura do retangulo: ");
                r._largura = Double.Parse(Console.ReadLine());
                Console.Write("Declare a altura do retangulo: ");
                r._altura = Double.Parse(Console.ReadLine());

                Console.WriteLine(r.ToString());
            }
            else if(x == 2)
            {
                Classes.Funcionario f;
                f = new Classes.Funcionario();

                Console.Write("Nome do Funcionário: ");
                f._nome = Console.ReadLine();
                Console.Write("Salário Bruto: ");
                f._salarioBruto = Double.Parse(Console.ReadLine());
                Console.Write("Imposto sobre o Salário: ");
                f._imposto = Double.Parse(Console.ReadLine());

                Console.WriteLine(f.ToString());

                Console.Write("Aumento: ");
                f.AumentarSalario(Double.Parse(Console.ReadLine()));

                Console.WriteLine(f.ToString());
            }
            else
            {
                Classes.Aluno a;
                a = new Classes.Aluno();

                Console.Write("Nome do Aluno: ");
                a._aluno = Console.ReadLine();
                a.SetNotas();
                Console.WriteLine(a.ToString());
            }
        }
    }
}
