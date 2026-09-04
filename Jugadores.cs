using System;

class Program
{
	
    static void Main()
    {
	string[] Jugadores = { "morax", "salmon", "belial", "dominic", "gatoman"};
	int[] Vidas = { 2, 5, 3,4, 2};
	int[] Puntos = { 20, 50, 70, 60, 80};
	int[] Velocidad = { 5, 6, 7, 8, 10};
	string[] Llave = { "si", "no", "si", "no", "no",};
	string[] Esta_en_la_puerta = { "no", "no", "si", "no", "si",};
	
	int Jugador = 2;
		
		
	Console.WriteLine("Nombre: " + Jugadores[Jugador]);
    Console.WriteLine("Vidas: " + Vidas[Jugador]);
	Console.WriteLine("Puntos: " + Puntos[Jugador]);
	Console.WriteLine("Velocidad: " + Velocidad[Jugador]);
    Console.WriteLine("Llave: " + Llave[Jugador]);
	Console.WriteLine("Esta_en_la_puerta:" + Esta_en_la_puerta[Jugador]);
   }

} 
