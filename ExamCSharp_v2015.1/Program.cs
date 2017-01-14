using System;

namespace ExamCSharp_v2015._1
{
	class Program
	{
		static void Main(string[] args)
		{
			// zad04
			Stozek stozek = new Stozek(3, 4);
			Console.WriteLine(stozek.Objetosc());
			// /zad04
			Console.WriteLine();

			// zad05
			Ulamek ulamek1 = new Ulamek();
			Ulamek ulamek2 = new Ulamek(2);
			Ulamek ulamek3 = new Ulamek(1, 2);
			Ulamek ulamek4 = new Ulamek(-1, 3);
			Console.WriteLine(ulamek1);
			Console.WriteLine(ulamek2);
			Console.WriteLine(ulamek3);
			Console.WriteLine(ulamek4);
			Console.WriteLine(Ulamek.Suma(ulamek3, ulamek4));
			Console.WriteLine(ulamek3 * ulamek4);
			// /zad05
			Console.WriteLine();
		}
	}
}
