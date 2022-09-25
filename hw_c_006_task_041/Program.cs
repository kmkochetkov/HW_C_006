// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Подсчёт количества положительных чисел

int PositiveCount(int[] col)

{
   int count = col.Length;
    int i = 0;
    int positiv = 0;
 for (i = 0; i<count; i++)
    if (col[i]>0) positiv++;

     return positiv;
}

// Основная программа

// Задаём количество чисел
int n = 0;
    try
    {
        Console.Write("Сколько чисел вы хотите ввести?: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {    
        Console.WriteLine("Нужно вводить целое число!");
    }


// Создаём новый массив длиной n
int[] array = new int[n];

// Заполняем массив
int i = 0;

for (i = 0; i<n; i++)
{
    try
    {
        Console.Write($"Введите {i}-е число : ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {    
        Console.WriteLine("Нужно вводить целое число!");
    }
}

Console.WriteLine($"Количество введённых положительных чисел равно: {PositiveCount(array)}");


