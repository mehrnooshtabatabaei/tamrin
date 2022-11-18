using System;
public class program
{
    public class Age
    {
        int year, week, days, DAYSINWEEK = 7;

        public void calc_age(int ndays) {

            year = ndays / 365;
            week = (ndays % 365) / DAYSINWEEK;
            days = (ndays % 365) % DAYSINWEEK;
            Console.WriteLine("{0} is equivalent to: \n{1} years, \n{2} weeks \n{3} days", ndays, year, week, days);

        }
    }

    public static void Main()
    {
        Age myAge = new Age();
        Console.Write("Enter the number of days: ");
        int days = int.Parse(Console.ReadLine());
        myAge.calc_age(days);


        Console.ReadLine();
    }
}