try
{

    double num1, num2, num3;

    char opcion;
    do
    {
        Console.Clear();
        Console.WriteLine("bienvenido al programa ");
        Console.WriteLine("opcion '+' suma ");
        Console.WriteLine("opcion '-' resta ");
        Console.WriteLine("opcion '*' multiplicar");
        Console.WriteLine("opcion '/' dividir");
        Console.WriteLine("opcion A salir del programa");
        opcion = char.Parse(Console.ReadLine().ToUpper());
        if (opcion != 'A')
        {

            switch (opcion)
            {
                case '+':
                    Console.WriteLine("bienvenido ala suma ");
                    Console.WriteLine("ingrese el primer numero");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el se gundo numero");
                    num2 = double.Parse(Console.ReadLine());
                    num3 = num1 + num2;
                    Console.WriteLine(" el resultado es :" + num3);



                    break;
                case '-':
                    Console.WriteLine("bienvenido ala resta ");
                    Console.WriteLine("ingrese el primer numero");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el se gundo numero");
                    num2 = double.Parse(Console.ReadLine());
                    num3 = num1 - num2;
                    Console.WriteLine(" el resultado es :" + num3);

                    break;


                case '/':
                    Console.WriteLine("bienvenido ala division");
                    Console.WriteLine("ingrese el primer numero");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el se gundo numero");
                    num2 = double.Parse(Console.ReadLine());
                    num3 = num1 / num2;
                    Console.WriteLine(" el resultado es :" + num3);



                    break;
                case '*':
                    Console.WriteLine("bienvenido ala multiplicacion");
                    Console.WriteLine("ingrese el primer numero");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el se gundo numero");
                    num2 = double.Parse(Console.ReadLine());
                    num3 = num1 * num2;
                    Console.WriteLine(" el resultado es :" + num3);

                    break;

                default:
                    Console.WriteLine("valor no valido ");

                    break;


            }

            Console.WriteLine("repetir 1");
            Console.WriteLine("salir A");
            opcion = char.Parse(Console.ReadLine().ToUpper());



        }



    }


    while (opcion != 'A');
    {
        Console.WriteLine("gracias por utilizar el programa bye");
    }

}
catch (Exception error)
{
    Console.WriteLine("VALOR NO VALIDO");
}
