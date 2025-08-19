using System.ComponentModel.Design;

Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe seu salário: ");
decimal salario = decimal.Parse(Console.ReadLine());

Console.WriteLine($"Seu nome é {nome} e seu salário é R${salario}");

decimal faixa1 = 2259.20m;
decimal faixa2 = 2826.65m;
decimal faixa3 = 3751.05m;
decimal faixa4 = 4664.68m;
decimal faixa5 = 4664.49m;


if (salario <= faixa1)
{
    Console.WriteLine("Você está isento de imposto");
}

else if (salario <= faixa2)
{
    double irps = (double)salario * 0.075 - 169.41;
    Console.WriteLine(irps);
}

else if (salario <= faixa3)
{
    double irps = (double)salario * 0.15 - 381.44;
    Console.WriteLine(irps);
}

else if (salario <= faixa4)
{
    double irps = (double)salario * 0.225 - 662.77;
    Console.WriteLine(irps);
}

else if (salario > faixa5)
{
    double irps = (double)salario * 0.275 - 896;
    Console.WriteLine(irps);
}

