// Задайте двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

//                        строки     столбцы
int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows,columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumLine(int[,] matrix, int i)
{
  int SumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    SumLine += matrix[i,j];
  }
  return SumLine;
}

//void Change(int[,] matrix);
int minSumLine = 0;
int sumElements = 0;
int sumLine = sumElements(array, 0);
for(int i = 1; i < matrix.GetLength(0); i++)
{
  int tempsumLine = sumElements(array, i);
  if (sumLine > tempSumLine)
  {
     sumLine = tempSumLine;
     minSumLine = i;
  }

}



const int ROWS = 4; // 3 СТРОКИ
const int COLUMNS = 3; // 4 СТОЛБЦА
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] matrix = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
 PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);

