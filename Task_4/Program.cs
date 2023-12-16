//Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен 
//наименьший элемент массива. Под удалением понимается создание нового 
//двумерного массива без строки и столбца

int n = 5;



        int[,] array = new int[n, n];

        Random random = new Random();


        Console.WriteLine("Исходный массив:");



        for (int i = 0; i < n; i++)

        {

            for (int j = 0; j < n; j++)

            {

                array[i, j] = random.Next(1, 10);

                Console.Write(array[i, j] + " ");

            }

            Console.WriteLine();

        }



        int min = array[0, 0];

        int minRow = 0;

        int minCol = 0;


        for (int i = 0; i < n; i++)

        {

            for (int j = 0; j < n; j++)

            {

                if (array[i, j] < min)

                {

                    min = array[i, j];

                    minRow = i;

                    minCol = j;

                }

            }

        }


        Console.WriteLine();

        Console.WriteLine("Минимальный элемент: " + min);

        Console.WriteLine();



        int[,] newArray = new int[n - 1, n - 1];

        int newRow = 0;

        int newCol = 0;


        for (int i = 0; i < n; i++)

        {

            if (i != minRow)

            {

                for (int j = 0; j < n; j++)

                {

                    if (j != minCol)

                    {

                        newArray[newRow, newCol] = array[i, j];

                        Console.Write(newArray[newRow, newCol] + " ");

                        newCol++;

                    }

                }

                newRow++;

                newCol = 0;

                Console.WriteLine();

            }

        }



        Console.WriteLine();

        Console.WriteLine("Новый массив:");

        for (int i = 0; i < n - 1; i++)

        {

            for (int j = 0; j < n - 1; j++)

            {

                Console.Write(newArray[i, j] + " ");

            }

            Console.WriteLine();

        }
