//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

// int ExponentiationOfNumber(int number, int exponent)
// {
//    int result = 1;
//    for (int i = 0; i < exponent; i++)
//    {
//       result *= number;
//    }
//    return result;
// }

// Console.WriteLine("Введите число -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите в какую степень возвести -> ");
// int exponent = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} , {exponent} -> {ExponentiationOfNumber(num, exponent)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumNumber(int number)
// {
//    int sum = 0;
//    while (number > 0)
//    {
//       sum += number % 10;
//       number /= 10;
//    }
//    return sum;
// }

// Console.Write("Введите число -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} -> {SumNumber(num)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Array(int size)
{
   int[] mask = new int[size];
   for (int i = 0; i < size; i++)
   {
      mask[i] = new Random().Next(0, 10);
   }
   return mask;
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write(array[i] + " ");
   }
   Console.WriteLine();
}

Console.Write("Введите размер массива -> ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = Array(size);
PrintArray(arr);