using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(IsPrime(10, 30));
		Console.WriteLine(IsPrime(10, 29));
		Console.WriteLine(IsPrime(20, 22));
		Console.WriteLine(IsPrime(1, 1));
	}
	
	public static int IsPrime(int start, int end)
	{
		if (end == 1) return 0;
		if (start < 1) { 
			start = 2;
		}
	    int result = 0;
		for(int i = start; i <= end; i++)
		{
			if (IsPrime(i)) result++; 				
		}
		return result;
	}
	public static bool IsPrime(int n)
	{
		bool result = true;
		for(int i = 2; i < n; i++)
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
