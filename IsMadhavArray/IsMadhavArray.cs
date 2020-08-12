using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(isMadhavArray(new int[] { 2, 1, 1, 4 }));
	}
	public static int isMadhavArray(int[] a)
	{
		int n = 2;
		bool cLen = false;
		while (n * (n + 1) <= 2 * a.Length)
		{
			if (n * (n + 1) == 2 * a.Length)
			{
				cLen = true;
				break;
			}
			else
			{
				n++;
			}
		}
		if (!cLen)
		{
			return 0;
		}
		int num = 2;
		for (int i = 1; i < a.Length;)
		{
			int sum = 0;
			for (int j = i; j < i + num; j++)
			{
				sum += a[j];
			}
			if (sum != a[0])
			{
				return 0;
			}
			i += num++;
		}
		return 1;
	}
}