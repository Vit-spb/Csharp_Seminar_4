/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Expon(int numberA, int numberB)
{
    int exp = 1;
    int numB = Math.Abs(numberB);
if (numberB !=0)
{
   for(int i = 1; i <= numB; i++)
    {
       exp *= numberA;
    }
    return exp;
}
else
     Console.Write("Число B не может равняться - ");
     return 0; 
}
int Number(string Num)
{
    Console.WriteLine(Num);   
    return Convert.ToInt32(Console.ReadLine());
}
// ---------------------------------------------
int numberA = Number("введите число A: ");
int numberB = Number("введите число B: ");
Console.Write(Expon(numberA, numberB));