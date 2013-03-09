using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public delegate void DoSomething();


class Timer
{
    static void PrintLine()
    {
        Console.WriteLine("new line\n");
    }
    static void PauseTime()
    {
        Thread.Sleep(2000);
    }
    static void Main(string[] args)
    {
        DoSomething print = new DoSomething(PrintLine);
        print += PauseTime;
        for (int i = 0; i < 100; i++)
        {
            print();
        }
        
    }
}

