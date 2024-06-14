/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERT" •
                    ──────────────────────────────────────
                  

       


    ▬ "LINQ" 
        → is an "Acronym" 
        → for "Language Integrated Query" 
        → and "It" is a "Component" 
        → of the "C# Programming Language" 
        → "Developed" by "Microsoft" 
        → that allows "Querying" 
        → and "Manipulating Data" 
        → in a "Uniform Way", 
        → using the "C# Language". 



    ▬ "LINQ" 
        → provides an "Efficient" 
        → and "Easy-To-Understand Way" 
        → to "Work" with: 
            •► "Data Collections", 
            •► "Databases" 
        → and "Other Data Sources" 
        → Within ".NET Applications".




    ▬ "LINQ" - "Syntax"
        → is "Similar" 
        → with "SQL" ("Structured Query Language"). 
        
        

    ▬ "LINQ"
        → allows us to "Embed" 
        → "Queries" into "C#".


    ▬ In "LINQ"
        → "Each Query"
        → is "Written" 
        → in "Query Syntax".
        
     
     ▬ We can "Use" - "Basic Query Expression Patterns"
        → to "Transform Data" from :
            •► "Databases",
            •►  "XML Documents",          
            •► "Collections".  
    
            
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;



//──────────────────────────────────────────────────────────────
// ▬ "Person" Class ▬
public class Person
{
    // ▼ "Variables" ▼
    public string Name;
    public int Age;
}





//──────────────────────────────────────────────────────────────
// ▬ "LINQ" Class ▬
public class LINQ
{
    
    // ▬ "RunLINQ()" Method ▬
    public static void RunLINQ()
    {
        // ▼ "List" of "People" Objects ▼
        List<Person> people = new List<Person>()
        {
            new Person() { Name = "Marius", Age = 36 }, 
            new Person() { Name = "Nicolas", Age = 18 },
            new Person() { Name = "Jeanine", Age = 25 },
            new Person() { Name = "Ela", Age = 32 },
        };
        
        
        //---------------------- "GET"/"SELECT" QUERY ----------------------
        // ▼ "Select()" Method
        //      → to "Selects"/"Gets"
        //      → the "Age" Property
        //      → for "Each Person"
        //      → in the "List"
        //      → and Gets the "Max Age" Value ▼
        int oldestPersonAge = people.Select(x => x.Age).Max();
        
        
        // ▼ Printing the "Oldest Person Age" ▼
        Console.WriteLine($"The Oldest Person is {oldestPersonAge} years old.");
    }
}