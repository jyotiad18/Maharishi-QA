using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(guthrieIndex(1));
		Console.WriteLine(guthrieIndex(3));
		Console.WriteLine(guthrieIndex(4));
		Console.WriteLine(guthrieIndex(42));
	}
	public static int guthrieIndex(int a)
	{
		int count = 0;
		if (a == 1) return count;

		while (a != 1)
		{
			if (a % 2 == 0)
			{
				a = a / 2;
			}
			else
			{
				a = (a * 3) + 1;
			}
			count++;
		}
		return count;
	}
}