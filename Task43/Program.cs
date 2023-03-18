// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// для начала нужно решить уравнение x=(b2-b1)/(k1-k2);


double GetDoubleFromConsole(string name)
{
    System.Console.Write($"Введите {name}: ");
    return Convert.ToDouble(Console.ReadLine());
}

void IntersectionPoint()
{
    double b1 = GetDoubleFromConsole("b1");
    double k1 = GetDoubleFromConsole("k1");
    double b2 = GetDoubleFromConsole("b2");
    double k2 = GetDoubleFromConsole("k2");
    double xСoordinate = (b2-b1)/(k1-k2);
    double yСoordinate = k1 * xСoordinate + b1;
    System.Console.Write($"Координаты точки пересечения прямых: ({xСoordinate}; {yСoordinate}) ");
}


IntersectionPoint();