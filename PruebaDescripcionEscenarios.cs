using System;

class Escenario
{
    public string descripcion;
    public int cantidadNpc;

    public void Mostrar()
    {
        Console.WriteLine(descripcion);
        Console.WriteLine("Personas en este lugar: " + cantidadNpc);
        Console.WriteLine();
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

class Joyeria : Escenario
{
    public Joyeria()
    {
        descripcion = "Bajas del taxi frente a la joyeria. El letrero dorado dice Joyas del Valle. La vitrina principal esta tapada con una lona. Detras del mostrador, Lucy limpia la misma vitrina una y otra vez. Joseph hojea un folder junto a la caja. La asistente joven ordena herramientas con las manos temblorosas.";
        cantidadNpc = 3;
    }
}

class Comisaria : Escenario
{
    public Comisaria()
    {
        descripcion = "Entras a la comisaria. Las paredes verdes estan despintadas y huele a cafe quemado. En la sala de interrogatorios, Ana esta sentada con las manos entre las rodillas y los ojos rojos. Junto a la puerta, una policia te observa con los brazos cruzados y una libreta en la mano.";
        cantidadNpc = 2;
    }
}

public class Program
{
    static void Main()
    {
        Mansion mansion = new Mansion();
        Joyeria joyeria = new Joyeria();
        Comisaria comisaria = new Comisaria();

        mansion.Mostrar();
        joyeria.Mostrar();
        comisaria.Mostrar();

        Console.ReadLine();
    }
}
