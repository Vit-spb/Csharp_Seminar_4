// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int Prompt(string message)
{
    Console.Write(message); //Выводим приглашение ко вводу 
    int result = Convert.ToInt32(Console.ReadLine());
    return result; //возвращаем результат
}

int[] GenArray (int Length, int minVal, int maxVal)
{
    int[] array = new int[Length];
    Random random = new Random();
        for (int i = 0; i < Length; i++)
            {
                array[i] = random.Next (minVal, maxVal + 1);
            }
        return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

int length = Prompt("Введите длину массива: ");
    if(length <= 0)
    {
        Console.WriteLine($"Длина массива должна быть натуральным числом");
        return;
    }
int min = Prompt("Введите начальное значение диапазона случайных чисел: ");
int max = Prompt("Введите конечное значение диапазона случайных чисел: ");
int[] array = GenArray(length, min, max);

PrintArray(array);