/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                           • "SEARCHING" •
                    ───────────────────────────
                       • "TREE TRAVERSAL" •
                  
                  
                  
    ▬ "Trees"
        → are a "Hierarchy" Data Structures.
        
        
        
    ▬ "Tree Traversal"
        → means "Visiting" Each "Node" 
        → in a "Tree"

        
    ▬ There are "3 Main Types" 
        → of "Travers" a "Tree":
        1. "In-Order"
            → means "Visiting" Each "Node" 
            → in "In Horizontal Order"
            → from "Left" to "Right"
                (1) "Left" Node ("Leave") 
                (2) "Root" Node ("Root") 
                (3) "Right" Node ("Leave")
        
        2. "Pre-Order"
            → means "Visiting" Each "Node"
            → in "In Vertical Order"
            → from "Top" to "Bottom"
                (1) "Root" Node ("Root")
                (2) "Left" Node ("Leave")
                (3) "Right" Node ("Leave")
                
                
        3. "Post-Order"  
            → means "Visiting" Each "Node"
            → in "In Vertical Order"
            → from "Bottom" to "Top"
                (1) "Left" Node ("Leave")
                (2) "Right" Node ("Leave")
                (3) "Root" Node ("Root")
      
      
    ▬ A "Tree" 
        → in an "Other Tree"
        → is Called "Sub-Tree".
        
              
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.searching;



// ▬▬ "Node" Class ▬▬
public class Node3
{
    // ▼ "Fields" ▼
    public int Data; // ◄ "Number" of the "Node"
    public Node3 Left; // ◄ "Left Child"  Node ◄
    public Node3 Right; // ◄ "Right Child" Node ◄
}




// ▬▬ "TreeTraversal" Class ▬▬
public class TreeTraversal
{
    
    // ▬ "InOrderTraversal()" Method ▬
    public static void InOrderTraversal(Node3 root)
    {
        // ▼ Checking if "Root Node" is "Not Null" ▼
        if (root != null)
        {
            // ▼ "Left Sub-Tree" Traversal ▼
            InOrderTraversal(root.Left);
            
            // ▼ "Root Node" Printing ▼
            Console.Write(" " + root.Data);
            
            
            // ▼ "Right Sub-Tree" Traversal ▼
            InOrderTraversal(root.Right);
        }
    }
    
    
    
    
    // ▬ "PreOrderTraversal()" Method ▬
    public static void PreOrderTraversal(Node3 root)
    {
        // ▼ Checking if "Root Node" is "Not Null" ▼
        if (root != null)
        {
            // ▼ "Root Node" Printing ▼
            Console.Write(" " + root.Data);
            
            // ▼ "Left Sub-Tree" Traversal ▼
            PreOrderTraversal(root.Left);
            
            // ▼ "Right Sub-Tree" Traversal ▼
            PreOrderTraversal(root.Right);
        }
    }

    
    
    // ▬ "PostOrderTraversal()" Method ▬
    public static void PostOrderTraversal(Node3 root)
    {
        // ▼ Checking if "Root Node" is "Not Null" ▼
        if (root != null)
        {
            // ▼ "Left Sub-Tree" Traversal ▼
            PostOrderTraversal(root.Left);
            
            // ▼ "Right Sub-Tree" Traversal ▼
            PostOrderTraversal(root.Right);
            
            // ▼ "Root Node" Printing ▼
            Console.Write(" " + root.Data);
        }
    }




    // ▬ "RunTreeTraversal()" Method ▬
    public static void RunTreeTraversal()
    {
        // ▼ Creating "Left Node" ▼
        Node3 leftNode = new Node3() 
        {
            Data = 1,
            Left = null,
            Right = null
        };
    
    
        // ▼ Creating "Right Node" ▼
        Node3 rightNode = new Node3() 
        {
            Data = 3,
            Left = null,
            Right = null
        };
    
    
        // ▼ Creating "Root Node" ▼
        Node3 rootNode = new Node3() 
        {
            Data = 2,
            Left = leftNode,
            Right = rightNode
        };   
        
        
        // ▼ (1) "Printing" ▼
        Console.Write("In-Order Traversal: ");
        
        
        // ▼ "Call" the Method
        //      → for "In-Order Traversal"
        //      → on the "Tree" ▼
        InOrderTraversal(rootNode);
        
        
        
        // ▼ (2) "Printing" ▼
        Console.Write("\n\nPre-Order Traversal: ");
        
        
        // ▼ "Call" the Method
        //      → for "Pre-Order Traversal"
        //      → on the "Tree" ▼
        PreOrderTraversal(rootNode);
        
        
        
        // ▼ (3) "Printing" ▼
        Console.Write("\n\nPost-Order Traversal: ");
        
        
        // ▼ "Call" the Method
        //      → for "Post-Order Traversal"
        //      → on the "Tree" ▼
        PostOrderTraversal(rootNode);
        
        Console.WriteLine();
    }
} 