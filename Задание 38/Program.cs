// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементами массива.

int size = ReadInt("Введите размер массива: ");
int min = ReadInt("Введите минимальное число диапазона массива: ");
int max = ReadInt("Введите максимальное число диапазона массива: ");
int [] num = new int[size];

FillArrayRandomNum(num);
Console.Write("Массив: ");
PrintArray(num);

int maxFillarray = num[0];
int minFillarray = num[0];

for (int i = 0; i < num.Length; i++)
{
    if (num[i] > maxFillarray)
    {
        maxFillarray = num[i];
    }
    if (num[i] < minFillarray)
    {
        minFillarray = num[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом массива = {maxFillarray - minFillarray}");

//Заполнение массива
void FillArrayRandomNum(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

//Вывод массива на экран
void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//Функция ввода
int ReadInt(string inpmas)  
{
    Console.Write(inpmas);
    return Convert.ToInt32(Console.ReadLine());
}