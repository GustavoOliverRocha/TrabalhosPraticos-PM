//2 – Elabore um programa que calcule a equação de segundo grau utilizando a formula de Bhaskara. OBS: O usuário deve entrar com ‘a’, ‘b’ e ‘c’ e devemos calcular o valor de ‘x1’ e ‘x2’.
		
		double a,b,c,delta,x1,x2;
		Console.WriteLine("Entre com o valor de A");
		a = double.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o valor de B");
		b = double.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o valor de C");
		c = double.Parse(Console.ReadLine());
		
		delta = (b*b)-4*a*c;
		if(delta >= 0)
		{
			x1 = - b + Math.Sqrt(delta)/(2*a);
			x2 = - b - Math.Sqrt(delta)/(2*a);
			Console.WriteLine("Delta: "+ delta);
			Console.WriteLine("x1: "+ x1);
			Console.WriteLine("x2: "+ x2);
		}
		else
			Console.WriteLine("Delta menor que zero, não há raizes");