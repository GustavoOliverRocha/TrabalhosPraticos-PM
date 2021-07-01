using System;
					
public class Program
{
	public static void Main()
	{
	/*2 – Desenvolva uma calculadora, onde será necessário entrar com a operação,
	primeiro e segundo valor, exiba o resultado na tela.*/
		Console.ForegroundColor= ConsoleColor.DarkBlue;
        Console.BackgroundColor= ConsoleColor.White ;
		int op;
		double n1,n2;
		
		Console.WriteLine("============== Calculadorinha ==============");
		Console.WriteLine("Tecle 1 para somar");
		Console.WriteLine("Tecle 2 para subtrair");
		Console.WriteLine("Tecle 3 para multiplicar");
		Console.WriteLine("Tecle 4 para dividir");
		op = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Entre com o primeiro numero: ");
		n1 = double.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o segundo numero: ");
		n2 = double.Parse(Console.ReadLine());
		
		switch(op)
		{
			case 1: Console.WriteLine("Soma: " + (n1+n2));break;
			case 2: Console.WriteLine("Subtracao: " + (n1-n2));break;
			case 3: Console.WriteLine("Multiplicacao: " + (n1*n2));break;
			case 4: Console.WriteLine("Divisao: " + (n1/n2));break;
			default: Console.WriteLine("ERROR: opcao invalida"); break;
		}

	}
}