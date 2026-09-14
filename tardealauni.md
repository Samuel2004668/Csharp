using System;
					
public class Program
{
	static int ManejarLinea(string texto, int numeroSalto)
	{
		Console.WriteLine(texto);

			if (numeroSalto == 1)
			{
				return 1; 
			}

			if (numeroSalto == 0)
			{
				return 0;
			}

			string entrada = Console.ReadLine();

			if (entrada == "1")
			{
				return 0; 
			}

			if (entrada == "2")
			{
				return numeroSalto;
			}

			return 0; 
	}
	
	static void Main()
{
		string[] textos = new string[15];
		int[] saltos    = new int[15];

			textos[0] = "Bogotá amanece gris. Miras el celular: 7:18 a.m.";
			saltos[0] = 0;

			textos[1] = "La clase empieza a las 8:00. Sales corriendo a la calle.";
			saltos[1] = 0;
			
			textos[2] = "Mientras corres ves a un gato que te ve con ojos tristes. 1)Seguir tu camino. 2)Mimarlo un poco.";
			saltos[2] = 7;
			
			textos[3] = "Llegas a la esquina. 1) Tomar el camino conocido. 2) Tomar un atajo.";
			saltos[3] = ; 
		
			textos[4] = "Caminas por la ruta de siempre, pasando la panadería.";
			saltos[4] = 0;
		
			textos[5] = "Te detienes frente a la panaderia. Tienes Hambre. 1)Continuar tu camino. 2)Parar y comer algo";
			saltos[5] = 1;

			textos[6] = "Llegas a clase justo a tiempo. FINAL: LLEGASTE.";
			saltos[6] = 11; 

			textos[7] = "El gato parece en guardia,. 1)Seguir tu camino y dejarlo ser. 2)Insistir en mimarlo.";
			saltos[7] = 0;
		
			textos[8] = "Cuando insistes en mimarlo, el gato se te lanza y te araña la cara. FINAL: NO LLEGASTE(Aveces es mejor no insistir...o vas a salir herid@).";
			saltos[8] = 1;
				
			textos[9] = "Entras a la panaderia, la fila es larga y parece que tomara tiempo. 1)Salir y continuar tu camino. 2)Esperar pacientemente.";
			saltos[9] = 9;
				
			textos[10] = "Tras una hora de espera no te atendieron, habia demasiados clientes. FINAL: NO LLEGASTE(Y moriste de hambre).";
			saltos[10] = 1;

			textos[11] = "Tras una hora de espera no te atendieron, habia demasiados clientes. FINAL: NO LLEGASTE(Y moriste de hambre).";
			saltos[11] = 1;

			textos[12] = "Entras por el atajo. Al fondo hay una construcción bloqueando el paso.";
			saltos[12] = 0;

			textos[13] = "1) Rodear por el andén. 2) Cruzar la calle rápidamente.";
			saltos[13] = 14; 

			textos[14] = "Rodeas con cuidado y llegas a clase apenas a tiempo. FINAL: LLEGASTE(En regaño es mejor que una clase perdida ¿Verdad?).";
			saltos[14] = 1; 

			textos[15] = "Cruzas justo cuando pasa una moto. FINAL: NO LLEGASTE(Felicidades te atropellaron).";
			saltos[15] = 1;
		
		
		 for (int i = 0; i < textos.Length; i++){
			int resultado = ManejarLinea(textos[i], saltos[i]);

			if (resultado == 1)
			{
				break;
			}

			else if (resultado != 0)
			{
				i = resultado - 1; 
			}
		}
}
	}
