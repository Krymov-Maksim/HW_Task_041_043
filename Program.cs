// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3


// using System.ComponentModel.DataAnnotations;

// int CheckNumber(int number)                                           // Метод проверки правильности ввода числа
// {
//     if (number < 1) System.Console.WriteLine("Wrong number of range");
//     if (number > 20) System.Console.WriteLine("This is so more. Need to inpum number less (1 - 20)");
//     return number;
// }

// int[] ArrayInput(int size)                                            // Метод ввода чисел в массив с клавиатуры
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"Input {i + 1} number: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArrayConsole(int[] array)                                    // Вывод массива на экран Консоли
// {
//     System.Console.Write($"Array entered: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// int HMNumbersGreaterZero(int[] array)                                // Код подсчета чисел больше нуля 
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) result++;
//     }
//     return result;
// }

// System.Console.WriteLine("Enter count of numbers in massive (> 0): ");  // Main. Ввод числа M
// int number = Convert.ToInt32(Console.ReadLine());
// CheckNumber(number);

// int[] array = ArrayInput(number);
// PrintArrayConsole(array);
// System.Console.WriteLine($"Numbers in this Array are greater than Zero: {HMNumbersGreaterZero(array)}");

// --------------------------------------NEXT-----------------------------------------------


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




double CheckNumber(double number)                                           // Метод проверки правильности ввода числа
{
    if (number < -100) System.Console.WriteLine("Wrong number of range");
    if (number > 100) System.Console.WriteLine("This is so more. Need to inpum number less (from -100 to 100)");
    return number;
}


double[] ArrayInput(int size)                                            // Метод ввода коэффициентов в массив с клавиатуры
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Input {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        CheckNumber (array [i]);
    }
    return array;
}

bool CheckArray (double [] Array)                                  // Метод проверки на параллельность и совпадении прямых
    {
        if (Array[0] == Array[2] && Array[1] == Array[3])
            {
                System.Console.WriteLine("Прымые совпадают");
                return false;
            }
        else if (Array[0] == Array[2])
            {
                System.Console.WriteLine("Прямые параллельны");
                return false;
            }
        else return true;
    }

double[] PointIntersec (double[] array)                            // Метод рассчета по формуле x = (b2-b1)/(k1-k2), y = k1*x+b1.
 {
    double [] ArrayPoint = new double [2];
    ArrayPoint[0] = (array[3]-array[1])/(array[0]-array[2]);
    ArrayPoint[1] = array[0]*ArrayPoint[0]+array[1];

    return ArrayPoint; 
 }

void PrintArray (double [] ArrayPoint)                              // Вывод массива на консоль
{
    System.Console.Write($"Точка пересечения прямых -> (");
    for(int i = 0; i < ArrayPoint.Length; i++)
    {
        System.Console.Write($"{ArrayPoint[i]}, ");
    }
        System.Console.WriteLine(")");
}


// Main

System.Console.WriteLine("Заданы две прямые: y=k1*x+b1, y=k2*x+b2. Введите k1, b1, k2, b2. По примеру задачи 5,2,9,4.");
int size = 4; 
double [] array = ArrayInput (size);

if (CheckArray (array) == true)
{
    double [] ArrayPoint = PointIntersec (array);
    PrintArray (ArrayPoint);
}
else
    System.Console.WriteLine("Запустите программу заново и введите коэффициенты корректно");
