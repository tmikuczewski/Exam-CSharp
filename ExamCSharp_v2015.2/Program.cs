using System;

namespace ExamCSharp_v2015._2
{
	class Program
	{
		static void Main(string[] args)
		{
			// zad04
			FunkcjaKwadratowa
				fk1 = new FunkcjaKwadratowa(2, -3, 1),
				fk2 = new FunkcjaKwadratowa(2, 3, 1),
				fk3 = new FunkcjaKwadratowa(2, -3, -1),
				fk4 = new FunkcjaKwadratowa(2, 0, 1),
				fk5 = new FunkcjaKwadratowa(2, -3, 0),
				fk6 = new FunkcjaKwadratowa(-2, -3, -1);
			Console.WriteLine($"1. {fk1}");
			Console.WriteLine($"2. {fk2}");
			Console.WriteLine($"3. {fk3}");
			Console.WriteLine($"4. {fk4}");
			Console.WriteLine($"5. {fk5}");
			Console.WriteLine($"6. {fk6}");

			double[,] pierwiastki = fk1.Pierwiastki();
			Console.WriteLine($"Ad1. x1: {pierwiastki[0, 0]}, x2: {pierwiastki[1, 0]}");
			// /zad04
			Console.WriteLine();

			// zad05
			KontoStandard ks = new KontoStandard("85502016000023017");
			KontoPremium kp = new KontoPremium("63724296000024519", 1000);

			ks.Wplata(1000);
			Console.WriteLine("KontoStd: " + ks.Stan);
			ks.Wyplata(200);
			Console.WriteLine("KontoStd: " + ks.Stan);

			kp.Wplata(200);
			Console.WriteLine("KontoPrem: " + kp.Stan);
			kp.Wplata(15000);
			Console.WriteLine("KontoPrem: " + kp.Stan);
			kp.Wyplata(15000);
			Console.WriteLine("KontoPrem: " + kp.Stan);
			kp.Wyplata(1300);
			Console.WriteLine("KontoPrem: " + kp.Stan);
			kp.Wyplata(kp.Stan + 1000);
			Console.WriteLine("KontoPrem: " + kp.Stan);
			// /zad05
		}
	}
}
