using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> items = new List<int> { 1, 5, 33, 24, 12, 50 };
			Func<int, bool> func = n => n % 2 == 0;

			var result = GetEvenInts(items, func);
			foreach (int i in result)
			{
				Console.WriteLine(i);
			}
		}
		static List<int> GetEvenInts(List<int> list, Func<int, bool> func)
		{
			List<int> GetEvenItems = new List<int>();
			foreach (int i in list)
			{
				bool getEven = func(i);
				Console.WriteLine($"{i} 是否為偶數: {getEven}");
				if (func(i))
				{
					GetEvenItems.Add(i);
				}
			}
			return GetEvenItems;
		}
	}
}
