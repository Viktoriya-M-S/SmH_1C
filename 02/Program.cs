﻿Console.Write("Number 1 = ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Number 2 = ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1; 

if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}
Console.WriteLine("Max = " + max);


