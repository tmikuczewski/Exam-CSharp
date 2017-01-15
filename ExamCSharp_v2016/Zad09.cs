using System;

namespace ExamCSharp_v2016
{
	public abstract class KontoBankowe
	{
		public KlientBanku Wlasciciel { get; set; }
		public string Numer { get; set; }
		public decimal Stan { get; set; }

		public abstract bool Przelew(decimal d);
		public abstract void WplataWlasna(decimal d);
		public abstract bool Wyplata(decimal d);

		public override string ToString() => $"Dostępne środki: {Math.Round(this.Stan, 2)} zł";
	}

	public class KlientBanku
	{
	}

	public class KontoStudent : KontoBankowe
	{
		public KontoStudent(string numerKonta)
			: this(numerKonta, 0M)
		{
		}
		public KontoStudent(string numerKonta, decimal stanPoczatkowy)
		{
			this.Wlasciciel = new KlientBanku();
			this.Numer = numerKonta;
			this.Stan = stanPoczatkowy;
		}

		public override bool Przelew(decimal d)
		{
			if ((d < 0M) || (this.Stan < d))
			{
				return false;
			}

			if (d < 100M)
			{
				this.Stan -= d;
			}
			else if (this.Stan >= (1.005M * d))
			{
				this.Stan -= (1.005M * d);
			}
			else
			{
				return false;
			}
			return true;
		}
		public override void WplataWlasna(decimal d)
		{
			if (d < 0M)
			{
				return;
			}

			if (d > 1000M)
			{
				this.Stan += (d + 10);
			}
			else
			{
				this.Stan += d;
			}
		}
		public override bool Wyplata(decimal d)
		{
			if ((d < 0M) || (d > 100M) || (this.Stan < d))
			{
				return false;
			}
			this.Stan -= d;
			return true;
		}
	}

	public class KontoFirma : KontoBankowe
	{
		public KontoFirma(string numerKonta)
			: this(numerKonta, 0M)
		{
		}
		public KontoFirma(string numerKonta, decimal stanPoczatkowy)
		{
			this.Wlasciciel = new KlientBanku();
			this.Numer = numerKonta;
			this.Stan = stanPoczatkowy;
		}

		public override bool Przelew(decimal d)
		{
			if ((d < 0M) || (this.Stan < (d + 10)))
			{
				return false;
			}
			this.Stan -= (d + 10);
			return true;
		}
		public override void WplataWlasna(decimal d)
		{
			if ((d < 0M) || (this.Stan < 9M))
			{
				return;
			}

			if (d < 1000M)
			{
				this.Stan += (d - 10);
			}
			else
			{
				this.Stan += d;
			}
		}
		public override bool Wyplata(decimal d)
		{
			return Przelew(d);
		}
	}
}
