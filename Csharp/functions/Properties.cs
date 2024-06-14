/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "FUNCTIONS" •
                     ───────────────
                     • "PROPERTIES" •


       

    ▬ "Properties" in "C#" 
        → are "Members" of a "Class" 
        → that Provide "Controlled Access" 
        → to the "Class's Data". 
        
        
        ♦ "Properties" 
            → are "Used" 
            → to "Protect Class Data" 
            → from "Direct Access" 
            → and to "Provide" 
            → a More "Controlled Interface" 
            → for "Reading" 
            → and "Writing" 
            → this "Data". Here are some key points about properties in C#:


    1. "Defining" a "Property": 
        ♦ A "Property" is "Defined" 
            → "Using" the "Syntax": 
                •► "{ get; set; }" 
            → "Inside" a "Class". This consists of a block of code that defines access to the property (typically `get' for reading and `set' for writing).



    2. "Get" and "Set Accessors":         
        ♦ The `get` and `set` Blocks 
            → are "Used" to "Access" 
            → and "Change" 
            → the "Property Value". 
            
        
        ♦ They may "Include" 
            → "Additional Logic" 
            → to "Validate" or "Process" 
            → the "Data".



    3. "Access Modifiers":         
        ♦ "Properties" 
            → can be "Defined" 
            → with Different "Access Modifiers"l 
                •► public, 
                •► private, 
                •► protected, 
                •► internal 
            → to "Control" 
            → their "Visibility" 
            → "Inside" or "Outside" 
            → the "Class".


    4. "Auto-Implemented Properties": 
        ♦ These are "Properties" 
            → that "Do Not Require" 
            → "Separate Definitions" 
            → for "Storage Fields". 
        
        
        ♦ The "Compiler" 
            → "Automatically Generates" 
            → a "Private Storage Field" 
            → for "Them".


    5. "Indexed Properties" ("Indexers"): 
        ♦ These Allow "Access" 
            → to "Objects" 
            → as if they were "Arrays", 
            → allowing them to "Be Indexed" 
            → using "Integer Values" 
            → or "Other Types" of "Keys".


    6. "Calculated Properties": 
        ♦ These are "Properties" 
            → whose "Values" are "Calculated" 
            → from "Other Values" 
            → of "Class Members" 
            → or from "Other Resources".



    7. "Using Properties": 
        ♦ "Properties" 
            → are "Used" 
            → to "Access" and "Manipulate" 
            → the "Data" of a "Class" 
            → in an "Encapsulated" 
            → and "Safe Manner". 
        
        
        ♦ They "Provide" 
            → an "Additional Level" 
            → of "Abstraction" 
            → and "Control" 
            → over "Data Access".

    
    ▬ In "General", 
        → using "Properties" 
        → "Contributes" to "Better Class Design" 
        → and More "Efficient Data Management" 
        → within a "C# Application".


 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.functions;

public class Properties
{
    // ▼ "Auto Implemented Property" ▼
    public string Id { get; set; }  
    
    
    // ▼ "Another Way"
    //      → to "Implement" t
    //      → he "Property" ▼
    private string id2;
    public string Id2 {
        get { return id2; }  // ◄◄ "Getter" Nethod ◄◄ 
        
        set { id2 = value; } // ◄◄ "Setter" Method ◄◄
        
    }
    
    
    
    
    
    
    
    public  static void RunProperties()
    {
       // ▼ Create an "Instance" of the "Properties" Class ▼
       Properties obj1 = new Properties();
       
       // ▼ Assign a "Value" to the "Property" ▼
       obj1.Id = "001";
       
       // ▼ Print the "Value" of the "Property" ▼
       Console.WriteLine("Property Value: " + obj1.Id);
    }
} 