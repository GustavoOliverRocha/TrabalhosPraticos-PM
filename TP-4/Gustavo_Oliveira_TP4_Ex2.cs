using System;
					
public class Program
{		static int Sominha(int n1, int n2)
		{
			return n1+n2;
		}
	public static void Main()
	{
		
		/*2 – Crie um programa e fluxograma que permita ao usuário entrar com dois números.
		Executar as quatro operações com esses dois números(Soma, Subtração, multiplicação, divisão).
		Não se esquecer de mostrar as respostas na tela.*/
		int n1,n2;
		Console.WriteLine("Entre com o primeiro numero:");
		n1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o segundo numero:");
		n2 = int.Parse(Console.ReadLine());
		
		
		Console.WriteLine("Soma: "+ (n1+n2));
		Console.WriteLine("Subtracao: "+ (n1-n2));
		Console.WriteLine("Multiplicacao: "+ (n1*n2));
		Console.WriteLine("Divisao: "+ (n1/n2));
		
	}
}