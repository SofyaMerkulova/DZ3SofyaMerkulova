using System;

namespace TasksFromFile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Дана последовательность из 10 чисел. Определить, является ли эта последовательность
          упорядоченной по возрастанию. В случае отрицательного ответа определить
          порядковый номер первого числа, которое нарушает данную последовательность.
          Использовать break.*/
            Console.WriteLine("Упражнение 1");
            string numbers;
            Console.Write("Введите последовательность из 10 чисел: ");
            numbers = Console.ReadLine();
            int[] sequenceOfNumbers = new int[10];
            string[] numbersFromUser = numbers.Split(',');
            bool growing = true;
            for (int i = 0; i < sequenceOfNumbers.Length; i++)
            {
                sequenceOfNumbers[i] = int.Parse(numbersFromUser[i]);
            }
            for (int i = 0; i < sequenceOfNumbers.Length - 1; i++)
            {
                if (sequenceOfNumbers[i] > sequenceOfNumbers[i + 1])
                {
                    Console.WriteLine($"Последовательность не упорядочена по возрастанию, нарушается на {i + 1}");
                    growing = false;
                    break;
                }

            }
            if (growing)
            {
                Console.WriteLine("Последовательность возрастает.");
            }
            Console.WriteLine(" ");
            /*2. Игральным картам условно присвоены следующие порядковые номера в зависимости от
          их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
         Порядковые номера остальных карт соответствуют их названиям («шестерка»,
         «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
         соответствующей карты. Использовать try-catch-finally.*/
            Console.WriteLine("упражнение 2");

            try
            {
                Console.WriteLine("Введите k, такое что 6 <=k <= 14 : ");
                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 6:
                        Console.WriteLine("Это шестёрка");
                        k = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Это семёрка");
                        k = int.Parse(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Это восьмёрка");
                        k = int.Parse(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("Это девятка");
                        k = int.Parse(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("Это десятка");
                        k = int.Parse(Console.ReadLine());
                        break;
                    case 11:
                        Console.WriteLine("Это валет");
                        k = int.Parse(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("Это дама");
                        k = int.Parse(Console.ReadLine());
                        break;
                    case 13:
                        Console.WriteLine("Это король");
                        k = int.Parse(Console.ReadLine());
                        break;
                    case 14:
                        Console.WriteLine("Это туз");
                        k = int.Parse(Console.ReadLine());
                        break;
                }
                if (k < 6 || k >= 15)
                {
                    string fault = k + "is not a valid number ";
                    throw new ArgumentOutOfRangeException(fault);
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Обратите внимание на заданный промежуток");
            }
            finally
            {

            }
            Console.WriteLine(" ");
            /*3. Напишите программу, которая принимает на входе строку и производит выходные
            данные в соответствии со следующей таблицей:*/
            Console.WriteLine("Упражнение 3");
            Console.WriteLine("Введите строку: ");
            string stringByUser = Console.ReadLine();
            stringByUser = stringByUser.ToLower();
            switch (stringByUser)
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
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("anything else");
                    break;
            }
            Console.WriteLine(" ");
            /*4.Составить программу, которая в зависимости от порядкового номера дня недели(1, 2,
          ...,7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
            Использовать enum.*/
            Console.WriteLine("Упражнение 4");
            SecondMain();
        }
    enum DaysOfWeek
        {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    static void SecondMain()
    {
            try
            {
                Console.WriteLine("Введите число от 1 до 7: ");
                string justDay = Console.ReadLine();
                int dayOfWeek = int.Parse(justDay);
                DaysOfWeek number = (DaysOfWeek)dayOfWeek;
                if (dayOfWeek < 1 || dayOfWeek > 7)
                {
                    string fault = dayOfWeek + "is not a valid number ";
                    throw new ArgumentOutOfRangeException(fault);
                }
                Console.WriteLine($"Этому номеру соответствует день недели: {number} ");
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Обратите внимание на заданный промежуток");
            }
            finally
            {

            }
            /*5. Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
            "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
            результату. Вывести на экран сколько кукол в “сумке”.*/
          






        }


}
}
    

    
