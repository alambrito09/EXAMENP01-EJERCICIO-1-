try
{
    Random rand = new Random();
    int ramd = rand.Next(1, 101);
    int num4, opcion;
    opcion = 0;
    do
    {
        Console.WriteLine("quieres jugar ");
        Console.WriteLine("opcion 1 si");
        Console.WriteLine("opicon 2 salir");
        opcion = int.Parse(Console.ReadLine());
        if (opcion != 2)
        {

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    do
                    {

                        Console.WriteLine("juguemos ingresa un numero del 1 al 100");
                        Console.WriteLine();
                        num4 = int.Parse(Console.ReadLine());
                        if (num4 < ramd)
                        {
                            Console.WriteLine("demasiado bajo");
                        }
                        else
                        {
                            Console.WriteLine("demasiado alto");
                        }
                    }
                    while (num4 != ramd);
                    {
                        Console.Clear();
                        Console.WriteLine("numero alcanzado es : " + ramd);
                    }
                    break;




            }

            Console.WriteLine("volvel a jugar presione 1");
            Console.WriteLine("SALIR 2");
            opcion = int.Parse(Console.ReadLine());


        }
    }
    while (opcion != 2);
    {
        Console.WriteLine("gracias por jugar");
    }
}
catch (Exception error)
{
    Console.WriteLine("valor no valido");
}