using System;
					
public class Program
{
	public static void Main()
	{
	// 4- Escreva um programa que imprima as seguintes sequencias de números: (1, 1 2 3 4 5 6 7 8 9 10) 
		//(2, 1 2 3 4 5 6 7 8 9 10) (3, 1 2 3 4 5 6 7 8 9 10) (4, 1 2 3 4 5 6 7 8 9 10) e assim sucessivamente,
		//até que o primeiro número (antes da vírgula), também chegue a 10.
		int i;
		i=1;
		while(i <= 10)
		{
			Console.WriteLine(i+"ª Sequencia: 1 2 3 4 5 6 7 8 9 10");
			i++;
		}
	}
}