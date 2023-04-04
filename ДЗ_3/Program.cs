/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int number = Input("Введите число: ");
Calculate(number);

int Input(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
} 

void Calculate(int number)
{
    
    for (int i = 1; i < number; i++)
    {
        Console.Write($"{Cube(i)},");
    }
    Console.Write($"{Cube(number)}");
}

int Cube(int number)
{
    return number*number*number;
}