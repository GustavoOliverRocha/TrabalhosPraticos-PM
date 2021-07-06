using System;
					
public class Program
{
	public static void Main()
	{
		/*1 - Crie um programa que, utilizando a estrutura “Do While”,
		permita que o usuário digite um numero, este numero deve ser par,
		mostrar na tela o numero digitado. Não permitir que o usuário digite um numero que não seja par.*/
		
		int n1;
		do
		{
			Console.WriteLine("Entre com um numero par");
			n1 = int.Parse(Console.ReadLine());
			if(n1 % 2 != 0)
				Console.WriteLine("Errou: Por favor entre com um numero par\n\n");
		}while(n1 % 2 != 0);
		
		Console.WriteLine("Seu numero: " + n1);
		
	}
}