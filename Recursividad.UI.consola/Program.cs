using Recursividad.Logica;


Console.WriteLine("Metodos recursivos");
Console.WriteLine("\n\n calcular factorial de 5");

Recursividades oRecursividades = new Recursividades();
int resultado = oRecursividades.CalcularFactorial(5);

Console.WriteLine("Factorial de 5 es:" + resultado);