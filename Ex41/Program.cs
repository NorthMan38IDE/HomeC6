// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputInt(string msg)
{
    System.Console.Write($"{msg}");
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    if (isCorrect) 
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int[] InputArray(int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputInt($"Введите {i + 1}-й элемент ");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Threading.Thread.Sleep(50);
        System.Console.WriteLine($" a[{i}] = {array[i]}");
    }
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0;i<array.Length;i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int len = InputInt("Введите кол-во элементов");
int [] array;
array = InputArray(len);
PrintArray(array);
System.Console.WriteLine($"Кол-во чисел больше 0 - {CountPositive(array)} ");