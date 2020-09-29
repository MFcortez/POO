using System;
using System.Collections.Generic;
using System.Linq;

namespace POO_07_09_2020
{
	public class Classes
	{
		public class Retangulo
		{
			public double _largura;
			public double _altura;

			public double Area()
			{
				return _largura * _altura;
			}
			public double Perimetro()
			{
				return (_largura + _altura) * 2;
			}
			public double Diagonal()
			{
				return Math.Sqrt((_altura * _altura) + (_largura * _largura));
			}

			public override string ToString() 
			{
				return "Area: " + Area()
					+ " Perimetro: " + Perimetro()
					+ " Diagonal: " + Diagonal();
			}
		}
		public class Funcionario
		{
			public string _nome;
			public double _salarioBruto;
			public double _imposto;

			public double SalarioLiquido()
			{
				return _salarioBruto - _imposto;
			}

			public void AumentarSalario(double porcentagem)
			{
				_salarioBruto += _salarioBruto*(porcentagem/100);
			}

			public override string ToString()
			{
				return _nome
					+ ", " + SalarioLiquido();
			}

		}

		public class Aluno
		{
			public string _aluno;
			public double [] _notas = new double [3];
			

			public void SetNotas()
			{
				for(int x = 0; x < 3; x++)
				{
					Console.Write("Insira a " + (x+1) + "ª nota: ");
					_notas[x] = Double.Parse(Console.ReadLine());

					if(_notas[0] > 30)
					{
						_notas[0] = 30;
					}
					else if(_notas[x] > 35)
					{
						_notas[x] = 35;
					}
				}
			}

			public double NotaFinal()
			{
				return _notas.Sum();
			}

			public string Situacao()
			{
				if(_notas.Sum() >= 60)
				{
					return "Aprovado";
				}
				else
				{
					return "Reprovado";
				}
			}

			public override string ToString()
			{
				return _aluno
					+ "\nNota 1: " + _notas[0]
					+ "\nNota 2: " + _notas[1]
					+ "\nNota 3: " + _notas[2]
					+ "\nNota Final: " + NotaFinal()
					+"\n" + Situacao();
			}
		}

	}
}
