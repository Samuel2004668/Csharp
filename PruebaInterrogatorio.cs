using System;

class Npc
{
    public string escenario;
    public string nombre;
    public string[] dialogoArray;      
    public string[] respuestasArray;  
    public string[] opcionesArray;     
    public Npc(string nom, string escn, string intro, string[] rsp)
    {
        nombre = nom;
        escenario = escn;

        dialogoArray = new string[1];
        dialogoArray[0] = intro;

        respuestasArray = rsp;

        opcionesArray = new string[8];
        opcionesArray[0] = "1) Preguntar por su coartada";
        opcionesArray[1] = "2) Preguntar por la herencia";
        opcionesArray[2] = "3) Preguntar por su padre";
        opcionesArray[3] = "4) Preguntar por las joyas";
        opcionesArray[4] = "5) Preguntar por sus hermanos";
        opcionesArray[5] = "6) Preguntar quien cree que fue";
        opcionesArray[6] = "7) Pedirle el video de seguridad";
        opcionesArray[7] = "8) Despedirse";
    }

    public void Dialogo()
    {
       //Intro
        Console.WriteLine(dialogoArray[0]);

        string opcion = "0";

        while (opcion != "8")
        {
            // MENU 
            Console.WriteLine();
            for (int i = 0; i < opcionesArray.Length; i++)
            {
                Console.WriteLine(opcionesArray[i]);
            }

            opcion = Console.ReadLine();

            // RESPUESTAS 
            switch (opcion)
            {
                case "1":
                    Console.WriteLine(nombre + ": " + respuestasArray[0]);
                    break;
                case "2":
                    Console.WriteLine(nombre + ": " + respuestasArray[1]);
                    break;
                case "3":
                    Console.WriteLine(nombre + ": " + respuestasArray[2]);
                    break;
                case "4":
                    Console.WriteLine(nombre + ": " + respuestasArray[3]);
                    break;
                case "5":
                    Console.WriteLine(nombre + ": " + respuestasArray[4]);
                    break;
                case "6":
                    Console.WriteLine(nombre + ": " + respuestasArray[5]);
                    break;
                case "7":
                    Console.WriteLine(nombre + ": " + respuestasArray[6]);
                    break;
                case "8":
                    Console.WriteLine(nombre + ": Gracias por escucharme, detective...");
                    break;
                default:
                    Console.WriteLine("Esa no es una opcion valida.");
                    break;
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        // RESPUESTAS DE ANA 
        string[] respuestasAna = new string[7];
        respuestasAna[0] = "Yo estaba en mi habitacion. Escuche voces en el pasillo...";
        respuestasAna[1] = "Si... papa me iba a dejar sus joyerias...";
        respuestasAna[2] = "Mi papa era... dificil. Exigente...";
        respuestasAna[3] = "El anillo y el colgante eran de mi mama...";
        respuestasAna[4] = "El mayor es serio... el tercero y el cuarto cambiaron...";
        respuestasAna[5] = "Yo... no quiero acusar a nadie sin pruebas...";
        respuestasAna[6] = "Ya le entregue la cinta, detective.";

        // CREAR A ANA 
        Npc ana = new Npc(
            "Ana",
            "Comisaria",
            "Ana te mira con nerviosismo. Esta sentada en una silla de la sala de interrogatorios.",
            respuestasAna
        );

        // INICIAR INTERROGATORIO
        ana.Dialogo();

        Console.ReadLine();
    }
}
