//crear un programa el cual nos pida indicar un tamaño a un vector para rellenar esos espacios con numeros aleatorios

//Luego crear un programa para modificar un valor en una posicion seleccionada dentro del vector

//indicamos tamalo
Console.WriteLine("Ingrese el tamaño deseado para el listado");
int n = int.Parse(Console.ReadLine());
int[] vector = new int[n];

//Generamos clase random para generar numero aleatorio
//Random es una clase, genera un numero aleatorio segun el metodo utilizado
Random aleatoreador = new Random();

//Recorremos el vector para agregar los valores
for (int i = 0; i < vector.Length; i++) 
{
    //Next es una propiedad de random que devuelve un numero entero
    vector[i] = aleatoreador.Next(100);
}

//ceamos un contador y mostramos los valores cargados en el vector
var contador = 0;
//for each = para cada 
foreach (int i in vector)
{
    contador++;
    Console.Write(contador +":" + i + " ");
}

// \t agrega una tabulacion al texto
Console.WriteLine();
Console.WriteLine("Ingrese posicion a modificar");

var k = int.Parse(Console.ReadLine());

if (k > vector.Length - 1 || k < 0)
{
    Console.WriteLine("El valor es incorrecto");
}
else
{
    Console.WriteLine("Ingrese nuevo valor");
    while (true)
    {
        var nuevoValor = int.Parse(Console.ReadLine());
        if (nuevoValor > 0 && nuevoValor < 100)
        {
            vector[k - 1] = nuevoValor;
            break;
        }
        else
        {
            Console.WriteLine("El valor debe ser mayor a 0 y menor a 100");
        }
    }   

    //vector[k - 1] = int.Parse(Console.ReadLine());
    contador = 0;
    //for each = para cada 
    foreach (int i in vector)
    {
        contador++;
        Console.Write(contador + ":" + i + " ");
    }

}