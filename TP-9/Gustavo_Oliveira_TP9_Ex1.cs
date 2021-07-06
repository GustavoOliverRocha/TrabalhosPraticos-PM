using System;
					
public class Program
{
	static int sominha(int n1, int n2)
	{
		return n1+n2;
	}

	static int subtracao(int n1, int n2)
	{
		return n1-n2;
	}

	static int multiplicacao(int n1, int n2)
	{
		return n1*n2;
	}

	static int divisao(int n1, int n2)
	{
		return n1/n2;
	}

	public static void Main()
	{
		int n1,n2,op;
		inicio:

		Console.WriteLine("Escolha a operacao: ");
		Console.WriteLine("1- Somar.");
		Console.WriteLine("2- Subtrair.");
		Console.WriteLine("3- Multiplicar.");
		Console.WriteLine("4- Dividir.");
		op = int.Parse(Console.ReadLine());

		switch(op)
		{
			case 1:
				Console.WriteLine("\n\nSomar(+)");
				Console.WriteLine("Entre com um numero: ");
				n1 = int.Parse(Console.ReadLine());
				Console.WriteLine("Entre com outro numero: ");
				n2 = int.Parse(Console.ReadLine());
				Console.WriteLine("O Resultado da Soma é: " + sominha(n1,n2));
			break;

			case 2:
				Console.WriteLine("\n\nSubtrair(-)");
				Console.WriteLine("Entre com um numero: ");
				n1 = int.Parse(Console.ReadLine());
				Console.WriteLine("Entre com outro numero: ");
				n2 = int.Parse(Console.ReadLine());
				Console.WriteLine("O Resultado da Subtracao é: " + subtracao(n1,n2));
			break;

			case 3:
				Console.WriteLine("\n\nMultiplicar(x)");
				Console.WriteLine("Entre com um numero: ");
				n1 = int.Parse(Console.ReadLine());
				Console.WriteLine("Entre com outro numero: ");
				n2 = int.Parse(Console.ReadLine());
				Console.WriteLine("O Resultado da Multiplicacao é: " + multiplicacao(n1,n2));
			break;

			case 4:
				Console.WriteLine("\n\nDividir(/)");
				Console.WriteLine("Entre com um numero: ");
				n1 = int.Parse(Console.ReadLine());
				Console.WriteLine("Entre com outro numero: ");
				n2 = int.Parse(Console.ReadLine());
				Console.WriteLine("O Resultado da Divisao é: " + divisao(n1,n2));
			break;
			
			default:
				Console.WriteLine("Error: Opcao invalida\n\n"); 
				goto inicio;
			break;
		}
	}
}