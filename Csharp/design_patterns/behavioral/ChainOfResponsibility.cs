/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "BEHAVIORAL" •
                    ────────────────────
              • "CHAIN" OF "RESPONSIBILITY" •

       


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





  ▬ "Chain" of "Responsibility" Design Pattern 
    → "Delegates Commands" 
    → to a "Chain" of "Objects" 
    → that "Process" those "Commands".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.behavioral;



//──────────────────────────────────────────────────────────────
// ▬ (1) "Abstract  Class" "HandlerBase" Class ▬
public abstract class HandlerBase
{
    // ▼ "Properties" ▼
    public HandlerBase NextContestant { get; private set; }
    public ContextObject Question { get; private set; }
    
    
    // ▬ "Constructor" ▬
    public HandlerBase(HandlerBase nextHandler, ContextObject question)
    {
        NextContestant = nextHandler;
        Question = question;
    }
    
    
    // ▬ "HandleRequest()" AbstractMethod ▬
    public abstract void HandleRequest();
}





//──────────────────────────────────────────────────────────────
// ▬ (2) "Object Class" - "ContextObject" Class ▬
public class ContextObject
{
    // ▼ "Property" ▼
    public string? Question { get; set; }
}





//──────────────────────────────────────────────────────────────
// ▬ (3-1) "Concrete Class" - "ContestantOne" Class
//          → that "Extends" the "Abstract  Class" ▬
public class ContestantOne : HandlerBase
{
    // ▬ "Constructor" ▬
    public ContestantOne(HandlerBase nextHandler, ContextObject question) : base(nextHandler, question) { }
    
    
    // ▬ "HandleRequest()" Method ▬
    public override void HandleRequest()
    {
        Console.WriteLine("Question : {0}", Question.Question.ToString());
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Waiting for Contestant One to Respond...");
        
        // ▼ "Sleep" foi "3 seconds" ▼
        Thread.Sleep(3000);
        
        Console.Write("\t no Response from Contestant One...");
        
        // ▼ "Calling" the "HandleRequest()" Method ▼
        NextContestant.HandleRequest(); 
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (3-2) "Concrete Class" - "ContestantTwo" Class
//          → that "Extends" the "Abstract  Class" ▬
public class ContestantTwo : HandlerBase
{
    // ▬ "Constructor" ▬
    public ContestantTwo(HandlerBase nextHandler, ContextObject question) : base(nextHandler, question) { }
    
    
    // ▬ "HandleRequest()" Method ▬
    public override void HandleRequest()
    {
        Console.WriteLine("Question : {0}", Question.Question.ToString());
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Waiting for Contestant Two to Respond...");
        
        // ▼ "Sleep" foi "3 seconds" ▼
        Thread.Sleep(3000);
        
        Console.Write("\t no Response from Contestant Two...");
        
        // ▼ "Calling" the "HandleRequest()" Method ▼
        NextContestant.HandleRequest(); 
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (3-3) "Concrete Class" - "ContestantThree" Class
//          → that "Extends" the "Abstract  Class" ▬
public class ContestantThree : HandlerBase
{
    // ▬ "Constructor" ▬
    public ContestantThree(HandlerBase nextHandler, ContextObject question) : base(nextHandler, question)
    {
    }

    // ▬ "HandleRequest()" Method ▬
    public override void HandleRequest()
    {
        if (NextContestant != null)
        {
            Console.WriteLine("Question : {0}", Question.Question);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Waiting for Contestant Three to Respond...");

            // ▼ "Sleep" for "3 seconds" ▼
            Thread.Sleep(3000);

            Console.Write("\t no Response from Contestant Three...");

            // ▼ "Calling" the "HandleRequest()" Method ▼
            NextContestant.HandleRequest();
        }
        else
        {
            Console.WriteLine("End of the chain reached. No more contestants.");
        }
    }
}




//──────────────────────────────────────────────────────────────
// ▬ "ChainOfResponsibility" Class ▬
public class ChainOfResponsibility
{
    // ▬ "RunChainOfResponsibility()" Method ▬
    public static void RunChainOfResponsibility()
    {
        // ▼ "Creating" the "ContextObject" Object ▼
        ContextObject question = new ContextObject()
        {
            Question = "What is the name of the first president of the USA?"
        };
    
        // ▼ "Creating" the "ContestantThree" Object ▼    
        ContestantThree contestantThree = new ContestantThree(null, question);
    
        // ▼ "Creating" the "ContestantTwo" Object ▼
        ContestantTwo contestantTwo = new ContestantTwo(contestantThree, question);
    
        // ▼ "Creating" the "ContestantOne" Object ▼
        ContestantOne contestantOne = new ContestantOne(contestantTwo, question);
    
    
        // ▼ "Calling" the "HandleRequest()" Method ▼
        contestantOne.HandleRequest();
    }
}