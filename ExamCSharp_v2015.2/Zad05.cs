namespace ExamCSharp_v2015._2
{
	public abstract class KontoBankowe
	{
		public KontoBankowe(string numerKonta)
		{
			this._Wlasciciel = new Osoba();
			this._Numer = numerKonta;
		}

		public Osoba Wlasciciel => this._Wlasciciel;
		public string Numer => this._Numer;
		public decimal Stan => this._Stan;

		public abstract bool Wplata(decimal kwota);
		public abstract bool Wyplata(decimal kwota);

		protected Osoba _Wlasciciel;
		protected string _Numer;
		protected decimal _Stan;
	}

	public class Osoba
	{
		public string Pesel { get; set; }
	}

	public class KontoStandard : KontoBankowe
	{
		public KontoStandard(string numerKonta)
			: base(numerKonta)
		{
		}

		public override bool Wplata(decimal kwota)
		{
			if (kwota <= 0M)
			{
				return false;
			}
			this._Stan += kwota;
			return true;
		}

		public override bool Wyplata(decimal kwota)
		{
			if ((kwota <= 0M) || ((kwota + 1) > this.Stan))
			{
				return false;
			}
			this._Stan -= (kwota + 1);
			return true;
		}
	}

	public class KontoPremium : KontoBankowe
	{
		public KontoPremium(string numerKonta, decimal debet)
			: base(numerKonta)
		{
			this.Debet = debet;
		}

		public decimal Debet { get; set; }

		public override bool Wplata(decimal kwota)
		{
			if (kwota <= 0M)
			{
				return false;
			}

			if (kwota < 1000)
			{
				this._Stan += (kwota - 2);
			}
			else if (kwota > 10000)
			{
				this._Stan += (kwota + 10);
			}
			else
			{
				this._Stan += kwota;
			}
			return true;
		}

		public override bool Wyplata(decimal kwota)
		{
			if ((kwota <= 0M) || (kwota > (this.Stan + this.Debet)))
			{
				return false;
			}
			this._Stan -= kwota;
			return true;
		}
	}
}
