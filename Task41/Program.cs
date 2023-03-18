// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// решаем, что пользователь заполняет массив, величина которого изначально также задаётся пользователем.

//заполнение массива из консоли
void FillArrayConsoleNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите значение {i} элемента массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

//печать массива в консоль
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        System.Console.Write(array[i]);
        else
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine("]");
}

void NumbersGreaterThanZero(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) quantity++;
    }
    System.Console.WriteLine($"Количество чисел больше 0 в массиве:  {quantity}");
}

System.Console.Write($"Введите размер массива: ");
int mLength = Convert.ToInt32(Console.ReadLine());
int[] arrayM = new int[mLength];

FillArrayConsoleNumbers(arrayM);
PrintArray(arrayM);
NumbersGreaterThanZero(arrayM);