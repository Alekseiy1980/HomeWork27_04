// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
// //программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2


// //Заполняем рандомно массив трехзначными значениями
// int[] RandomArray(int size)
// {
//    int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//       array[i] = new Random().Next(100, 1000);
//    }
//    return array;
// }
// // выводим массив ы консоль
// void PrintArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// //счетчик четных значений
// int EvenNumbers(int[] array)
// {
//    int count = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] % 2 == 0) count++;
//    }
//    return count;
// }

// Console.Write("Введите размер массива : ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = RandomArray(size);
// PrintArray(myArray);
// Console.WriteLine($"Колличество четных значений в массве - {EvenNumbers(myArray)}");


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// //Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// //Заполняем рандомно массив 
// int[] RandomArray(int size)
// {
//    int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//       array[i] = new Random().Next(-100, 100);
//    }
//    return array;
// }

// void PrintArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
// }

// void QuantityOddElements(int[] array)
// {
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (i % 2 != 0)
//       {
//          sum += array[i];
//       }
//    }
//    Console.WriteLine($" Сумма элементов , стоящих на нечетных позициях -> {sum}");
// }
// Console.Write("Введите размер массива : ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = RandomArray(size);
// PrintArray(myArray);
// QuantityOddElements(myArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateDoubleArray(int size)
{
   double[] arr = new double[size];
   for (int i = 0; i < size; i++)
      arr[i] = new Random().Next(0, 10) + Math.Round(new Random().NextDouble(), 2);// метод Math.Round(new Random().NextDouble нужен для уменьшения чисел после запятой
   return arr;
}
void PrintArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write(array[i] + " ");
   }
   Console.WriteLine();
}

void BetweenTheNumbers(double[] array)
{
   double result = 0;
   double minValue = array[0];
   double maxValue = array[0];

   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > maxValue)
      {
         maxValue = array[i];
      }
      else if (array[i] < minValue)
      {
         minValue = array[i];
      }
   }
   result = maxValue - minValue;
   Console.WriteLine($"{maxValue} - {minValue} = {result}");
}
Console.Write("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateDoubleArray(size);
PrintArray(myArray);
BetweenTheNumbers(myArray);