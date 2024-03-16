static void ejemplo1()
{
    //Declaracion de un arreglo
    int[] calificaciones;

    //Asignacion de datos
    calificaciones = new int[] { 85, 92, 77, 68, 94, 75, 99, 48, 36, 63 };

    //Imrpimir en pantalla el arreglo
    Console.WriteLine("La nota que usted solicito es de: " + calificaciones[2]);
    Console.WriteLine("\n");

    //Uso del foreach
    double sumaNotas = 0;
    foreach (int numero in calificaciones)
    {
        sumaNotas += numero;
    }

    //Uso de la propiedad Length
    double promedio = sumaNotas / calificaciones.Length;

    //Imrpimir en pantalla el resultado
    Console.WriteLine($"El promedio de notas es: {promedio:F2}");
    Console.WriteLine("\n");

    double SumaNotas = 0;
    int cantidadNotas = 0;

    for (int i = 0; i < calificaciones.Length; i++)
    {
        SumaNotas += calificaciones[i];
        cantidadNotas++; 
        Console.WriteLine($"Calificacion {i + 1}: {calificaciones[i]}");
    }

    bool hayAprobados = Array.Exists(calificaciones, calif => calif >= 60);
}


static void ejemplo2()
{
    int[] elementos = new int[] { 50, 20, 80, 90, 60 };
    Console.WriteLine("Original: ");
    Array.Sort(elementos);
    Array.Reverse(elementos);

    int[] edades = { 25, 30, 18, 42, 30 };
    int indice = Array.IndexOf(edades, 30);

}

ejemplo1();