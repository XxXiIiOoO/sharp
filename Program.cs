using System;
int vibor;
double a, b, res;
bool vihod = false;
while (!vihod)
{
    Console.WriteLine("Выберите операцию:");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");

    Console.Write("Введите номер операции: ");
    vibor = int.Parse(Console.ReadLine());

    switch (vibor)
    {
        case 1:
            Console.Write("Введите первое число: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = double.Parse(Console.ReadLine());
            res = a + b;
            Console.WriteLine($"Результат: {res}");
            break;
        case 2:
            Console.Write("Введите первое число: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = double.Parse(Console.ReadLine());
            res = b - a;
            Console.WriteLine($"Результат: {res}");
            break;
        case 3:
            Console.Write("Введите первое число: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = double.Parse(Console.ReadLine());
            res = a * b;
            Console.WriteLine($"Результат: {res}");
            break;
        case 4:
            Console.Write("Введите первое число: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = double.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль");
            }
            else
            {
                res = a / b;
                Console.WriteLine($"Результат: {res}");
            }
            break;
        case 5:
            Console.Write("Введите число: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            int n = int.Parse(Console.ReadLine());
            res = Math.Pow(a, n);
            Console.WriteLine($"Результат: {res}");
            break;
        case 6:
            Console.Write("Введите число: ");
            a = double.Parse(Console.ReadLine());
            res = Math.Sqrt(a);
            Console.WriteLine($"Результат: {res}");
            break;
        case 7:
            Console.Write("Введите число: ");
            a = double.Parse(Console.ReadLine());
            res = a / 100;
            Console.WriteLine($"Результат: {res}");
            break;
        case 8:
            Console.Write("Введите число: ");
            n = int.Parse(Console.ReadLine());
            res = 1;
            for (int i = 2; i <= n; i++)
            {
                res *= i;
            }
            Console.WriteLine($"Факториал числа {n} равен {res}");
            break;
        case 9:
            vihod = true;
            Console.WriteLine("Выход из программы");
            break;
        default:
            Console.WriteLine("Ошибка: неверный номер операции");
            break;
    }
    Console.WriteLine();
}
