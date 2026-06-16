//receita
		double farinhaXicara = 2/4.0;
		double tomateXicara = 1/4.0;
		double leiteMl = 200/4.0;
		double ovo = 2/4.0;
		double salColher = 1/4.0;
					
		Console.WriteLine("Quantas porções deseja fazer?");
		int porcao = int.Parse(Console.ReadLine());
		
		Console.WriteLine($"Ingredientes para {porcao} porções:");
		Console.WriteLine($"Farinha: {farinhaXicara*porcao} xícara(s)");	
		Console.WriteLine($"Tomate picado: {tomateXicara*porcao} xícara(s)");
		Console.WriteLine($"Leite: {leiteMl*porcao} ml");
		Console.WriteLine($"Ovos: {ovo*porcao} unidade(s)");
		Console.WriteLine($"Sal: {salColher*porcao} colher(es)");
