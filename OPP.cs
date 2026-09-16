using System;

class Jugador
{
    public string nombre;
    private string rol;
    private int velocidad;
    private int fuerza;
    private int inteligencia;
    private int resistencia;

    public void AsignarPersonaje(string nombreElegido, string herramienta, bool leGustaElTe)
    {
        nombre = nombreElegido;

        if (herramienta == "mapa")
        {
            rol = "Explorador";
            velocidad = 90;
            fuerza = 50;
            inteligencia = 70;
            resistencia = 60;
        }
        else if (herramienta == "espada")
        {
            if (leGustaElTe)
            {
                rol = "Guerrero";
                velocidad = 50;
                fuerza = 90;
                inteligencia = 40;
                resistencia = 90;
            }
            else
            {
                rol = "Mago";
                velocidad = 40;
                fuerza = 30;
                inteligencia = 100;
                resistencia = 50;
            }
        }
    }

    public void MostrarPersonaje()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Rol: {rol}");
        Console.WriteLine($"Velocidad: {velocidad}");
        Console.WriteLine($"Fuerza: {fuerza}");
        Console.WriteLine($"Inteligencia: {inteligencia}");
        Console.WriteLine($"Resistencia: {resistencia}");
    }
}			

public class Program
{
	public static void Main()
	{
	Jugador jugador1 = new Jugador();
		
		// Preguntas
        Console.WriteLine("¿Cómo te llamas?");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hola, {nombre}, bienvenid@");
        Console.WriteLine("¿te gusta el te?(Si/No):");
        string te = Console.ReadLine();
        Console.WriteLine("¿escoge tu herramienta? (Mapa/Espada):");
        string herramienta = Console.ReadLine();
		
	jugador1.AsignarPersonaje(nombre, herramienta , true); 
	jugador1.MostrarPersonaje();
		}
	}
