using System;
namespace Tumakov_lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня
         в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
         февраля (високосный год не учитывать).*/
            Console.WriteLine("Упражнение 4.1");
            string numberOfTheDay;
            Console.WriteLine("Введите число от 1 до 365: ");
            numberOfTheDay = Console.ReadLine();
            int monthOfTheYear = 0;
            int dayOfYear;
            dayOfYear = int.Parse(numberOfTheDay);
            int date;
            date = 0;
            if (dayOfYear <= 31 & dayOfYear > 0)
            {
                monthOfTheYear = 1;
                date = dayOfYear;
            }
            else if (dayOfYear <= 59 & dayOfYear > 31)
            {
                monthOfTheYear = 2;
                date = dayOfYear - 31;
            }
            else if (dayOfYear <= 90 & dayOfYear > 59)
            {
                monthOfTheYear = 3;
                date = dayOfYear - 59;
            }
            else if (dayOfYear <= 120 & dayOfYear > 90)
            {
                monthOfTheYear = 4;
                date = dayOfYear - 90;
            }
            else if (dayOfYear <= 151 & dayOfYear > 120)
            {
                monthOfTheYear = 5;
                date = dayOfYear - 120;
            }
            else if (dayOfYear <= 181 & dayOfYear > 151)
            {
                monthOfTheYear = 6;
                date = dayOfYear - 151;
            }
            else if (dayOfYear <= 212 & dayOfYear > 181)
            {
                monthOfTheYear = 7;
                date = dayOfYear - 181;
            }
            else if (dayOfYear <= 243 & dayOfYear > 212)
            {
                monthOfTheYear = 8;
                date = dayOfYear - 212;
            }
            else if (dayOfYear <= 273 & dayOfYear > 243)
            {
                monthOfTheYear = 9;
                date = dayOfYear - 243;
            }
            else if (dayOfYear <= 304 & dayOfYear > 273)
            {
                monthOfTheYear = 10;
                date = dayOfYear - 273;
            }
            else if (dayOfYear <= 334 & dayOfYear > 304)
            {
                monthOfTheYear = 11;
                date = dayOfYear - 304;
            }
            else if (dayOfYear <= 365 & dayOfYear > 334)
            {
                monthOfTheYear = 12;
                date = dayOfYear - 334;
            }
            string month = "";
            switch (monthOfTheYear)
            {
                case 1:
                    month = "января";
                    break;
                case 2:
                    month = "февраля";
                    break;
                case 3:
                    month = "марта";
                    break;
                case 4:
                    month = "апреля";
                    break;
                case 5:
                    month = "мая";
                    break;
                case 6:
                    month = "июня";
                    break;
                case 7:
                    month = "июля";
                    break;
                case 8:
                    month = "августа";
                    break;
                case 9:
                    month = "сентября";
                    break;
                case 10:
                    month = "октября";
                    break;
                case 11:
                    month = "ноября";
                    break;
                case 12:
                    month = "декабря";
                    break;
            }
            Console.WriteLine($"Этому числу соответствует дата: {date} {month}");
            /*Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного
            пользователем. Если число меньше 1 или больше 365, программа должна вырабатывать
            исключение, и выдавать на экран сообщение.*/
            Console.WriteLine("Упражнение 4.2");
            try {
                string numberOfTheDay1;
                Console.WriteLine("Введите число от 1 до 365: ");
                numberOfTheDay1 = Console.ReadLine();
                int monthOfTheYear1 = 0;
                int dayOfYear1;
                dayOfYear1 = int.Parse(numberOfTheDay1);
                int date1 = 0;
                if (dayOfYear1 <= 31 & dayOfYear1 > 0)
                {
                    monthOfTheYear1 = 1;
                    date1 = dayOfYear1;
                }
                else if (dayOfYear1 <= 59 & dayOfYear1 > 31)
                {
                    monthOfTheYear1 = 2;
                    date1 = dayOfYear1 - 31;
                }
                else if (dayOfYear1 <= 90 & dayOfYear1 > 59)
                {
                    monthOfTheYear1 = 3;
                    date1 = dayOfYear1 - 59;
                }
                else if (dayOfYear1 <= 120 & dayOfYear1 > 90)
                {
                    monthOfTheYear1 = 4;
                    date1 = dayOfYear1 - 90;
                }
                else if (dayOfYear1 <= 151 & dayOfYear1 > 120)
                {
                    monthOfTheYear1 = 5;
                    date1 = dayOfYear1 - 120;
                }
                else if (dayOfYear1 <= 181 & dayOfYear1 > 151)
                {
                    monthOfTheYear1 = 6;
                    date1 = dayOfYear1 - 151;
                }
                else if (dayOfYear1 <= 212 & dayOfYear1 > 181)
                {
                    monthOfTheYear1 = 7;
                    date1 = dayOfYear1 - 181;
                }
                else if (dayOfYear1 <= 243 & dayOfYear1 > 212)
                {
                    monthOfTheYear1 = 8;
                    date1 = dayOfYear1 - 212;
                }
                else if (dayOfYear1 <= 273 & dayOfYear1 > 243)
                {
                    monthOfTheYear1 = 9;
                    date1 = dayOfYear1 - 243;
                }
                else if (dayOfYear1 <= 304 & dayOfYear1 > 273)
                {
                    monthOfTheYear1 = 10;
                    date1 = dayOfYear1 - 273;
                }
                else if (dayOfYear1 <= 334 & dayOfYear1 > 304)
                {
                    monthOfTheYear1 = 11;
                    date1 = dayOfYear1 - 304;
                }
                else if (dayOfYear1 <= 365 & dayOfYear1 > 334)
                {
                    monthOfTheYear1 = 12;
                    date1 = dayOfYear1 - 334;
                }
                string month1 = "";
                switch (monthOfTheYear1)
                {
                    case 1:
                        month1 = "января";
                        break;
                    case 2:
                        month1 = "февраля";
                        break;
                    case 3:
                        month1 = "марта";
                        break;
                    case 4:
                        month1 = "апреля";
                        break;
                    case 5:
                        month1 = "мая";
                        break;
                    case 6:
                        month1 = "июня";
                        break;
                    case 7:
                        month1 = "июля";
                        break;
                    case 8:
                        month1 = "августа";
                        break;
                    case 9:
                        month1 = "сентября";
                        break;
                    case 10:
                        month1 = "октября";
                        break;
                    case 11:
                        month1 = "ноября";
                        break;
                    case 12:
                        month1 = "декабря";
                        break;
                }
                if (dayOfYear1 < 1 || dayOfYear1 >= 366)
                {
                    string fault = dayOfYear1 + "is not a valid number ";
                    throw new ArgumentOutOfRangeException(fault);
                }
                Console.WriteLine($"Этому числу соответствует дата: {date1} {month1}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка в введённых данных");

            }
            finally
            {

            }
            /*Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
           учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он
           делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
           год. Однако, если он делится без остатка на 400, это високосный год.)*/
            Console.WriteLine(" Домашнее задание 4.1");
            try {
                string year;
                Console.WriteLine("Введите год: ");
                year = Console.ReadLine();
                int newYear;
                newYear = int.Parse(year);
                int checkFirst = newYear % 4;
                int checkSecond = newYear % 400;
                int checkThird = newYear % 100;
                string numberOfTheDay3;
                Console.WriteLine("Введите число от 1 до 365(6): ");
                numberOfTheDay3 = Console.ReadLine();
                int monthOfTheYear3 = 0;
                int dayOfYear3;
                int date3 = 0;
                dayOfYear3 = int.Parse(numberOfTheDay3);
                if (checkFirst == 0 & checkThird != 0 || checkSecond == 0)
                {
                    date3 = 0;
                    if (dayOfYear3 <= 31 & dayOfYear3 > 0)
                    {
                        monthOfTheYear3 = 1;
                        date3 = dayOfYear3;
                    }
                    else if (dayOfYear3 <= 60 & dayOfYear3 > 31)
                    {
                        monthOfTheYear3 = 2;
                        date3 = dayOfYear3 - 31;
                    }
                    else if (dayOfYear3 <= 91 & dayOfYear3 > 60)
                    {
                        monthOfTheYear3 = 3;
                        date3 = dayOfYear3 - 60;
                    }
                    else if (dayOfYear3 <= 121 & dayOfYear3 > 91)
                    {
                        monthOfTheYear3 = 4;
                        date = dayOfYear3 - 91;
                    }
                    else if (dayOfYear3 <= 152 & dayOfYear3 > 121)
                    {
                        monthOfTheYear3 = 5;
                        date3 = dayOfYear3 - 121;
                    }
                    else if (dayOfYear3 <= 182 & dayOfYear3 > 152)
                    {
                        monthOfTheYear3 = 6;
                        date3 = dayOfYear3 - 152;
                    }
                    else if (dayOfYear3 <= 213 & dayOfYear3 > 182)
                    {
                        monthOfTheYear3 = 7;
                        date3 = dayOfYear3 - 182;
                    }
                    else if (dayOfYear3 <= 244 & dayOfYear3 > 213)
                    {
                        monthOfTheYear3 = 8;
                        date3 = dayOfYear3 - 213;
                    }
                    else if (dayOfYear3 <= 274 & dayOfYear3 > 244)
                    {
                        monthOfTheYear3 = 9;
                        date3 = dayOfYear3 - 244;
                    }
                    else if (dayOfYear3 <= 305 & dayOfYear3 > 274)
                    {
                        monthOfTheYear3 = 10;
                        date3 = dayOfYear3 - 274;
                    }
                    else if (dayOfYear3 <= 335 & dayOfYear3 > 305)
                    {
                        monthOfTheYear3 = 11;
                        date3 = dayOfYear3 - 305;
                    }
                    else if (dayOfYear3 <= 366 & dayOfYear3 > 335)
                    {
                        monthOfTheYear3 = 12;
                        date3 = dayOfYear3 - 335;
                    }
                }
                else
                {
                    if (dayOfYear3 <= 31 & dayOfYear3 > 0)
                    {
                        monthOfTheYear3 = 1;
                        date3 = dayOfYear3;
                    }
                    else if (dayOfYear3 <= 59 & dayOfYear3 > 31)
                    {
                        monthOfTheYear3 = 2;
                        date3 = dayOfYear3 - 31;
                    }
                    else if (dayOfYear3 <= 90 & dayOfYear3 > 59)
                    {
                        monthOfTheYear3 = 3;
                        date3 = dayOfYear3 - 59;
                    }
                    else if (dayOfYear3 <= 120 & dayOfYear3 > 90)
                    {
                        monthOfTheYear3 = 4;
                        date = dayOfYear3 - 90;
                    }
                    else if (dayOfYear3 <= 151 & dayOfYear3 > 120)
                    {
                        monthOfTheYear3 = 5;
                        date3 = dayOfYear3 - 120;
                    }
                    else if (dayOfYear3 <= 181 & dayOfYear3 > 151)
                    {
                        monthOfTheYear3 = 6;
                        date3 = dayOfYear3 - 151;
                    }
                    else if (dayOfYear3 <= 212 & dayOfYear3 > 181)
                    {
                        monthOfTheYear3 = 7;
                        date3 = dayOfYear3 - 181;
                    }
                    else if (dayOfYear3 <= 243 & dayOfYear3 > 212)
                    {
                        monthOfTheYear3 = 8;
                        date3 = dayOfYear3 - 212;
                    }
                    else if (dayOfYear3 <= 273 & dayOfYear3 > 243)
                    {
                        monthOfTheYear3 = 9;
                        date3 = dayOfYear3 - 243;
                    }
                    else if (dayOfYear3 <= 304 & dayOfYear3 > 273)
                    {
                        monthOfTheYear3 = 10;
                        date3 = dayOfYear3 - 273;
                    }
                    else if (dayOfYear3 <= 334 & dayOfYear3 > 304)
                    {
                        monthOfTheYear3 = 11;
                        date3 = dayOfYear3 - 304;
                    }
                    else if (dayOfYear3 <= 365 & dayOfYear3 > 334)
                    {
                        monthOfTheYear3 = 12;
                        date3 = dayOfYear3 - 334;
                    }
                }
                    string month3 = "";
                    switch (monthOfTheYear3)
                    {
                        case 1:
                            month3 = "января";
                            break;
                        case 2:
                            month3 = "февраля";
                            break;
                        case 3:
                            month3 = "марта";
                            break;
                        case 4:
                            month3 = "апреля";
                            break;
                        case 5:
                            month3 = "мая";
                            break;
                        case 6:
                            month3 = "июня";
                            break;
                        case 7:
                            month3 = "июля";
                            break;
                        case 8:
                            month3 = "августа";
                            break;
                        case 9:
                            month3 = "сентября";
                            break;
                        case 10:
                            month3 = "октября";
                            break;
                        case 11:
                            month3 = "ноября";
                            break;
                        case 12:
                            month3 = "декабря";
                            break;
                    }
                    if (dayOfYear3 < 1 || dayOfYear3 >= 366)
                    {
                        string fault = dayOfYear3 + "is not a valid number ";
                        throw new ArgumentOutOfRangeException(fault);
                    }
                    Console.WriteLine($"Этому числу соответствует дата: {date3} {month3}");
                   }
                  catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка в введённых данных");

            }
            finally
            {

            }









        }
    }
}

