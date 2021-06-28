using System;
					
public class Program
{
	public static void Main()
	{
		//Ex6
		double b,a;
		Console.WriteLine("Entre com a base:");
		b = double.Parse(Console.ReadLine());
		Console.WriteLine("Entre com a Altura:");
		a = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Area do Retangulo: " + (b*a));
		
	}
}