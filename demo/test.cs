using System;

public class EnumTest
{
    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    static void Main()
    {
        Console.WriteLine("Sun = {0}", Day.Sun);
        Console.WriteLine("Fri = {0}", Day.Fri);
    }
}