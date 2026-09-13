using System;

public class Program
{
    public static void Main()
    {
string[] dibujo = new string[3]; // el dibujo tiene 3 filas (tamaño fijo)

// Fila 0: "xxxxxxx" — un solo segmento de 7 "x"
char[] simbolosFila0     = { 'x' };
int[]  repeticionesFila0 = {  8  };

string fila0 = "";
for (int s = 0; s < simbolosFila0.Length; s++)
{
    for (int i = 0; i < repeticionesFila0[s]; i++)
    {
        fila0 += simbolosFila0[s];
    }
}
dibujo[0] = fila0;

// Fila 1: "xOxxOx" — varios segmentos
char[] simbolosFila1     = { 'x', 'O', 'x', 'O', 'x' };
int[]  repeticionesFila1 = {  2 ,  1 ,  2 ,  1 ,  2  };

string fila1 = "";
for (int s = 0; s < simbolosFila1.Length; s++)
{
    for (int i = 0; i < repeticionesFila1[s]; i++)
    {
        fila1 += simbolosFila1[s];
    }
}
dibujo[1] = fila1;

// Fila 2: "xx(--)xx" — aún más segmentos
char[] simbolosFila2     = { 'x', '(', '-', ')', 'x' };
int[]  repeticionesFila2 = {  2 ,  1 ,  2 ,  1 ,  2  };

string fila2 = "";
for (int s = 0; s < simbolosFila2.Length; s++)
{
    for (int i = 0; i < repeticionesFila2[s]; i++)
    {
        fila2 += simbolosFila2[s];
    }
}
dibujo[2] = fila2;

foreach (string filaDelDibujo in dibujo)
{
    Console.WriteLine(filaDelDibujo);
}
	}	}
