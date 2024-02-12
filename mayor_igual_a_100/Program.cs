// See https://aka.ms/new-console-template for more information
Console.WriteLine("mayor o igual a 100");

{
    Console.Write("Ingrese la cantidad de números a sumar: ");
    int N = Convert.ToInt32(Console.ReadLine());

    int sumatoria = 0;

    for (int i = 0; i < N; i++)
    {
        Console.Write("Ingrese el número " + (i + 1) + " ");
        int numero = Convert.ToInt32(Console.ReadLine());
        sumatoria += numero;
    }

    if (sumatoria >= 100)
    {
        Console.WriteLine("La sumatoria es mayor o igual a 100.");
    }
    else
    {
        Console.WriteLine("La sumatoria es menor a 100.");
    }
}

