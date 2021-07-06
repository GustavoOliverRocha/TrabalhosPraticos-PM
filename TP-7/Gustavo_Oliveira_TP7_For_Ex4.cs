using System;
					
public class Program
{
	public static void Main()
	{
		/*4 –Criar um programa que permita o usuário entrar com vinte números,
		após o termino da digitação, mostrar na tela qual o maior e menor numero que o usuário digitou.*/
		
		int n1,i,maior,menor;
		maior =0;
		menor = 0;
		for(i=0;i<20;i++)
		{
			Console.WriteLine("Entre com um numero: ");
			n1 = int.Parse(Console.ReadLine());
			if(i == 0)
			{
				maior = n1;
				menor = n1;
			}
			if(n1 > maior)
				maior = n1;
			if(n1 < menor)
				menor = n1;
		}
		Console.WriteLine("Maior numero: "+maior);
		Console.WriteLine("Menor numero: "+menor);
	}
}