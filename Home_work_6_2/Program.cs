// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
double Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

void FindPoints(double k1, double b1, double k2, double b2)
{
    if (k2 == k1)
    {
        Console.WriteLine("Функции не пересекается!");
    }
    else
    {
        double x = Math.Round((b1 - b2) / (k2 - k1), 2);
        double y = Math.Round(k1 * ((b1 - b2) / (k2 - k1)) + b1, 2);
        Console.WriteLine($"Ответ: x = {x}; y = {y}");
    }
}

double k1 = Prompt("Введете число: k1 = ");
double b1 = Prompt("Введете число: b1 = ");

double k2 = Prompt("Введете число: k2 = ");
double b2 = Prompt("Введете число: b2 = ");
FindPoints(k1, b1, k2, b2);

// Console.Write("Vvedete chislo: k1 = ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Vvedete chislo: b1 = ");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Vvedete chislo: k1 = ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Vvedete chislo: b1 = ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// double x = (b1-b2)/(k2-k1);
// double y = k1*((b1-b2)/(k2-k1))+b1;
// Console.WriteLine($"x = {x}; y = {y}");