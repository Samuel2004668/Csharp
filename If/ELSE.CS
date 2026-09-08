using System;
					
public class Program
{
	public static void Main()
	{	
		//Preguntas
		
		string[] nombres = new string[1];
		Console.WriteLine("Como te llamas?");
		string nombre = Console.ReadLine();
		
		Console.WriteLine($"Hola, {nombre}, bienvenid@");
		
		Console.WriteLine("dime tu color favorito: azul, verde, morado, rojo");
		string color = Console.ReadLine ();
		
		Console.WriteLine("¿sabes nadar? Si/No");
		string nadar = Console.ReadLine ();
		
		Console.WriteLine("¿te gusta el chocolate? Si/No");
		string comida = Console.ReadLine ();
		
		Console.WriteLine("¿Te gusta cocinar? Si/No");
		string pasaTiempo = Console.ReadLine ();
		
		Console.WriteLine("$¿Cual es tu edad?");
		int edad = int.Parse(Console.ReadLine ());
		
		Console.WriteLine("¿Te ejercitas? Si/No");
		string Fisico = Console.ReadLine ();
		
		
		string personaje;
		
		if(color == "rojo" && nadar =="si" &&comida =="no" && pasaTiempo =="si"  && edad >= 20  && Fisico =="si"){
		 	personaje = "Guerrero";
			}
		else if(color == "rojo" && nadar =="si" &&comida =="no" && pasaTiempo =="si"  && edad >= 20  && Fisico =="si"){
		 	personaje = "Guerrero";
			}
		}
		// Las preguntas otorgan
			int Velocidad;
			int Fuerza;
			int Inteligencia;
			int Resistencia;
		
		// Guerrero
		if(personaje == "Guerrero"){
	    	Velocidad = 70;
			Fuerza = 80;
			Inteligencia = 50;
			Resistencia = 100;
		}
		
		/*
		// Explorador
		Velocidad = 100;
		Fuerza = 70;
		Inteligencia = 60;
		Resistencia = 70;
		
		// Mago
		Velocidad = 80;
		Fuerza = 20;
		Inteligencia = 100;
		Resistencia = 60;
		
		// Tanque
		Velocidad = 40;
		Fuerza = 100;
		Inteligencia= 40;
		Resistencia = 80;
		*/
		
			

		
	}
}
