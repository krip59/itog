/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число");
int numberB = Convert.ToInt32(Console.ReadLine());
int degre = Degre(numberA,numberB);
Console.WriteLine(degre);
int Degre(int numA, int numB)
{
    if (numB == 0)
    {
        return 0;
    }
    else
    {
        return numA + Degre(numA, numB-1);
    }

}