		//4 – Criar um programa que permita que o usuário digite seu peso em kg, calcular e mostrar:Peso em gramas, O peso com um acréscimo de 10%
		Console.ForegroundColor= ConsoleColor.DarkBlue;
        Console.BackgroundColor= ConsoleColor.Grey  ;
		double peso,g;
		Console.WriteLine("Entre seu Peso em KG: ");
		peso = double.Parse(Console.ReadLine());
		g = peso * 1000;
		Console.WriteLine("Seu peso em g: "+ g);
		Console.WriteLine("Peso com acrescimo de 10% em g: " + (g + (g*0.1)));
		Console.WriteLine("Peso com acrescimo de 10% em KG: " + (peso + (peso*0.1)));