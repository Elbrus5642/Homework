/* Напишите программу, 
которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число N:");
string numberStr = Console.ReadLine() ??"";
int numberA = Convert.ToInt32(numberStr);
int evenNumber = 2;
if (numberA == 1)
{
  Console.WriteLine("Чётных чисел в интервале нет, поскольку нет интервала");
}
if (numberA <=0)
{
  Console.WriteLine("Отрицательное число не может быть внутри интервала от 1 до N");
}

if (numberA % 2 == 0)
{
  //Console.WriteLine($"Число {numberA}  even/чётное");
  
  while (evenNumber <= numberA )
  {
    Console.Write($"{evenNumber}, ");
    evenNumber = evenNumber + 2;
  }  
}
else
{
  //Console.WriteLine($"Число {numberA}  odd/нечётное");
  
  while (evenNumber < numberA )
  {
    Console.Write($"{evenNumber}, ");
    evenNumber = evenNumber + 2;
  }    
}

