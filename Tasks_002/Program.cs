// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summa(int N)
    {
    int Sum = 0;
    string con = Convert.ToString(N);
    // if (con.Length >= 0) 
    {
        for(int i = 0; i <= con.Length; i++)
            {
            Sum += N % 10;
            N /= 10;
            }
    }
        return Sum;
    }

int Number(string Num)
    {
        Console.WriteLine(Num);   
        return Math.Abs(Convert.ToInt32(Console.ReadLine()));
    }
int N = Number("введите число: ");
Console.Write(Summa(N));

 
// int NN = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine(NN);  