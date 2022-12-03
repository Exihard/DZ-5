// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

int size = ReadInp("Введите размер массива: ");
int min = ReadInp("Введите минимальное число диапазона массива: ");
int max = ReadInp("Введите максимальное число диапазона массива: ");
int [] num = new int[size];

FillArrayRandomNum(num);
PrintArray(num);
int result = 0;

for (int i = 0; i < num.Length; i++)
{
    if (i % 2 != 0)
    {
        result += num[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

//Заполнение массива
void FillArrayRandomNum(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

//Вывод массива
void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//Функция ввода
int ReadInp(string inpmas)  
{
    Console.Write(inpmas);
    return Convert.ToInt32(Console.ReadLine());
}