using System;
					
public class Program
{
	static bool seraqueeumtriangulo(int l1, int l2,int l3)
	{
		Console.WriteLine("Lado 1: "+l1);
		Console.WriteLine("Lado 2: "+l2);
		Console.WriteLine("Lado 3: "+l3);

		if(l1+l2 > l3 && l3 + l2 > l1 && l3 + l1 > l2)
			return true;
		else
			return false;
	}
public static void Main()
	{
		/*2-Crie um programa no qual o usuário deverá informar três valores inteiros
		(segmentos de retas). O programa deverá informar se esses valores representam
		os lados de um triângulo.
				Dica: Dados três segmentos de reta distintos,
				se a soma das medidas de dois deles é sempre maior que a
				medida do terceiro, então, eles podem formar um triângulo.*/

		int l1,l2,l3;

		Console.WriteLine("Entre com o primeiro lado: ");
		l1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o segundo lado: ");
		l2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o terceiro lado: ");
		l3 = int.Parse(Console.ReadLine());

		if(seraqueeumtriangulo(l1,l2,l3))
			Console.WriteLine("Pode formar um triangulo.");
		else
			Console.WriteLine("Não da pra formar um triangulo.");
	}
}