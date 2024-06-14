/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "CREATIONAL" •
                    ────────────────────
                   • "ABSTRACT FACTORY" •

       


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



  ▬ The "Abstract Factory" Design Pattern 
    → lets us "Create Objects" 
    → "Wthout Specifying" their "Type".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.creational;



//──────────────────────────────────────────────────────────────
// ▬ (1)  "Abstract Factory" - "IMobile" Interface  ▬
public interface IMobile
{
    // ▬ "Methods" ▬
    IAndroid GetAndroidPhone();
    IiOS GetIOSPhone();
}




//──────────────────────────────────────────────────────────────
// ▬ (2)  "Concrete Factory" - "Samsung" Class
//          → that "Implements" the "Abstract Factory" (Interface) ▬
public class Samsung : IMobile
{
    // ▬ "GetAndroidPhone()" Overridden Method ▬
    public IAndroid GetAndroidPhone()
    {
        return new SamsungGalaxy();
    }

    // ▬ "GetIOSPhone()" Overridden Method ▬
    public IiOS GetIOSPhone()
    {
        return new SamsungGuru();
    }
}



//──────────────────────────────────────────────────────────────
// ▬ (3-1)  "Abstract Product 1" - "IAndroid" Interface  ▬
public interface IAndroid
{
    // ▬ "Method" ▬
    string GetModelDetails();
}




//──────────────────────────────────────────────────────────────
// ▬ (3-2)  "Abstract Product 2" - "IiOS" Interface ▬
public interface IiOS
{
    // ▬ "Method" ▬
    string GetModelDetails();
}




//──────────────────────────────────────────────────────────────
// ▬ (4-1)  "Concrete Product 1" - "SamsungGalaxy" Class
//          → that "Implements" the "Abstract Product 1" (Interface) ▬
public class SamsungGalaxy : IAndroid
{
    // ▬ "GetModelDetails()" Overridden Method ▬
    public string GetModelDetails()
    {
        return "Model: Samsung Galaxy - RAM: 8GB - Camera: 50MP";
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (4-2)  "Concrete Product 2" - "SamsungGuru" Class
//          → that "Implements" the "Abstract Product 2" (Interface) ▬
public class SamsungGuru : IiOS
{
    // ▬ "GetModelDetails()" Overridden Method ▬
    public string GetModelDetails()
    {
        return "Model: Samsung Guru - RAM: 4GB - Camera: 20MP";
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (5)  "Client2" - "MobileClient" Class ▬
public class MobileClient
{
    // ▼ "Member Variables" ▼
    IAndroid androidPhone;
    IiOS iOSPhone;
    
    
    // ▬ "Constructor" ▬
    public MobileClient(IMobile factory)
    {
        // ▼ Creating an "Android Phone" & "iOS Phone" ▼
        androidPhone = factory.GetAndroidPhone();
        iOSPhone = factory.GetIOSPhone();
    }
    
    
    // ▬ "GetAndroidPhoneDetails()" Method ▬
    public string GetAndroidPhoneDetails()
    {
        return androidPhone.GetModelDetails();
    }
    
    
    
    // ▬ "GetiOSPhoneDetails()" Method ▬
    public string GetiOSPhoneDetails()
    {
        return iOSPhone.GetModelDetails();
    }
}




//──────────────────────────────────────────────────────────────
// ▬ "AbstractFactory" Class for "Testing" ▬
public class AbstractFactory
{
    // ▬ "RunAbstractFactory()" Method ▬
    public static void RunAbstractFactory()
    {
        // ▼ "MobileClient" Object ▼
        IMobile samsungMobilePhon = new Samsung();
        
        // ▼ "MobileClient" Object ▼
        MobileClient samsungClient = new MobileClient(samsungMobilePhon);
        
         
        // ▼ "GetAndroidPhoneDetails()" Method ▼
        Console.WriteLine(samsungClient.GetAndroidPhoneDetails());
        
        // ▼ "GetiOSPhoneDetails()" Method ▼
        Console.WriteLine(samsungClient.GetiOSPhoneDetails());
    }
} 