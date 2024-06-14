/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                           • "ALGORITHMS" •
                    • "CYCLE DETECTION ALGORITHMS" •
                    ────────────────────────────────
               • "FLOYD" - "TORTOISE & HARE" ALGORITHM •

       


    ▬ "Floyd" - "Tortoise and Hare" Algorithm 
        → is an "Efficient Method" 
        → for "Detecting Cycles" 
        → in a "Circular Data Structure", 
        → such as a: 
            •► "Circular List" or a 
            •► D"irected Graph". 



        ♦ It is "Based" 
            → on the "Movement" 
            → of "Two Pointers", 
                • the "Mouse" and 
                • the "Rabbit", 
            → which "Move" 
            → within the "Data Structure" 
            → and "Meet" if there is
            → a "Cycle".
 

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.algorithms;


//──────────────────────────────────────────────────────────────
// ▬ "FloydTortoiseAndHare" Class ▬
public class FloydTortoiseAndHare
{
    // ▬ "FloydTortoiseAndHareAlgorithm()" Method ▬
    public static bool FloydTortoiseAndHareAlgorithm<T>(LinkedList<T> list) where T : IEquatable<T>
    {
        // ▼ "Checking" ▼
        if (list.Count <= 2)
        {
            return false;
        }

        // ▼ Creating "tortoise" & "hare" Objects of "Linked List Node" ▼
        LinkedListNode<T> tortoise = list.First;
        LinkedListNode<T> hare = list.First;

        // ▼ "Loop" ▼
        while (hare != null && hare.Next != null)
        {
            // ▼ "Move tortoise one step" ▼
            tortoise = tortoise.Next;

            // ▼ "Move hare two steps" ▼
            hare = hare.Next.Next;

            // ▼ "Check if hare meets tortoise" ▼
            if (tortoise.Equals(hare))
            {
                return true;
            }
        }

        // ▼ "Return" ▼
        return false;
    }

    
    
    
    
    // ▬ "RunFloydTortoiseAndHare()" Method ▬
    public static void RunFloydTortoiseAndHare()
    {
        // Initialize a linked list
        LinkedList<int> myList = new LinkedList<int>();

        // Add elements to the linked list
        myList.AddLast(1);
        myList.AddLast(2);
        myList.AddLast(3);
        myList.AddLast(4);
        myList.AddLast(5);

        // Display the original linked list
        Console.Write("Original 'LinkedList': ");
        foreach (var item in myList)
        {
            Console.Write(item + " -> ");
        }
        Console.Write("null");
        
        
        Console.WriteLine();
        
        
        // Create a cycle in the linked list
        // Last node points to the second node
        LinkedListNode<int> lastNode = myList.Last;
        LinkedListNode<int> secondNode = myList.First.Next;
        lastNode.List.AddAfter(lastNode, secondNode.Value);

        // Display the linked list after adding the cycle
        Console.Write("\nLinked List After Adding the Cycle: ");
        foreach (var item in myList)
        {
            Console.Write(item + " -> ");
        }
        Console.Write("null");
        
        
      
        // Check for cycle using Floyd's Tortoise and Hare Algorithm
        bool hasCycle = FloydTortoiseAndHareAlgorithm(myList);

        // Display the result
        if (hasCycle)
        {
            Console.WriteLine(" Cycle Detected in the 'Linked List'! \n There is a 'Cycle' in the 'Linked List'.");
        }
        else
        {
            Console.WriteLine("\n No 'Cycle Detected' in the 'Linked List'. \n The 'Linked List' is 'Acyclic'.");
        }
    }
}