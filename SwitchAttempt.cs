using System;

public class Program
{
    public static void Main()
    {
        // Preguntas
        Console.WriteLine("¿Cómo te llamas?");
        string nombre = Console.ReadLine();

        Console.WriteLine($"Hola, {nombre}, bienvenid@");

        Console.WriteLine("Dime tu color favorito (azul, verde, morado o rojo):");
        string color = Console.ReadLine();

        Console.WriteLine("¿Sabes nadar? (si/no):");
        string nadar = Console.ReadLine();

        Console.WriteLine("¿Te gusta el chocolate? (si/no):");
        string comida = Console.ReadLine();

        Console.WriteLine("¿Te gusta cocinar? (si/no):");
        string pasaTiempo = Console.ReadLine();

        Console.WriteLine("¿Cuál es tu edad?");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("¿Te ejercitas? (escribe si/no):");
        string fisico = Console.ReadLine();

        string personaje = "Indefinido"; // Valor por defecto

        // Asignación del rol según respuestas 
        if (color == "rojo" && nadar == "si" && comida == "no" && pasaTiempo == "si" && edad >= 18 && fisico == "si")
        {
            personaje = "Guerrero";
        }
        else if (color == "verde" && nadar == "si" && comida == "no" && pasaTiempo == "no" && edad >= 18 && fisico == "si")
        {
            personaje = "Explorador";
        }
        else if (color == "morado" && nadar == "no" && comida == "si" && pasaTiempo == "no" && edad >= 18 && fisico == "no")
        {
            personaje = "Mago";
        }
        else if (color == "azul" && nadar == "si" && comida == "si" && pasaTiempo == "no" && edad >= 18 && fisico == "si")
        {
            personaje = "Tanque";
        }
        else
        {
            // Si no cumple ninguna, se asigna el rol por defecto
            personaje = "Aldeano";
        }

        // Valores por defecto
        int velocidad = 0;
        int fuerza = 0;
        int inteligencia = 0;
        int resistencia = 0;

        // Estadísticas según el personaje
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
        else 
        {
            velocidad = 20;
            fuerza = 20;
            inteligencia = 20;
            resistencia = 20;
        }

        // Mensaje final
        Console.WriteLine($"¡Felcidades {nombre}, este es tu rol y estadísticas!");
        Console.WriteLine($"Rol: {personaje}");
        Console.WriteLine($"Velocidad: {velocidad}");
        Console.WriteLine($"Fuerza: {fuerza}");
        Console.WriteLine($"Inteligencia: {inteligencia}");
        Console.WriteLine($"Resistencia: {resistencia}");
        Console.WriteLine("Estas son tus herramientas:");
		
		
		//Switch 1: Items
		switch (personaje)
		{
			case "Guerrero":
					Console.WriteLine("Espada, Armadura de malla, Pocion de Fuerza x1");
				break;
				
			case "Explorador":
					Console.WriteLine("Arco corto, Flechas, Brujula");
				break;
				
			case "Mago":
					Console.WriteLine("Grimorio, Bastón mágico, Poción de Mana x1");
				break;
				
			case "Tanque":
					Console.WriteLine("Escudo grande, Armadura pesada, Poción de resistencia x1");
				break;
				
			default:
					Console.WriteLine("Hoz, Pan, Llave maestra");
				break;
		}		
		//Switch 2: Eleccion De Bendición
				
		Console.WriteLine("Esta es tu Bendición Unica");
			string bendicion = "{personaje}";
				
				switch (bendicion)
				{
			case "	Guerrero":
					Console.WriteLine("Bastion Divino: Defensa +20% y reducción de daño a aliados");
			break;
						
			case "Explorador":
				Console.WriteLine("Viento Veloz: +15% de velocidad de movimiento y +10% de evasión");
			break;
			
			case "Mago":
				Console.WriteLine("Flujo Arcano: 30% de regeneracion de mana y +15% de efectividad al castear hechizos");
			break;
						
			default:
				Console.WriteLine("Trueque Dorado: Obtienes mejores precios en tiendsa y acceso a comerciantes ocultos");
			break;
}
		}
    }
