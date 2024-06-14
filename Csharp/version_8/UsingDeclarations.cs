/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ─────────────────────
                  • "USING" DECLARATIONS •

       


  ▬ "using" Keyword 
        → is "Used" to "Import" 
        → a "Namespace".
        
        
        
  ▬ "using declarations" 
        → "Introduced" in "C# 8.0"
        → "Provided" a more "Compact Way" 
        → to "Import Namespaces" 
        → into a "Source File". 
    
    
    
        ♦ This "Eliminated" 
            → the "Need" to "Use"
            → "Separate"
                •► "using" Statements 
            → for "Each Namespace", 
            → allowing "Them" 
            → to be "Added Directly" 
            → within a "using" Section. 
        
        
        ♦ This "Makes" the "Code" 
            → more "Concise" 
            → and "Easier" to "Read", 
            → "Especially" when "Multiple Namespaces" 
            → are "Required". 
    
    
    
    ▬ "Note That" 
            •► "using declarations" 
        → "Work Exclusively" 
        → for "Namespaces" 
        → and do "Not Apply" 
        → to "Other Entities" 
        → such as "Classes" 
        → or "Other Types".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


//──────────────────────────────────────────────────────────────
// ▬ "UsingDeclarations" Class ▬
public class UsingDeclarations
{
    // ▬ "RunUsingDeclarations()" Method ▬
    public static void RunUsingDeclarations()
    {
        // ▼ "File Path" ▼
        string filePath = @"C:\Users\Administrator\RiderProjects\Csharp\Csharp\csharp_version_8\filename.txt";
        
        
        // ▼ "Write" some "Text" to the "File" ▼
        using (var fileWriter = new StreamWriter(filePath))
        {
            fileWriter.WriteLine("Hello, using declarations!");
        }

        // ▼ "Read" the "Text" from the "File"
        //      → and "Display It" in the "Console" ▼
        using (var fileReader = new StreamReader(filePath))
        {
            string fileContent = fileReader.ReadToEnd();
            Console.WriteLine("File content:");
            Console.WriteLine(fileContent);
        }
    }
} 