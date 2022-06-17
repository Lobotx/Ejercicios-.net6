using Ejercicio_clase_13.Classes;

var Billetera1 = new Billetera() //La mia ni de casualidad
{
    BilletesDe10 = 5,
    BilletesDe20 = 3,
    BilletesDe50 = 1,
    BilletesDe100 = 6,
    BilletesDe200 = 2,
    BilletesDe500 = 6,
    BilletesDe1000 = 2,
};

var Billetera2 = new Billetera() 
{
    BilletesDe10 = 3,
    BilletesDe20 = 6,
    BilletesDe50 = 3,
    BilletesDe100 = 2,
    BilletesDe200 = 1,
    BilletesDe500 = 3,
    BilletesDe1000 = 1,
};
var Billetera3 = new Billetera();

Console.WriteLine($"El importe total de la Primer billetera es {Billetera1.Total()}");
Console.WriteLine($"El importe total de la Segunda billetera es {Billetera2.Total()}");



Billetera3 = Billetera3.Combinar(Billetera1, Billetera2);


Console.WriteLine($"La combinacion de ambas billeteras es {Billetera3.Total()}");
Console.WriteLine($"El nuevo valor de la Primer billetera es {Billetera1.Total()}");
Console.WriteLine($"El nuevo valor de la Primer billetera es {Billetera2.Total()}");