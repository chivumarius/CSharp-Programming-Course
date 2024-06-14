namespace CSharp.data_structures_and_collections;

public class DoubleLinkedLists
{
    // ▼ Creating a "List" of "Strings" ▼
    static LinkedList<string> linkedList1 = new LinkedList<string>();
    
    

    // ▬ "RunDoubleLinkedLists()" Method ▬
    public static void RunDoubleLinkedLists()
    {
      //------------------------------------------------------  
      // ▼ "Add" a "Value" to the "List" ▼
      linkedList1.AddFirst("root");                                  // ◄◄ "Add" at the "Start" of the "LinkedList" 
      linkedList1.AddAfter(linkedList1.First, "element1");       // ◄◄ "Add" between the "Existing Nodes" ◄◄
      linkedList1.AddAfter(linkedList1.Find("element1"), "element2");     
      linkedList1.AddAfter(linkedList1.Find("element2"), "element3");     
      linkedList1.AddAfter(linkedList1.Find("element3"), "element4");     
      linkedList1.AddAfter(linkedList1.Find("element4"), "element5");     
      linkedList1.AddBefore(linkedList1.First, "new root");     // ◄◄ "Add" before an "Existing Nodes" ◄◄
      linkedList1.AddLast("last element");                          // ◄◄ "Add" at the "End" of the "LinkedList"
       
      
      //------------------------------------------------------------------
    // ▼ "Getting" - "Each Value" of the "LinkedList" ▼
      Console.WriteLine("\nGetting Each Value of the LinkedList: ");
      foreach (string value in linkedList1)
      {
        Console.WriteLine(value);
      }
      
      
      
      //----------------------------------------------------------------
      // ▼ Getting the "Size" of the "LinkedList" ▼
      Console.WriteLine("\nThe Curent Size of the LinkedList is: " + linkedList1.Count);

      
      
      
      //----------------------------------------------------------------
      // ▼ "Finding" a "Value" in the "LinkedList" ▼
      LinkedListNode<string> node = linkedList1.Find("new root");  
      if (node != null)
      {
          Console.WriteLine("\nNode Value was Found in the LinkedList: " + node.Value);
      }
      else
      {
          Console.WriteLine("\nValue not found in the LinkedList.");
      }
      
      
      
      
      //----------------------------------------------------------------
      // ▼ "Removing" a "Specific Node" from the "LinkedList" ▼
      Console.WriteLine("\nRemoving a Specific Node (new root) from the LinkedList: ");
      linkedList1.Remove("new root");
      foreach (string value in linkedList1)
      {
        Console.WriteLine(value);
      }
      
      
      
      //----------------------------------------------------------------
      // ▼ "Remove First Node" from the "LinkedList" ▼
      Console.WriteLine("\nRemoving the First Node from the LinkedList: ");
      linkedList1.RemoveFirst();
      foreach (string value in linkedList1)
      {
        Console.WriteLine(value);
      }
      
      
      
      //----------------------------------------------------------------
      // ▼ "Remove Last Node" from the "LinkedList" ▼
      Console.WriteLine("\nRemoving the Last Node from the LinkedList: ");
      linkedList1.RemoveLast();
      foreach (string value in linkedList1)
      {
        Console.WriteLine(value);
      }
      
      
      
      //----------------------------------------------------------------
      // ▼ "Remove All" the "Nodes" of the "LinkedList" ▼
      Console.WriteLine("\nRemoving All the Nodes from the LinkedList: ");
      linkedList1.Clear();
      foreach (string value in linkedList1)
      {
        Console.WriteLine(value);
      }
    }
}