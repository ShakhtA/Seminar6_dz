/* Напишите программу, которая найдёт точку пересечения двух прямых,
   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
   значения b1, k1, b2 и k2 задаются пользователем.
   b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//------------------БЛОК ОПИСАНИЙ------------------------------
double GetNumberFromUser(string num_message, string error_message)
{
    double num;
    while (true)
    {
        Console.Write(num_message);
        if (double.TryParse(Console.ReadLine(), out num))
            return num;
        Console.WriteLine(error_message);
    }   
}

double[] GetCoord(double k1, double b1, double k2, double b2)
{
    double[] arr = new double[2];
    arr[0] = (b2 - b1) / (k1 - k2);
    arr[1] = k1 * arr[0] + b1;
    double y = k2 * arr[0] + b2;
    return arr;
}

void PrintResult(double k1, double b1, double k2, double b2, double[] arr)
{
    Console.Write($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ");
    Console.Write($"({arr[0]:f1}; {arr[1]:f1})");
    Console.WriteLine();
}

//---------------------------------------------------------------

Console.Clear();

// Запрос данных у пользователя
double k1 = GetNumberFromUser("Введите коэффициент k1 - ", "Ошибка ввода!");    
double b1 = GetNumberFromUser("Введите свободный член b1 - ", "Ошибка ввода!");
double k2 = GetNumberFromUser("Введите коэффициент k2 - ", "Ошибка ввода!");
double b2 = GetNumberFromUser("Введите свободный член b2 - ", "Ошибка ввода!");

double[] coord = GetCoord(k1, b1, k2, b2);
PrintResult(k1, b1, k2, b2, coord);
Console.WriteLine();

