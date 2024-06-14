/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "CREATIONAL" •
                    ────────────────────
                      • "PROTOTYPE" •

       


  ▬ A "Design Pattern" 
    → is a "General Reusable Solution" 
    → to a "Frequent Problem" 
    → in "Software Engineering".



  ▬ "Creational" Design Patterns 
    → are "Used" 
    → to "Create Objects".



  ▬ There Contain "2 Main Ideas":
    (1) "Encapsulation"
    
    (2) "Hiding" how "Instances" 
        → of these "Classes" 
        → are "Created" 
        → and "Combined".



  ▬ "Prototype" Design Pattern 
    → "Creates" a "New Object" 
    → from an "Object" 
    → that "Already Exists".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.creational;


//──────────────────────────────────────────────────────────────
// ▬ (1) "Prototype" - "ICloneable" Interface ▬



//──────────────────────────────────────────────────────────────
// ▬ (2) "Concrete Prototype" - "Person" Class
//         → that "Implements" the "ICloneable" Interface ▬
public class Person : ICloneable
{
    // ▼ "Properties"
    public string FirstName { get; set; }
    public string LastName { get; set; }
   
    
    // ▬ "Clone()" Method ▬
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}




//──────────────────────────────────────────────────────────────
// ▬ "Client2" - "Prototype" Class
//      → that "Uses" the "Prototype" ▬
public class Prototype
{
    // ▬ "RunPrototype()" Method ▬
    public static void RunPrototype()
    {
        // ▼ "Person" Object ▼
        Person person1 = new Person
        {
            FirstName = "Marius",
            LastName = "Chivu"
        };
            
        // ▼ "Cloning" the "Person" Object ▼
        Person person2 = person1.Clone() as Person;
        
        // ▼ "Printing" the "Cloned" "Person" Object ▼
        Console.WriteLine($"Cloned Person: {person2.FirstName} {person2.LastName}");
    }
} 