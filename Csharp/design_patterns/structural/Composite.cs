/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "STRUCTURAL" •
                    ────────────────────
                      • "COMPOSITE" •

       


  ▬ A "Design Pattern" 
    → is a "General Reusable Solution" 
    → to a "Frequent Problem" 
    → in "Software Engineering".



  ▬ "Structural" Design Patterns 
    → "Define" the "Relationships" 
    → between "Objects"
    → and "Allow Us" 
    → to "Compose Objects" 
    → in "Different Ways" 
    → to "Create New Functionality".


    ♦ They "Help" 
      → to "Ensure" that "Even" 
      → if "One Part Changes", 
      → the "Entire Structure" of the "Code" 
      → does "Not Need" to "Change".


    ♦ It "Focuses" 
      → on "Inheritance"
      → (which is a "Primary Component" 
      → of "Structural" Design Patterns).




  ▬ "Composite" Design Pattern 
    → "Takes" a "Group" of "Objects" 
    → and "Combines Them" 
    → into a "Single Object".
    
  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.structural;



//──────────────────────────────────────────────────────────────
// ▬ (1) "Abstract Class" - "Component" Class ▬
public abstract class Component
{
    // ▬ "Abstract Methods" ▬
    public abstract void AddChild(Component c);
    public abstract void Traverse();
}




//──────────────────────────────────────────────────────────────
// ▬ (2-1) "Concrete Class 1" - "File" Class
//        → that "Extends" the "Abstract Class" ▬
public class File : Component
{
    // ▼ "Variable" ▼
    private string value = string.Empty;
    
    
    // ▬ "Constructor" ▬
    public File(string val)
    {
      value = val;
    }
    
    
    // ▬ "AddChild()" Overridden Methods ▬
    public override void AddChild(Component c)
    { }

    
    // ▬ "Traverse()" Overridden Methods ▬
    public override void Traverse()
    {
      Console.WriteLine("File: " + value);
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (2-2) "Concrete Class 2" - "Folder" Class
//        → that "Extends" the "Abstract Class" ▬
public class Folder : Component
{
    // ▼ "Variable" ▼
    private string value = string.Empty;
    private List<Component> componentList = new List<Component>();

    // ▬ "Constructor" ▬
    public Folder(string val)
    {
        value = val;
    }

    // ▬ "AddChild()" Overridden Methods ▬
    public override void AddChild(Component c)
    {
        componentList.Add(c);
    }

    // ▬ "Traverse()" Overridden Methods ▬
    public override void Traverse()
    {
        Console.WriteLine("Folder: " + value);

        // ▼ "Iterate" the "List" of "Components" ▼
        foreach (Component c in componentList)
        {
            // ▼ "Call" the "Traverse()" Method ▼
            c.Traverse();
        }
    }
}




//──────────────────────────────────────────────────────────────
// ▬ "Client2" - "Composite" Class
//    → that "Uses" the "Composite" Design Pattern ▬
public class Composite
{
    // ▬ "RunComposite()" Method ▬
    public static void RunComposite()
    {
        // ▼ "Create" an "Object" of "Folder" Class ▼
        Folder folder1 = new Folder("Folder 1");
        Folder folder2 = new Folder("Folder 2");
        
        
        // ▼ "Create" an "Object" of "File" Class ▼
        File file1 = new File("File 1");
        File file2 = new File("File 2");
        File file3 = new File("File 3");
        
        
        // ♦ Build "Directory Structure" for "Folders" and "Files" ♦
        // ▼ "Folder 2" ▼
        folder2.AddChild(file1);
        folder2.AddChild(file2);
        
        // ▼ "Folder 1" ▼
        folder1.AddChild(folder2);
        folder1.AddChild(file3);
        
        // ▼ "Traverse" the "Root Directory" ▼
        folder1.Traverse();
    }
} 