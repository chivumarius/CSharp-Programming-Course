/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "OOP" •
                        ─────────
                   • "ENCAPSULATION" •
       



    ▬ "Encapsulation"
            → means "Data Hiding".
        
 
    ▬ "Encapsulation" 
            → can be "Implemented"
            → by Using "Access Modifiers".
     
     
     
     
    ▬ "Access Modifiers" in "C#": 
        
        1. "Public" 
            → means that the "Its Data" 
            → can be "Accessed" 
            → from "Anywhere".
            
                
        2. "Protected" 
            → means that the "Data" 
            → can "Only" be "Accessed" 
            → in the "Class" 
            → in which "It" is "Declared" and in its subclasses
       
       
        3. "Private" 
            → means that the "Referred Code" 
            → must be in the "Same Class",
            → the "Data"
            → cannot be "Accessed"
            → from "Another Class".
       
        
        4. "Internal" 
            → means that "Only Code" 
            → from the "Same Assembly" ("Package")
            → can "Access" the "Data".      
  
  
   
   ▬ "Static Class" 
        → is a "Class" 
        → that "Contains" 
        → Only "Static Methods" and "Variables". 
        
        
        ♦ "It" 
            → is "Often Used" 
            → when we want to "Group Methods" or "Variables" 
            → that do "Not Require" 
            → the "Creation" of a "Specific Object" 
            → of the "Class" 
            → to be "Accessed" 
            → or "Used".

    
    
    ▬ "Static Methods" 
        → are "Methods" 
        → that can be "Called" 
        → "Without" Creating an "Object/Instance" 
        → of that "Class". 
    
    
    
    ▬ "Static Variables" 
        → are "Variables" 
        → that are "Shared" 
        → between "All Objects/Instances" 
        → of a "Class" 
        → and can be "Accessed" 
        → "Without" Creating an "Object/Instance"
        →  of the "Class". 
    
                
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.oop;



//────────────────────────────────────────────────────
// ▬▬ "Encapsulation" Class ▬▬
public class Encapsulation
{


    // ▬ "RunEncapsulation()" Method ▬
    public static void RunEncapsulation()
    {
        // ▼ "Accessing" the "Static Method"
        //      → of the  "Calculation" Class
        //      → "Without Creating"
        //      → an "Object" of the "Class" ▼
        int result = Calculation.Multiply(5, 6);
        Console.WriteLine("Using 'private' Access Modifier for Encapsulation in the Calculate Class: " + result);
    }
}





//────────────────────────────────────────────────────
// ▬▬ "Calculation" Class ▬▬
public class Calculation
{
    // ▼ "Encapsulation"/ "Hiding"
    //      → of "Static Variables" ▼
    private static int number1;
    private static int number2;

    
    
    // ▬ "Multiply()" Static Method ▬
    public static int Multiply(int num1, int num2)
    {
        return num1 * num2 +number1 + number2;
    }
}



