		/*7 – A prefeitura esta concedendo empréstimos a seus funcionários seguindo a regra de que a prestação não pode
		ser maior que 30% do valor do salário. Criar um programa que permita a entrada do salário e da prestação do empréstimo,
		verificar se a prestação digitada corresponde a regra de empréstimo descrita acima.*/
		Console.ForegroundColor= ConsoleColor.DarkMagenta ;
        Console.BackgroundColor= ConsoleColor.DarkYellow ;
		double sal,presta,val;
		Console.WriteLine("Entre com o Salario: ");
		sal = double.Parse(Console.ReadLine());
		Console.WriteLine("Entre com a Prestacao: ");
		presta = double.Parse(Console.ReadLine());
		
		val = sal * 0.30;
		if( presta > val)
			Console.WriteLine("Prestacao maior que 30% do salario");
		else
			Console.WriteLine("Pode dar o emprestimo");