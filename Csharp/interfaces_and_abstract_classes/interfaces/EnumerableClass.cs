using System.Collections;

namespace CSharp.interfaces_and_abstract_classes.interfaces;



// ▬▬ "Money" Class ▬▬
public class Money
{
    // ▼ "Field" ▼
    public int amount;
}




// ▬▬ "IEnumerator" Interface 
//      → is an "Object"
//      → that "Iterates"
//      → over a "Collection" of "Items" ▬
public class Wallet : IEnumerable
{
    // ▼ "Array" ▼
    Money[] bills = null;
    int openIndex = 0; 
    
    
    // ▬ "Constructor" ▬
    public Wallet()
    {
        // ▼ "Array"  → with "100  Objects" ▼
        bills = new Money[100];
    }
    
    
    
    
    // ▬ "Add()" Method
    //      → responsible for "Adding" the "Money Objects"
    //      → into the "Wallet" ▬
    public void Add(Money bill)
    {
      // ▼ Set the "bills Array" to the "bill" ▼
      bills[openIndex] = bill;
      openIndex++;
    }
    
    
    
    // ▬ "GetEnumerator()" Interface Member Method ▬
    public IEnumerator GetEnumerator()
    {
        // ▼ "Iterate" 
        foreach(Money bill in bills)
        {
            if(bill == null)
            {
                break;
            }
            
            // ▼ "Yield" Keyword
            //      → allows "Iterating"
            //      → through a "Collection"
            //      → without keeping "All Elements"
            //      → in "Memory" at the "Same Time" ▼
            yield return bill; 
        }
    }
}





// ▬▬ "Enumerable" Class ▬▬
public class EnumerableClass
{
    
    // ▬ "RunEnumerable()" Method ▬
    public static void RunEnumerable()
    {
        // ▼ "Create" an "Instance" of "Wallet" Class ▼
        Wallet wallet1 = new Wallet();
        
       
        // ▼ "Call" the "Add()" Method ▼
        wallet1.Add(new Money() { amount = 1 });
        wallet1.Add(new Money() { amount = 5 });
        wallet1.Add(new Money() { amount = 10 });
        wallet1.Add(new Money() { amount = 20 });
        wallet1.Add(new Money() { amount = 50 });
        wallet1.Add(new Money() { amount = 100 });
        
        
        // ▼ "Iterate" through the "Wallet" ▼
        foreach(Money bill in wallet1)
        {
            Console.WriteLine("Bill: " + bill.amount);
        }
    }
}