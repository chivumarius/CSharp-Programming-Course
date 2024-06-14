/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "BEHAVIORAL" •
                    ────────────────────
                     • "INTERPRETER" •

       


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





  ▬ "Interpreter" Design Pattern 
    → allows the "Interpretation" 
    → and "Evaluation" 
    → of "Expressions" 
    → or "Languages" 
    → "Defined" by "Objects".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.behavioral;



//──────────────────────────────────────────────────────────────
// ▬ (1) "RomanNumerals" Class ▬
public class RomanNumerals
{
    // ▼ "Rewrite Properties" ▼
    public int Input { get; set; }
    public string Output { get; set; }
  
    
    // ▬ "Constructor" ▬
    public RomanNumerals(int baseTenNumber)
    {
        Input = baseTenNumber;
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (2) "Abstract Class" - "Expression" Class ▬
public abstract class Expression
{
    // ▬ "Method" ▬
    public abstract void Interpret(RomanNumerals baseTenNumber);
}




//──────────────────────────────────────────────────────────────
// ▬ (3-1) "Concrete Class 1" - "RomanOneExpression" Class
//          → responsible for "1 Digit"
//          → that "Extends" the "Abstract Class" ▬
public class RomanOneExpression : Expression
{
    // ▼ "Constants" ▼
    const string ONE = "I";
    const string TWO = "II";
    const string THREE = "III";
    const string FOUR = "IV";
    const string FIVE = "V";
    const string SIX = "VI";
    const string SEVEN = "VII";
    const string EIGHT = "VIII";
    const string NINE = "IX";
    const string TEN = "X";
    const string ELEVEN = "XI";
    const string TWELVE = "XII";
    const string THIRTEEN = "XIII";
    const string FOURTEEN = "XIV";
    const string FIFTEEN = "XV";
    const string SIXTEEN = "XVI";
    const string SEVENTEEN = "XVII";
    const string EIGHTEEN = "XVIII";
    const string NINETEEN = "XIX";
    
    
    
    // ▬ "Interpret()" Overriden Method ▬
    public override void Interpret(RomanNumerals baseTenNumber)
    {
        // ▼ "While" - "Input - 9" ▼
        while ((baseTenNumber.Input - 9) >= 0)
        {
            baseTenNumber.Output += NINE;
            baseTenNumber.Input -= 9;
        }
        
        
        // ▼ "While" - "Input - 5" ▼
        while ((baseTenNumber.Input - 5) >= 0)
        {
            baseTenNumber.Output += FIVE;
            baseTenNumber.Input -= 5;
        }
        
        
        // ▼ "While" - "Input - 4" ▼
        while ((baseTenNumber.Input - 4) >= 0)
        {
            baseTenNumber.Output += FOUR;
            baseTenNumber.Input -= 4;
        }
        
        
        // ▼ "While" - "Input - 3" ▼
        while ((baseTenNumber.Input - 3) >= 0)
        {
            baseTenNumber.Output += THREE;
            baseTenNumber.Input -= 3;
        }
        
        
        // ▼ "While" - "Input - 2" ▼
        while ((baseTenNumber.Input - 2) >= 0)
        {
            baseTenNumber.Output += TWO;
            baseTenNumber.Input -= 2;
        }
        
        
        // ▼ "While" - "Input - 1" ▼
        while ((baseTenNumber.Input - 1) >= 0)
        {
            baseTenNumber.Output += ONE;
            baseTenNumber.Input -= 1;
        }
    }
}






//──────────────────────────────────────────────────────────────
// ▬ (3-2) "Concrete Class " - "RomanTenExpression" Class
//          → that "Extends" the "Abstract Class" ▬
public class RomanTenExpression : Expression
{
    // ▼ "Constants" ▼
    const string TEN = "X";
    const string TWENTY = "XX";
    const string THIRTY = "XXX";
    const string FORTY = "XL";
    const string FIFTY = "L";
    const string NINETY = "XC";
    
    
    
    
    
    // ▬ "Interpret()" Overriden Method ▬
    public override void Interpret(RomanNumerals baseTenNumber)
    {
        // ▼ "While" - "Input - 90" ▼
        while ((baseTenNumber.Input - 90) >= 0)
        {
            baseTenNumber.Output += NINETY;
        }
        
        
        
        // ▼ "While" - "Input - 50" ▼
        while ((baseTenNumber.Input - 50) >= 0)
        {
            baseTenNumber.Output += FIFTY;
            baseTenNumber.Input -= 50;
        }
        
        
        // ▼ "While" - "Input - 40" ▼  
        while ((baseTenNumber.Input - 40) >= 0)
        {
            baseTenNumber.Output += FORTY;
            baseTenNumber.Input -= 40;
        }
        
        
        // ▼ "While" - "Input - 30" ▼
        while ((baseTenNumber.Input - 30) >= 0)
        {
            baseTenNumber.Output += THIRTY;
            baseTenNumber.Input -= 30;
        }
        
        
        // ▼ "While" - "Input - 20" ▼
        while ((baseTenNumber.Input - 20) >= 0)
        {
            baseTenNumber.Output += TWENTY;
            baseTenNumber.Input -= 20;
        }
        
        
        // ▼ "While" - "Input - 10" ▼
        while ((baseTenNumber.Input - 10) >= 0)
        {
            baseTenNumber.Output += TEN;
            baseTenNumber.Input -= 10;
        }
    }
}





//──────────────────────────────────────────────────────────────
// ▬ "Interpreter" Class ▬
public class Interpreter
{
    // ▬ "RunInterpreter()" Method ▬
    public static void RunInterpreter()
    {
       // ▼ "Expression Array" ▼
       Expression[] expressions = new Expression[]
       {
           new RomanTenExpression(),
           new RomanOneExpression()
       };
       
        
        // ▼ "Variable" ▼
        var context = new RomanNumerals(56);
        
        // ▼ "Loop" ▼
        foreach (var exp in expressions)
        {
            exp.Interpret(context);
        }
        
        
        // ▼ "Output" ▼
        Console.WriteLine("The Equivalent in Roman Letters of the Number '56' is: " + context.Output);
    }
} 