// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("введите число M: ");
int startReport = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число N: ");
int endReport = Convert.ToInt32(Console.ReadLine());

int Sum(int start, int finish)
{
  if (start > finish) return 0;
  return start + Sum(start + 1, finish);
}
Console.WriteLine(Sum(startReport, endReport));
