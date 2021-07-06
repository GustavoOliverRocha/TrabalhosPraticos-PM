
using System;
					
public class Program
{
	public static void Main()
	{
		/*4 - Crie um programa que leia um número do teclado até
			que encontre um número igual a zero. No final, mostre a
			soma dos números digitados.*/
		int n1,acum;
		acum = 0;
		do{

			Console.WriteLine("Entre com um numero: ");
			n1 = int.Parse(Console.ReadLine());
			acum += n1;

		}while(n1 != 0);
		Console.WriteLine("Soma dos numeros: "+ acum);
		
	}
}