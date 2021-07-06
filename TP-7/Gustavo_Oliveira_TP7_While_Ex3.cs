using System;
					
public class Program
{
	public static void Main()
	{
	//3 - Ler 10 valores e escrever quantos desses valores lidos são NEGATIVOS.
		int n1,i,nega;
		i=0;
		nega = 0;
		while(i < 10)
		{
			Console.WriteLine("Entre com o "+(i+1)+"º numero: ");
			n1 = int.Parse(Console.ReadLine());
			if(n1 < 0)
				nega++;
			i++;
		}
		Console.WriteLine("Total de Numeros negativos: "+nega);
	}
}