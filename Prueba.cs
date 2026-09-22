using System;
					
public class Program
{
	static void DialogoAna()
{
    string opciones = "";
    bool videoEntregado = false;

    Console.WriteLine("Ana te mira con nerviosismo. Esta sentada en una banca de la comisaria.");

    while (opciones != "8")
    {
        Console.WriteLine();
        Console.WriteLine("¿Que quieres preguntarle a Ana?");
        Console.WriteLine("1) Preguntar por su coartada");
        Console.WriteLine("2) Preguntar por la herencia");
        Console.WriteLine("3) Preguntar por su padre");
        Console.WriteLine("4) Preguntar por las joyas");
        Console.WriteLine("5) Preguntar por sus hermanos");
        Console.WriteLine("6) Preguntar quien cree que fue");
        Console.WriteLine("7) Pedirle el video de seguridad");
        Console.WriteLine("8) Despedirse");

        opciones = Console.ReadLine();

        switch (opciones)
        {
            case "1":
                Console.WriteLine("Ana: Yo estaba en mi habitacion...");
                break;

            case "2":
                Console.WriteLine("Ana: Si... papá me iba a dejar sus joyerias...");
                break;

            case "3":
                Console.WriteLine("Ana: Mi papá era... dificil. Exigente...");
                break;

            case "4":
                Console.WriteLine("Ana: El anillo y el colgante eran de mi mama...");
                break;

            case "5":
                Console.WriteLine("Ana: El mayor es serio... el tercero y el cuarto cambiaron...");
                break;

            case "6":
                Console.WriteLine("Ana: Yo... no quiero acusar a nadie sin pruebas...");
                break;

            case "7":
                if (videoEntregado == false)
                {
                    Console.WriteLine("Ana: Detective... tengo algo que mostrarle...");
                    Console.WriteLine("Ana te entrega una cinta VHS.");
                    videoEntregado = true;
                }
                else if (videoEntregado == true)
                {
                    Console.WriteLine("Ana: Ya le entregue la cinta, detective.");
                }
                else
                {
                    Console.WriteLine("Ana: No... no tengo nada que darle todavia. No confio lo suficiente.");
                }
                break;

            case "8":
                Console.WriteLine("Ana: Gracias por escucharme, detective...");
                break;

            default:
                Console.WriteLine("Esa no es una opcion valida.");
                break;
        }
    }
}
	
	public static void Main()
	{
		DialogoAna();
	}
}
