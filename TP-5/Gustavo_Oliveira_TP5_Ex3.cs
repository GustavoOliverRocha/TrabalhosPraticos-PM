using System;
					
public class Program
{
	public static void Main()
	{
		/*3 - Faça um programa para ler: a descrição do produto (nome),
		a quantidade adquirida e o preço unitário. Calcular e escrever o total
		(total = quantidade adquirida * preço unitário), o desconto e o total a pagar
		(total a pagar = total - desconto), sabendo-se que:
			- Se quantidade <= 5 o desconto será de 2%
			- Se quantidade > 5 e quantidade <=10 o desconto será de 3%
			- Se quantidade > 10 o desconto será de 5%*/
		
		
		string nm;
		int qt;
		double preco,total,totalPag,desc;
		desc = 0;
		
		Console.WriteLine("Entre com o nome: ");
		nm = Console.ReadLine();
		Console.WriteLine("Entre com o preco: ");
		preco = double.Parse(Console.ReadLine());
		Console.WriteLine("Entre com a quantidade: ");
		qt = int.Parse(Console.ReadLine());
		
		total = preco * qt;
		
		if(qt <= 5)
			desc = total * 0.02;
		else if(qt <= 10)
			desc = total * 0.03;
		else
			desc = total * 0.05;
		
		totalPag = total - desc;
		
		Console.WriteLine("Produto: " + nm);
		Console.WriteLine("Total: R$ " + total);
		Console.WriteLine("Desconto R$ " + desc);
		Console.WriteLine("Total a Pagar: R$ " + totalPag);
		
		
	}
}