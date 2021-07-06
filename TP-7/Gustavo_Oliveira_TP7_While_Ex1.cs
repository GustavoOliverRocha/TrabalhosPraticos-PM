using System;
					
public class Program
{
	public static void Main()
	{
	//1 - Elabore um programa que exiba na tela uma sequencia de números naturais começando em I, terminando em F.
		int i,f;
		Console.WriteLine("Entre com o inicio: ");
		i = int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o fim: ");
		f = int.Parse(Console.ReadLine());
		Console.WriteLine("-----------------------");
		while(i <= f)
		{
			Console.WriteLine(i);
			i++;
		}
		Console.WriteLine("-----------------------");
	}
}