/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
 по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
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
      matr[i, j] = new Random().Next(-10, 10);
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

void WaneLines(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      for (int a = 0; a < matr.GetLength(1) - 1; a++)
      {
        if (matr[i, a] < matr[i, a + 1])
        {
          int tmp = matr[i, a + 1];
          matr[i, a + 1] = matr[i, a];
          matr[i, a] = tmp;
          
        }
      }
    }
  }
}

int rows = Prompt("Введите количество строк матрицы:  ");
int columns = Prompt("Введите количество столбцов матрицы:  ");
int[,] matr = new int[rows, columns];
FillMatrix(matr);
PrintMatrix(matr);
WaneLines(matr);
Console.WriteLine("Массив отсортированный по убыванию элементов каждой строки");
PrintMatrix(matr);


