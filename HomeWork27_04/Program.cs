
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

double Line(double xa, double xb, double ya, double yb, double za, double zb)
{
   double koordinates = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
   return Math.Round(koordinates, 2);
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

      Console.Clear();
      Console.WriteLine(" Input X to A : ");
      double xa = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(" Input X to B : ");
      double xb = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(" Input Y to A : ");
      double ya = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(" Input Y to B : ");
      double yb = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(" Input Z to A : ");
      double za = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(" Input Z to B : ");
      double zb = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine(Line(xa, xb, ya, yb, za, zb));
   }

   Console.WriteLine("Выход -> \tN \nПродолжить  ->  Y");
   otv = Console.ReadLine();
   if (otv == "N" || otv == "n")
   {
      flag = false;
   }
} while (flag);