/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "BEHAVIORAL" •
                    ────────────────────
                       • "ITERATOR" •

       


  ▬ A "Design Pattern" 
    → is a "General Reusable Solution" 
    → to a "Frequent Problem" 
    → in "Software Engineering".



  ▬ "Behavioral" Design Patterns
    → "Help" to "Define" 
    → how "Objects Interact".


    ♦ They "Increase" 
      → the "Flexibility" 
      → in the "Communication" 
      → between "Objects".


    ♦ They "Focus" 
      → on "Assigning Responsibilities" 
      → between "Objects"
      → and on the "Way" 
      → that "Objects" 
      → are "Interconnected".





  ▬ "Iterator" Design Pattern 
    → "Lets" us "Access" 
    → the "Elements" of an "Object" 
    → in "Sequence" 
    → "Without" having to "Expose" 
    → the "Underlying Representation" 
    → of the "Object".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.behavioral;



//──────────────────────────────────────────────────────────────
// ▬ (1) "Person" Class ▬
public class Person
{
    // ▼ "Read-Only Properties" ▼
    public int Age { get; }
    public string Name { get; }
    
    
    // ▬ "Constructor" ▬
    public Person(int age, string name)
    {
        Age = age;
        Name = name;
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (2) "PersonCollection" Class
//          → that "Implements" the "IEnumerator" Interface ▬
public class PersonCollection
{
    // ▼ "Variable" ▼
    private int position;
    
    // ▼ "List" ▼
    private List<Person> peopleList = new List<Person>();
    
    
    
    // ▬ "Constructor" ▬
    // Initialize the collection with some default people
    public PersonCollection()
    {
        // ▼ "Set" ▼
        position = -1;
       
        // Adding some default people to the list
        peopleList.Add(new Person(25, "Jeanine"));
        peopleList.Add(new Person(23, "Claudia"));
        peopleList.Add(new Person(30, "Marius"));
        peopleList.Add(new Person(40, "Sebastian"));
    }
    
    
    
    // ▼ "Property" ▼
    // Property to get the current person in the collection
    public object Current
    {
        get { return peopleList[position]; }
    }
    
    
    // ▬ "MoveNext()" Method ▬
    // Method to move to the next person in the collection
    public bool MoveNext()
    {
        ++position;
        return position < peopleList.Count;
    }
    
    
    
    // ▬ "Reset()" Method ▬
    // Method to reset the position in the collection
    public void Reset()
    {
        position = -1;
    }
}



//──────────────────────────────────────────────────────────────
// ▬ "Iterator" Class ▬
public class Iterator
{
    // ▬ "RunIterator()" Method ▬
    public static void RunIterator()
    {
        // Create the people collection
        PersonCollection collectionOfPeople = new PersonCollection();

        // Iterate over and display people's names and ages
        while (collectionOfPeople.MoveNext())
        {
            Person currentPerson = (Person)collectionOfPeople.Current;
            Console.WriteLine("Name: {0}, Age: {1}", currentPerson.Name, currentPerson.Age);
        }
    }
} 