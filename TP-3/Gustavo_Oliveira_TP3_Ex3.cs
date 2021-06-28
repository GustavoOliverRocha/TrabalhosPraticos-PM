//Ex3 Strings
		string nmCompleto,nm,sobre;
		Console.WriteLine("Entre com o nome completo: ");
		nmCompleto= Console.ReadLine();
		
		nm = nmCompleto.Substring(0,nmCompleto.IndexOf(" "));
		sobre = nmCompleto.Replace(nm,"");
		Console.WriteLine("Nome: "+ nm);
		Console.WriteLine("Sobrenome: "+ sobre);
		Console.WriteLine("O conteúdo da string do caractere 5 ao 10: "+(nmCompleto.Substring(5,5)));
		Console.WriteLine("Troca do 'a' pelo 'o' "+(nmCompleto.Replace("a","o")));