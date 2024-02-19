// See https://aka.ms/new-console-template for more information
using Ejercicio_figuras_polimorfismo;

Console.WriteLine("FIGURAS GEOMETRICAS");
Console.WriteLine();




Cuadrado cuadrados = new Cuadrado();
Console.Write("Lado A: ");
cuadrados.LadoA = double.Parse(Console.ReadLine());
Console.Write("Lado B: ");
cuadrados.LadoB = double.Parse(Console.ReadLine());

double resultado = cuadrados.CalcularAreas();
double perimetro = cuadrados.CalcularPerimetro();

Console.WriteLine("El area de un cuadrado es " + resultado);
Console.WriteLine("El perimetro de un cuadrado es  " + perimetro);

Console.WriteLine();



Triangulo triangulo = new Triangulo();
Console.Write("Lado A: ");
cuadrados.LadoA = double.Parse(Console.ReadLine());
Console.Write("Lado B: ");
cuadrados.LadoB = double.Parse(Console.ReadLine());
Console.Write("Lado c: ");
cuadrados.LadoB = double.Parse(Console.ReadLine());

double res = triangulo.CalcularAreas();
double peri = triangulo.CalcularPerimetro();

Console.WriteLine("El area de un triangulo es " + res);
Console.WriteLine("El perimetro de un triangulo es  " + peri);

Console.WriteLine();



Circulo Circulo = new Circulo();
Console.Write("Radio: ");
Circulo.Radio = double.Parse(Console.ReadLine());


double resp = Circulo.CalcularAreas();
double perim = Circulo.CalcularPerimetro();

Console.WriteLine("El area de un circulo es " + resp);
Console.WriteLine("El perimetro de un circulo es  " + perim);




