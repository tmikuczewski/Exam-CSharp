using System;

namespace ExamCSharp_v2016
{
	public delegate void MojaDelegata(int ktoryRaz);

	public class Nadawca
	{
		public event MojaDelegata Z;

		public void A()
		{
			this.Z?.Invoke(++this._KtoryRaz);
		}

		private int _KtoryRaz;
	}

	public class Odbiorca
	{
		public void B(int ktoryRaz)
		{
			Console.WriteLine($"B wita {ktoryRaz}. raz!");
		}
	}
}
