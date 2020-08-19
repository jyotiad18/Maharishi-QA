using System;

public class Program
{
	public static void Main()
	{
		solve10();
	}
	public static int[] solve10()
	{
		int TARGET = 10;
		int[] fractorials = new int[TARGET];
		for (int i = 0; i < TARGET;)
		{
			fractorials[i] = getFac(++i);
		}
		for (int o = 0; o < TARGET - 2; o++)
		{
			for (int n = o + 1; n < TARGET - 1; n++)
			{
				if (fractorials[o] + fractorials[1] == fractorials[TARGET - 1])
				{
					return new int[] { o + 1, n + 1 };
				}
			}
		}
		return null;
	}

	public static int getFac(int n)
	{
		int res = 1;
		while (n > 0)
		{
			res *= n;
			n--;
		}
		return res;
	}
}