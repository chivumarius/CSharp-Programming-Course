namespace CSharp.data_types
{
    internal class StringDataType
    {
        public static void StringType()
        {
            // ▼ "Declaration" & "Instantiation" of a "String" ▼
            string str1 = "Hi";


            // ▼ "Empty Strings" ▼
            string emptyString1 = "";
            string emptyString2 = string.Empty;


            // ▼ "Strings Concatenation" ▼
            string s1 = "Hi, ";
            string s2 = "my name is ";
            string s3 = "Marius";
            string s4 = "!";

            string s5 = s1 + s2 + s3 + s4;
            Console.WriteLine("Strings Concatenation: " + s5);


            // ▼ "Checking" the "Equality" of "Strings" ▼
            string string1 = "abc";
            string string2 = "abc";

            Console.WriteLine("\n" + "String Equality 1: " + (string1 == string2));
            Console.WriteLine("String Equality 2: " + string.Equals(string1, string2));




            // ▼  "Literal/Verbatim String" - Use the "@" Symbol
            //      → to Allow "Keywords"
            //      → to be "Used" as "Variable Names" ("@if") ▼
            string @if = "My name is Marius";
            Console.WriteLine("\n" + "Literal/Verbatim String - Using @ Symbol for Keyword Variable Name: " + @if);


            // ▼ "Literal/Verbatim String" - Use the "@" Symbol
            //      → to "Print" the "String"
            //      → as "Written" ▼
            Console.WriteLine("\n" + "Literal/Verbatim String - Use the @ Symbol to Print the String as it is Written: " + @"a \n b ");




            // ▼ Use "$" Symbol
            //      → for "String Interpolation" ▼
            string name = "Jeanine";
            Console.WriteLine("\n" + "Interpolation String - Use the $ Symbol for String Interpolation: " + $"My name is {name}!");






            // ▼ "Slicing Strings" into "Sub-Strings" ▼
            string s = "abcde";

            Console.WriteLine("\n" + "Slicing Strings - into Substrings: ");
            Console.WriteLine(" * Check if the Substring is Part of the String: " + s.Contains("bcde"));

            Console.WriteLine("\n" + " * Get the Substring of String - Starting from the Position 1: " + s.Substring(0));
            Console.WriteLine(" * Get the Substring of String - Starting from the Position 2: " + s.Substring(1));
            Console.WriteLine(" * Get the Substring of String - Starting from the Position 3: " + s.Substring(2));
            Console.WriteLine(" * Get the Substring of String - Starting from the Position 4: " + s.Substring(3));
            Console.WriteLine(" * Get the Substring of String - Starting from the Position 5: " + s.Substring(4));

            Console.WriteLine("\n * Get the Substring of String - Between a Starting Position 2  and an Ending Position 4: " + s.Substring(1, 3));






            // ▼ "Escape Sequences" ▼
            Console.WriteLine("\n--------------- escape sequences in c# ---------------");
            Console.WriteLine(" * \' → \' Output a Single Quote \' ");
            Console.WriteLine(" * \" → \" Output a Double  Quote \" ");
            Console.WriteLine(" * \\ → Output a Backslash \\ ");
            Console.WriteLine(" * \n → Insert a Newline ");
            Console.WriteLine(" * \r → Insert a \r Carriage-Return ");
            Console.WriteLine(" * \t → Insert \t a \t Tab ");
            Console.WriteLine(" * \0 → Insert a \0 \0 \0 Null \0 \0 \0 Character ");
            Console.WriteLine(" * \b → Insert a Backspace ");






            // ▼ "Formatting Strings" ▼
            // ▼ "Escape Sequences" ▼
            Console.WriteLine("\n--------------- FORMATTING STRINGS ---------------");

            int price = 100;
            Console.WriteLine(" * \"Currency Format\" ({0:C}: " + string.Format("The product {0:C}", price));



            int price1 = 50;
            int price2 = 150;
            int price3 = 50;
            Console.WriteLine(" * \"Currency Format\" ({0:C}): " + string.Format("The product 1 is {0:C}, the product 2 is {1:C}, the product 3 is {2:C}", price1, price2, price3));



            // ▼ Forma ▼ 
            float percent = 0.5f;
            Console.WriteLine(" * \"Percent Format\" ({0:P}): " + string.Format("The task is {0:P} completed.", percent));
        }
    }
}
