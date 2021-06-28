		//6 – Criar um programa que permita que o usuário digite um número, verificar se o mesmo é múltiplo de 5.
		Console.ForegroundColor= ConsoleColor.Red;
        Console.BackgroundColor= ConsoleColor.DarkYellow;
		int nm, result;
		Console.WriteLine("Entre com um numero: ");
		nm = int.Parse(Console.ReadLine());
		
		result = nm % 5;
		if(result == 0)
			Console.WriteLine("É multiplo de 5");
		else
			Console.WriteLine("Não é multiplo de 5");