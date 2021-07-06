using System;
					
public class Program
{
	public static void Main()
	{
	//2 - Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.
		int idade,i,pessoas;
		i=0;
		pessoas = 0;
		while(i < 10)
		{
			Console.WriteLine("Entre com a idade da "+(i+1)+"º pessoa: ");
			idade = int.Parse(Console.ReadLine());
			if(idade > 18)
				pessoas++;
			i++;
		}
		Console.WriteLine("Numero de pessoas maiores de 18 são: "+pessoas);
	}
}