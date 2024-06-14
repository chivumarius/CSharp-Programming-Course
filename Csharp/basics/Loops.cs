namespace CSharp.basics;

public static class Loops
{
    public static void PrintVariables()
    {
        // ▼ "Create" a "List" of "Strings" ▼
        List<string> list = new List<string>() {"a", "b", "c", "d"};  

        // ▼ "For" Loop ▼
        for(int i = 0; i < list.Count; i++){
            Console.WriteLine(list[i]); 
        }              
    }
}
