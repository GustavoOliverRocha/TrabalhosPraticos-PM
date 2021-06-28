		//3 - Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor correspondente em graus Celsius
		Console.ForegroundColor= ConsoleColor.DarkBlue;
        Console.BackgroundColor= ConsoleColor.Yellow ;
		double f,c;
		Console.WriteLine("Entre com a temperatura em Fahrenheit: ");
		f = double.Parse(Console.ReadLine());
		c = (f - 32) * 5/9;
		Console.WriteLine("Temperatura em Celsius: " + c);