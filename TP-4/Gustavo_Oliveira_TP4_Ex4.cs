using System;
					
public class Program
{		static int Sominha(int n1, int n2)
		{
			return n1+n2;
		}
	public static void Main()
	{
		//Ex4
		int n1,n2,n3, md;
		Console.WriteLine("Entre com o primeiro numero:");
		n1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o segundo numero:");
		n2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o terceiro numero:");
		n3 = int.Parse(Console.ReadLine());
		
		md = (n1+n2+n3)/3;
		
		Console.WriteLine("Media: " + md);	
		
	}
}