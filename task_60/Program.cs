//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int Prompt(string massage)
{
  System.Console.Write(massage);
  string ReadInput = System.Console.ReadLine();
  int result = Convert.ToInt32(ReadInput);
  return result;
}
void FillMatrix(int[,,] matr3d)
{
  for (int i = 0; i < matr3d.GetLength(0); i++)
  {
    for (int j = 0; j < matr3d.GetLength(1); j++)
    {
      for (int k = 0; k < matr3d.GetLength(2); k++)
        matr3d[i, j, k] = new Random().Next(10, 100);
    }
  }
}
void CreateMatr(int[,,] matr3d)
{
  int[] tmp = new int[matr3d.GetLength(0) * matr3d.GetLength(1) * matr3d.GetLength(2)];
  int number;
  for (int i = 0; i < tmp.GetLength(0); i++)
  {
    tmp[i] = new Random().Next(10, 100);
    number = tmp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (tmp[i] == tmp[j])
        {
          tmp[i] = new Random().Next(10, 100);
          j = 0;
          number = tmp[i];
        }
        number = tmp[i];
      }
    }
  }
  int count = 0;
  for (int rows = 0; rows < matr3d.GetLength(0); rows++)
  {
    for (int columns = 0; columns < matr3d.GetLength(1); columns++)
    {
      for (int depth = 0; depth < matr3d.GetLength(2); depth++)
      {
        matr3d[rows, columns, depth] = tmp[count];
        count++;
      }
    }
  }
}
void PrintMatrix(int[,,] matr3d)
{
  for (int i = 0; i < matr3d.GetLength(0); i++)
  {
    for (int j = 0; j < matr3d.GetLength(1); j++)
    {
      for (int k = 0; k < matr3d.GetLength(2); k++)
      {
        //}
        Console.Write($"{matr3d[i, j, k]} = ({i}) ({j}) ({k})");

      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
int rows = Prompt("Введите первое значение размерности трёхмерного массива:  ");
int columns = Prompt("Введите второе значение размерности трёхмерного массива:  ");
int depth = Prompt("Введите третье значение размерности трёхмерного массива:  ");
int[,,] matr3d = new int[rows, columns, depth];
FillMatrix(matr3d);
CreateMatr(matr3d);
PrintMatrix(matr3d);
