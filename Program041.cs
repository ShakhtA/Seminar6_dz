// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

//--------------------------БЛОК ОПИСАНИЙ-------------------------------------
int GetSizeFromUser(string num_message, string error_message)
{
    int num;
    while (true)
    {
     try
        {
            Console.Write(num_message);
            num = int.Parse(Console.ReadLine() ?? "");
            if (num > 0)
                return num;
            Console.WriteLine("Ошибка ввода!");
        }
    catch
        {
            Console.WriteLine(error_message);
        }
    }
}

int[] GetArray(int size, string error_message)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = GetNumberFromUser("Ведите число: ", "Ошибка ввода!");
    }
    return arr;
}

int GetNumberFromUser(string num_message, string error_message)
{
    int num;
    while (true)
    {
     try
        {
            Console.Write(num_message);
            num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch
        {
            Console.WriteLine(error_message);
        }
    }   
}

int CountPositiveNumber(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
        count += el > 0 ? 1:0;
    return count;
}

void PrintResult(int[] arr, int count)
{
    Console.WriteLine($"{string.Join(", ", arr)} -> {count}");
    Console.WriteLine();
}
//-----------------------------------------------------------------------------
Console.Clear();

// Функция запрашивает у пользователя количество (М) чисел
int M = GetSizeFromUser("Введите положительное число: ", "Ошибка ввода!"); 

int[] array = GetArray(M, "Ошибка ввода!"); // Функция запрашивает у пользователя М чисел и заносит их в массив
int count = CountPositiveNumber(array);     // Функция возвращает кол-во чисел, больших, чем 0
PrintResult(array, count);                  // Вывод результата на экран
