using System;
					
public class Program
{
	public static void Main()
	{
		/*2 – Crie um programa que permite que o usuário digite o valor de um numero qualquer,
		verificar se o numero é múltiplo de 3 e de 7 ao mesmo tempo,
		caso seja imprimir na tela “Múltiplo de 3 e 7”, caso não imprimir “Não é múltiplo”.*/
		int n1,m3,m7;
		Console.WriteLine("Entre com o numero: ");
		n1 = int.Parse(Console.ReadLine());
		m3 = n1 % 3;
		m7 = n1 % 7;
		if(m3 == 0 && m7 == 0)
			Console.WriteLine("É multiplo de 7 e 3");
		else 
			Console.WriteLine("Não é multiplo de 7 e 3");
		
	}
}