/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "STACKS" •

       

    ▬ "Stacks" 
        → are "Data Structures" 
        → that "Operate" 
        → on the "LIFO" ("Last In First Out") Principle.
        
        
        ♦ "Capacity" 
            → is the "Number" of "Elements" 
            → that the "Stack" 
            → can "Hold".
  
    
    ▬ "Key Operation"s 
        → that can be "Performed" on "Stacks":
    
        1. "Push()" 
            → "Adds" an "Element"
            → to the "Top"
            → of the "Stack".
            
            
        2. "Pop()" 
            → "Removes" and "Return" 
            → the "Element"
            → from the "Top"
            → of the "Stack".
           
            
        3. "Peek()"
            → "Get" an "Element"
            → from the "Top"
            → of the "Stack"
            → "Without Removing It".
            
            
        4. "Clear()"
            → "Removes All Elements"
            → from the "Stack".
            
        5. "Count" Property
            → "Get" the "Number"
            → of "Stack Elements".
           
        
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;

public class Stacks
{

    // ▬ "RunStacks()" Method ▬
    public static void RunStacks()
    {
       // ▼ "Create" an "Object/Instance" of the "Stack" Class ▼
       Stack<string> stack1 = new Stack<string>();
       
       // ▼ "Push" ("Add")  an "Element" to the "Stack" ▼
       stack1.Push("a");
       stack1.Push("b");
       stack1.Push("c");
       
       
       // ▼ "Check"/"Count" the "Number" of "Elements" in the "Stack" ▼
       Console.WriteLine("The Stack contain " + stack1.Count + " Elements");
    }
    
    
    //───────────────────────────────────────────────────────
    /*  ▐ "Problem": "Balanced Braces" ▐        
         
            • Given 
                → a "String" of "Braces",
                → "Determine" if the "Braces" are "Balanced".  
            
            • "Return" 
                → "True" if the "Braces" are "Balanced" and
                → "False" if the "Braces" are "Unbalanced".
     */ 
    
    // ▬ "IsBalanced()" Method ▬
    public static bool IsBalanced(string inputString)
    {
        // ▼ "Creating" → "Objects/Instances" of the "Stack" Class ▼
        Stack<char> stackOfClosingBraces = new Stack<char>();
        Stack<char> stackOfOpeningBraces = new Stack<char>();

        
        // ▼ "Iterating" over the "Input String" of "Braces" ▼
        foreach(char character in inputString)
        {
            // ▼ "Check" if the "Closing Braces" are "Balanced" ▼
            if(character == '}' || character == ']' || character == ')')
            {
                // ▼ "Push" ("Add") the "Closing Braces" to the "Stack" ▼
                stackOfClosingBraces.Push(character);
            }
        }
        
        
        // ▼ "Revers Iteration" over the "Input String" of "Braces" ▼
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            // ▼ Check if the "Opening Braces" are "Balanced" ▼
            if(inputString[i] == '{' || inputString[i] == '[' || inputString[i] == '(')
            {
                // ▼ "Push" ("Add") the "Opening Braces" to the "Stack" ▼
                stackOfOpeningBraces.Push(inputString[i]);
            }
        }
        
        
        // ▼ "Check" if the "Stack Elements" are "Even" 
        //      → the "Braces" are "Not Balanced" ▼
        if((stackOfClosingBraces.Count + stackOfOpeningBraces.Count) % 2 != 0)
        {
            return false;
        }
        
        
        while(stackOfClosingBraces.Count != 0)
        {
            // ▼ "Storing" the "Characters" ▼
            char closingBrace = stackOfClosingBraces.Pop();
            char openingBrace = stackOfOpeningBraces.Pop();
            
            
            // ▼ "Check" the "Braces Match" ▼
            if(closingBrace == '}' && openingBrace == '{' ||
               closingBrace == ']' && openingBrace == '[' || 
               closingBrace == ')' && openingBrace == '('
               )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        return true;
    }
    
    
    
    
    // ▬ "RunStacks2()" Method ▬
    public static void RunStacks2()
    {
       // ▼ "Call" the "IsBalanced()" Method
       //     → to "Check" if the "Braces" are "Balanced" ▼
       Console.WriteLine
       (
           "Stack is Balanced: " + 
           IsBalanced("{{[]}}").ToString()
        ); 
       
       
       Console.WriteLine
       (
           "Stack is Balanced: " + 
           IsBalanced("(((]").ToString()
       );



       Console.WriteLine();
    }
    
    
    
    
    // ▬ "RunStacks3()" Method ▬
    public static void RunLastInFirstOut()
    {
        // ▼ Creating an "Object/Instance" of the "LastInFirstOut" Class ▼
        LastInFirstOut LastInFirstOut = new LastInFirstOut();
       
        // ▼ "Add" ("Push") "Elements" to the "Stack" ▼
        LastInFirstOut.Push(1);
        LastInFirstOut.Push(2);
        LastInFirstOut.Push(3);
       
        // ▼ "Remove" and "Return" ("Pop") "Elements" from the "Top" of the"Stack" ▼
        Console.WriteLine(LastInFirstOut.Pop());
        Console.WriteLine(LastInFirstOut.Pop());
        Console.WriteLine(LastInFirstOut.Pop());
    }
}






// ▬ "LastInFirstOut" Class ▬
public class LastInFirstOut
{
    // ▼ "Properties" ▼
    const int MAX = 1000;   // ◄◄ "Constant" ◄◄
    int top;
    
    
    // ▼ "Object Array"
    //      → to "Store" the "Elements"
    //      → "Added" to the "Stack" ▼
    object[] stack = new object[MAX];
    
    
    
    // ▬ "Constructor" ▬
    public LastInFirstOut()
    {
        top = -1; // ◄◄  "Stack" is "Empty" ◄◄ 
    }
    
    
    
    // ▬ "Push()" Method
    //      → to "Add" an "Element" to the "Stack" ▬
    public void Push(object obj)
    {
        // ▼ "Check" ▼
        if(top < MAX)
        {
            // ▼ "Set" the "Element"
            //      → to the "Top" of the "Stack" ▼
            stack[++top] = obj;
        }
    }
    
    
    
    // ▬ "Pop()" Method
    //      → to "Remove" an "Element" from the "Stack" ▬
    public object Pop()
    {
        // ▼ "Check" if the "Stack" is "Not Empty" ▼
        if(top >= 0)
        {
            // ▼ "Get" the "Element"
            //      → from the "Top" of the "Stack"
            object o = stack[top];
            top--;
            return o;
        }
        else
        {
            return -1; // 
        }
    }
    
    
    
    // ▬ "Peek()" Method
    //      → to "Get" an "Element" from the "Stack" ▬
    public object Peek()
    {
        // ▼ "Get" the "Element" from the "Top" ▼
        return stack[top];
    }
} 