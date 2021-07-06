using System;
					
public class Program
{
	public static void Main()
	{
		/*1 – Elabore um programa que crie o seguinte menu:
		Formulas:
		  1 – Baskara.
		  2 – Força. (F = m * a)
		  3 – Velocidade. (V = Vo + a*t)*/
		Console.ForegroundColor= ConsoleColor.DarkBlue;
        Console.BackgroundColor= ConsoleColor.White ;
		
		int op;
		Console.WriteLine("==================Outra Calculadorinhaaa==================");
		Console.WriteLine("1-Bhaskasra");
		Console.WriteLine("2- Forca");
		Console.WriteLine("3-Velocidade");
		op = int.Parse(Console.ReadLine());
		switch(op)
		{
			case 1:		
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
					x1 = (-b + (Math.Sqrt(delta)))/(2*a);
					x2 = (-b - (Math.Sqrt(delta)))/(2*a);
					Console.WriteLine("Delta: "+ delta);
					Console.WriteLine("x1: "+ x1);
					Console.WriteLine("x2: "+ x2);
				}
				else
					Console.WriteLine("Delta menor que zero, não há raizes");
				
			break;
				
			case 2:
				double mass,acel,forca;
				Console.WriteLine("Entre com a Massa: ");
				mass = double.Parse(Console.ReadLine());
				Console.WriteLine("Entre com a Aceleracao: ");
				acel = double.Parse(Console.ReadLine());
				
				forca = mass * acel;
				Console.WriteLine("Forca: "+ forca);
			break;
				
			case 3:
				double ace,tem,vo,v;
				
				Console.WriteLine("Entre com velocidade inicial: ");
				vo = double.Parse(Console.ReadLine());
				
				Console.WriteLine("Entre com a Aceleracao: ");
				ace = double.Parse(Console.ReadLine());
				
				Console.WriteLine("Entre com o Tempo: ");
				tem = double.Parse(Console.ReadLine());
				
				v = vo + (ace * tem);
				
				Console.WriteLine("Velocidade: "+v);
			break;

			default: 
				Console.WriteLine("ERROR: Opcao invalida");
			break;
		
		}
	}
}