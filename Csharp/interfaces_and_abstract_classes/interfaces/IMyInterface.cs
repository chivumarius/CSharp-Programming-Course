/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "INTERFACE" •
                     ───────────────


       

    ▬ An "Interface" in "C#" 
        → is an "Abstract Contract" 
        → that can be "Implemented" 
        → by "Other Classes"
        → that "Implement It". 
        
        
        ♦ It "Defines" 
            → a "Set" of "Methods" 
            → and "Properties" 
            → that a "Class" must "Implement" 
            → when "It Inherits" 
            → or "Implements" 
            → that "Interface".



    ▬ "Features" of "Interfaces":
        1. "Abstract": 
            ♦ "Interfaces" 
                → are "Always Abstract", 
                → which Means "They" 
                → Cannot Be "Instantiated Directly". 
            
            
            ♦ They are "Used" 
                → to "Define" a "Common Contract" 
                → between the "Different Classes" 
                → that "Implement Them".



        2. "Implementation Contracts": 
            ♦ An "Interface Defines" 
                → a "Set" of "Methods" 
                → and "Properties" 
                → that "Classes" that "Implement It" 
                → must "Provide". 
            
            
            ♦ These "Methods" and "Properties" 
                → represent the "Implementation Contract".



        3. "Multiple Implementations": 
            ♦ A "Class" 
                → can "Implement Multiple Interfaces", 
                → allowing it to "Provide Different Functionality" 
                → and "Behavior" 
                → as "Needed".



    ▬ "Using Interfaces" in "C#":
        1. "Implementation" of "Methods" and "Properties": 
            ♦ A "Class" 
                → "Implements" an "Interface" 
                → by Providing "Definitions" 
                → for "All" the "Methods" 
                → and "Properties" 
                → "Defined" in the "Interface".



        2. "Polymorphism": 
            ♦ "Interfaces" 
                → allow the "Use" 
                → of "Polymorphism" in "C#". 
            
            
            ♦ Thus, an "Interface Type Reference" 
                → can be "Used" 
                → to "Access" any "Object" 
                → that "Implements" that "Interface".



        3. "Separation" of "Logic": 
            ♦ "Interfaces" 
                → "Facilitate" the "Separation" 
                → of "Logic" 
                → by "Defining" 
                → a "Clear Contract" 
                → between Different "Application Components".




    ▬ In "C#" 
        → it is "Recommended" 
        → by "Convention" 
        → that the "Names" 
        → of the "Interfaces" 
        → to "Start" with a "Capital Letter"
        → "I" (Example: "IMyInterface").   
    
  
  
    ▬ "Defining" an "Interface" 
        → is done with the "Help" 
        → of the "interface" Keyword.
    
    ▬ The "Implementation" in a "Class"
        → is done with the "help" 
        → of the Punctuation Mark ":"
       
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

// ▼ "Directory" ▼
namespace CSharp.interfaces_and_abstract_classes.interfaces;



// ▬▬ "Interface" ▬▬
public interface IMyInterface
{
    
    // ▬ "Methods Signature" without "Body" ▬  
    void Example1();
    int Example2();
    string Example3(string str1, string str2);
}



// ▬▬  "Interface 2" ▬
public interface IMySecondInterface
{
}




// ▬▬ "Class" that "Implements" → "Multiple Interfaces" ▬▬
public class MyClass : IMyInterface, IMySecondInterface
{
    // ▬ Example1() Method "Implementation"▬
    public void Example1()
    {
        Console.WriteLine("Example 1 - Method Implementation");
    }

    
    
    // ▬ Example2() Method "Implementation"▬
    public int Example2()
    {
        int number = 2;
        Console.WriteLine("Example {number} - Method Implementation");
        return number;
    }
    

    // ▬ Example3() Method "Implementation"▬
    public string Example3(string str1, string str2)
    {
        return str1 + str2;
    }
    
    
    
    // ▬ The "Run Method" of the "Class" ▬
    public string RunMyClass()
    {
        
        Example1();
        Example2();
        return Example3("Example 3 -", " Method Implementation");
    }
}