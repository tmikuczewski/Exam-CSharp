namespace ExamCSharp_v2015._1
{
	public delegate void BoolDelegate(bool wartosc);

	public class A
	{
		public event BoolDelegate Z;

		public bool Wartosc { get; set; }

		public void MA()
		{
			Z?.Invoke(GetBool());
		}

		private bool GetBool()
		{
			this.Wartosc = !this.Wartosc;
			return this.Wartosc;
		}
	}

	public class B
	{
		public int IleRazy { get; set; }

		public void MB(bool wartosc)
		{
			if (wartosc)
			{
				this.IleRazy++;
			}
		}
	}
}
