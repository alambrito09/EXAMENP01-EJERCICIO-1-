try
{
    Console.WriteLine("Ingrese un número: ");
    int numero = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
        int resultado = numero * i;
        Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
    }
}
catch (Exception error)
{
    Console.WriteLine("valor no valido");
}