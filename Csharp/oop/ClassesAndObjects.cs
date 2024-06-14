/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "OOP" •
                        ─────────
                • "CLASSES" AND "OBJECTS" •
       


    ▬ "Object-Oriented Programming" ("OOP")
        → allow us to Create 
        → our own "Data Structures"
        → with "Methods"
        → that can be :Used" on "Them".


    ▬ "OOP"
        → allow us to Create 
        → a "Custom  Data Structures"
        → that become an "Object"
        → and which has "Data" and "Functions".
        
        
 
        ♦ "Example" - "Car" Object:             
           
            • "Data":
                - int speed;
                - float gas;
                - string make;
                - string model;
            
            
            • "Functions":
                - void Drive(){}
                - void Start(){}
                - void Stop(){}
                - void Break(){}
        
             
   
   
    ▬ "OOP" 
        → allows the "Creation" of "Relationships" 
        → between "Objects",
        → through which an "Object" 
        → can "Inherit Characteristics" 
        from A"nother Object".
   
   
   
  
    ▬ "Procedural Programming"
        → uses "Functions" 
        → to "Write" a "Programs"
        → and to "Solve Problems".
  
  
   
    
    ▬ The Advantages of "OOP" 
        → Compared to "Procedural Programming":
            
            • "OOP" 
                → supports "Inheritance"
            
            • "Object-Oriented Languages" 
                → (C#, Java, C++, Python) 
                → support "Classes" and "Objects"
              
                
            • The "4 Pillars" of "OOP": 
                → "Encapsulation", 
                → "Abstraction", 
                → "Inheritance", 
                → "Polymorphism"   
    
    
    
    
    ▬ The "4 Pillars" or "Concepts" of "OOP": 
        
        1. "Encapsulation"
            → means "Data Hiding".
        
        
        2. "Abstraction"
            → means "Hiding" the "Programming Details" 
            → (how "Things Work").
            → from the "End User".
                
        
        3 "Inheritance"
            → means that a "Class" 
            → can Share 
            → "Data" and "Functionalities" 
            → to "Other Classes" 
            → "Without" to "Writing" 
            → the "Logic".
                
         
        4 "Polymorphism"  
            → means that "Classes" 
            → can have "Different Functionalities" 
            → or "Share" a "Common Interface", 
            → in other words 
            → "Objects" can Take "Multiple Forms".         
        
        
  
    ▬ "Classes"
        → are "Blueprints" 
        → of the "Objects"
        → that contain "Methods"/"Functions" 
        → and "Fields"/"Variables".     
   
   
   
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
// ▬▬ "ClassesAndObjects" Class ▬▬
public class ClassesAndObjects
{

    // ▬ "RunClassesAndObjects()" Method ▬
    public static void RunClassesAndObjects()
    {
        Console.WriteLine("Accessing the 'Car' Static Class:");

        // ▼ "Accessing" the "Methods" 
        //      →  of "Car" Static Class
        //      → "Without Creating" an "Object/Instance" ▼
        Car.Start();
        Car.Drive();
        Car.Stop();
    }
    
    
    
    //────────────────────────────────────────────────────
    // ▬▬ "Car" Class → Static (Used Only Here) ▬▬
    public static class Car
    {
        // ▼ Members "Fields/Variables" ▼
        static int speed;
        static string color;
        static float price;
        
        
        // ▬ "Start()" Method/Function ▬
        public static void Start()
        {
           Console.WriteLine("Car Started"); 
        }
        
        
        
        // ▬ "Drive()" Method/Function ▬
        public static void Drive()
        {
            Console.WriteLine("Car is Driving");
        }
        
        
        
        // ▬ "Stop()" Method/Function ▬
        public static void Stop()
        {
            Console.WriteLine("Car Stopped");
        }
    }
} 


