//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] matrix = {

            {1, 2, 3},

            {4, 5, 6},

            {7, 8, 9}

        };

        int minSum = int.MaxValue;

        int minSumIndex = -1;

        for (int i = 0; i < matrix.GetLength(0); i++)

        {

            int sum = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)

                sum += matrix[i, j];


            if (sum < minSum)

            {

                minSum = sum;

                minSumIndex = i;

            }

        }

Console.WriteLine("Строка с наименьшей суммой элементов: ");

        for (int j = 0; j < matrix.GetLength(1); j++)

            Console.Write(matrix[minSumIndex, j] + " ");
