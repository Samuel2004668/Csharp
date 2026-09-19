using System;

public class Program
{
    public static void Main()
    {
	int[] Vidas = { 2, 1, 3};
	int[] Puntos = { 20, 50, 30};
	int[] Velocidad = { 5, 6, 7,};
	string[] Llave = { "si", "no", "si"};
	string[] Esta_en_la_puerta = { "no", "no", "si"};
		
        string[] nombres = new string[3];
		Console.WriteLine("Como te llamas?");
		string nombre = Console.ReadLine();
		Console.WriteLine($"Hola, {nombre}, bienvenid@");
		Console.WriteLine($"dime un numero, de 0 a 2:");
	 int index = int.Parse(Console.ReadLine());
	
	Console.WriteLine("Tienes: ");
    Console.WriteLine("Vidas: " + Vidas[index]);
	Console.WriteLine("Puntos: " + Puntos[index]);
	Console.WriteLine("Velocidad: " + Velocidad[index]);
    Console.WriteLine("Llave: " + Llave[index]);
	Console.WriteLine("Esta_en_la_puerta:" + Esta_en_la_puerta[index]);
		
		string[] lugar = new string[3];
		Console.WriteLine("Donde empezaras tu aventura?");
		string Lugar = Console.ReadLine();
    }
}
