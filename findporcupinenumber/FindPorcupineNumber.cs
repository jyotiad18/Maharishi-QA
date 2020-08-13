using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(findPorcupineNumber(139));
	}
	public static int findPorcupineNumber(int a)
	{
		while (true)
		{
			if (IsPrime(++a) && IsValidLastNumber(a))
			{
				int j = a;
				while (true)
				{
					if (IsPrime(++j))
					{
						if (IsValidLastNumber(j))
						{
							return a;
						}
						else
						{
							break;
						}
					}
				}
			}
		}
	}
	public static bool IsValidLastNumber(int n)
	{
		return n % 10 == 9;
	}
	public static bool IsPrime(int n)
	{
		bool result = true;
		for (int i = 2; i < n; i++)
		{
			if (n % i == 0)
			{
				result = false;
				break;
			}
		}
		return result;
	}
}