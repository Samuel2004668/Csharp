using System;

public class Program
{
    public static void Main()
    {
        // Preguntas
        Console.WriteLine("¿Cómo te llamas?");
        string nombre = Console.ReadLine();

        Console.WriteLine($"Hola, {nombre}, bienvenid@");

        Console.WriteLine("Dime tu color favorito: azul, verde, morado, rojo");
        string color = Console.ReadLine(); 
		
        Console.WriteLine("¿Sabes nadar? (si/no)");
        string nadar = Console.ReadLine();

        Console.WriteLine("¿Te gusta el chocolate? (si/no)");
        string comida = Console.ReadLine();

        Console.WriteLine("¿Te gusta cocinar? (si/no)");
        string pasaTiempo = Console.ReadLine();

        Console.WriteLine("¿Cuál es tu edad?");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("¿Te ejercitas? (si/no)");
        string fisico = Console.ReadLine();

        string personaje = "Indefinido"; 

        // Asignación del rol según respuestas
		
        if (color == "rojo" && nadar == "si" && comida == "no" && pasaTiempo == "si" && edad >= 20 && fisico == "si")
        {
            personaje = "Guerrero";
        }
        else if (color == "verde" && nadar == "si" && comida == "no" && pasaTiempo == "no" && edad >= 18 && fisico == "si")
        {
            personaje = "Explorador";
        }
        else if (color == "morado" && nadar == "no" && comida == "si" && pasaTiempo == "no" && edad >= 22 && fisico == "no")
        {
            personaje = "Mago";
        }
        else if (color == "azul" && nadar == "si" && comida == "si" && pasaTiempo == "no" && edad >= 30 && fisico == "si")
        {
            personaje = "Tanque";
        }

        // Estadísticas por defecto
        int velocidad = 0;
        int fuerza = 0;
        int inteligencia = 0;
        int resistencia = 0;

        // Asignar estadísticas según el Rol
		
        if (personaje == "Guerrero")
        {
            velocidad = 70;
            fuerza = 80;
            inteligencia = 50;
            resistencia = 100;
        }
        else if (personaje == "Explorador")
        {
            velocidad = 100;
            fuerza = 70;
            inteligencia = 60;
            resistencia = 70;
        }
        else if (personaje == "Mago")
        {
            velocidad = 80;
            fuerza = 20;
            inteligencia = 100;
            resistencia = 60;
        }
        else if (personaje == "Tanque")
        {
            velocidad = 40;
            fuerza = 100;
            inteligencia = 40;
            resistencia = 80;
        }

        // Mensaje final con el rol y las estadísticas
        Console.WriteLine($"¡Felcidades {nombre}, este es tu rol y estadísticas!");
        Console.WriteLine($"Rol: {personaje}");
        Console.WriteLine($"Velocidad: {velocidad}");
        Console.WriteLine($"Fuerza: {fuerza}");
        Console.WriteLine($"Inteligencia: {inteligencia}");
        Console.WriteLine($"Resistencia: {resistencia}");
    }
}
