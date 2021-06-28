		/*8 – Criar um programa que permita que o usuário digite um número, verificar e mostrar na tela se o número é positivo, negativo ou zero.*/
		Console.ForegroundColor= ConsoleColor.Red;
        Console.BackgroundColor= ConsoleColor.White ;
		int n1;
		Console.WriteLine("Entre com um numero: ");
		n1 = int.Parse(Console.ReadLine());
		
		if(n1 > 0)
			Console.WriteLine("É positivo");
		else if(n1 < 0)
			Console.WriteLine("É negativo");
		else
			Console.WriteLine("É Zero");