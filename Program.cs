//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write ("Input your first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Input your second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine ());

if (number_1 == number_2)
{
    Console.WriteLine($"Your numbers are equal");
}

if (number_1 > number_2)
{
    Console.WriteLine($"Your first number is bigger than the second one");
}
if (number_1 < number_2)
{
    Console.WriteLine($"Your first number is less than the second one");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write ("Input your first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Input your second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Input your third number: ");
int number_3 = Convert.ToInt32(Console.ReadLine ());
int max = number_1;

if (number_2 > max)
{ 
    max = number_2;
} 
if (number_3 > max)
{
    max = number_3;
}
Console.Write ($"Your maximum number is  {max}");
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
// 1. Ввод числа
// 2. Проверить является ли число чётным?
// 3. Вывести соответствующее сообщение пользователю

/*
Console.Write ("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number % 2 == 0)
{
    Console.WriteLine ("Your number is even");
}
else
{
    Console.WriteLine ("Your number is odd");
}
*/


//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine ("Input your 1st number: ");
int number_N = Convert.ToInt32(Console.ReadLine());

int current_i = 2;

while (current_i <= number_N)
{
    Console.Write (current_i + " ");
    current_i = current_i + 2; // current_i +=; current_i = current_i + 1
}