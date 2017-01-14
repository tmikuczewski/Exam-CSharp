using System;
//using System.Numerics;

namespace ExamCSharp_v2015._2
{
	public class FunkcjaKwadratowa
	{
		public FunkcjaKwadratowa(double a, double b, double c)
		{
			if (a == 0D)
			{
				throw new ArgumentException("Wartość parametru musi być różna od zera!", nameof(this.A));
			}
			this.A = a;
			this.B = b;
			this.C = c;
		}

		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }

		public double Delta => (Math.Pow(this.B, 2) - (4 * this.A * this.C));

		public override string ToString()
		{
			string
				a = $"{this.A}x^2",
				b = (this.B != 0D) ? (((this.B >= 0D) ? " + " : " - ") + Math.Abs(this.B) + "x") : string.Empty,
				c = (this.C != 0D) ? (((this.C >= 0D) ? " + " : " - ") + Math.Abs(this.C)) : string.Empty;

			return $"{a}{b}{c}";
		}

		public double[,] Pierwiastki()
		{
			double delta = this.Delta;
			double aa = (2 * this.A);
			if (delta >= 0D)
			{
				double pierwiastekDelta = Math.Sqrt(delta);
				return new double[,]
				{
					{ ((-this.B - pierwiastekDelta) / aa), 0 },
					{ ((-this.B + pierwiastekDelta) / aa), 0 }
				};
			}
			else
			{
				//TM: Treść zadania wymusza typ zwracany double[,] co uniemożliwia obliczenie pierwiastków w dziedzinie zespolonej.
				//double pierwiastekDelta = Math.Sqrt(Math.Abs(delta));
				//Complex
				//	pierwiastek1 = new Complex(0, pierwiastekDelta),
				//	pierwiastek2 = new Complex(0, -pierwiastekDelta);
				//
				//return new Complex[,]
				//{
				//	{ ((-this.B + pierwiastek1) / aa), 0 },
				//	{ ((-this.B + pierwiastek2) / aa), 0 }
				//};

				throw new NotSupportedException();
			}
		}
	}
}
