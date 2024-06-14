using System;

namespace CSharp.basics;

public static class Variables
{
    public static void PrintVariables()
    {
        // (1) "Integers"
        int x = 5;
        int y = 10;
        int z = 20;
        int intNumber = 30;

        // (2) "Floatings"
        float a = 3.14f;
        float b = 7.62f;
        float floatNumber = 0.25f;

        // (3) "Strings"
        string firstName = "Marius";
        string lastName = "Chivu";

        // (4) "Characters"
        char firstLetterOfFirstName = 'M';
        char firstLetterOfLastName = 'C';

        // (5) "Booleans"
        bool open = true;
        bool close = false;

        // Print values
        Console.WriteLine($"Integers: x={x}, y={y}, z={z}, intNumber={intNumber}");
        Console.WriteLine($"Floatings: a={a}, b={b}, floatNumber={floatNumber}");
        Console.WriteLine($"Strings: firstName={firstName}, lastName={lastName}");
        Console.WriteLine($"Characters: firstLetterOfFirstName={firstLetterOfFirstName}, firstLetterOfLastName={firstLetterOfLastName}");
        Console.WriteLine($"Booleans: open={open}, close={close}");
    }
}
