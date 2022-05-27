Console.WriteLine("Ingrese la longitud del listado");

int longitudVector = int.Parse(Console.ReadLine());
int[] vector = new int[longitudVector];

Random numeroAlAzar = new Random();

for (int i=0; i < vector.Length; i++)
{
    vector[i] = numeroAlAzar.Next(vector.Length);
   
}
Console.WriteLine("El vector es: ");


foreach (int i in vector)
{
    Console.WriteLine(i);
}

Console.WriteLine("El vector invertido es: ");



for (int j = 0; j < vector.Length; j++)
{
    //aca se invierte la longitud del vector asignandole un valor negativo, de modo que se reproduzca de manera negativa o al reves
    Console.WriteLine(vector[vector.Length - j - 1]);    
}
