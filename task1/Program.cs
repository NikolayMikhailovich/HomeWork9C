// Задача 1: Задайте значения M и N. Напишите программу,
//  которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
  System.Console.Write(message);
  string? input = System.Console.ReadLine();
  int result = int.Parse(input);
  return result;
}

void PrintNumbersBetween(int start, int finish)
{
  if (start <= finish)
  {
    if (start <= finish && start % 2 == 0)
    {
      System.Console.Write($"{start}");
      System.Console.Write(", ");
    }
    PrintNumbersBetween(start + 1, finish);

  }
}

int m = Prompt("Введите число M: ");
int n = Prompt("Введите число N: ");
PrintNumbersBetween(m, n);