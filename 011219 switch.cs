using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	class Program
	{
		static void Main(string[] args)
		{
			switchexercice();

		}

		private static void switchexercice()
		{
			int a, b;
			a = 3;
			b = 5;
			Console.WriteLine("1. Somme?");
			Console.WriteLine("2. Soustraction?");
			Console.WriteLine("3.product?");
			Console.WriteLine("4.puissance?");
			Console.WriteLine("5.racine?");
			Console.WriteLine("6.Exit?");
			Console.WriteLine("quelle operation souhaitez-vous effectuer?");
			int Number = Convert.ToInt32(Console.ReadLine());

			int s = a + b;
			int subs = a - b;
			int p = a * b;
			int puissance = a ^ b;
			int racine = a ^ (1 / b);
			switch (Number)
			{
				case 1:
					Console.WriteLine($"a+b= {s}");
					break;
				case 2:
					Console.WriteLine($"a-b={subs}");
					break;
				case 3:
					Console.WriteLine($"a*b={p}");
					break;
				case 4:
					Console.WriteLine($"a^b={puissance}");
					break;
				case 5:
					Console.WriteLine($"aracineb={racine}");
					break;
				default:
					break;
			}
		}
	}
}

