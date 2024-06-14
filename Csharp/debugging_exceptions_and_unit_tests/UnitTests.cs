/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DEBUGGING EXCEPTIONS" & "UNIT TESTS" •
                    ─────────────────────────────────────────
                                • "UNIT TESTS" •

       


    ▬ A "Unit Test"  
        → is a "Method/Way" 
        → of "Testing Individual Units" 
        → of "Code" (usually "Methods" or "Classes") 
        → to "Verify" that "They Work" 
        → "According" to "Specifications". 


        ♦ It Involves 
            → "Isolating" and "Testing" 
            → a "Unit" of "Code" 
            → Without "External Dependencies" 
            → using Various "Techniques" such as 
                •► "Stubs", 
                •► "Mocks" or 
                •► "Doubles".




    ▬ The "Main Features" of "Unit Tests" include:

        1. "Automation": 
            • "Unit Tests" 
                → are "Automated" 
                → and can be "Run Automatically" 
                → Without "Human Intervention".


        2. "Isolation": 
            • Code Units 
                → are "Tested" in "Isolation" 
                → from "Other Components" 
                → or "External Dependencies" 
                → to "Ensure" that "Any Problems" 
                → are "Accurately Located" 
                → and "Identified".
        

        3. "Repeatability": 
            • "Unit Tests" 
                → can be "Run Repeatedly" 
                → and with the "Same Results".
        

        4. "Specific Purpose": 
            • "Unit Tests" 
                → "Focus" on "Verifying" the "Behavior" 
                → of an "Individual Unit" of "Code" 
                → or "Small Functionality" 
                → "Without Testing" 
                → the "Entire Application".
        

        5. "Speed": 
            • "Unit Tests" 
                → should be "Fast" 
                → to Provide "Quick Feedback" 
                → to the "Developer" 
                → "During" the "Development Cycle".



    ▬ The "Main Purpose" of "Unit Tests" 
        → is to "Ensure" 
        → the "Quality" and "Correctness" 
        → of the "Code" 
        → and to "Make" it "Easier" 
        → to "Refactor" and "Extend It" 
        → in the "Future" 
        → "Without" introducing "Bugs" 
        → or "Unwanted Side Effects".




    ▬ "Framework
        → is "One" of the "Most Popular Framework" 
        → for "Unit Testing" in "C#".
        
        
        ♦ "NUnit" 
            → is an "Open-Source Framework" 
            → and is Widely "Used" 
            → in the "C# Developer Community" 
            → for "Writing" and "Running" 
            → "Unit Tests".
    
    
    ▬ To "Start" using "NUnit" 
        → for "unit testing" in "C#", 
        → you "Need" to "Install" 
        → the "NUnit Package" 
        → using a "Package Manager" 
        → like "NuGet". 
    
    
    ▬ Here are the Basic Steps 
        → to "Install" and "Use" 
        → "NUnit" in a "C# Project":

        1. "Open Visual Studio" 
            → and "Open" the "C# Project" Solution 
            → where you "Want" 
            → to "Add Unit Tests".
       
       
        2. "Go" 
            → to "Tools" 
            → "NuGet Package Manager" 
            → "Manage NuGet Packages for Solution".
        
        
        3. "Search" 
            → for the "NUnit" Package 
            → and "Install It" 
            → in your "Project".
        
        
        4. "After Installation", 
            → "Create" a n"Nw Test Project" 
            → in your "Solution".
        
        
        5. Add "Test Methods" 
            → using NUnit's "[Test]" Attribute 
            → to your "Test Methods".
        
        
        6. "Run" the "Tests" 
            → using "Options" in "Visual Studio" 
            → or using the "NUnit Console".

    
    
    ▬ "NUnit" 
        → "Provides" a "Number" 
        → of "Useful Unit Testing Features" 
        → such as: 
            •► "Assertions", 
            •► "Binding", 
            •► "Parameterization" 
        ► and "More" 
        → that "Allow" you 
        → to "Write Robust" 
        → and "Efficient Unit Tests" 
        → for your "C# Code".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.debugging_exceptions_and_unit_tests;


//──────────────────────────────────────────────────────────────
// ▬ "UnitTests" Class ▬
public class UnitTests
{
    
    // ▬ "RunUnitTests()" Method ▬
    public static void RunUnitTests()
    {
        
    }
} 