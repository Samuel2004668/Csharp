using System;
class Npc
{
	public string escenario;
	public string nombre;
	public string[] dialogoArray;//index=0 es intro
	public string[] respuestasArray;//index=0 es intro
	public string opciones = "";
	
	Npc(string nom,string escn, string[] dlg, string[] rsp){
		nombre = nom;
		escenario = escn;
		dialogoArray = dlg;
		respuestasArray = rsp;
	}
	
	public void dialogo(){
		string oracion_0 = dialogoArray[0];
        Console.WriteLine(oracion_0);

    while (opciones != "8")
    {
        Console.WriteLine();
		string oracion_1 = dialogoArray[1];
        Console.WriteLine(oracion_1);
        string oracionConResp_2 = dialogoArray[2];
        Console.WriteLine(oracionConResp_2);
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
				string oracionResp = respuestasArray[0];
                Console.WriteLine(oracionResp);
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
				Console.WriteLine("Ana: Ya le entregue la cinta, detective.");
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
}					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}
