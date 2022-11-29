/* Напишите программу, которая на вход 
принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число");
string numberA = Console.ReadLine() ??"";
Console.WriteLine("Введите второе число");
string numberB = Console.ReadLine() ??"";
int numberOne = Convert.ToInt32(numberA);
int numberTwo = Convert.ToInt32(numberB);
if (numberOne > numberTwo)
  {
     Console.Write($"Большее число {numberOne}  ");
     Console.Write($"Меньшее число {numberTwo}");
  }
  else
  {
   Console.Write($"Большее число {numberTwo}  ");
     Console.Write($"Меньшее число {numberOne}");
  }
