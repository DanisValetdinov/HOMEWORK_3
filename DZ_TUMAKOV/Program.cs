namespace std
{
    class DZ_TUMAKOV
    {
        static void Main()
        {
            TASK1();
            TASK2();
            TASK3();
        }
        static void TASK1()
        {
            /*Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня
            в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
            февраля (високосный год не учитывать).*/
            Console.WriteLine("Упражнение 4.1. Считывает с экрана число и переводит его в месяц и день месяца");
            Console.Write("Введите число: ");
            bool IsDay = ushort.TryParse(Console.ReadLine(), out ushort Day);
            if (IsDay)
            {
                DateTime Date = new DateTime(2024, 1, 1).AddDays(Day - 1);
                Console.WriteLine(Date.ToString("dd MMMM"));
            }
            else
            {
                Console.WriteLine("Данные введены неправильно");
            }
        }
        static void TASK2()
        {
            /*Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного
            пользователем. Если число меньше 1 или больше 365, программа должна вырабатывать
            исключение, и выдавать на экран сообщение.*/
            Console.WriteLine("\nУпражнение 4.2. Добавить к предыдущему заданию проверку числа введенного пользователем");
            //Так получилось что я уже сделал проверку, как обычно
            Console.Write("Введите число: ");
            bool IsDay = ushort.TryParse(Console.ReadLine(), out ushort Day);
            if (IsDay && Day > 0 && Day < 366)
            {
                DateTime Date = new DateTime(2024, 1, 1).AddDays(Day - 1);
                Console.WriteLine(Date.ToString("dd MMMM"));
            }
            else
            {
                Console.WriteLine("Данные введены неправильно");
            }
        }
        static void TASK3()
        {
            /*Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
            учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он
            делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
            год. Однако, если он делится без остатка на 400, это високосный год.)*/
            Console.WriteLine("Упражнение 4.3. Проверить весокосный ли год");
            Console.Write("Введите число: ");
            bool IsDay = ushort.TryParse(Console.ReadLine(), out ushort Day);
            Console.Write("Введите год:");
            bool IsYear = ushort.TryParse(Console.ReadLine(), out ushort Year);
            if (IsDay && Day > 0 && Day < 366 && Year > 0 && Year < 10000)
            {   
                DateTime Date = new DateTime(Year, 1, 1).AddDays(Day - 1);
                Console.WriteLine(Date.ToString("dd MMMM yyyy"));
            }
            else
            {
                Console.WriteLine("Данные введены неправильно");
            }
        }
    }
}