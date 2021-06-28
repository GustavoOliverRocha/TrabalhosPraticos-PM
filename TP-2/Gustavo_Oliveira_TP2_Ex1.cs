		//1 – Criar um programa que permita a digitação do salário mínimo e do salário do usuário, calcular quantos salários mínimos a pessoa ganha.
		Console.ForegroundColor= ConsoleColor.DarkBlue;
        Console.BackgroundColor= ConsoleColor.White ;
		double sal, salMin,qtSal;
		Console.WriteLine("Entre com o Salario: ");
		sal = double.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o Salario Minimo: ");
		salMin = double.Parse(Console.ReadLine());
		qtSal = Math.Round(sal / salMin);
		Console.WriteLine("Quantidade de Salarios minimos: " + qtSal);