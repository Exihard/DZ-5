// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int size = ReadInp("");
int [] num = new int[size];

FillArrayRandomNum(num);
PrintArray(num);
int result = 0;

for (int i = 0; i < num.Length; i++)
{
    if (num[i] % 2 == 0)
    {
        result++;
    }
}
if (result % 10 == 1)
{
    Console.WriteLine($"В массиве {result} четное число");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"В массиве {result} четных числа");
}
else

    Console.WriteLine($"В массиве {result} четных чисел");


// Заполнение массива
void FillArrayRandomNum(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
}

// Вывод массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Фуекция ввода
int ReadInp(string vvod)
{
    Console.Write("Введите размер массива: ");
    return Convert.ToInt32(Console.ReadLine());
}