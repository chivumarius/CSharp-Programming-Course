/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERY" •
                    ──────────────────────────────────────
                • "GROUP BY()" METHOD & "I GROUPING" INTERFACE •

       


    ▬ The "GroupBy()" Method in "LINQ" 
        → is "Used" 
        → to "Group" the "Elements" 
        → of a "Sequence" 
        → "Aaccording" to a "Specific Key". 
    
    
    
    ▬ "GroupBy()" Method 
        → "Turns" a "Sequence" of "Elements" 
        → into a "Sequence" of "Groups", 
        → where "Each Group" 
        → "Contains" a "Set" of "Elements" 
        → that "Share" the "Same Value" 
        → for the "Specified Key". 
        
        
        ♦ For "Example": 
            • We can "Group" 
                → the "Person" Objects 
                → "According" to their "Age", 
                → thus Creating "Groups" 
                → of "People" of the "Same Age". 
    
    
    
    ▬ "GroupBy()" Method 
        → "Returns" an 
            •► "IEnumerable<IGrouping<TKey, TElement>>", 
                → where:
                    •► "TKey" 
                        → is the "Type" 
                        → of the "Key" and 
                    
                    •► "TElement" 
                        → is the "Type" 
                        → of the "Elements" 
                        → in "Each Group". 
    ▬ "GroupBy()" Method 
        → "Gives Us" the "Possibility" 
        → to "Organize" and "Work" 
        → with "Data" in a "Grouped Manner", 
        → "According" to "Certain Criteria Defined" 
        → by "Keys".





   ▬ "IGrouping<TKey, TElement>" 
        → is an "Interface" in ".NET" 
        → that represents a "Group" of "Elements" 
        → with the "Same Key" 
        → in a "Grouping Operation", such as: 
            •► "GroupBy()" 
        → in "LINQ". 
        
        
        
    ▬ It "Defines" 
        → a "Common Key" 
        → and allows "Iterating" 
        → through the "Elements" 
        → of the "Group". 
    
    
    
    ▬ "It" is "Essential" 
        → in "Working" 
        → with the "Results" of "Grouping Operations", 
        → "Providing Access" to "Each Group" 
        → and Its "Associated Elements".
    

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;



//──────────────────────────────────────────────────────────────
// ▬ "Person" Class ▬
public class Person3
{
    // ▼ "Variables" ▼
    public string FirstName;
    public string LastName;
}




//──────────────────────────────────────────────────────────────
// ▬ "GroupByAndIGrouping" Class ▬
public class GroupByAndIGrouping
{
    
    // ▬ "RunGroupByAndIGrouping()" Method ▬
    public static void RunGroupByAndIGrouping()
    {
       // ▼ Creating a "List" of "Person" Objects ▼
       List<Person3> people = new List<Person3>()
       {
           new Person3() { FirstName = "Marius", LastName = "Chivu" },
           new Person3() { FirstName = "Ella", LastName = "Popescu" },
           new Person3() { FirstName = "Nicholas", LastName = "Chivu" },
           new Person3() { FirstName = "Vlad", LastName = "Popescu" },
           new Person3() { FirstName = "Jeanine", LastName = "Chivu" },
           new Person3() { FirstName = "Sebastian", LastName = "Popescu" }
       };
       
       
       //------------- "GROUP BY" -------------
       Console.WriteLine("GroupBy() Method -> to 'Group' the 'List' of 'Person' Objects by 'LastName': ");
       
      
       // ▼ "Grouping" the "List" of "Person" Objects ▼
       IEnumerable<IGrouping<string, Person3>> groupedPeople = people.GroupBy(p => p.LastName); 
       
       
      
       // ▼ "Iterating" through the "Grouped People" Elements ▼ 
       foreach(var personGroup in groupedPeople) 
       {
           Console.WriteLine($" * Key: {personGroup.Key}");
           
           // ▼ "Iterating" through the "Group" Elements ▼
           foreach(var person in personGroup) 
           {
               Console.WriteLine($"\t{person.LastName}, {person.FirstName}");
           }
       }
    }
} 