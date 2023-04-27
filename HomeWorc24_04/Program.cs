
int Menu()
{
   char key;
   Console.WriteLine("Menu");
   Console.WriteLine("1. Программа принимает трехзначное число и выводит вторую циыру этого числа");
   Console.WriteLine("2. Программа принимает любое число, и выодит третью циыру этого числа");
   Console.WriteLine("3. День недели");
   Console.WriteLine("4. Exit");
   Console.WriteLine("Enter your choice: ");

   return (key = Convert.ToChar(Console.Read()));

}

int TaskOne(int num)
{
   return (num / 10 % 10);
}

int TaskTwo(int numThree)
{
   if (numThree < 100)
   {
      return -1;
   }
   if (numThree > 100)
   {
      return (numThree = numThree / 1000 % 10);
   }
}

bool TaskThree(int day)
{
   if (day == 6 && day == 7) return true;
   else if (day >= 1 && day < 6) return false;
}

bool exit = true; ;
do
{
   char key = Menu();


   if (key == '1')
   {
      Console.WriteLine(" Задание 1");
      Console.Write("Введите трехзначное число -> ");
      int num = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"Вторая цифра Вашего числа -> {TaskOne(num)}");
   }
   else if (key == '2')
   {
      Console.WriteLine(" Задание 2");
      Console.Write("Введите  число -> ");
      int num = Convert.ToInt32(Console.ReadLine());
      int num_three = TaskTwo(num);
      if (num_three == -1)
      {
         Console.WriteLine("Третьей цифры нет");
      }
      else Console.WriteLine($"{num} -> {num_three}");

   }
   else if (key == '3')
   {
      Console.WriteLine(" Задание 3");
      Console.Write("Введите  число -> ");
      int num = Convert.ToInt32(Console.ReadLine());
      if (TaskThree(num))
      {
         Console.WriteLine($"{num} -> да");
      }
      else Console.WriteLine($"{num} -> нет");
   }
   else if (key == '4')
   {
      exit = false;
   }
} while (exit);
