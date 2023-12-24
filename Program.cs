// Console.WriteLine("Введите размеры массива");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         array [i, j] = Convert.ToInt32(new Random().Next(0,11));
// }

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         Console.Write(array[i,j] + "\t  ");
//         Console.WriteLine();
// }

//  Console.WriteLine("Введите координаты");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a>m && b>n)
//  Console.WriteLine("такого числа нет");
//  else
//  {
//     object c = array.GetValue(a,b);
//  Console.WriteLine(c);
//  }


// var array = new int[4, 4]
// { 
// { 1, 2, 3, 4 },
// { 0, 0, 0, 0 },
// { 0, 0, 0, 0 },
// { 5, 6, 7, 8 }
// };
// for(int i = 0; i < array.GetLength(1); i++)
// {
// var tmp = array[3, i];
// array[3, i] = array[0, i];
// array[0, i] = tmp;
// }
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i,j] + " ");
// }
// Console.WriteLine();
// }
// Console.ReadKey(true);


Console.Clear();
Console.WriteLine($"\nВведите размер массива m и n :");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}


