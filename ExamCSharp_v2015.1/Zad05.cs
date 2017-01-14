namespace ExamCSharp_v2015._1
{
	public class Ulamek
	{
		public Ulamek()
			: this(1)
		{
		}
		public Ulamek(int liczba)
			: this(liczba, 1)
		{
		}
		public Ulamek(int licznik, uint mianownik)
		{
			this.Licznik = licznik;
			this.Mianownik = mianownik;
		}

		public int Licznik { get; set; }
		public uint Mianownik { get; set; }

		public override string ToString() 
			=> $"{this.Licznik}{((this.Mianownik != 1U) ? (@" \ " + this.Mianownik) : string.Empty)}";

		public static Ulamek Suma(Ulamek lewy, Ulamek prawy)
		{
			int nowyLicznik = (int)(lewy.Licznik * prawy.Mianownik) + (int)(prawy.Licznik * lewy.Mianownik);
			uint nowyMianownik = (lewy.Mianownik * prawy.Mianownik);

			return new Ulamek(nowyLicznik, nowyMianownik);
		}

		public static Ulamek operator *(Ulamek lewy, Ulamek prawy)
		{
			return new Ulamek((lewy.Licznik * prawy.Licznik), (lewy.Mianownik * prawy.Mianownik));
		}
	}
}
