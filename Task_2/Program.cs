//Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Console.WriteLine("Исходный массив:");
PrintArray(array);
int width = array.GetLength(1);
int[] tempArray = new int[width];
for (int i = 0; i < width; i++)
{
    tempArray[i] = array[0, i];
    array[0, i] = array[2, i];
    array[2, i] = tempArray[i];
}
Console.WriteLine("Измененный массив:");
PrintArray(array);
Console.ReadKey();
static void PrintArray(int[,] array)
{
    int width = array.GetLength(1);
    int height = array.GetLength(0);
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
