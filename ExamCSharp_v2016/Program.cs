using System;

namespace ExamCSharp_v2016
{
	class Program
	{
		static void Main(string[] args)
		{
			// zad08
			Wektor w1 = new Wektor(5);
			Wektor w2 = new Wektor(5, 2);
			Wektor w3 = new Wektor(1, 2, 3, 4, 5);
			Wektor w4 = new Wektor(5, 4, 3, 2, 1);

			double iloczynSkalarny = Wektor.IloczynSkalarny(w3, w4);
			Wektor w = w3 + w4;

			Console.WriteLine(w1);
			Console.WriteLine(w2);
			Console.WriteLine(w3);
			Console.WriteLine(w4);
			Console.WriteLine(w3.Dim.ToString());
			Console.WriteLine(w4[2].ToString());
			Console.WriteLine(iloczynSkalarny.ToString());
			Console.WriteLine(w);
			// /zad08
			Console.WriteLine();

			// zad09
			KontoBankowe[] listaKont = new KontoBankowe[]
			{
				new KontoStudent("569800230038165276", 100),
				new KontoStudent("257500243397412677", 250),
				new KontoFirma("357692760032000053", 1000),
				new KontoFirma("557463669700009483", 2500)
			};
			foreach (KontoBankowe konto in listaKont)
			{
				Console.WriteLine(konto);
			}
			Console.WriteLine(" -5zł");
			foreach (KontoBankowe konto in listaKont)
			{
				konto.Wyplata(5);
			}
			foreach (KontoBankowe konto in listaKont)
			{
				Console.WriteLine(konto);
			}
			// /zad09
		}
	}
}
