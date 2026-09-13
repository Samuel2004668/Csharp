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

     // Switch 1: Estadísticas según el personaje
		
        int velocidad = 0;
        int fuerza = 0;
        int inteligencia = 0;
        int resistencia = 0;

		switch (personaje)
		{
		case "Guerrero":
		velocidad = 70;
        fuerza = 80;
        inteligencia = 50;
        resistencia = 100;
        break;

    	case "Exlporador":
		velocidad = 100;
        fuerza = 50;
        inteligencia = 50;
        resistencia = 30;
        break;
		
		case "Mago":
		velocidad = 80;
        fuerza = 20;
        inteligencia = 100;
        resistencia = 20;
        break;

		case "Tanque":
        velocidad = 40;
        fuerza = 100;
        inteligencia = 40;
        resistencia = 80;
        break;
			
		default:
        velocidad = 20;
        fuerza = 20;
        inteligencia = 20;
        resistencia = 20;
        break;
}

        // Mensaje final
        Console.WriteLine($"¡Felcidades {nombre}, este es tu rol y estadísticas!");
        Console.WriteLine($"Rol: {personaje}");
        Console.WriteLine($"Velocidad: {velocidad}");
        Console.WriteLine($"Fuerza: {fuerza}");
        Console.WriteLine($"Inteligencia: {inteligencia}");
        Console.WriteLine($"Resistencia: {resistencia}");
		Console.WriteLine("Estas son tus herramientas:");
		
		
		//Switch 2: Items
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
		//Switch 3: Eleccion De Bendición
				
		Console.WriteLine("Esta es tu Bendición Única");
		
	string bendicion = "";
		
		switch (personaje)
		{
		case "Guerrero":
				bendicion = "Furia Sangrienta: Cuanto menos HP tengas, más daño infliges (hasta +35%).";
			break;

			case "Explorador":
				bendicion = "Viento Veloz: +15% de velocidad de movimiento y +10% de evasión";
			break;
			
			case "Mago":
				bendicion = "Flujo Arcano: 30% de regeneración de mana y +15% de efectividad al castear hechizos";
			break;

			case "Tanque":
				bendicion = "Bastion Divino: Defensa +20% y reducción de daño a aliados";
			break;

    default:
        bendicion = "Trueque Dorado: Obtienes mejores precios en tiendas y acceso a comerciantes ocultos";
        break;
}
		Console.WriteLine(bendicion);
		
		// Switch 4: Elección de misión inicial
		Console.WriteLine($"Bienvenid@, {nombre} es hora de empezar tu aventura, ¿Que mision tomaras?");
		Console.WriteLine("1. Bosque Sombrío");
		Console.WriteLine("2. Cuevas de Cristal");
		Console.WriteLine("3. Ruinas Antiguas");
		
		string mision = Console.ReadLine();
		string recompensa = "";
		int puntos = 0;
		
		switch (mision)
		{
			case "1":
			case "Bosque Sombrío":
				mision = "Bosque Sombrío";
				recompensa = "50 de oro y una Poción de Vida";
				puntos = +80;
			break;
			
			case "2":
			case "Cuevas de Cristal":
				mision = "Cuevas de Cristal";
				recompensa = "80 de oro y un Cristal Mágico";
				puntos = +40;
			break;

			case "3":
			case "Ruinas Antiguas":
				mision = "Ruinas Antiguas";
				recompensa = "120 de oro y un Mapa Antiguo";
				puntos = +60;
			break;
			
			default:
				mision = "Aldea";
				recompensa = "20 de oro y un Pan";
				puntos = +10;
			break;
}
		Console.WriteLine($"Has elegido: {mision}");
		Console.WriteLine($"Recompensa obtenida: {recompensa}");
		Console.WriteLine($"Puntos obtenidos: {puntos}");
		}
    }
