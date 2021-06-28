using System;
					
public class Program
{		static int Sominha(int n1, int n2)
		{
			return n1+n2;
		}
	public static void Main()
	{
		
	//Desenvolva um programa e fluxograma para calcular a idade de uma pessoa, entrando com o ano de nascimento e ano atual.

		int anoN, anoA;
		Console.WriteLine("Entre com o ano de nascimento: ");
		anoN =  int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o ano Atual: ");
		anoA = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Sua Idade e: "+ (anoA - anoN));
		
	}
}