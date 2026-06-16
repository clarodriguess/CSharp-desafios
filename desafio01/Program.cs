	
	
		Console.WriteLine("Digite em que ano estamos: (AAAA)");
		int anoAtual = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Digite o ano do seu nascimento: (AAAA)");
		int anoNascimento = int.Parse(Console.ReadLine());
		
		int idade = anoAtual - anoNascimento;
		Console.WriteLine($"Você tem {idade} anos");
	
