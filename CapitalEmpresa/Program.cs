// See https://aka.ms/new-console-template for more information
Console.WriteLine("** CAPITAL DE EMPRESA ** ");
Console.WriteLine(" ");

double aportacion1, aportacion2, aportacion3;


Console.WriteLine("¿Cuanto aporto el socio 1?");
aportacion1 = double.Parse(Console.ReadLine());

Console.WriteLine("¿Cuanto aporto el socio 2?");
aportacion2 = double.Parse(Console.ReadLine());

Console.WriteLine("¿Cuanto aporto el socio 3?");
aportacion3 = double.Parse(Console.ReadLine());

double capital = aportacion1 + aportacion2 + aportacion3;
Console.WriteLine("---------------------------------------");
Console.WriteLine("La capital de la empresa es:" + capital.ToString("0.00"));
