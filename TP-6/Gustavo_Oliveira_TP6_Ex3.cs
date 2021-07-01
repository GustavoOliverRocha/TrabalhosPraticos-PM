using System;
					
public class Program
{
	public static void Main()
	{
		/*3 - Uma empresa concederá um aumento de salário aos seus funcionários, variável de acordo com o cargo,
		conforme a tabela abaixo.Programa que lê o salário e o código do cargo de um funcionário e calcula o novo salário.
				Se o cargo do funcionário não estiver na tabela, ele recebe 40% de aumento.
            Código     Cargo               Aumento

            1               Gerente              10%

            2               Analista              20%

            3               Técnico               30%

			•No final é mostrado o salário antigo, o novo salário e a diferença.*/
		Console.ForegroundColor= ConsoleColor.Red;
        Console.BackgroundColor= ConsoleColor.Yellow;
		int cd;
		double sal,nSal,dif;
		Console.WriteLine("Entre com o Codigo do funcionario");
		cd = int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o Salario: ");
		sal = double.Parse(Console.ReadLine());
		switch(cd)
		{
			case 1: nSal = sal + (sal * 0.10); break;
			case 2: nSal = sal + (sal * 0.20); break;
			case 3: nSal = sal + (sal * 0.30); break;
			default: nSal = sal + (sal * 0.40); break;
		}
		dif = nSal - sal;
		Console.WriteLine("Antigo salario: "+ sal);
		Console.WriteLine("Novo salario: "+ nSal);
		Console.WriteLine("Diferenca: " + dif);
		
	}
}