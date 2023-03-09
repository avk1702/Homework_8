/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и
выдаёт номер строки с наименьшей суммой элементов: 0 строка*/

int Prompt(string massage)
{
  System.Console.Write(massage);
  string ReadInput = System.Console.ReadLine();
  int result = Convert.ToInt32(ReadInput);
  return result;
}
void FillMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
      matr[i, j] = new Random().Next(1, 10);
  }
}
void PrintMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    Console.Write(matr[i, j] + "  ");
    Console.WriteLine();
  }
}
int LineSum(int[,] matr, int i)
{
  int lineSum = matr[i, 0];
  for (int j = 1; j < matr.GetLength(1); j++)
  {
    lineSum = lineSum + matr[i, j];
  }
  return lineSum;
}
void LineMinSum(int[,] matr)
{
  int lineMinSum = 0;
  int lineSum = LineSum(matr, 0);
  for (int i = 1; i < matr.GetLength(0); i++)
  {
    int tmpLineSum = LineSum(matr, i);
    if (lineSum > tmpLineSum)
    {
      lineSum = tmpLineSum;
      lineMinSum = i;
    }
  }
  Console.WriteLine("Строка с наименьшей суммой элементов  " + (lineMinSum));
}

int rows = Prompt("Введите размер прямоугольного двумерного массива:  ");
int[,] matr = new int[rows, rows];
FillMatrix(matr);
PrintMatrix(matr);
LineMinSum(matr);


