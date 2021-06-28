//1 – Desenvolva um programa para calcular a área, diâmetro e perímetro do círculo.
		double r;
		Console.WriteLine("Entre com o Raio do circulo");
		r = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Area: " + (3.14* Math.Pow(r,2)));
		Console.WriteLine("Diametro: " + (2*r));
		Console.WriteLine("Perimetro: " + (2*3.14*r));