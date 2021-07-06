using System;
					
public class Program
{
	public static void Main()
	{
		/*3 – Crie um programa que permita que o usuário digite 10 números, some apenas os números digitados maiores do que 10.*/
		int n1,i,acum;
		acum = 0;
		for(i=0;i<10;i++)
		{
			Console.WriteLine("Entre com um numero: ");
			n1 = int.Parse(Console.ReadLine());
			/*if(i == 0)
				acum = n1;*/
			if(n1 > 10)
				acum += n1;
		}
		Console.WriteLine(acum);
	}
}