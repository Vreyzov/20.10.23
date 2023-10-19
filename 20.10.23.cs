////стр 33 №3
//Console.WriteLine("Введите натуральное число ");
//int n = Convert.ToInt32(Console.ReadLine());
//double composition = 1;
//for (double k = 1; k <= n; k++)
//{
//    double P = (2 * k) / (2 * k + 1);
//    composition *= P;
//}
//Console.WriteLine($"Произведение первых сомножителей:{composition}");

//стр 41 №1
//Console.WriteLine("Введите натуральное число ");
//int z = Convert.ToInt32(Console.ReadLine());
//int x = 0;
//int y;
//int s;
//int sum;
//s = z;
//while (z != 0)
//{
//    if (z / 10 == 0)
//        x = z;
//    z /= 10;
//}
//y = s % 10;
//sum = x + y;
//Console.WriteLine($"Cумма первого и последнего числа = {sum}");

//стр 43 №1
//Console.WriteLine("Введите натуральное число ");
//int n = Convert.ToInt32(Console.ReadLine());
//int x = 0;
//int y = n % 10;
//while (n > 0)
//{

//    if (n > 9)
//    {
//        x = n % 10;
//        n /= 10;
//    }
//    else
//    {
//        Console.WriteLine("Введите число");
//        break;

//    }

// }
//int sum = n + x;
//Console.WriteLine($"Сумма первой и последней цифры числа: {sum}");

// стр 38 №1
//double i;
//double sum = 0;
//while (true)
//{
//    Console.WriteLine("Введите число посдедовательности.Для остановки введите 0");
//    i = Convert.ToDouble(Console.ReadLine());
//    if (i == 0)
//    {
//        break;
//    }
//    {
//        sum += i;
//    }
//}
//Console.WriteLine($"Сумма: {sum}");
// стр 38 №4
//double i;
//int k = 0;
//Console.WriteLine("Введите число для поиска:");
//double x = Convert.ToDouble(Console.ReadLine());

//while (true)
//{
//    Console.WriteLine("Введите число посдедовательности. Для остановки введите 0");
//    i = Convert.ToDouble(Console.ReadLine());
//    if (i == 0)
//    {
//        break;
//    }
//    if (i == x)
//    {
//        k += 1;

//    }

//}
//Console.WriteLine($"{k} - Столько раз встречается ваше число в этой последовательности");

// стр 38 №6
//double i;
//double composition = 1;
//while (true)
//{
//    Console.WriteLine("Введите число посдедовательности.Для остановки введите 0");
//    i = Convert.ToDouble(Console.ReadLine());
//    if (i == 0)
//    {
//        break;
//    }
//    {
//        composition *= i;
//    }
//}
//Console.WriteLine($"Произведение: {composition}");

////задание 7 стр 38
//int[] sequence = { -1, 2, -3, 4, -5, 6, -7, 8, -9 };
//int sum = 0;
//foreach (int number in sequence)
//{
//    sum += Math.Abs(number);
//}
//Console.WriteLine($"Сумма модулей элементов последовательности: {sum}");

////задание 9 стр 38
//int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int sum = 0;
//foreach (int number in sequence)
//{
//    sum += number*number;
//}
//Console.WriteLine($"Сумма квадратов элементов последовательности: {sum}");

//задание 10 стр 38
//int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int sum = 0;
//int sum1 = 0;
//foreach (int number in sequence)
//{
//    sum += number;
//    sum1 = sum / 9;
//}
//Console.WriteLine($"Среднее арифметическое последовательности: {sum1}");

////задание 12 стр 38
//int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int sum = -1;
//foreach (int number in sequence)
//{
//    sum *= number * number;
//}
//Console.WriteLine($"Сумма произведеней элементов последовательности: {sum}");
