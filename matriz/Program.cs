// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

//Declarando uma matriz 3 linhas por 2 colunas
int[,] matriz = new int[3, 2]
{
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};

for ( int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}
