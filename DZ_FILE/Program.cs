namespace std
{
    class DZ_FILE
    {
        static void Main()
        {
            TASK1();
            TASK2();
            TASK3();
            TASK4();
            TASK5();
        }
        static void TASK1()
        {
            /*1. Дана последовательность из 10 чисел. Определить, является ли эта последовательность
            упорядоченной по возрастанию. В случае отрицательного ответа определить
            порядковый номер первого числа, которое нарушает данную последовательность.
            Использовать break.*/
            Console.WriteLine("Задание 1. Определить, является ли последовательность упорядоченной по возрастанию");
            int[] ar = { 3, 5, 8, 16, 27, 4, 6, 54, 34, 12 };
            for (int i = 0; i < ar.Length - 1; i++)
            {
                if (ar[i] >= ar[i + 1])
                {
                    Console.WriteLine($"{i + 2} - порядковый номер первого числа, который нарушает последовательность");
                    break;
                }
            }   
        }
        static void TASK2()
        {
            /*2. Игральным картам условно присвоены следующие порядковые номера в зависимости от
            их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            Порядковые номера остальных карт соответствуют их названиям («шестерка»,
            «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
            соответствующей карты. Использовать try-catch-finally.*/
            Console.WriteLine("Задание 2. По заданному номеру определить достоинство карты");
            string[] Cards = { "Шесть", "Семь", "Восемь", "Девять", "Десять", "Валет", "Дама", "Король", "Туз" };
            Console.Write("Введите номер карты(от 6 до 14):");
            bool IsCard = byte.TryParse(Console.ReadLine(), out byte Card);
            try
            {
                Console.WriteLine($"Номер - {Card}. Карта - {Cards[Card - 6]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка. Необходимо ввести число от 6 до 14");
            }
            finally
            {
                Console.WriteLine("Не знаю для чего в этой задаче finally, но пусть будет");
            }
        }
        static void TASK3()
        {
            /*3. Напишите программу, которая принимает на входе строку и производит выходные
            данные в соответствии со следующей таблицей:*/
            Console.WriteLine("Задание 3. Принимает на входе строку и производит выходные данные");
            Console.Write("Введите строку:");
            string Input = Console.ReadLine().ToLower();
            switch (Input)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
        }
        static void TASK4()
        {
            /*4. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
            ...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).
            Использовать enum.*/
            Console.WriteLine("Задание 4. Выводит день недели в зависимости от введенного числа");
            Console.Write("Введите номер дня недели: ");
            bool IsDay = byte.TryParse(Console.ReadLine(), out byte DayOfWeek);
            if (IsDay)
            {
                Console.WriteLine((DayOfWeek)DayOfWeek);
            }
        }
        static void TASK5()
        {
            /*5. Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
            "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
            результату. Вывести на экран сколько кукол в “сумке”.*/
            Console.WriteLine("Задание 5. При встрече с определенным элементом в массиве кладет его в 'сумку'");
            byte result = 0;
            string[] strings = { "Hello Ki", "WTF", "HI", "BONJOUR BARBIE", "Hello Kitty", "Barbie doll" };
            foreach (string str in strings)
            {
                if (str == "Hello Kitty" || str == "Barbie doll")
                {
                    result++;
                }
            }
            Console.WriteLine($"Количество кукол в сумке = {result}");
        }
        enum DayOfWeek
        {
            Понедельник = 1,
            Вторник = 2,
            Среда = 3,
            Четверг = 4,
            Пятница = 5,
            Суббота = 6,
            Воскресенье = 7
        }
    }
}
