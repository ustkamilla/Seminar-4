/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] CreateArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new System.Random().Next(0, 10);
    return arr;
}

void PrintArray(int[] array)
{
  foreach (int item in array)
  {
    System.Console.Write($"{item}\t");
  }
}

int[] array = CreateArray(8);

PrintArray(array);
