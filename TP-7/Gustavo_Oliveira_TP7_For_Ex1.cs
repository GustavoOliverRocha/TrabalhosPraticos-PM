using System;
					
public class Program
{
	public static void Main()
	{
		//1 – Crie um programa que permita o usuário digitar um numero qualquer. Imprimir na tela a tabuada deste numero.
		int n1,i;
		Console.WriteLine("Entre com um numero: ");
		n1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Tabuada do "+n1);
		for(i=0; i<=10; i++)
		{
			Console.WriteLine(n1 +"x"+ i +" = "+ (n1*i));
		}
	}
}