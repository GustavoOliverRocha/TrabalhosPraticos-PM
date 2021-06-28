using System;
					
public class Program
{
	public static void Main()
	{
		//Ex8
		double n1,n2,n3,mdf;
		Console.WriteLine("Entre com a primeira nota:");
		n1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com a segunda nota:");
		n2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com a terceira nota:");
		n3 = int.Parse(Console.ReadLine());
		
		mdf = ((n1*2)+(n2*3)+(n3*5))/10;
		Console.WriteLine("Media final: "+mdf);
		
	}
}