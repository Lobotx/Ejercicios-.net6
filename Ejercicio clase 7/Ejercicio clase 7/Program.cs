Console.WriteLine("Bienvenidx!");

int[] enteros = new int[10];

Console.WriteLine("Se le va a solicitar la cantidad de 10 numeros:");
Console.WriteLine("Pulse cualquier tecla para continuar...");
Console.ReadKey();

//Solicitud de ingreso de valores

for (int i = 0; i < enteros.Length; i++)
{
    Console.Clear();
    Console.WriteLine($"Ingrese el numero de la posicion {i + 1}");
    enteros[i] = int.Parse(Console.ReadLine());    
}
Console.Clear();


 //Numeros ingresados
 Console.WriteLine("Los numeros ingresados fueron:");

for (int i = 0; i < enteros.Length; i++)
{
    Console.WriteLine(enteros[i]);
}


    
//Suma de valores

    int suma = 0;

for (int i = 0; i < enteros.Length; i++)
{
    suma += enteros[i];
}

Console.WriteLine($"La suma de los numeros anteriores es:{suma}");


//Promedio de los valores

int promedio = 0;

for (int i = 0; i < enteros.Length; i++)
{

    promedio = suma / enteros.Length;
    

}

Console.WriteLine($"El promedio de los numeros anteriores es: {promedio} ");

//Mayor y menor numero del array

int numeroMayor, numeroMenor;

numeroMayor = enteros[0];
numeroMenor = enteros[0];

for (int i = 0; i < enteros.Length; i++)
{
    if (enteros[i] > numeroMayor)
        numeroMayor = enteros[i];
    if (enteros[i] < numeroMenor)
        numeroMenor = enteros[i];

}

Console.WriteLine($"El numero mayor es: {numeroMayor}");
Console.WriteLine($"El numero menor es:{numeroMenor}");

Console.WriteLine($"Resultado suma: {suma}");
Console.WriteLine($"Resultado promedio: {promedio}");
Console.WriteLine($"Resultado mayor: {numeroMayor}");
Console.WriteLine($"Resultado mayor: {numeroMenor}");

Console.WriteLine("Pulse cualquier tecla para finalizar...");
Console.ReadKey();
