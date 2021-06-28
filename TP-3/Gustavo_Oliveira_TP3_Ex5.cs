		//5 – DESAFIO(Crie um gerador de e-mail que solicite o nome do usuário completo e mostre ao final o email:  nome.ultimosobrenome@fatec.sp.gov.br
		string nomeComp,email,nome,nomeult;
		Console.WriteLine("Entre com o nome completo: ");
		nomeComp = Console.ReadLine();
		string[] nomesQuebrados = nomeComp.Split(new char[] { ' ' });
		nome = nomesQuebrados[0].ToLower();
		nomeult = nomesQuebrados[nomesQuebrados.Length-1].ToLower();
		email = nome+"."+nomeult+"@fatec.sp.gov.br";
		Console.WriteLine("Seu email: "+ email);