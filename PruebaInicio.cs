using System;

class Escenario
{
    public string descripcion;
    public int cantidadNpc;

    public void Mostrar()
    {
        Console.WriteLine(descripcion);
        Console.WriteLine("Personas en este lugar: " + cantidadNpc);
    }
}

class Mansion : Escenario
{
    public Mansion()
    {
        descripcion = "Llegas a la mansion de un importante maganate en El Poblado. Las luces de la policia iluminan los jardines de azul y rojo. En el salon, Michael fuma junto a la ventana. Andrew te observa desde el sofa con los brazos cruzados. Un policia uniformado toma notas cerca de la puerta.";
        cantidadNpc = 3;
    }
}

public class Program
{
    static void Main()
    {
       // INTRO 
        Console.WriteLine("========================================");
        Console.WriteLine("        JOYAS FAMILIARES");
        Console.WriteLine("========================================");
        Console.WriteLine();
        Console.WriteLine("Medellin, Colombia. Año 2000.");
        Console.WriteLine("Son las 11:58 p.m. y suena tu telefono.");
        Console.WriteLine("Es la policia y suena urgente, al parecer un magnate joyero ha sido envenenado en su hogar");
        Console.WriteLine("Su mansion se ubica en El Poblado los unicos presentes eran sus cinco hijos...");
        Console.WriteLine("Ademas, dos piezas familiares han sido robadas: un anillo y un colgante, ambos fueron heredados generacion tras generacion en su familia.");
        Console.WriteLine("Te han contratado como detective privado para resolver el caso antes de que sea tarde.");
        Console.WriteLine("Sera una Noche larga...");
        Console.WriteLine();

       // NOMBRE 
        Console.Write("Antes de comenzar, Detective, ¿Como te llamas? ");
        string nombre = Console.ReadLine();

       // SALUDO 
        Console.WriteLine($"Bienvenido, Detective {nombre}.");
        Console.WriteLine("Tienes que encontrar al culpable.");
        Console.WriteLine("El tiempo corre. Buena suerte.");
 

       // ESCENARIO INICIAL 
        Console.WriteLine($"--- Detective {nombre} ---");
        Console.WriteLine();

        Mansion mansion = new Mansion();
        mansion.Mostrar();

        Console.ReadLine();
    }
}
