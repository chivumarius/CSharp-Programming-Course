/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "DICTIONARIES" •

       

    ▬ "Dictionaries" in "C#" 
        → are "Unordered Data Structures" 
        → that Store "Key-Value" Pairs, 
        → allowing "Quick Access" 
        → to "Values" 
        → using the "Corresponding Keys". 
        
        
        ♦ They "Provide" 
            → an "Efficient Way" 
            → to "Manage" and "Access Data" 
            → "Based" on a "Specific Key", 
            → "Similar" to how a "Real-Life Dictionary Works", 
            → where: 
                •► "Keys" 
                    → are "Words" and
                •► "Values" 
                    → are "Associated Definitions".
    
        
        ♦ "dictionary" Keyword
            → is "Used" to "Create" 
            → a "Dictionary".
        
        
        ♦ The "Keys" 
            → of the "Dictionary" 
            → must be of "Immutable" Type.
            
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;

public class Dictionaries
{
    
    
    
    // ▬ "RunStacks()" Method ▬
    public static void RunDictionaries()
    {
        // ▼ "Create" an "Object/Instance" of the "Dictionary" Class ▼
        Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
        
        // ▼ "Add" a "Key-Value" Pair to the "Dictionary" ▼
        dictionary1.Add("key1", "value1");
        dictionary1.Add("key2", "value2");
        dictionary1.Add("key3", "value3"); 
        dictionary1.Add("key4", "value4");
        dictionary1.Add("key5", "value5");
        
        
        
        // ▼ "Check"/"Count" the "Number" of "Elements" in the "Dictionary" ▼
        Console.WriteLine("The Dictionary contain " + dictionary1.Count + " Elements");
        
        
        
     
        
        // ▼ "Getting" - "Each Keys" of the "Dictionary" ▼
        Console.WriteLine("\nGetting Each Key of the Dictionary:");

        foreach (string key in dictionary1.Keys)
        {
            Console.WriteLine(key);
        }
        
        
        
        // ▼ "Getting" - "Each Values" of the "Dictionary" ▼
        Console.WriteLine("\nGetting Each Value of the Dictionary:");
        
        foreach (string value in dictionary1.Values)
        {
            Console.WriteLine(value);
        }

        
        
        
        // ▼ "Getting" a "Specific Values" for a "Key" of the "Dictionary" ▼
        Console.WriteLine("\nGetting a Specific Value for a Key of the Dictionary: " + dictionary1["key3"]);
        
        
        // ▼ "Getting Safely" a "Specific Value " from a Key of the "Dictionary" ▼
        string valueString = "";
        dictionary1.TryGetValue("key1", out valueString);
        Console.WriteLine("\nGetting Safely a Specific Value  from a Key of the Dictionary: " + valueString);

        
        
        // ▼ "Removing" the "Dictionary" by "Key" ▼
        Console.WriteLine("\nRemoving Dictionary by Key:");
        
        dictionary1.Remove("key5");
        
        foreach (string key in dictionary1.Keys)
        {
            Console.WriteLine(key);
        }

        
        
        // ▼ "Removing All" the "Key-Value" Pairs from the "Dictionary" ▼
        Console.WriteLine("\nRemoving All Key-Value Pairs from the Dictionary:");
        
        dictionary1.Clear();
        
        foreach (string key in dictionary1.Keys)
        {
            Console.WriteLine(key);
        }
        
    }
}