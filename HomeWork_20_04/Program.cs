string otv;
bool flag = true;
do
{
   Console.Clear();
   Console.WriteLine("Выберите кокое задание вывести ");
   Console.WriteLine("1 - найти Max число сдвух веденных \n2 - найти Max число с трех введеннх чисел\n3 - Проверить число четное или нет \n4 - Вывести все четные числа от 1 до N");
   otv = Console.ReadLine();

   if (otv == "1")
   {
      Console.WriteLine("Введите два числа и программа найдет Max ");
      Console.Write("-> ");
      int max = Convert.ToInt32(Console.ReadLine());
      Console.Write("-> ");
      int n = Convert.ToInt32(Console.ReadLine());
      if (max > n)
      {
         Console.WriteLine($"max -> {max}");
      }
      else
      {
         Console.WriteLine($"max -> {n}");
      }
   }
   if (otv == "2")
   {
      Console.WriteLine("Введите три числа и программа найдет Max ");
      int count = 0;
      Console.Write("-> ");
      int max = Convert.ToInt32(Console.ReadLine());

      while (count < 2)
      {
         Console.Write("-> ");
         int n = Convert.ToInt32(Console.ReadLine());
         if (n > max)
         {
            max = n;
         }
         count++;
      }
      Console.WriteLine($"max -> {max}");

   }
   if (otv == "3")
   {
      Console.WriteLine("Введите число и программа выведит четное оно или нет ");
      Console.Write("-> ");
      int number = Convert.ToInt32(Console.ReadLine());
      if (number % 2 == 0)
      {
         Console.WriteLine($" {number} -> да");
      }
      else
      {
         Console.WriteLine($" {number} -> нет");
      }
   }
   if (otv == "4")
   {
      Console.WriteLine("Введите число и программа Выведит все четные числа от1 до N ");
      Console.Write("-> ");
      int number = Convert.ToInt32(Console.ReadLine());
      int count = 1;
      while (count <= number)
      {
         if (count % 2 == 0)
         {
            Console.Write($" {count}, ");
         }
         count++;
      }
      Console.WriteLine("");
   }
   Console.WriteLine("Выход -> N \nПродолжить  - Y");
   otv = Console.ReadLine();
   if (otv == "N" || otv == "n")
   {
      flag = false;
   }
} while (flag);
