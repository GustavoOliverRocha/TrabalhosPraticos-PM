using System;
					
public class Program
{
	public static void Main()
	{
		/*1 – Crie um programa que permita que o usuário digite o valor das
		vendas que executou neste mês, imprimir na tela o premio que ganhou
		por estas vendas de acordo com os critérios abaixo:

		•Menor que R$ 1000,00 (Sem premio).
		•Maior igual a R$ 1000,00 e menor que R$ 3000,00 (premio de R$ 150,00).
		•Maior igual a R$ 3000,00 (premio de R$ 300,00).*/

	     double vendas_val;

	     Console.WriteLine("Entre com o valor das Vendas:");
		 vendas_val = double.Parse(Console.ReadLine());
			
			if(vendas_val < 1000)
				Console.WriteLine("Sem Premio");
			
			else if(vendas_val >= 1000 && vendas_val < 3000)
				Console.WriteLine("Premio: R$ 150,00");
			
			else
				Console.WriteLine("Premio: R$ 300,00");
		
	}
}