// See https://aka.ms/new-console-template for more information
Console.WriteLine("** CONVERSION DE MEDIDAS ** ");
Console.WriteLine(" ");

double metros;




Console.WriteLine("Ingrese la medida de telas en metros");
metros = double.Parse(Console.ReadLine());

double cm = metros * 100.0;
Console.WriteLine("------------------------------------------------");
Console.WriteLine("La medida en centimetros es: " +cm.ToString("0.00"));

double pie = metros / 12.0;

Console.WriteLine("La medida en pies es: " +pie.ToString("0.00"));

double yarda = metros / 3.0;
Console.WriteLine("La medida en yardas es: " +yarda.ToString("0.00"));

double pulgada = metros / 2.54;
Console.WriteLine("La medida en pulgadas es: "+pulgada.ToString("0.00"));





