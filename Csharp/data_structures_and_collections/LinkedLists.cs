/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "LINKED LISTS" •

       

    ▬ A "LinkedList"
        → is a "Sequence"
        → of "Data Structures"
        → "Connected" by "Links".
        
        
        ♦ "Each Link"
            → called also "Node"
            → "Contains" a "Connection"
            → to "Another Link",
            → To "Next Link" (called "Next")
            → and "It" can "Store Data".
 
 
        ♦ "Each Link"
            → has "2 Things":
                •► "Data" Field
                •► "Next Link" Field
            
            
            
        
     ▬ A "LinkedList"
        
        ♦ "Start"
            → with the "Link Element"
            → called: 
                •► "First", 
                •► "Head" or 
                •► "Root".        
 
 
 
        ♦ "Last"
            → with the "Link Element"
            → called: 
                •► "Null", 
            → to "Mark" 
            → the "End" 
            → of the "LinkedList".
 
    
    
    ▬ "Types" of "LinkedLists":
        1. "Single LinkedList"
            → has Only "Forward Navigation".
            
        
        2. "Double LinkedList"
            → has "Forward Navigation" 
            → and "Backward Navigation".
            
            ♦ "Each Link" (Node)
                → Contain a "link" to the "Previous" Field,
                → a "Data" Field
                → and a "link" to the "Next" Field.
        
        
        3. "Circular LinkedList"
            → in which the "Last Element" 
            → is "Connected" 
            → to the "First Element".
       
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;

public class LinkedLists
{
    
    
    // ▬▬ "LinkedList" Sub-Class ▬▬
    public class LinkedList
    {
        // ▼ "Variable" ▼
        private Node root; 
        
        
        // ▼ "First Node" Property ▼
        public Node First
        {
            // ▼ "Getter" → give us the "Root Node" ▼
            get { return root; } 
        }
        
        
        // ▼ "Last Node" Property ▼
        public Node Last
        {
            // ▼ "Getter" → give us the "Last Node" ▼
            get
            {
                // ▼ Creating a "Current Node"
                //      → to "Put Us" at the "Start"
                //      → of the "LinkedList"
                Node currentNode = root; 
                
                
                // ▼ "Checking": If the "Current Node" is "Null" 
                if(currentNode == null)
                {
                    return null;
                }
                
                
                // ▼ "Traversing" the "LinkedList"
                //      → and Setting the "Current Node"
                //      → to the "Next Node" ▼
                while(currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                
                return currentNode;
            } 
        }




        // ▬ The "Append()" Method
        //      → to "Add Elements"
        //      → to the "End"
        //      → of "LinkedList"
        public void Append(object value)
        {
            // ▼ "Creating" a "Node"
            //      → that "Holds" the "Data"
            //      → of the "Value Pasted In" ▼
            Node node = new Node { data = value };
            
            
            // ▼ "Checking": If the "Root Node" is "Null"
            if(root == null)
            {
                // ▼ Set the "Root Node"
                root = node;
            }
            else
            {
                // ▼ Set the "Last Node" to "Next Node"  ▼
                Last.next = node;
            }
        }
        
        
        
        
        // ▬ The "Delete()" Method
        //      → to "Delete" a "Node"
        //      → in the "LinkedList" ▬
        public void Delete(Node node)
        {
            // ▼ "Checking": If the "Root" is "Node" ▼
            if(root == node)
            {
                root = node.next;
                node.next = null;
            }
            else
            {
                // ▼  "Create" a "Current" Node ▼
                Node current = root;
                
                
                // ▼ "Traversing" the "LinkedList"
                while(current.next != null)
                {
                    if(current.next == node)
                    {
                        current.next = node.next;
                        node.next = null;
                        break;
                    }
                    
                    // ▼ Set the "Current" Node to "Next" Node ▼
                    current = current.next;
                }
            }
        }


        
        
        
        // ▬▬ "Node" Sub-Class ▬▬
        public class Node
        {
            // ▼ "Variables" ▼
            public Node next;
            public object data;
        }
    }




    // ▬ "RunLinkedLists()" Method ▬
    public static void RunLinkedLists()
    {
        // ▼ "Create" an "Instance" of the "LinkedList" Class ▼
        LinkedLists.LinkedList linkedList = new LinkedLists.LinkedList();

        
        // ▼ "Append Elements" to the "LinkedList" ▼
        linkedList.Append(1);
        linkedList.Append(2);
        linkedList.Append(3);
        linkedList.Append(4);

        // Display all nodes in the list
        LinkedLists.LinkedList.Node currentNode = linkedList.First;
        while (currentNode != null)
        {
            Console.WriteLine("Node: " + currentNode.data);
            currentNode = currentNode.next;
        }
    }
}