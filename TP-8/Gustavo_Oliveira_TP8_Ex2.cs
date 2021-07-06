using System;
					
public class Program
{
	public static void Main()
	{
		/*2 - Elabore um programa que receba via teclado quatro notas de um aluno.
		Calcular e exibir na tela a media aritmética dessas notas.
		Obs. A cada nota digitada, verificar se as mesmas estão no intervalo de 0 a 10.
		Perguntar se o usuário deseja continuar.*/
		
		double n1,n2,n3,n4,ma;
		int op;
		do
		{
			vnt1:
			Console.WriteLine("Entre com a primeira nota: ");
			n1 =  double.Parse(Console.ReadLine());
			if(n1 < 0 || n1 > 10)
			{
				Console.WriteLine("Nota invalida\n\n\n");
				goto vnt1;
			}
			
			
			vnt2:
			Console.WriteLine("Entre com a segunda nota: ");
			n2 =  double.Parse(Console.ReadLine());
			if(n2 < 0 || n2 > 10)
			{
				Console.WriteLine("Nota invalida\n\n\n");
				goto vnt2;
			}
			
			
			vnt3:
			Console.WriteLine("Entre com a terceira nota: ");
			n3 =  double.Parse(Console.ReadLine());
			if(n3 < 0 || n3 > 10)
			{
				Console.WriteLine("Nota invalida\n\n\n");
				goto vnt3;
			}
			
			vnt4:
			Console.WriteLine("Entre com a quarta nota: ");
			n4 =  double.Parse(Console.ReadLine());
			if(n4 < 0 || n4 > 10)
			{
				Console.WriteLine("Nota invalida\n\n\n");
				goto vnt4;
			}

			ma = (n1+n2+n3+n4)/4;

			Console.WriteLine("\n\n\nMedia aritmética: "+ ma);
			Console.WriteLine("\n\nDeseja continuar?\n1 para continuar, qualquer outra tecla para sair");
			op = int.Parse(Console.ReadLine());
			
		}while(op == 1);
		
		Console.WriteLine("Programa Encerrado");
		
	}

}