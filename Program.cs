// ══════════════════════════════════ Главное меню и основные функции ══════════════════════════════════

int choice = 1; // ТЕКУЩИЙ ВЫБРАННЫЙ ЭЛЕМЕНТ
// Список меню
string[] ListMenu = {
    "  Задача 64: Ряд чисел от [n] до 1.                                       ",
    "  Задача 66: Сумма всех чисел от [m] до [n].                              ",
    "  Задача 68: Функция аккермана                                            ",
    "  ВЫХОД ИЗ ПРОГРАММЫ                                                      "};
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;
void menu() // Функция выводит главное меню на экран консоли
{
    int CurrentLine = 1;
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine(choice);
    int i = 0;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.Write("═══════════════════════  Г Л А В Н О Е   М Е Н Ю  ════════════════════════\n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Write("                                                                          \n");
    while (i < ListMenu.Length)
    {
        CurrentLine = i + 1;
        if (choice == CurrentLine)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write($"{ListMenu[i].ToUpper()}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write($"{ListMenu[i]}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        i++;
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.Write("\n" +
    "╔════════════════════════════════════════════════════════╤═══════════════╗\n" +
    "║  Используйте [стрелки] для навигации.                  │   ▲ : Вверх   ║\n" +
    "║  [ENTER] - Выбор выделенного пункта                    │   ▼ : Вниз    ║\n" +
    "╚════════════════════════════════════════════════════════╧═══════════════╝\n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
}
int GetNum() // Запрос на ввод целого числа
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите целое число... ");
    int result1 = Convert.ToInt32(Console.ReadLine());
    return result1;
}
double GetDouble() // Запрос на ввод Вещественного числа
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите целое или дробное число... ");
    double result1 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
    return result1;
}
void ErrorCatch() // Функция обрабатывает ошибку, выдает сообщение и запускает программу с начала
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("" +
    "  ╔═ О Ш И Б К А  В В О Д А ════════════════════════════╗\n" +
    "  ║  Возможно вы ввели не верные данные.                ║\n" +
    "  ║  Программа будет перезапущена...                    ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    Console.ForegroundColor = ConsoleColor.White;
    pause();
}
void pause() // Функция паузы, для чтения результатов
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("" +
    "  ╔═════════════════════════════════════════════════════╗\n" +
    "  ║  ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ...          ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    try
    {
        main();
    }
    catch
    {
        ErrorCatch();
    }
}
void ext() // Функция задает пользователю вопрос хочет ли он выйти из программы и закрывает ее если ответ да
{
AskAgayn:
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("  ╔═ В Ы Х О Д   И З   П Р О Г Р А М М Ы ═══════════════╗  \n" +
    "  ║      Вы уверены что хотите закрыть программу?       ║  \n" +
    "  ║              [ENTER] Да     [ESC] Нет               ║  \n" +
    "  ╚═════════════════════════════════════════════════════╝  \n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("" +
        "  ╔═ О Ш И Б К А  В В О Д А ════════════════════════════╗\n" +
        "  ║  Вам нужно нажать [ENTER] или [ESC].                ║\n" +
        "  ╚═════════════════════════════════════════════════════╝\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("" +
        "  ╔═════════════════════════════════════════════════════╗\n" +
        "  ║  ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ...          ║\n" +
        "  ╚═════════════════════════════════════════════════════╝\n");
        ConsoleKeyInfo key1;
        key1 = Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
        goto AskAgayn;
    }
    else if (key.Key == ConsoleKey.Escape) main();
    else if (key.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        System.Environment.Exit(0);
    }
    else main();
}

// ══════════════════════════════════════ ДОМАШНЕЕ ЗАДАНИЕ ══════════════════════════════════════

// 1 Задача //
void Nums(int n)
{
    if (n >= 1)
    {
        Console.Write($"{n} ");
        Nums(n - 1);
    }
}
// 2 Задача //

int numsSum(int n, int m, int o)
{
    if (n <= m) o = numsSum(n + 1, m, o) + n;
    return (o);
}

// 3 Задача //

int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (n > 0 && m == 0) return Akkerman(n - 1, 1);
    else return Akkerman(n - 1, Akkerman(n, m - 1));
}

// ═════════════════════════════════════════════════════════════════════════════════════════════

// ═══════════════════════════════ Обработка выбранного элемента в меню ═══════════════════════════════
// ВЫПОЛНЕНИЕ ПРОГРАММЫ И ОТСЛЕЖИВАНИЕ НАЖАТИЯ КЛАВИШ
void main()
{
restart:
    menu();
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.UpArrow)
    {
        if (choice <= ListMenu.Length)
        {
            if (choice == 1)
            {
                choice = ListMenu.Length;
                goto restart;
            }
            else
            {
                choice = choice - 1;
                goto restart;
            }
        }
        else goto restart;
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        if (choice >= 1)
        {
            if (choice == ListMenu.Length)
            {
                choice = 1;
                goto restart;
            }
            else
            {
                choice = choice + 1;
                goto restart;
            }
        }
        else goto restart;
    }
    else if (key.Key == ConsoleKey.Enter)
    {
        // Здесь объявляются функции которые программа выполнит при выборе того или иного пункта меню
        switch (choice)
        {
            case 1: // Ready
                { // Действие при выборе 1-го пункта меню
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в\n" +
                    "промежутке от N до 1. Выполнить с омощью рекурсии.\n\n" +
                    "N = 5-> (5, 4, 3, 2, 1)\n" +
                    "N = 8-> (8, 7, 6, 5, 4, 3, 2, 1)\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Введите число [n]...");
                    int n = GetNum();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n\n");
                    Nums(n);
                    Console.Write("\n\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    pause();
                    goto restart;
                }
            case 2: // Ready
                { // Действие при выборе 2-го пункта меню
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных" +
                    "элементов в промежутке от M до N. Выполнить с помощью рекурсии.\n\n" +
                    "M = 1; N = 15 -> 120\n" +
                    "M = 4; N = 8. -> 30\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Введите число [m]...");
                    int m = GetNum();
                    Console.WriteLine("Введите число [n]...");
                    int n = GetNum();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n\n");
                    Console.WriteLine($"Сумма всех натуральных чисел от [m] до [n] равна: {numsSum(m, n, 0)}");
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    pause();
                    goto restart;
                }
            case 3: // 
                { // Действие при выборе 3-го пункта меню
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны\n" +
                    "два неотрицательных числа m и n.\n\n" +
                    "m = 2, n = 3 -> A(m,n) = 9\n" +
                    "m = 3, n = 2 -> A(m,n) = 29\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Введите число [m]...");
                    int m1 = GetNum();
                    Console.WriteLine("Введите число [n]...");
                    int n1 = GetNum();
                    int f = Akkerman(m1, n1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n\n");
                    Console.WriteLine($"Функция Аккермана A({m1}, {n1}) равно {f}");
                    Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                    pause();
                    goto restart;
                }
            case 4: // Exit
                { // Действие при выборе 6-го пункта меню
                    ext();
                    goto restart;
                }
        }
    }
    else goto restart;
}

// ═══════════════════════════════════════════════════════════════════════════════════════════════════════════

// ═══════════════════════════════ Запуск обработки меню и выбранного элемента ═══════════════════════════════

try
{
    main();
}

catch
{
    ErrorCatch();
}