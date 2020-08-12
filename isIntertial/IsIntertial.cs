using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(isInertial(new int[] { 2, 12, 4, 6, 8, 11 }));
	}
	public static int isInertial(int[] a)
	{
		List<int> odd = new List<int>();
		List<int> even = new List<int>();
		foreach (int _a in a)
		{
			if (_a % 2 == 0)
			{
				even.Add(_a);
			}
			else
			{
				odd.Add(_a);
			}
		}
		if (odd.Count == 0 || even.Count == 0)
		{
			return 0;
		}
		odd.Sort();
		if (even.Count == 1)
		{
			if (even[0] > odd[even.Count - 1])
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
		even.Sort();
		if (even[even.Count - 1] < odd[odd.Count - 1])
		{
			return 0;
		}
		if (even[even.Count - 2] < odd[0])
		{
			return 1;
		}
		return 0;
	}
}