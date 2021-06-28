		//2 – Elaborar um programa que permita que o usuário digite uma temperatura em graus Celsius e o programa converta para Kelvin.
		Console.ForegroundColor= ConsoleColor.Red;
        Console.BackgroundColor= ConsoleColor.Yellow;
		double c,k;
		Console.WriteLine("Entre com a temperatura em Celsius: ");
		c = double.Parse(Console.ReadLine());
		k = c + 273.15;
		Console.WriteLine("Temperatura em Kelvin: "+k);