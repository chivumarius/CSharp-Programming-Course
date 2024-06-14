using System;

namespace CSharp.basics;
    
public static class ConditionalStatements
{
    public static void RunConditionalStatements()
    {
        bool complete = true;
        bool started = false;
        int x;

        if (complete)
        {
            x = 10;
        }
        else if (started)
        {
            x = 25;
        }
        else
        {
            x = 1;
        }

        Console.WriteLine(x);
    }
}
