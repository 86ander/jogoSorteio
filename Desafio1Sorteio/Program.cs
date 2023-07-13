int numeroInformado;
Random sorteia = new Random();
int numeroSorteado = sorteia.Next(1, 101);
for (int i=1; i<=10; i++)
{
    Console.WriteLine("Digite um número");
    numeroInformado = Convert.ToInt32(Console.ReadLine());
    if (numeroInformado == numeroSorteado)
    {
        Console.WriteLine("Párabens, você acertou o número");
        i = 10;
    } else if (numeroInformado > numeroSorteado)
        Console.WriteLine("Digite um número menor");
    else
        Console.WriteLine("Digite um numero maior");
    if (i == 10 && numeroInformado != numeroSorteado)
    {
        Console.WriteLine("Suas tentativas acabaram, infelizmente você não acertou o número");
        Console.WriteLine("O número sorteado era " + numeroSorteado);
    }
}

