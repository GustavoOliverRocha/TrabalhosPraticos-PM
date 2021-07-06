using System;
					
public class Program
{
	public static void Main()
	{
		/*2 -  Ler um valor N e imprimir todos os valores inteiros
		entre 1 (inclusive) e N (inclusive). Considere que o N será sempre maior que ZERO.*/
		int n1,i;
		Console.WriteLine("Entre com um numero: ");
		n1 = int.Parse(Console.ReadLine());
		for(i=1;i<=n1;i++)
			Console.WriteLine(i);
		
	}
}