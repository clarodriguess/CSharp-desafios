Console.Write("Valor da compra: R$ ");
//double valor = Convert.ToDouble(Console.ReadLine());
double valor = double.Parse(Console.ReadLine());

double desconto = 0;

if (valor < 100)
{
    desconto = 0;
}
else if (valor < 500)
{
    desconto = 0.05;
}
else
{
    desconto = 0.10;
}

double valorFinal = valor - (valor * desconto);

Console.WriteLine($"Desconto aplicado: {desconto * 100}%");
Console.WriteLine($"Valor a pagar: R$ {valorFinal:F2}"); //2casas decimais
