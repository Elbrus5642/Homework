/*Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Введите первое число:");
string numberA = Console.ReadLine() ??"";
int numberOne = Convert.ToInt32(numberA);
Console.WriteLine("Введите второе число:");
string numberB = Console.ReadLine() ??"";
int numberTwo = Convert.ToInt32(numberB);
Console.WriteLine("Введите третье число:");
string numberC = Console.ReadLine() ??"";
int numberThree = Convert.ToInt32(numberC);
int maxnumber = numberOne;

//Последовательное сравнение чисел друг с другом

if (numberTwo > maxnumber) 
{
   maxnumber =  numberTwo; 
}

if (numberThree > maxnumber)
{
    maxnumber = numberThree;
    Console.WriteLine($"Максимальное число {maxnumber}  ");
}  
else
{
    Console.WriteLine($"Максимальное число {maxnumber}  ");
}
    
      
