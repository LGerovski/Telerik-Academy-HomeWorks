using System;


class NullIntDouble
{
    static void Main()
    {
        int? intNumber = null;
        double? doubleNumber = null;
        Console.WriteLine(intNumber + " " + doubleNumber);
        intNumber += 5;
        doubleNumber += null;
        Console.WriteLine(intNumber + " " + doubleNumber);
    }
}

