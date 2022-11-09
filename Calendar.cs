using System;
using System.Globalization;

class GFG
{
    static int dayOfFirstDate, yearOfFirstDate, dayOfSecondDate, yearOfSecondDate, firstDay, firstYear, secondDay, secondYear, firstDate, secondDate, lastDay;
    static int countRange;


    static bool expressidefinitionOfMonths = true;
    static bool controlOfIf = true;
    static string monthOfFirstDate, monthOfSecondDate, firstMonth, secondMonth;
    static int i = 1;

    // Print Day for a Date
    static void Zellercongruence(int day,
                      int month, int year)
    {
        if (month == 1)
        {
            month = 13;
            year--;
        }
        if (month == 2)
        {
            month = 14;
            year--;
        }
        int q = day;
        int m = month;
        int k = year % 100;
        int j = year / 100;
        int h = q + 13 * (m + 1) / 5 + k + k / 4
                                 + j / 4 + 5 * j;
        h = h % 7;
        switch (h)
        {
            case 0:
                Console.WriteLine("Saturday");
                break;

            case 1:
                Console.WriteLine("Sunday");
                break;

            case 2:
                Console.WriteLine("Monday");
                break;

            case 3:
                Console.WriteLine("Tuesday");
                break;

            case 4:
                Console.WriteLine("Wednesday");
                break;

            case 5:
                Console.WriteLine("Thursday");
                break;

            case 6:
                Console.WriteLine("Friday");
                break;
        }
    }

    // Driver code
    public static void Main()
    {
        string month1 = "January";
        string month2 = "February";
        string month3 = "March";
        string month4 = "April";
        string month5 = "May";
        string month6 = "June";
        string month7 = "July";
        string month8 = "August";
        string month9 = "September";
        string month10 = "October";
        string month11 = "November";
        string month12 = "December";
        int k = 1;
        int a = 2;
        int countRange;
        bool controlOfWhile = true;



        do
        {
            do
            {
                do
                {
                    try
                    {
                        Console.Write("Please enter the day of first date:");
                        firstDay = Convert.ToInt32(Console.ReadLine());   //Gets the day of the first date from the user
                        i = 2;
                        if (firstDay > 31)
                        {
                            Console.WriteLine("Please enter a valid value!");
                            i = 1;
                            a = 1;
                        }
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Please enter a valid value!");
                    }
                } while (i == 1);

                do
                {
                    Console.Write("Please enter the month of first date:");
                    firstMonth = Console.ReadLine();  //Gets the month of the first date from the user
                    firstMonth = firstMonth.ToLower();
                    firstMonth = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(firstMonth);
                    if (firstMonth == month1)
                    {
                        i = 1;
                    }
                    else if (firstMonth == month2)
                    {
                        if (firstDay <= 29)
                        {
                            i = 1;
                            a = 2;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid value!");
                            i = 1;
                            a = 1;
                        }
                    }
                    else if (firstMonth == month3)
                    {
                        i = 1;
                    }

                    else if (firstMonth == month4)
                    {
                        if (firstDay <= 30)
                        {

                            i = 1;
                            a = 2;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid value!");
                            i = 1;
                            a = 1;
                        }

                    }
                    else if (firstMonth == month5)
                    {

                        i = 1;
                    }
                    else if (firstMonth == month6)
                    {
                        if (firstDay <= 30)
                        {
                            a = 2;
                            i = 1;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid value!");
                            i = 1;
                            a = 1;
                        }
                    }
                    else if (firstMonth == month7)
                    {
                        i = 1;
                    }
                    else if (firstMonth == month8)
                    {
                        i = 1;
                    }
                    else if (firstMonth == month9)
                    {
                        if (firstDay <= 30)
                        {
                            i = 1;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid value!");
                            i = 1;
                            a = 1;
                        }
                    }
                    else if (firstMonth == month10)
                    {
                        i = 1;
                    }
                    else if (firstMonth == month11)
                    {
                        if (firstDay <= 30)
                        {

                            i = 1;
                            a = 2;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid value!");
                            i = 1;
                            a = 1;
                        }

                    }
                    else if (firstMonth == month12)
                    {
                        i = 1;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid value!");
                        i = 2;

                    }

                } while (i == 2);
            } while (a == 1);

            do
            {
                try
                {
                    do
                    {
                        Console.Write("Please enter the year so that the first date is not earlier than 2015:");
                        firstYear = Convert.ToInt32(Console.ReadLine());  //Gets the year of the first date from the user
                        if (firstYear < 2015)
                        {
                            Console.WriteLine("Please enter a valid value!");
                            k = 1;
                        }
                        else
                        {
                            i = 2;
                            k = 2;
                        }
                        if (firstMonth == month2)
                        {
                            if (firstDay == 29)
                            {
                                if (firstYear % 4 != 0)
                                {
                                    Console.WriteLine("Please enter a valid value!");
                                    a = 1;
                                    k = 2;
                                }
                            }
                        }
                    } while (k == 1);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter a valid value!");
                }
            } while (i == 1);
        } while (a == 1);

        do
        {
            do
            {
                do
                {
                    try
                    {
                        Console.Write("Please enter the day of second date:");
                        secondDay = Convert.ToInt32(Console.ReadLine());  //Gets the day of the second date from the user
                        i = 2;
                        if (secondDay > 31)
                        {
                            Console.WriteLine("Please enter a valid value!");
                            i = 1;
                            a = 1;
                        }
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Please enter a valid value!");
                        i = 1;
                    }
                } while (i == 1);
                a = 2;

                do
                {
                    Console.Write("Please enter the month of second date:");
                    secondMonth = Console.ReadLine();   //Gets the month of the second date from the user
                    secondMonth = secondMonth.ToLower();
                    secondMonth = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(secondMonth);
                    if (secondMonth == month1)
                    {
                        i = 1;

                    }
                    else if (secondMonth == month2)
                    {
                        if (secondDay <= 29)
                        {
                            i = 1;

                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid value!");
                            i = 1;
                            a = 1;
                        }
                    }
                    else if (secondMonth == month3)
                    {
                        i = 1;
                    }


                    else if (secondMonth == month4)
                    {
                        if (secondDay <= 30)
                        {

                            i = 1;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid value!");
                            i = 1;
                            a = 1;
                        }
                    }
                    else if (secondMonth == month5)
                    {
                        i = 1;
                    }
                    else if (secondMonth == month6)
                    {
                        if (secondDay <= 30)
                        {
                            i = 1;

                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid value!");
                            i = 1;
                            a = 1;
                        }
                    }
                    else if (secondMonth == month7)
                    {
                        i = 1;
                    }
                    else if (secondMonth == month8)
                    {
                        i = 1;
                    }
                    else if (secondMonth == month9)
                    {
                        if (secondDay <= 30)
                        {
                            i = 1;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid value!");
                            i = 1;
                            a = 1;
                        }
                    }
                    else if (secondMonth == month10)
                    {

                        i = 1;

                    }
                    else if (secondMonth == month11)
                    {
                        if (secondDay <= 30)
                        {
                            i = 1;

                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid value!");
                            i = 1;
                            a = 1;
                        }

                    }
                    else if (secondMonth == month12)
                    {
                        i = 1;

                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid value!");
                        i = 2;

                    }


                } while (i == 2);
            } while (a == 1);

            do
            {
                try
                {
                    do
                    {
                        Console.Write("Please enter the year so that the second date is not earlier than 2015:");
                        secondYear = Convert.ToInt32(Console.ReadLine());  //Gets the year of the second date from the user
                        if (secondYear < 2015)
                        {
                            Console.WriteLine("Please enter a valid value!");
                        }
                        else
                        {
                            i = 2;
                            k = 2;
                        }
                        if (secondMonth == month2)
                        {
                            if (secondDay == 29)
                            {
                                if (secondYear % 4 != 0)
                                {
                                    Console.WriteLine("Please enter a valid value!");
                                    a = 1;
                                    k = 2;
                                }
                            }
                        }
                    } while (k == 1);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter a valid value!");
                }
            } while (i == 1);
        } while (a == 1);
        countRange = 0;
        do
        {
            try
            {
                Console.Write("Please enter the count range : ");
                Console.Write("n = ");
                countRange = Convert.ToInt32(Console.ReadLine());  //Gets the count range from the user
                if (countRange == 0)
                {
                    Console.WriteLine("Please enter a valid value");
                    a = 1;
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Please enter a valid value");
                a = 1;
            }
        } while (a == 1);


        Console.Clear();

        if (firstMonth == month1)
        {
            Console.Write(firstDay + " " + month1 + " " + firstYear + " ");
            Zellercongruence(firstDay, 1, firstYear);
        }
        if (firstMonth == month2)
        {
            Console.Write(firstDay + " " + month2 + " " + firstYear + " ");
            Zellercongruence(firstDay, 2, firstYear);
        }
        if (firstMonth == month3)
        {
            Console.Write(firstDay + " " + month3 + " " + firstYear + " ");
            Zellercongruence(firstDay, 3, firstYear);
        }
        if (firstMonth == month4)
        {
            Console.Write(firstDay + " " + month4 + " " + firstYear + " ");
            Zellercongruence(firstDay, 4, firstYear);
        }
        if (firstMonth == month5)
        {
            Console.Write(firstDay + " " + month5 + " " + firstYear + " ");
            Zellercongruence(firstDay, 5, firstYear);
        }
        if (firstMonth == month6)
        {
            Console.Write(firstDay + " " + month6 + " " + firstYear + " ");
            Zellercongruence(firstDay, 6, firstYear);
        }
        if (firstMonth == month7)
        {
            Console.Write(firstDay + " " + month7 + " " + firstYear + " ");
            Zellercongruence(firstDay, 7, firstYear);
        }
        if (firstMonth == month8)
        {
            Console.Write(firstDay + " " + month8 + " " + firstYear + " ");
            Zellercongruence(firstDay, 8, firstYear);
        }
        if (firstMonth == month9)
        {
            Console.Write(firstDay + " " + month9 + " " + firstYear + " ");
            Zellercongruence(firstDay, 9, firstYear);
        }
        if (firstMonth == month10)
        {
            Console.Write(firstDay + " " + month10 + " " + firstYear + " ");
            Zellercongruence(firstDay, 10, firstYear);
        }
        if (firstMonth == month11)
        {
            Console.Write(firstDay + " " + month11 + " " + firstYear + " ");
            Zellercongruence(firstDay, 11, firstYear);
        }
        if (firstMonth == month12)
        {
            Console.Write(firstDay + " " + month12 + " " + firstYear + " ");
            Zellercongruence(firstDay, 12, firstYear);
        }
        if (secondMonth == month1)
        {
            Console.Write(secondDay + " " + month1 + " " + secondYear + " ");
            Zellercongruence(secondDay, 1, secondYear);
        }
        if (secondMonth == month2)
        {
            Console.Write(secondDay + " " + month2 + " " + secondYear + " ");
            Zellercongruence(secondDay, 2, secondYear);
        }
        if (secondMonth == month3)
        {
            Console.Write(secondDay + " " + month3 + " " + secondYear + " ");
            Zellercongruence(secondDay, 3, secondYear);
        }
        if (secondMonth == month4)
        {
            Console.Write(secondDay + " " + month4 + " " + secondYear + " ");
            Zellercongruence(secondDay, 4, secondYear);
        }
        if (secondMonth == month5)
        {
            Console.Write(secondDay + " " + month5 + " " + secondYear + " ");
            Zellercongruence(secondDay, 5, secondYear);
        }
        if (secondMonth == month6)
        {
            Console.Write(secondDay + " " + month6 + " " + secondYear + " ");
            Zellercongruence(secondDay, 6, secondYear);
        }
        if (secondMonth == month7)
        {
            Console.Write(secondDay + " " + month7 + " " + secondYear + " ");
            Zellercongruence(secondDay, 7, secondYear);
        }
        if (secondMonth == month8)
        {
            Console.Write(secondDay + " " + month8 + " " + secondYear + " ");
            Zellercongruence(secondDay, 8, secondYear);
        }
        if (secondMonth == month9)
        {
            Console.Write(secondDay + " " + month9 + " " + secondYear + " ");
            Zellercongruence(secondDay, 9, secondYear);
        }
        if (secondMonth == month10)
        {
            Console.Write(secondDay + " " + month10 + " " + secondYear + " ");
            Zellercongruence(secondDay, 10, secondYear);
        }
        if (secondMonth == month11)
        {
            Console.Write(secondDay + " " + month11 + " " + secondYear + " ");
            Zellercongruence(secondDay, 11, secondYear);
        }
        if (secondMonth == month12)
        {
            Console.Write(secondDay + " " + month12 + " " + secondYear + " ");
            Zellercongruence(secondDay, 12, secondYear);
        }
        Console.WriteLine("The count range is: " + countRange);

        // Calculates from which date the program will start counting
        if (firstYear == secondYear && firstMonth == secondMonth)
        {
            if (firstDay < secondDay)
            {
                dayOfFirstDate = firstDay;
                monthOfFirstDate = firstMonth;
                yearOfFirstDate = firstYear;
                dayOfSecondDate = secondDay;
                monthOfSecondDate = secondMonth;
                yearOfSecondDate = secondYear;
            }
            else
            {
                dayOfFirstDate = secondDay;
                monthOfFirstDate = secondMonth;
                yearOfFirstDate = secondYear;
                dayOfSecondDate = firstDay;
                monthOfSecondDate = firstMonth;
                yearOfSecondDate = firstYear;
            }
        }
        else if (firstYear == secondYear && firstMonth != secondMonth)
        {
            if (firstMonth == month1)
            {
                dayOfFirstDate = firstDay;
                monthOfFirstDate = firstMonth;
                yearOfFirstDate = firstYear;
                dayOfSecondDate = secondDay;
                monthOfSecondDate = secondMonth;
                yearOfSecondDate = secondYear;
            }

            if (firstMonth == month2)
            {
                if (secondMonth != month1)
                {
                    dayOfFirstDate = firstDay;
                    monthOfFirstDate = firstMonth;
                    yearOfFirstDate = firstYear;
                    dayOfSecondDate = secondDay;
                    monthOfSecondDate = secondMonth;
                    yearOfSecondDate = secondYear;
                }
                else
                {
                    dayOfSecondDate = firstDay;
                    monthOfSecondDate = firstMonth;
                    yearOfSecondDate = firstYear;
                    dayOfFirstDate = secondDay;
                    monthOfFirstDate = secondMonth;
                    yearOfFirstDate = secondYear;
                }
            }
            if (firstMonth == month3)
            {
                if (secondMonth != month1 || secondMonth != month2)
                {
                    dayOfFirstDate = firstDay;
                    monthOfFirstDate = firstMonth;
                    yearOfFirstDate = firstYear;
                    dayOfSecondDate = secondDay;
                    monthOfSecondDate = secondMonth;
                    yearOfSecondDate = secondYear;
                }
                else
                {
                    dayOfSecondDate = firstDay;
                    monthOfSecondDate = firstMonth;
                    yearOfSecondDate = firstYear;
                    dayOfFirstDate = secondDay;
                    monthOfFirstDate = secondMonth;
                    yearOfFirstDate = secondYear;
                }
            }
            if (firstMonth == month4)
            {
                if (secondMonth != month1 || secondMonth != month2 || secondMonth != month3)
                {
                    dayOfFirstDate = firstDay;
                    monthOfFirstDate = firstMonth;
                    yearOfFirstDate = firstYear;
                    dayOfSecondDate = secondDay;
                    monthOfSecondDate = secondMonth;
                    yearOfSecondDate = secondYear;
                }
                else
                {
                    dayOfSecondDate = firstDay;
                    monthOfSecondDate = firstMonth;
                    yearOfSecondDate = firstYear;
                    dayOfFirstDate = secondDay;
                    monthOfFirstDate = secondMonth;
                    yearOfFirstDate = secondYear;
                }
            }
            if (firstMonth == month5)
            {
                if (secondMonth != month1 || secondMonth != month2 || secondMonth != month3 || secondMonth != month4)
                {
                    dayOfFirstDate = firstDay;
                    monthOfFirstDate = firstMonth;
                    yearOfFirstDate = firstYear;
                    dayOfSecondDate = secondDay;
                    monthOfSecondDate = secondMonth;
                    yearOfSecondDate = secondYear;
                }
                else
                {
                    dayOfSecondDate = firstDay;
                    monthOfSecondDate = firstMonth;
                    yearOfSecondDate = firstYear;
                    dayOfFirstDate = secondDay;
                    monthOfFirstDate = secondMonth;
                    yearOfFirstDate = secondYear;
                }
            }
            if (firstMonth == month6)
            {
                if (secondMonth != month1 || secondMonth != month2 || secondMonth != month3 || secondMonth != month4 || secondMonth != month5)
                {
                    dayOfFirstDate = firstDay;
                    monthOfFirstDate = firstMonth;
                    yearOfFirstDate = firstYear;
                    dayOfSecondDate = secondDay;
                    monthOfSecondDate = secondMonth;
                    yearOfSecondDate = secondYear;
                }
                else
                {
                    dayOfSecondDate = firstDay;
                    monthOfSecondDate = firstMonth;
                    yearOfSecondDate = firstYear;
                    dayOfFirstDate = secondDay;
                    monthOfFirstDate = secondMonth;
                    yearOfFirstDate = secondYear;
                }
            }
            if (firstMonth == month7)
            {
                if (secondMonth != month1 || secondMonth != month2 || secondMonth != month3 || secondMonth != month4 || secondMonth != month5 || secondMonth != month6)
                {
                    dayOfFirstDate = firstDay;
                    monthOfFirstDate = firstMonth;
                    yearOfFirstDate = firstYear;
                    dayOfSecondDate = secondDay;
                    monthOfSecondDate = secondMonth;
                    yearOfSecondDate = secondYear;
                }
                else
                {
                    dayOfSecondDate = firstDay;
                    monthOfSecondDate = firstMonth;
                    yearOfSecondDate = firstYear;
                    dayOfFirstDate = secondDay;
                    monthOfFirstDate = secondMonth;
                    yearOfFirstDate = secondYear;
                }
            }
            if (firstMonth == month8)
            {
                if (secondMonth != month1 || secondMonth != month2 || secondMonth != month3 || secondMonth != month4 || secondMonth != month5 || secondMonth != month6 || secondMonth != month7)
                {
                    dayOfFirstDate = firstDay;
                    monthOfFirstDate = firstMonth;
                    yearOfFirstDate = firstYear;
                    dayOfSecondDate = secondDay;
                    monthOfSecondDate = secondMonth;
                    yearOfSecondDate = secondYear;
                }
                else
                {
                    dayOfSecondDate = firstDay;
                    monthOfSecondDate = firstMonth;
                    yearOfSecondDate = firstYear;
                    dayOfFirstDate = secondDay;
                    monthOfFirstDate = secondMonth;
                    yearOfFirstDate = secondYear;
                }
            }
            if (firstMonth == month9)
            {
                if (secondMonth != month1 || secondMonth != month2 || secondMonth != month3 || secondMonth != month4 || secondMonth != month5 || secondMonth != month6 || secondMonth != month7 || secondMonth != month8)
                {
                    dayOfFirstDate = firstDay;
                    monthOfFirstDate = firstMonth;
                    yearOfFirstDate = firstYear;
                    dayOfSecondDate = secondDay;
                    monthOfSecondDate = secondMonth;
                    yearOfSecondDate = secondYear;
                }
                else
                {
                    dayOfSecondDate = firstDay;
                    monthOfSecondDate = firstMonth;
                    yearOfSecondDate = firstYear;
                    dayOfFirstDate = secondDay;
                    monthOfFirstDate = secondMonth;
                    yearOfFirstDate = secondYear;
                }
            }
            if (firstMonth == month10)
            {
                if (secondMonth != month1 || secondMonth != month2 || secondMonth != month3 || secondMonth != month4 || secondMonth != month5 || secondMonth != month6 || secondMonth != month7 || secondMonth != month8 || secondMonth != month9)
                {
                    dayOfFirstDate = firstDay;
                    monthOfFirstDate = firstMonth;
                    yearOfFirstDate = firstYear;
                    dayOfSecondDate = secondDay;
                    monthOfSecondDate = secondMonth;
                    yearOfSecondDate = secondYear;
                }
                else
                {
                    dayOfSecondDate = firstDay;
                    monthOfSecondDate = firstMonth;
                    yearOfSecondDate = firstYear;
                    dayOfFirstDate = secondDay;
                    monthOfFirstDate = secondMonth;
                    yearOfFirstDate = secondYear;
                }
            }
            if (firstMonth == month11)
            {
                if (secondMonth != month1 || secondMonth != month2 || secondMonth != month3 || secondMonth != month4 || secondMonth != month5 || secondMonth != month6 || secondMonth != month7 || secondMonth != month8 || secondMonth != month9 || secondMonth != month10)
                {
                    dayOfFirstDate = firstDay;
                    monthOfFirstDate = firstMonth;
                    yearOfFirstDate = firstYear;
                    dayOfSecondDate = secondDay;
                    monthOfSecondDate = secondMonth;
                    yearOfSecondDate = secondYear;
                }
                else
                {
                    dayOfSecondDate = firstDay;
                    monthOfSecondDate = firstMonth;
                    yearOfSecondDate = firstYear;
                    dayOfFirstDate = secondDay;
                    monthOfFirstDate = secondMonth;
                    yearOfFirstDate = secondYear;
                }
            }
            if (firstMonth == month12)
            {
                dayOfFirstDate = secondDay;
                monthOfFirstDate = secondMonth;
                yearOfFirstDate = secondYear;
                dayOfSecondDate = firstDay;
                monthOfSecondDate = firstMonth;
                yearOfSecondDate = firstYear;
            }
        }
        else
        {
            if (firstYear < secondYear)
            {
                dayOfFirstDate = firstDay;
                monthOfFirstDate = firstMonth;
                yearOfFirstDate = firstYear;
                dayOfSecondDate = secondDay;
                monthOfSecondDate = secondMonth;
                yearOfSecondDate = secondYear;
            }
            else
            {
                dayOfFirstDate = secondDay;
                monthOfFirstDate = secondMonth;
                yearOfFirstDate = secondYear;
                dayOfSecondDate = firstDay;
                monthOfSecondDate = firstMonth;
                yearOfSecondDate = firstYear;
            }
        }
        if (monthOfFirstDate == month1 || monthOfFirstDate == month2)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("WINTER");
            Console.ResetColor();
        }
        while (controlOfWhile)
        {


            if (monthOfFirstDate == month1)
            {
                do
                {
                    if (dayOfFirstDate < 32)
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                    Zellercongruence(dayOfFirstDate, 1, yearOfFirstDate);
                                    break;
                                }
                            }
                        }
                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                        Zellercongruence(dayOfFirstDate, 1, yearOfFirstDate);

                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        dayOfFirstDate += countRange;
                        if (dayOfFirstDate >= 32)
                        {
                            monthOfFirstDate = month2;
                            dayOfFirstDate = Math.Abs(dayOfFirstDate - 31);
                        }
                    }
                    else
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (month1 == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        monthOfFirstDate = month2;
                        dayOfFirstDate = Math.Abs(dayOfFirstDate - 31);
                    }
                } while (monthOfFirstDate == month1);
            }
            if (yearOfFirstDate == yearOfSecondDate)
            {
                if (month1 == monthOfSecondDate)
                {
                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                    {
                        break;
                    }
                }
            }
            if (monthOfFirstDate == month2)
            {
                do
                {
                    if (yearOfFirstDate % 4 == 0)
                    {


                        if (dayOfFirstDate <= 29)
                        {
                            if (yearOfFirstDate == yearOfSecondDate)
                            {
                                if (monthOfFirstDate == monthOfSecondDate)
                                {
                                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                    {
                                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                        Zellercongruence(dayOfFirstDate, 2, yearOfFirstDate);
                                        break;
                                    }
                                }
                            }
                            Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                            Zellercongruence(dayOfFirstDate, 2, yearOfFirstDate);
                            if (yearOfFirstDate == yearOfSecondDate)
                            {
                                if (monthOfFirstDate == monthOfSecondDate)
                                {
                                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                    {
                                        break;
                                    }
                                }
                            }

                            dayOfFirstDate += countRange;
                            if (dayOfFirstDate > 29)
                            {
                                monthOfFirstDate = month3;
                                dayOfFirstDate = Math.Abs(dayOfFirstDate - 29);
                            }

                        }

                        else
                        {
                            if (yearOfFirstDate == yearOfSecondDate)
                            {
                                if (month2 == monthOfSecondDate)
                                {
                                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                    {
                                        break;
                                    }
                                }
                            }
                            monthOfFirstDate = month3;
                            dayOfFirstDate = Math.Abs(dayOfFirstDate - 29);
                        }
                    }
                    else if (yearOfFirstDate % 4 != 0)
                    {
                        if (dayOfFirstDate <= 28)
                        {
                            if (yearOfFirstDate == yearOfSecondDate)
                            {
                                if (monthOfFirstDate == monthOfSecondDate)
                                {
                                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                    {
                                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                        Zellercongruence(dayOfFirstDate, 2, yearOfFirstDate);
                                        break;
                                    }
                                }
                            }
                            Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                            Zellercongruence(dayOfFirstDate, 2, yearOfFirstDate);
                            if (yearOfFirstDate == yearOfSecondDate)
                            {
                                if (monthOfFirstDate == monthOfSecondDate)
                                {
                                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                    {
                                        break;
                                    }
                                }
                            }
                            dayOfFirstDate += countRange;
                            if (dayOfFirstDate > 28)
                            {
                                monthOfFirstDate = month3;
                                dayOfFirstDate = Math.Abs(dayOfFirstDate - 28);
                            }
                        }
                        else
                        {
                            if (yearOfFirstDate == yearOfSecondDate)
                            {
                                if (month2 == monthOfSecondDate)
                                {
                                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                    {
                                        break;
                                    }
                                }
                            }
                            monthOfFirstDate = month3;
                            dayOfFirstDate = Math.Abs(dayOfFirstDate - 28);
                        }
                    }
                } while (monthOfFirstDate == month2);
            }
            if (yearOfFirstDate == yearOfSecondDate)
            {
                if (month2 == monthOfSecondDate)
                {
                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                    {
                        break;
                    }
                }
            }
            if (monthOfFirstDate == month3 || monthOfFirstDate == month4 || monthOfFirstDate == month5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SPRING");
                Console.ResetColor();
            }
            if (monthOfFirstDate == month3)
            {
                do
                {
                    if (dayOfFirstDate <= 31)
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                    Zellercongruence(dayOfFirstDate, 3, yearOfFirstDate);
                                    break;
                                }
                            }
                        }
                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                        Zellercongruence(dayOfFirstDate, 3, yearOfFirstDate);
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        dayOfFirstDate += countRange;
                        if (dayOfFirstDate > 31)
                        {
                            monthOfFirstDate = month4;
                            dayOfFirstDate = Math.Abs(dayOfFirstDate - 31);
                        }
                    }
                    else
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (month3 == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        dayOfFirstDate = Math.Abs(dayOfFirstDate - 31);
                        monthOfFirstDate = month4;
                    }
                } while (monthOfFirstDate == month3);
            }
            if (yearOfFirstDate == yearOfSecondDate)
            {
                if (month3 == monthOfSecondDate)
                {
                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                    {
                        break;
                    }
                }
            }
            if (monthOfFirstDate == month4)
            {
                do
                {
                    if (dayOfFirstDate <= 30)
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                    Zellercongruence(dayOfFirstDate, 4, yearOfFirstDate);
                                    break;
                                }
                            }
                        }
                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                        Zellercongruence(dayOfFirstDate, 4, yearOfFirstDate);
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        dayOfFirstDate += countRange;
                        if (dayOfFirstDate > 30)
                        {
                            monthOfFirstDate = month5;
                            dayOfFirstDate = Math.Abs(30 - dayOfFirstDate);
                        }
                    }
                    else
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (month4 == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        monthOfFirstDate = month5;
                        dayOfFirstDate = Math.Abs(30 - dayOfFirstDate);
                    }
                } while (monthOfFirstDate == month4);
            }
            if (yearOfFirstDate == yearOfSecondDate)
            {
                if (month4 == monthOfSecondDate)
                {
                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                    {
                        break;
                    }
                }
            }
            if (monthOfFirstDate == month5)
            {
                do
                {
                    if (dayOfFirstDate <= 31)
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                    Zellercongruence(dayOfFirstDate, 5, yearOfFirstDate);
                                    break;
                                }
                            }
                        }
                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                        Zellercongruence(dayOfFirstDate, 5, yearOfFirstDate);
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        dayOfFirstDate += countRange;
                        if (dayOfFirstDate > 31)
                        {

                            monthOfFirstDate = month6;
                            dayOfFirstDate = Math.Abs(31 - dayOfFirstDate);
                        }
                    }
                    else
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (month5 == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        monthOfFirstDate = month6;
                        dayOfFirstDate = Math.Abs(31 - dayOfFirstDate);
                    }

                } while (monthOfFirstDate == month5);
            }
            if (yearOfFirstDate == yearOfSecondDate)
            {
                if (month5 == monthOfSecondDate)
                {
                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                    {
                        break;
                    }
                }
            }
            if (monthOfFirstDate == month6 || monthOfFirstDate == month7 || monthOfFirstDate == month8)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("SUMMER");
                Console.ResetColor();
            }
            if (monthOfFirstDate == month6)
            {
                do
                {
                    if (dayOfFirstDate <= 30)
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                    Zellercongruence(dayOfFirstDate, 6, yearOfFirstDate);
                                    break;
                                }
                            }
                        }
                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                        Zellercongruence(dayOfFirstDate, 6, yearOfFirstDate);
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        dayOfFirstDate += countRange;
                        if (dayOfFirstDate > 30)
                        {
                            monthOfFirstDate = month7;
                            dayOfFirstDate = Math.Abs(30 - dayOfFirstDate);

                        }
                    }
                    else
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (month6 == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        monthOfFirstDate = month7;
                        dayOfFirstDate = Math.Abs(30 - dayOfFirstDate);
                    }
                } while (monthOfFirstDate == month6);
            }
            if (yearOfFirstDate == yearOfSecondDate)
            {
                if (month6 == monthOfSecondDate)
                {
                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                    {
                        break;
                    }
                }
            }
            if (monthOfFirstDate == month7)
            {
                do
                {
                    if (dayOfFirstDate <= 31)
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                    Zellercongruence(dayOfFirstDate, 7, yearOfFirstDate);
                                    break;
                                }
                            }
                        }
                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                        Zellercongruence(dayOfFirstDate, 7, yearOfFirstDate);
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        dayOfFirstDate += countRange;
                        if (dayOfFirstDate > 31)
                        {
                            monthOfFirstDate = month8;
                            dayOfFirstDate = Math.Abs(31 - dayOfFirstDate);
                        }
                    }
                    else
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (month7 == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        monthOfFirstDate = month8;
                        dayOfFirstDate = Math.Abs(31 - dayOfFirstDate);
                    }
                } while (monthOfFirstDate == month7);
            }
            if (yearOfFirstDate == yearOfSecondDate)
            {
                if (month7 == monthOfSecondDate)
                {
                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                    {
                        break;
                    }
                }
            }
            if (monthOfFirstDate == month8)
            {
                do
                {
                    if (dayOfFirstDate <= 31)
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                    Zellercongruence(dayOfFirstDate, 8, yearOfFirstDate);
                                    break;
                                }
                            }
                        }
                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                        Zellercongruence(dayOfFirstDate, 8, yearOfFirstDate);
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        dayOfFirstDate += countRange;
                        if (dayOfFirstDate > 31)
                        {
                            monthOfFirstDate = month9;
                            dayOfFirstDate = Math.Abs(31 - dayOfFirstDate);
                        }
                    }
                    else
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (month8 == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        monthOfFirstDate = month9;
                        dayOfFirstDate = Math.Abs(31 - dayOfFirstDate);
                    }
                } while (monthOfFirstDate == month8);
            }
            if (yearOfFirstDate == yearOfSecondDate)
            {
                if (month8 == monthOfSecondDate)
                {
                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                    {
                        break;
                    }
                }
            }
            if (monthOfFirstDate == month9 || monthOfFirstDate == month10 || monthOfFirstDate == month11)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("AUTUMN");
                Console.ResetColor();
            }
            if (monthOfFirstDate == month9)
            {
                do
                {
                    if (dayOfFirstDate <= 30)
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                    Zellercongruence(dayOfFirstDate, 9, yearOfFirstDate);
                                    break;
                                }
                            }
                        }
                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                        Zellercongruence(dayOfFirstDate, 9, yearOfFirstDate);
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        dayOfFirstDate += countRange;
                        if (dayOfFirstDate > 30)
                        {
                            monthOfFirstDate = month10;
                            dayOfFirstDate = Math.Abs(30 - dayOfFirstDate);
                        }
                    }
                    else
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (month9 == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        monthOfFirstDate = month10;
                        dayOfFirstDate = Math.Abs(30 - dayOfFirstDate);
                    }
                } while (monthOfFirstDate == month9);
            }
            if (yearOfFirstDate == yearOfSecondDate)
            {
                if (month9 == monthOfSecondDate)
                {
                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                    {
                        break;
                    }
                }
            }
            if (monthOfFirstDate == month10)
            {
                do
                {
                    if (dayOfFirstDate <= 31)
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                    Zellercongruence(dayOfFirstDate, 10, yearOfFirstDate);
                                    break;
                                }
                            }
                        }
                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                        Zellercongruence(dayOfFirstDate, 10, yearOfFirstDate);
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        dayOfFirstDate += countRange;
                        if (dayOfFirstDate > 31)
                        {
                            monthOfFirstDate = month11;
                            dayOfFirstDate = Math.Abs(31 - dayOfFirstDate);
                        }
                    }
                    else
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (month10 == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        monthOfFirstDate = month11;
                        dayOfFirstDate = Math.Abs(31 - dayOfFirstDate);
                    }
                } while (monthOfFirstDate == month10);
            }
            if (yearOfFirstDate == yearOfSecondDate)
            {
                if (month10 == monthOfSecondDate)
                {
                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                    {
                        break;
                    }
                }
            }
            if (monthOfFirstDate == month11)
            {
                do
                {
                    if (dayOfFirstDate <= 30)
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                    Zellercongruence(dayOfFirstDate, 11, yearOfFirstDate);
                                    break;
                                }
                            }
                        }
                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                        Zellercongruence(dayOfFirstDate, 11, yearOfFirstDate);
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        dayOfFirstDate += countRange;
                        if (dayOfFirstDate > 30)
                        {
                            monthOfFirstDate = month12;
                            dayOfFirstDate = Math.Abs(30 - dayOfFirstDate);
                        }
                    }
                    else
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (month11 == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        monthOfFirstDate = month12;
                        dayOfFirstDate = Math.Abs(30 - dayOfFirstDate);
                    }
                } while (monthOfFirstDate == month11);
            }
            if (yearOfFirstDate == yearOfSecondDate)
            {
                if (month11 == monthOfSecondDate)
                {
                    if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                    {
                        break;
                    }
                }
            }
            if (monthOfFirstDate == month12)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("WINTER");
                Console.ResetColor();
            }
            if (monthOfFirstDate == month12)
            {
                do
                {
                    if (dayOfFirstDate <= 31)
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (monthOfFirstDate == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                                    Zellercongruence(dayOfFirstDate, 12, yearOfFirstDate);
                                    break;
                                }
                            }
                        }
                        Console.Write(dayOfFirstDate + " " + monthOfFirstDate + " " + yearOfFirstDate + " ");
                        Zellercongruence(dayOfFirstDate, 12, yearOfFirstDate);
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (month12 == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        dayOfFirstDate += countRange;
                        if (dayOfFirstDate > 31)
                        {
                            monthOfFirstDate = month1;
                            dayOfFirstDate = Math.Abs(31 - dayOfFirstDate);


                        }
                    }
                    else
                    {
                        if (yearOfFirstDate == yearOfSecondDate)
                        {
                            if (month12 == monthOfSecondDate)
                            {
                                if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate > dayOfSecondDate))
                                {
                                    break;
                                }
                            }
                        }
                        monthOfFirstDate = month1;
                        dayOfFirstDate = Math.Abs(31 - dayOfFirstDate);
                    }

                } while (monthOfFirstDate == month12);

                if (yearOfFirstDate == yearOfSecondDate)
                {
                    if (month12 == monthOfSecondDate)
                    {
                        if (dayOfFirstDate == dayOfSecondDate || (dayOfFirstDate + countRange > dayOfSecondDate))
                        {
                            break;
                        }
                    }
                }
                if (yearOfFirstDate != yearOfSecondDate)
                {
                    ++yearOfFirstDate;
                }

            }
        }
        Console.ReadKey();

    }
}


