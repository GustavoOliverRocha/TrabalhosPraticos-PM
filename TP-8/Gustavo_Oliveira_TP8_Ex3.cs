using System;
					
public class Program
{
	public static void Main()
	{
		/*3-Escreva um código que leia um número do teclado até que encontre
		um número menor ou igual a 1.*/
		
		int n1;
		do
		{
			Console.WriteLine("Entre com um numero: ");
			n1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Seu numero: "+ n1+"\n\n"  );
			
		}while(n1 > 1);
		
		Console.WriteLine("Programa Encerrado");
		
	}
}