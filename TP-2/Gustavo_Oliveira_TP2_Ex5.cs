		//5 – Criar um programa que permita que o usuário digite um número, verificar se este número é maior que 20,
		//se for maior mostrar na tela a metade do número digitado, caso seja menor 20 mostrar o dobro do número digitado.
		Console.ForegroundColor= ConsoleColor.Red;
        Console.BackgroundColor= ConsoleColor.White ;
		double n1;
		Console.WriteLine("Entre com um numero: ");
		n1 = double.Parse(Console.ReadLine());
		
		if(n1 > 20)
			Console.WriteLine(n1/2);
		else
			Console.WriteLine(n1*2);