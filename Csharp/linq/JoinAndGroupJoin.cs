/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERY" •
                    ──────────────────────────────────────
                     • "JOIN()" & "GROUPJOIN()" METHODS •

       


    ▬ "Join()" in "LINQ"
        → is "Used" to "Combine Two Collections" 
        → "According" to a "Specified Condition" 
        → and "Create Pairs" of "Elements" 
        → that "Meet" that "Condition". 
        
        
        ♦ The "Result" 
            → is a "New Collection" 
            → "Containing" these "Pairs" 
            → of "Elements". 
        
        
        ♦ To "Use" the "Join()" Method, 
            → it is "Necessary": 
                1- to "Specify Two Collections" 
                    → (the "Left" and the "Right Collection"), 
            2- to "Specify" → a "Matching Key" 
                → from "Each Collection" and 
            3- to "Specify" a "Function" 
                → that "Defines" the "Matching Condition" 
                → between these "Keys". 
        
        
        
        ♦ "After Applying" the "Join()" Method, 
            → the "Result" will "Contain" 
            → "Only" those "Elements" 
            → that "Match" the "Specified Condition".





    ▬ "GroupJoin()"" in "LIMQ"
        → is "Similar" 
        → to the "Join" Method, 
        → but has the "Additional Behavior" 
        → of "Grouping" the "Results". 
        
        
        ♦ It "Joins Two Collections", 
            → "Similar" to "Join()" Method, 
            → but "Instead" 
            → of "Returning" a "List" 
            → of "Pairs" of "Elements", 
            → It "Returns" 
            → a "List" of "Groups", 
            → where "Each Group" 
            → "Consists" of an "Element" 
            → from the "Left Collection" 
            → and a "Collection" of "Elements" 
            → in the "Right Collection" 
            → that "Satisfy" the "Specified Condition". 
        
        
        
        ♦ These "Groups" 
            → are "Represented" by "Objects" 
            → that "Implement" the "IGrouping" Interface,
                •► "IGrouping<TKey, TElement>" Interface, 
                    → where 
                        •► "TKey" 
                            → is the "Type" 
                            → of the "Grouping Key" and
                        •► "TElement" 
                            → is the "Type" of the "Elements" 
                            → in the "Right Collection".



    ▬ "GroupJoin()" is "Used" 
        → when we "Want" 
        → to "Combine Two Collections" 
        → and "Group" the "Results" 
        → "According" to "Certain Criteria", 
        → allowing us to "Iterate" 
        → through "Each Group" 
        → and "Access" the "Corresponding Elements" 
        → in the "Right Collection" 
        → "Associated" with "Each Group".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;



//──────────────────────────────────────────────────────────────
// ▬ "Person5" Class ▬
public class Person5
{
    // ▼ "Variables" ▼
    public string name;
    public int age;
}




//──────────────────────────────────────────────────────────────
// ▬ "Age" Class ▬
public class Age
{
    // ▼ "Variables" ▼
    public int ageNumber;
    public string ageLabel;
}




//──────────────────────────────────────────────────────────────
// ▬ "JoinAndGroupJoin" Class ▬
public class JoinAndGroupJoin
{

    // ▬ "RunJoinAndGroupJoin()" Method ▬
    public static void RunJoinAndGroupJoin()
    {
        // ▼ Creatting "2 Lists" of "Integers" ▼
        List<int> list1 = new List<int>() { 1, 2, 3, 4 };
        List<int> list2 = new List<int>() { 1, 2, 3, 5, 6 };


        //---------------------- "JOIN()" ----------------------------
        Console.Write("Join() Method -> to Get the 'Common Elements' of 'Two Lists': ");

        // ▼ "Join()" Method ▼
        var innerJoin = list1.Join(list2, int1 => int1, int2 => int2, (int1, int2) => int1);

        // ▼ "Iterating" through the "Collection" ▼
        foreach (var item in innerJoin)
        {
            Console.Write(item + ", ");
        }




        Console.WriteLine();




        //---------------------- "GROUP JOIN()" ----------------------------
        Console.WriteLine("\nGroupJoin() Method -> to Get the 'Common Elements' of 'Two Lists': ");


        // ▼ "Creating" a "List" of "Person5" ▼
        List<Person5> peopleList = new List<Person5>()
        {
            new Person5() { name = "Elena", age = 30 },
            new Person5() { name = "Marius", age = 25 },
            new Person5() { name = "Emil", age = 30 },
            new Person5() { name = "Ramona", age = 25 },
            new Person5() { name = "Mihai", age = 40 }
        };


        // ▼ "Creating" a "List" of "Age" ▼
        List<Age> agesList = new List<Age>()
        {
            new Age() { ageNumber = 25, ageLabel = "25" },
            new Age() { ageNumber = 30, ageLabel = "30" },
            new Age() { ageNumber = 40, ageLabel = "40" }
        };


        // ▼ "GroupJoin()" Method ▼
        var groupJoin = agesList.GroupJoin(
            peopleList,
            age => age.ageNumber,
            person5 => person5.age,
            (age, personGroup) => new { PersonGroup = personGroup, Number = age.ageLabel }
        );

       
        
        // ▼ "Iterating" through the "Collection" ▼
        foreach (var item in groupJoin)
        {
            Console.WriteLine(item.Number + " years");

            // ▼ "Iterating" through the "PersonGroup" ▼
            foreach (var person in item.PersonGroup)
            {
                Console.WriteLine("\t" + person.name);
            }
        }
    }
}