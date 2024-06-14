/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "CREATIONAL" •
                    ────────────────────
                    • "FACTORY  METHOD" •

       


  ▬ A "Design Pattern" 
    → is a "General Reusable Solution" 
    → to a "Frequent Problem" 
    → in "Software Engineering".



  ▬ "Creational" Design Patterns 
    → are "Used" 
    → to "Create Objects".



  ▬ There Contain "2 Main Ideas":
    (1) "Encapsulation"
    
    (2) "Hiding" how "Instances" 
        → of these "Classes" 
        → are "Created" 
        → and "Combined".



  ▬ The "Factory" Method Design Pattern 
    → "Creates Objects" 
    → "Without Specifying" the "Exact Classes" 
    → to "Create".
  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.creational;



//──────────────────────────────────────────────────────────────
// ▬ (1)  "Abstract Product" - "PlayingCard" Abstract Class  ▬
public abstract class PlayingCard
{
    // ▼ "Properties" ▼
    public abstract string Type { get; set; }
    public abstract int Value { get; set; }
    public abstract string Suit { get; set; }
}




//──────────────────────────────────────────────────────────────
// ▬ (2-1)  "Concrete Product 1" - "HoylePlayingCard" Class
//          → that "Extends" the "Abstract Product" (Abstract Class) ▬
public class HoylePlayingCard : PlayingCard
{
    // ▼ "Members Variables" ▼
    private string type;
    private int value; 
    private string suit;
    
    
    
    // ▬ "Constructor" ▬
    public HoylePlayingCard(int value, string suit)
    {
        type = "PlayingCard";
        this.value = value;
        this.suit = suit;
    }

    
    
    // ▼ "Type" Override Property ▼
    public override string Type
    {
        get { return type; }
        set { this.type = value; } 
    }
    
    
    // ▼ "Value" Override Property ▼
    public override int Value 
    {
        get { return value; } 
        set { this.value = value; } 
    }
    
    
    // ▼ "Suit" Override Property ▼
    public override string Suit
    {
        get { return suit; }
        set { this.suit = value; } 
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (2-2)  "Concrete Product 2" - "CongressPlayingCard" Class
//          → that "Extends" the "Abstract Product" (Abstract Class) ▬
public class CongressPlayingCard : PlayingCard
{
    // ▼ "Members Variables" ▼
    private string type;
    private int value; 
    private string suit;
    
    
    
    // ▬ "Constructor" ▬
    public CongressPlayingCard(int value, string suit)
    {
        type = "Congress";
        this.value = value;
        this.suit = suit;
    }
    
    
    
    // ▼ "Type" Override Property  ▼
    public override string Type
    {
        get { return type; }
        set { this.type = value; } 
    }
    
    
    // ▼ "Value" Override Property ▼
    public override int Value 
    {
        get { return value; } 
        set { this.value = value; } 
    }
    
    
    // ▼ "Suit" Override Property ▼
    public override string Suit
    {
        get { return suit; }
        set { this.suit = value; } 
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (3)  "Factory / Creator" - "Card Factory" Abstract Class  ▬
public abstract class CardFactory
{
    // ▬ "Abstract Method" ▬
    public abstract PlayingCard GetPlayingCard();
}






//──────────────────────────────────────────────────────────────
// ▬ (4-1)  "Concrete Factory/Creator 1" - "HoyleFactory" Class
//          → that "Extends" the "Factory/Creator" (Abstract Class) ▬
public class HoyleFactory : CardFactory
{
    // ▬ "Members Variables" ▬
    private string type;
    private int value;
    private string suit;
    
    
    
    // ▬ "Constructor" ▬
    public HoyleFactory(int value, string suit)
    {
        this.value = value;
        this.suit = suit;
    }
    
    
    
    // ▼ "GetPlayingCard()" Override Method ▼
    public override PlayingCard GetPlayingCard()
    {
        return new HoylePlayingCard(value, suit);
    }
}   





//──────────────────────────────────────────────────────────────
// ▬ (4-2)  "Concrete Factory/Creator 2" - "CongressFactory" Class
//          → that "Extends" the "Factory/Creator" (Abstract Class) ▬
public class CongressFactory : CardFactory
{
    // ▬ "Members Variables" ▬
    private string type;
    private int value;
    private string suit;
    
    
    
    // ▬ "Constructor" ▬
    public CongressFactory(int value, string suit)
    {
        this.value = value;
        this.suit = suit;
    }
    
    
    
    // ▼ "GetPlayingCard()" Override Method ▼
    public override PlayingCard GetPlayingCard()
    {
        return new CongressPlayingCard(value, suit);
    }
}   






//──────────────────────────────────────────────────────────────
// ▬ (5) "Client2" - "FactoryMethod" Class
//          → for "Testing" ▬
public class FactoryMethod
{
    // ▬ "RunFactoryMethod()" Method ▬
    public static void RunFactoryMethod()
    {
        // ▼ "CardFactory" Object ▼
        CardFactory factory = null;
        
        // ▼ "Message" in "Console" ▼
        Console.WriteLine("Enter the Card Type you would like to create: ");

        // ▼ Saving "Input Entered" in "Console" ▼
        string card = Console.ReadLine();
        
        
        // ▼ "Switch" Statement ▼
        switch (card.ToLower())
        {
           case "hoyle": 
                factory = new HoyleFactory(5, "Spades");
                break; 
           
           case "congress":
                factory = new CongressFactory(10, "Hearts");
                break;
           
           default:
                break;
        } 
        
        // ▼ "PlayingCard" Object ▼
        PlayingCard playingCard = factory.GetPlayingCard();
        
        // ▼ "Output" in "Console" ▼
        Console.WriteLine("Card Type' {0} \n Card Value: {1} \n Card Suit: {2}", playingCard.Type, playingCard.Value, playingCard.Suit);
        
        // ▼ "Read Key" in "Console" ▼
        Console.ReadKey();
    }
} 