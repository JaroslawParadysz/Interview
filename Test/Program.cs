using System;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			Color y = new Color { Name = "Blue" };
			Color x = y;
			y.Name = "Red";
			Console.WriteLine($"Color: {x.Name}");
		}
	}

	class Color
	{
		public string Name { get; set; }
	}
}
