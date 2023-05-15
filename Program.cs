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
/*
Console.WriteLine ("Input your 1st number: ");
int number_N = Convert.ToInt32(Console.ReadLine());

int current_i = 2;

while (current_i <= number_N)
{
    Console.Write (current_i + " ");
    current_i = current_i + 2; // current_i +=; current_i = current_i + 1
}
*/



//Seminar # 2
//Home tasks:
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//тип метода Имя метода (Аргументы)
/*
int CheckSecDigit (int number)
{
    // Выделяем 2 разряд трехзначного числа
    int SecDigit =  number / 10 % 10;
    return SecDigit;
}


Console.WriteLine("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 99 && user_number < 1000)
{
    
    int res = CheckSecDigit(user_number);
    Console.WriteLine($"The second digit of user added three digit number is {res} ");


}

else
{
    Console.WriteLine ("Вы ввели не трёхзначное число, введите новое число");
}
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
/*

int CheckThirdDigit (int number)
{
     while (number > 999)
     {
        number = number / 10;
     }   
      return number % 10;
}

Console.WriteLine("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 99)
{
    
    int res = CheckThirdDigit(user_number);
    Console.WriteLine($"The third digit of user added number is {res} ");


}

else if (user_number < 99)
{
    Console.WriteLine ("Третья цифра отсутствует, введите число больше 99");
}
*/



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
int Prompt (string message)
{
    Console.Write(message);
    string value =  Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend (int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday (int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine ("Это не день недели!");
    return false;
}

int weekDay = Prompt ("Введите день недели >");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Наконец-то выходной");
    }
    else
    {
        Console.WriteLine ("Придется поработать");
    } 
}