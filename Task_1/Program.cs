//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Console.WriteLine("Введите индексы элемента в двумерном массиве:");
Console.Write("Индекс строки: ");
int rowIndex = int.Parse(Console.ReadLine());
Console.Write("Индекс столбца: ");
int colIndex = int.Parse(Console.ReadLine());
if (rowIndex >= 0 && rowIndex < array.GetLength(0) &&
colIndex >= 0 && colIndex < array.GetLength(1))
{
    int element = array[rowIndex, colIndex];
    Console.WriteLine("Значение элемента: " + element);
}
else
{
    Console.WriteLine("Такого элемента не существует");
}
