using System;

public class Arr
{
	static void Main(string[] args)
	{
		int[] Arr = { 1, 5, 20, 4, 0, 3, 6 };
		int result = 0;
		for (int i = 0; i < Arr.Length; i++)
		{
			if (Arr[i] % 2 == 0)
			{
				result = result + Arr[i];
			}
		}
		Console.WriteLine("Сумма четных элементов масссива = {0}", result);
		Console.ReadKey();
	}

}