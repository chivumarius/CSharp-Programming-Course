/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 12.0" (2023) •
                    ──────────────────────
                      • "ANY TYPE ALIAS" •

       


    ▬ "Any Type" Alias in "C# 12"
        → allows "Programmers"
        → to "Define" an "Alias"
        → for "Unknown Types"
        → at "Compile Time"
        → by "Using" the
            •► "using" Keyword.
    
    
    
    ▬ This "Alias",
            •► named "any",
        → can be "Used" to "Declare Variables"
        → and "Parameters"
        → that can "Accept"
        → "Any Data Type"
        → and the "Type" is "Resolved"
        → at "Runtime".
    
    
    
    ▬ It is "Useful"
        → in "Situations" where we "Need"
        → to "Work" with "Unknown Data Types"
        → at "Compile Time",
        ► such as:
            •► "Generics" or
            •► "Dynamic Interfaces".



    ▬ "See":
      •► https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12
  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_12;

// ▼ Create "Alias" Alias ▼
using Alias = System.Console;
// ▼ Creating a "NewExampleItems" Alias in "C# 12" ▼
using NewExampleItems = System.Collections.Generic.List<NewExampleItem>;

//──────────────────────────────────────────────────────────────
// ▬ "OldExampleItem" Class ▬
public class OldExampleItem
{
    int exampleInt;
}

//──────────────────────────────────────────────────────────────
// ▬ "NewExampleItem" Class ▬
public class NewExampleItem
{
    int exampleInt;
}

//──────────────────────────────────────────────────────────────
// ▬ "AnyTypeAlias" Class ▬
public class AnyTypeAlias
{
    // ▬ "GetOldExampleItems()" Method ▬
    List<OldExampleItem> GetOldExampleItems()
    {
        return new List<OldExampleItem>() { };
    }

    // ▬ "GetNewExampleItems()" Method ▬
    NewExampleItems GetNewExampleItems()
    {
        // ▼ "Return" a "New List" of "NewExampleItem" ▼
        return new NewExampleItems() { new NewExampleItem() };
    }

    // ▬ "RunAnyTypeAlias()" Method ▬
    public static void RunAnyTypeAlias()
    {
        // ▼ "Printing" the "Alias" Alias ▼
        Alias.WriteLine("Using 'Alias' for 'Namespace' - 'System.Console'!");

        //
        AnyTypeAlias anyTypeAlias = new AnyTypeAlias();
        NewExampleItems newItems = anyTypeAlias.GetNewExampleItems();

        // ▼ "Printing" the "NewExampleItems" Alias ▼
        Alias.WriteLine($"Number of New Items: {newItems.Count}");
    }
}
