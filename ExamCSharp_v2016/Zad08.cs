using System;
using System.Collections.Generic;

namespace ExamCSharp_v2016
{
	public sealed class Wektor : List<double>
	{
		public Wektor(int n)
			: this(n, 1D)
		{
		}
		public Wektor(int n, double a)
		{
			for (int i = 0; i < n; i++)
			{
				this.Add(a);
			}
		}
		public Wektor(params double[] lista)
		{
			if (lista.Length > int.MaxValue)
			{
				throw new ArgumentOutOfRangeException(nameof(lista));
			}
			this.AddRange(lista);
		}

		public int Dim => this.Count;

		public override string ToString()
		{
			return (this.Dim > 0) ? $"{{{string.Join(",", this)}}}" : "pusty";
		}

		public static double IloczynSkalarny(Wektor lewy, Wektor prawy)
		{
			if (lewy.Dim != prawy.Dim)
			{
				throw new ArgumentException("Wymiary wektorów nie zgadzają się!");
			}

			double wynik = 0;
			for (int i = 0; i < lewy.Dim; i++)
			{
				wynik += (lewy[i] * prawy[i]);
			}
			return wynik;
		}

		public static Wektor operator +(Wektor lewy, Wektor prawy)
		{
			if (lewy.Dim != prawy.Dim)
			{
				throw new ArgumentException("Wymiary wektorów nie zgadzają się!");
			}

			Wektor wynik = new Wektor(lewy.Dim);
			for (int i = 0; i < lewy.Dim; i++)
			{
				wynik[i] = (lewy[i] + prawy[i]);
			}
			return wynik;
		}
	}
}
