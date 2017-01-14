using System;

namespace ExamCSharp_v2015._1
{
	public abstract class Figura
	{
		//TM: Treść zadania wymusza typ zwracany 'int'.
		public abstract int PolePowierzchni();
	}

	public class Kolo : Figura
	{
		public Kolo(int promien)
		{
			this.Promien = promien;
		}

		public int Promien { get; set; }

		public override int PolePowierzchni() => (int)(Math.PI * Math.Pow(this.Promien, 2));
	}

	public abstract class Ostroslup
	{
		public Figura PolePodstawy { get; set; }
		public int Wysokosc { get; set; }

		public abstract double Objetosc();
	}

	public class Stozek : Ostroslup
	{
		public Stozek(int promienPodstawy, int wysokosc)
		{
			this.PolePodstawy = new Kolo(promienPodstawy);
			this.Wysokosc = wysokosc;
		}

		public override double Objetosc() => ((1D / 3D) * this.PolePodstawy.PolePowierzchni() * this.Wysokosc);
	}
}
