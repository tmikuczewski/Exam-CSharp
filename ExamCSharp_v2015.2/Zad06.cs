using System;

namespace ExamCSharp_v2015._2
{
	public delegate void MojaDelegata();

	public class K1
	{
		public event MojaDelegata Z1;

		public void M1()
		{
			this.Z1?.Invoke();
		}
	}

	public class K2
	{
		public void M2()
		{
			Console.WriteLine("M2 wita!");
		}
	}
}
