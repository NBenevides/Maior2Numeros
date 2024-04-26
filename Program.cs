int numero1, numero2, maiorNumero;

Console.Write("Digite o primeiro numero: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2)
{
    maiorNumero = numero1;
}
else
{
    maiorNumero = numero2;

}

Console.WriteLine($"O maior numero e o: {maiorNumero}");