namespace CSharp.control_flow_statements_and_loops;

public class ForEach_Loop
{

    public static void ForEachMethod()    
    {
        /*
            ♦ "ForEach" Loop 
                → "Iterates Forward" (not Backward)
                → over the "Elements" 
                → of a "Collection" (List, Array).
                
                ♦ "Code" 
                    → is "Executed Once" 
                    → for "Each Element".
                
                ♦ "ForEach" Loop
                    → can be "Written" 
                    → as a "For" Loop.
                
                ♦ "ForEach" Loop
                    → does not Tracks "Index",
                    → it tracks "Element".                    
                    
                ♦ The "Incrementation" 
                    → is "Done" 
                    →in "One Step"
        
            
            ♦ "Syntax":
                foreach (Type VariableName in Collection){
                    Code;
                }
        */
        
        
        // ▼ "Foreach" Loop ▼
        foreach(char s in "Hello"){
            Console.WriteLine(s);
        }
    }    
}