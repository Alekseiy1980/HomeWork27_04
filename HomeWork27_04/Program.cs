
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
//  ними в 3D пространстве.

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Pallindrom(int num)
{
   int pallindromNumber = num % 100;

   int tmp = (pallindromNumber % 10) * 10;
   tmp += (pallindromNumber / 10);
   if (num / 1000 == tmp) Console.WriteLine($"{num} => да");
   else Console.WriteLine($"{num} => нет");
}

void Cube(int num)
{
   int counter = 1;
   Console.Write($"{num} => ");
   while (counter <= num)
   {
      Console.Write($"{counter * counter * counter}, ");
      counter++;
   }
   Console.WriteLine("");
}
string otv;
bool flag = true;
do
{
   Console.Clear();
   Console.WriteLine("Выберите кокое задание вывести ");
   Console.WriteLine("1 - Напишите программу, которая принимает на вход пятизначное число и проверяет,  является ли оно палиндромом. \n2 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N \n3 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
   otv = Console.ReadLine();

   if (otv == "1")
   {
      Console.Clear();
      Console.WriteLine("\tЧисло палиндром");
      Console.WriteLine("Введите число : ");
      int number = Convert.ToInt32(Console.ReadLine());
      Pallindrom(number);
   }
   if (otv == "2")
   {
      Console.Clear();
      Console.WriteLine("\tТаблица кубов");
      Console.WriteLine("Введите число : ");
      int number = Convert.ToInt32(Console.ReadLine());
      Cube(number);
   }
   if (otv == "3")
   {

   }

   Console.WriteLine("Выход -> \tN \nПродолжить  ->  Y");
   otv = Console.ReadLine();
   if (otv == "N" || otv == "n")
   {
      flag = false;
   }
} while (flag);