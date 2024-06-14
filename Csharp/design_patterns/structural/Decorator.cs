/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "STRUCTURAL" •
                    ────────────────────
                      • "DECORATOR" •

       


  ▬ A "Design Pattern" 
    → is a "General Reusable Solution" 
    → to a "Frequent Problem" 
    → in "Software Engineering".



  ▬ "Structural" Design Patterns 
    → "Define" the "Relationships" 
    → between "Objects"
    → and "Allow Us" 
    → to "Compose Objects" 
    → in "Different Ways" 
    → to "Create New Functionality".


    ♦ They "Help" 
      → to "Ensure" that "Even" 
      → if "One Part Changes", 
      → the "Entire Structure" of the "Code" 
      → does "Not Need" to "Change".


    ♦ It "Focuses" 
      → on "Inheritance"
      → (which is a "Primary Component" 
      → of "Structural" Design Patterns).




  ▬ "Decorator" Design Pattern 
    → "Lets" an "Object's Behavior" 
    → "Get Extended" 
    → at "Run Time".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.structural;


//──────────────────────────────────────────────────────────────
// ▬ (1) "Interface" - "ICar" Interface ▬
public interface ICar
{
    // ▼ "Properties" ▼
    string Type { get; }
    double Price { get; }
}




//──────────────────────────────────────────────────────────────
// ▬ (2) "Concrete Class" - "Car" Class
//        → that "Implements" the "Interface" ▬
public class Car : ICar
{
  // ▼ "Type" Property ▼
  public string Type
  {
    get { return "Tesla"; }
  }

  // ▼ "Price" Property ▼
  public double Price
  {
    get { return 1000000; }
  }
}



//──────────────────────────────────────────────────────────────
// ▬ (3) "Abstract Class" - "VehicleDecorator" Class
//        → that "Implements" the "Interface" ▬
public abstract class VehicleDecorator : ICar
{
  // ▼ "Member Variables" ▼
  private ICar vehicle;
  
  
  // ▬ "Constructor" ▬
  public VehicleDecorator(ICar vehicle)
  {
    this.vehicle = vehicle;
  }
  
  
  // ▼ "Type" Property Implementation ▼
  public string Type {
    get { return vehicle.Type; }
  }
  
  
  // ▼ "Price" Property Implementation ▼
  public double Price {
    get { return vehicle.Price; }
  }
}




//──────────────────────────────────────────────────────────────
// ▬ (4) "Concrete Class" - "SpecialOffer" Class
//          → that "Extends" the "Abstract Class" ▬
public class SpecialOffer : VehicleDecorator
{
  // ▬ "Constructor"
  //    → that "Calls" the "Base Class Constructor" ▬ 
  public SpecialOffer(ICar vehicle) : base(vehicle)
  { }
  
  
  // ▼ "Properties" ▼
  public int DiscountPercentage { get; set; } // Adăugare setter pentru DiscountPercentage
  public string Offer { get; set; } // Adăugare setter pentru Offer

  public new double Price // Folosim "new" pentru a ascunde Price-ul din clasa de bază și a-l suprascrie cu noua funcționalitate
  {
    get
    {
      // ▼ "Variables" ▼
      double price = base.Price;
      int percentage = 100 - this.DiscountPercentage;
      
      // ▼ "Return Statement" ▼
      return Math.Round((price * percentage) / 100, 2);
    }
  }
}





//──────────────────────────────────────────────────────────────
// ▬ (5) "Client2" - "Decorator" Class
//    → that "Decorates" an "Object" ▬
public class Decorator
{
  // ▬ "RunDecorator()" Method ▬
  public static void RunDecorator()
  {
    // ▼ "Create" a "Car" Object ▼
    Car car = new Car();

    // ▼ "Output" ▼
    Console.WriteLine($"Tesla - best price is: {car.Price}");

    // ▼ "Create" a "Special Offer" Object ▼
    SpecialOffer offer = new SpecialOffer(car);

    // ▼ "Set" a "Discount Percentage" ▼
    offer.DiscountPercentage = 50;
    offer.Offer = "50% Discount";

    // ▼ "Output" ▼
    Console.WriteLine($" * {offer.Offer} discounted on Tesla cars and new price is: {offer.Price}");
  }
}