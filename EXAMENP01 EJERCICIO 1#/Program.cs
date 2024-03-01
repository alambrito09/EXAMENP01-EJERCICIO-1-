try
{
    long num1, opcion;
    double num2;
    opcion = 0;

    do
    {
        Console.Clear();
        Console.WriteLine("bienvenido al programa ");
        Console.WriteLine("opcion 1 factorial de un numero");
        Console.WriteLine("opcion 2 raiz cuadrada");
        Console.WriteLine("opcion 3 salir del programa");

        if (opcion != 3)
        {
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("bienvenido al conversor de factorial");
                    Console.WriteLine("ingrese un numero porfavor que sea enterno porque sino no funciona ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    long num3 = 1;
                    for (int i = 1; i <= num1; i++)
                    {
                        num3 = num3 * i;
                    }
                    Console.WriteLine("el resultado es " + num3);
                    break;
                case 2:
                    Console.WriteLine("bienvenido ala raiz cuadrada de un umero ");
                    Console.WriteLine("ingrese un numero");
                    num2 = int.Parse(Console.ReadLine());
                    double raiz = Math.Sqrt(num2);
                    Console.WriteLine("el resultado es " + raiz);
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;

            }

            Console.WriteLine("repetir 1");
            Console.WriteLine("salir 3");
            opcion = int.Parse(Console.ReadLine());



        }



    }


    while (opcion != 3);
    {
        Console.WriteLine("gracias por utilizar el programa bye");
    }

}
catch (Exception error)
{
    Console.Clear();
    Console.WriteLine();

    Console.WriteLine("VALOR NO VALIDO");
}