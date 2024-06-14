/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "STRUCTURAL" •
                    ────────────────────
                        • "BRIDGE" •

       


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




  ▬ "Bridge" Design Pattern 
    → Decouples "Two Classes" 
    → so that they can "Vary Independent".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.structural;


//──────────────────────────────────────────────────────────────
// ▬ (1) "Abstraction Class" - "Message" Abstract Class ▬
public abstract class Message
{
  // ▼ "Properties" ▼
  public ISender Sender { get; set; } 
  public  string Subject { get; set; }
  public  string Body { get; set; }
  
  
  // ▬ "Send()" Abstract Method ▬
  public abstract void Send();
}
 



//──────────────────────────────────────────────────────────────
// ▬ (2-1) "Concrete Class 1" - "SystemMessage" Class
//    → that "Extends" the "Abstract Class" ▬
public class SystemMessage : Message
{
  // ▬ "Send()" Overridden Method ▬
  public override void Send()
  {
    // ▼ Calling "SendMessage()" Method ▼
    Sender.SendMessage(Subject, Body); 
  }
}




//──────────────────────────────────────────────────────────────
// ▬ (2-2) "Concrete Class 2" - "UserMessage" Class
//    → that "Extends" the "Abstract Class" ▬
public class UserMessage : Message
{
  // Proprietate publică pentru comentariile utilizatorului
  public string UserComments { get; set; }
  
  // Metoda suprascrisă Send
  public override void Send()
  {
    // Crearea mesajului complet, inclusiv comentariile utilizatorului
    string fullBody = string.Format("{0} - User Comments: {1}", Body, UserComments);
    
    // Apelarea metodei SendMessage a expeditorului pentru a trimite mesajul
    Sender.SendMessage(Subject, fullBody);
  }
}





//──────────────────────────────────────────────────────────────
// ▬ (3) "Interface" - "ISender" Class
//    → that will "Service" the "Bridge" ▬
public interface ISender
{
  // ▬ "Method" ▬
  void SendMessage(string subject, string body);
}






//──────────────────────────────────────────────────────────────
// ▬ (4-1) "Concrete Implementation 1" - "FacebookSender" Class
//          → that "Implements" the "Interface" ▬
public class FacebookSender : ISender
{
  // ▬ "SendMessage()" Method ▬
  public void SendMessage(string subject, string body)
  {
    Console.WriteLine("Facebook - {0} - {1}", subject, body);
  }
}





//──────────────────────────────────────────────────────────────
// ▬ (4-2) "Concrete Implementation 2" - "TwitterSender" Class
//          → that "Implements" the "Interface" ▬
public class TwitterSender : ISender
{
  // ▬ "SendMessage()" Method ▬
  public void SendMessage(string subject, string body)
  {
    Console.WriteLine("Twitter - {0} - {1}", subject, body);
  }
}




//──────────────────────────────────────────────────────────────
// ▬ (4-3) "Concrete Implementation 3" - "InstagramSender" Class
//          → that "Implements" the "Interface" ▬
public class InstagramSender : ISender
{
  // ▬ "SendMessage()" Method ▬
  public void SendMessage(string subject, string body)
  {
    Console.WriteLine("Instagram - {0} - {1}", subject, body);
  }
}




//──────────────────────────────────────────────────────────────
// ▬ "Client2" - "Bridge" Class
//    → that "Uses" the "Bridge" ▬
public class Bridge
{
  // ▬ "RunBridge()" Method ▬
    public static void RunBridge()
    {
        // ▼ "Variables" ▼
        ISender facebookSender = new FacebookSender();
        ISender twitterSender = new TwitterSender();
        ISender instagramSender = new InstagramSender();
        
        // ▼ "Creating" a "Message" ▼
        Message message = new SystemMessage();
        
        // ▼ "Setting" a "Test Message" ▼
        message.Subject = "Test Message";
        message.Body = "This is a Test Message";
        
        // ▼ "Sending Message" to "Facebook" ▼
        message.Sender = facebookSender;
        message.Send();
        
        // ▼ "Sending Message" to "Twitter" ▼
        message.Sender = twitterSender;
        message.Send();
        
        // ▼ "Sending Message" to "Instagram" ▼
        message.Sender = instagramSender;
        message.Send();
        
        
        Console.WriteLine();
        
        
        // ▼ "Creating" a "UserMessage" Message ▼
        UserMessage userMessage = new UserMessage();
        
        // ▼ "Setting" a "Test Message" ▼
        userMessage.Subject = "User Message";
        userMessage.Body = "This is a User Message";
        userMessage.UserComments = "Hello, this is a User Comment";
        
        // ▼ "Sending Message" to "Facebook" ▼
        userMessage.Sender = facebookSender;
        userMessage.Send();
        Console.ReadKey();
    }
} 