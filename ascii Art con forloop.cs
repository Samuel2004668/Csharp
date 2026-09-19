using System;

public class Program
{
    public static void Main()
    {
        // Arbolito = 11 filas 
        string[] dibujo = new string[11];

        // Fila 0:
        char[] simbolosFila0     = { ' ', '*' , ' ' };
        int[]  repeticionesFila0 = {  4 ,  1 ,  4  };

        string fila0 = "";
        for (int s = 0; s < simbolosFila0.Length; s++)
        {
            for (int i = 0; i < repeticionesFila0[s]; i++)
            {
                fila0 += simbolosFila0[s];
            }
        }
        dibujo[0] = fila0;

        // Fila 1: 
        char[] simbolosFila1     = { ' ', '*' , ' ' };
        int[]  repeticionesFila1 = {  3 ,  3 ,  3  };

        string fila1 = "";
        for (int s = 0; s < simbolosFila1.Length; s++)
        {
            for (int i = 0; i < repeticionesFila1[s]; i++)
            {
                fila1 += simbolosFila1[s];
            }
        }
        dibujo[1] = fila1;

        // Fila 2: 
        char[] simbolosFila2     = { ' ', '*' , ' ' };
        int[]  repeticionesFila2 = {  2 ,  5 ,  2  };

        string fila2 = "";
        for (int s = 0; s < simbolosFila2.Length; s++)
        {
            for (int i = 0; i < repeticionesFila2[s]; i++)
            {
                fila2 += simbolosFila2[s];
            }
        }
        dibujo[2] = fila2;

        // Fila 3: 
        char[] simbolosFila3     = { ' ', '*' , ' ' };
        int[]  repeticionesFila3 = {  1 ,  7 ,  1  };

        string fila3 = "";
        for (int s = 0; s < simbolosFila3.Length; s++)
        {
            for (int i = 0; i < repeticionesFila3[s]; i++)
            {
                fila3 += simbolosFila3[s];
            }
        }
        dibujo[3] = fila3;

        // Fila 4: 
        char[] simbolosFila4     = { '*' };
        int[]  repeticionesFila4 = {  9  };

        string fila4 = "";
        for (int s = 0; s < simbolosFila4.Length; s++)
        {
            for (int i = 0; i < repeticionesFila4[s]; i++)
            {
                fila4 += simbolosFila4[s];
            }
        }
        dibujo[4] = fila4;

        // Fila 5: 
        char[] simbolosFila5     = { ' ', '*' , ' ' };
        int[]  repeticionesFila5 = {  3 ,  3 ,  3  };

        string fila5 = "";
        for (int s = 0; s < simbolosFila5.Length; s++)
        {
            for (int i = 0; i < repeticionesFila5[s]; i++)
            {
                fila5 += simbolosFila5[s];
            }
        }
        dibujo[5] = fila5;

        // Fila 6: 
        char[] simbolosFila6     = { ' ', '*' , ' ' };
        int[]  repeticionesFila6 = {  2 ,  5 ,  2  };

        string fila6 = "";
        for (int s = 0; s < simbolosFila6.Length; s++)
        {
            for (int i = 0; i < repeticionesFila6[s]; i++)
            {
                fila6 += simbolosFila6[s];
            }
        }
        dibujo[6] = fila6;

        // Fila 7: 
        char[] simbolosFila7     = { ' ', '*' , ' ' };
        int[]  repeticionesFila7 = {  1 ,  7 ,  1  };

        string fila7 = "";
        for (int s = 0; s < simbolosFila7.Length; s++)
        {
            for (int i = 0; i < repeticionesFila7[s]; i++)
            {
                fila7 += simbolosFila7[s];
            }
        }
        dibujo[7] = fila7;

        // Fila 8: 
        char[] simbolosFila8     = { '*' };
        int[]  repeticionesFila8 = {  9  };

        string fila8 = "";
        for (int s = 0; s < simbolosFila8.Length; s++)
        {
            for (int i = 0; i < repeticionesFila8[s]; i++)
            {
                fila8 += simbolosFila8[s];
            }
        }
        dibujo[8] = fila8;

        // Fila 9: 
        char[] simbolosFila9     = { ' ', '|' , ' ' };
        int[]  repeticionesFila9 = {  3 ,  3 ,  3  };

        string fila9 = "";
        for (int s = 0; s < simbolosFila9.Length; s++)
        {
            for (int i = 0; i < repeticionesFila9[s]; i++)
            {
                fila9 += simbolosFila9[s];
            }
        }
        dibujo[9] = fila9;

        // Fila 10:
        char[] simbolosFila10     = { ' ', '|' , ' ' };
        int[]  repeticionesFila10 = {  3 ,  3 ,  3  };

        string fila10 = "";
        for (int s = 0; s < simbolosFila10.Length; s++)
        {
            for (int i = 0; i < repeticionesFila10[s]; i++)
            {
                fila10 += simbolosFila10[s];
            }
        }
        dibujo[10] = fila10;

        // y si todo funciona el arbolito...
        foreach (string filaDelDibujo in dibujo)
        {
            Console.WriteLine(filaDelDibujo);
        }
    }
}
