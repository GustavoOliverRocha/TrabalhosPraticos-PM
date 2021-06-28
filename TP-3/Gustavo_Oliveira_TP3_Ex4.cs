//4 – Crie um gerador de e-mail que solicite o nome do usuário completo e mostre ao final o email: nome@fatec.sp.gov.br
	string nome, email;
	Console.WriteLine("Entre com o nome completo: ");
	nome = Console.ReadLine();
	email = nome.Substring(0,nome.IndexOf(" "))+"@fatec.sp.gov.br";
	Console.WriteLine("Seu email é: "+ email);