/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                   • "DATA TYPES" •
                ► "BASICS BUILT-IN DATA TYPES" ◄
         


    ▬ The Basic "Built-In" Data Types are:

								  C#  		  .NET	
		1. "Ints":				int		→	System.Int32
		2. "Floats":			float	→	System.Single
		3. "Strings":			string	→	System.String
		4. "Characters":		char	→	System.Char
		5. "Booleans":			bool	→	System.Boolean


 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;


// ▬ "Folder" ▬
namespace CSharp.data_types
{

    // ▬ "Class" ▬
    class Basics_BuiltIn_DataTypes
    {

        // ▬ The "typeof Operator" → that "Provides" the "C#" Alias for DotNet ""System.Type" Object"  ▬
        // ▬ The "AliasType()" Method 
        //		→ to "Check" the "C# Aliases" 
        //		→ for "DotNet" Framework ▬
        public static void AliasType()
        {
            Console.WriteLine("Type Of Operator → for Integer: " + typeof(int));
            Console.WriteLine("Type Of Operator → for Float: " + typeof(float));
            Console.WriteLine("Type Of Operator → for String: " + typeof(string));
            Console.WriteLine("Type Of Operator → for Character: " + typeof(char));
            Console.WriteLine("Type Of Operator → for Boolean: " + typeof(bool));

        }

    }
}