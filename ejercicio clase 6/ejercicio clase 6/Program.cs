var adivinarNumero = true;
// Generar numero secreto al azar
var numeroDeIntentos = 0;


int numeroSecreto = new
        Random(DateTime.Now.Millisecond).Next(1, 21);

Console.WriteLine("¡Bienvenido!");

while (adivinarNumero)
{
    Console.WriteLine("Pulse una tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Se ha generado un numero secreto...\n"+
        "Debe adivinar el numero secreto elegido por skynet para derrotarlos\n"+
       "Ingrese un numero: ");

    numeroDeIntentos++;

    var numeroDelUsuario = int.Parse(Console.ReadLine());

        if (numeroDelUsuario < numeroSecreto)
        {
            Console.WriteLine("El numero que tiraste esta chiquito");
            

        }
        else if (numeroDelUsuario > numeroSecreto)
        {
            Console.WriteLine("El numero que tiraste esta grandecito");
        }
        else
        {
            Console.WriteLine($"Bien ahi pa' Le ganaste a la maquina \nEl numero secreto era {numeroSecreto}");
            Console.WriteLine($"Lo lograste en {numeroDeIntentos} intentos");
            break;
        }
}

