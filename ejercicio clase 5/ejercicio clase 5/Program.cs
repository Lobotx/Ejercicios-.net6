// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var consultaDeNombre = true;

while (consultaDeNombre) 

{
    Console.Clear();
    Console.WriteLine("Ingrese su nombre por favor: ");
    var nombre = Console.ReadLine();
    Console.WriteLine($"hola {nombre}!");

    Console.WriteLine("¿Desea continuar? S/N:");
    var respuesta = Console.ReadLine();
    if (respuesta.ToUpper() == "S")
        consultaDeNombre = true; 
    else if (respuesta.ToUpper() == "N")
    {
        Console.WriteLine("El programam finalizo correctamente");
        consultaDeNombre = false;
    }


    else
    {
        Console.WriteLine("Opcion no valida");
        consultaDeNombre = false;
    }   

}