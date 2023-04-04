/*Задача 21. 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int[] A = Input("Задайте координаты точки А: ");
int[] B = Input("Задайте координаты точки B: ");
Console.WriteLine($"Расстояние между точками A и B равно: {GetDistance(A,B)}");

int[] Input(string message)
{
    int[] result = new int[3];
    Console.WriteLine(message);
    Console.WriteLine("Введите X: "); 
    result[0] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите Y: "); 
    result[1] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите Z: ");
    result[2] = int.Parse(Console.ReadLine()!);
    return result;
} 

double GetDistance(int[] A,int[] B)
{
    return Math.Sqrt(((B[0]-A[0])*(B[0]-A[0])) + ((B[1]-A[1])*(B[1]-A[1])) + ((B[2]-A[2])*(B[2]-A[2])));
}