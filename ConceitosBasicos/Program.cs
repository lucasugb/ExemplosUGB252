using System.ComponentModel.Design;

Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe seu salário: ");
decimal salario = decimal.Parse(Console.ReadLine());

Console.WriteLine($"Seu nome é {nome} e seu salário é R${salario}");

decimal faixa1 = 2259.20m; //se menor ou igual = isento
decimal faixa2 = 2826.65m; //De 2.259,21 até 2.826,65: 7,5%
decimal faixa3 = 3751.05m; //De 2.826,66 até 3.751,05: 15%
decimal faixa4 = 4664.68m; //De 3.751,07 até 4.664,68: 22,5%
decimal faixa5 = 4664.49m; //Acima de R$ 4.664,68: 27,5%


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

