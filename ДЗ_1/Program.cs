/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

string number = Input("Задайте пятизначное число: ");
Validate(number);


string Input(string message)
{
    Console.WriteLine(message);
    string result = Console.ReadLine()!;
    return result;
} 

void Validate(string number)
{
    if(number.Length==5)
    {
        if(IsPolindrom(number)) Console.WriteLine("Данное число является палиндромом");
        else Console.WriteLine("Данное число не является палиндромом");
    }
    else
    {
        Console.WriteLine("Введнено неверное число");
    }

}

bool IsPolindrom(string number)
{
    if(number[0]==number[4]&&number[1]==number[3]) return true;
    else return false;
}