using System;
					
public class Program
{
	public static void Main()
	{
	/*4-Faça um programa para ler as 3 notas. Calcular a média de aproveitamento,
	usando a fórmula abaixo e escrever o conceito do aluno de acordo com a tabela
	de conceitos mais abaixo:
		AP = 25%	TP = 25%	P = 50%*/
		
		double nt1,nt2,nt3,md;
		
		Console.WriteLine("Entre com a primeira Nota: ");
		nt1 = double.Parse(Console.ReadLine());
		Console.WriteLine("Entre com a segunda Nota: ");
		nt2 = double.Parse(Console.ReadLine());
		Console.WriteLine("Entre com a terceira Nota: ");
		nt3 = double.Parse(Console.ReadLine());
		
		md = (nt1 * 0.25) + (nt2 * 0.25) + (nt3 * 0.50);
		
		
		if(md >= 9)
			Console.WriteLine("Conceito: A");
		else if(md >= 7.5)
			Console.WriteLine("Conceito: B");
		else if(md >= 6)
			Console.WriteLine("Conceito: C");
		else
			Console.WriteLine("Conceito: D");
		
	}
}