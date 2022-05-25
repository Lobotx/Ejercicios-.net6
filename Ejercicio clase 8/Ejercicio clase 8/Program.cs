//Solicitar tamaño de matriz

Console.WriteLine("Ingrese la cantidad de filas");
int cantidadDeFilas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de columnas");
int cantidadDeColumnas = int.Parse(Console.ReadLine());


int[,] numeros = new int[cantidadDeFilas, cantidadDeColumnas];
double[] promedios = new double[cantidadDeColumnas];

//Ingresar el tamaño de las filas y columnas

for (int f = 0; f < cantidadDeFilas; f++)
{
    Console.WriteLine($"Ingresar valores de fila {f+1}");
    for (int c = 0; c < cantidadDeColumnas; c++)
    {
        Console.WriteLine($"Ingrese los numeros de la columna {c + 1}");
        numeros[f, c ] = int.Parse(Console.ReadLine());
    }
}

//Mostrar valores de la matriz

for (int f = 0; f < cantidadDeFilas; f++)
{
    Console.WriteLine();
    Console.Write($"Valores de fila n° {f + 1}: ");
    for (int c = 0; c < cantidadDeColumnas; c++)
    {
        Console.Write($"{numeros[f, c]} ");

        
    }

}

Console.WriteLine();

//Calcular el promedio de cada columna
/*Aca la iteracion la hago de forma inversa para recibir el valor de las columnas primero en lugar de filas
es decir, en vez de primero (int f = 0; f<cantidadDeColumnas; f++) en su lugar ira (int c = 0; c<cantidadDeColumnas; c++) */

for (int c = 0; c<cantidadDeColumnas; c++)
{
    int suma = 0;
    double promedioTotal = 0;
    for (int f = 0; f < cantidadDeFilas; f++)
    {
        suma = suma + numeros[f, c];
        promedioTotal = suma / cantidadDeFilas;

        promedios[c] = promedioTotal;
    }
    
}

Console.WriteLine();

Console.Write("Los promedios son: ");

for (int p = 0; p < cantidadDeColumnas; p++)
{
    
    Console.Write($"{promedios[p]} ");


}


