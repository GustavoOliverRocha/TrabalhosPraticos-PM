using System;
					
public class Program
{
	public static void Main()
	{
		//Ex7
		int idade;
		Console.WriteLine("Entre com sua Idade: ");
		idade = int.Parse(Console.ReadLine());
		Console.WriteLine("Anos: "+ idade);
		Console.WriteLine("Meses: "+ (idade*12));
		Console.WriteLine("Dias: "+ (idade*365));
		
	}
}