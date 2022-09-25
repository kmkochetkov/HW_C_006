// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1,
// k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// создание массива коэффициентов уравнений
double[] coefficients = new double [4];
string[] coeffNames = new string[] {"b1", "k1", "b2", "k2"};
// Ввод значений коэффициентов

int index = 0;
while (index < 4)
    {
        try
        {
           Console.Write($"Введите коэфициент {coeffNames[index]} : ");
           coefficients[index] = Convert.ToInt32(Console.ReadLine());
        }
    catch
    {    
        Console.WriteLine("Нужно вводить целое число!");
    }
        index++;
    }

// Вычисление координат пересечения прямых

double x1 = ((coefficients[2]-coefficients[0]) / (coefficients[1]-coefficients[3]));
double y1 = coefficients[1]*x1+coefficients[0];

// Вывод результата вычислений 
Console.WriteLine($"Координата пересечения прямых: {x1},{y1}");