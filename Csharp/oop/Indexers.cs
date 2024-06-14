/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "OOP" •
                        ─────────
                      • "INDEXERS" •
       



    ▬ "Indexers" in "C#"
        → is a "Member" of a "Class" 
        → that allows the "Object" 
        → to be "Indexed" 
        → as an "Array". 
    
    
    
    ▬ "Indexers" 
        → allows "Access" to "Elements" 
        → using an "Index"  
        → "Specified" between "Square Brackets" "[]". 
    
    
    
    ▬ "Indexers" 
        → are "Declared" 
        → using the "this" Keyword 
        → "Followed" by the "Index Type". 
    
    
    ▬ "Indexers" 
        → can have "Getters" and "Setters" 
        → that "Control Access" 
        → and "Assignment" 
        → of the "Indexed Values". 
    
    
    
    ▬ "Indexers" 
        → are "Used" to Create "Classes" 
        → that "Simulate" 
        → the "Behavior" of an "Array" 
        → or "Collection", 
        → but can have "Additional Logic" 
        → in "Getters" and "Setters".
                  
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.oop;



//────────────────────────────────────────────────────
// ▬▬ "Indexers" Class ▬▬
public class Indexers
{
    // ▼ "Array" ▼
    private string[] dataArray = new string[100];
    
    
    
    // ▬ "Indexer" Method
    //      → "Without" a "Name"
    //      → only "this[]" ▬
    public object this[int index]
    {
        get
        {
            // ▼ Checking "Index" ▼
            if (index < 0 || index >= dataArray.Length)
            {
                Console.Write("Index out of Range");
                return null;
            }
            else
            {
                return dataArray[index];
            }
            
        }
        
        set
        {
            // ▼ Checking "Index" ▼
            if (index < 0 || index >= dataArray.Length)
            {
                Console.Write("Index out of Range");
            }
            else
            {
                dataArray[index] = value.ToString();
            }
        }
    }



    

    // ▬ "RunIndexers()" Method ▬
    public static void RunIndexers()
    {
        // ▼ "Creating" an "Instance/Object" of "Indexers" Class ▼
        Indexers indexerObject = new Indexers();
        
        
        // ▼ Setting "Values" in "Indexer" Method ▼
        indexerObject[0] = "Hello, ";
        indexerObject[1] = "I am ";
        indexerObject[2] = "Marius and I am ";
        indexerObject[3] = 30;
        indexerObject[4] = " years old. \nThe value of PI is ";
        indexerObject[5] = 3.14;
        indexerObject[6] = " and this is ";
        indexerObject[7] = true;
        
        
        // ▼ "Print" "Indexer" Values ▼
        
        for (int i = 0; i < 8; i++)
        {
            Console.Write(indexerObject[i]);
        }
        
        
        Console.WriteLine();
    }
    
} 


