/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "XML COMMENTS" •
                    ────────────────

       

    ▬ "XML Comments" in "C#" 
        → are a "Special Form" 
        → of "Comments" 
        → for "Documenting Code". 


        ♦ "They" 
            → are "Written" 
            → in a "Structured Format" 
            → "According" to the "XML Specification" 
            → and are "Used" 
            → to "Generate Automatic" 
            → "Source Code Documentation".



    ▬ "XML Comments" 
        → are Added Before 
        → the "Type Declaration" of "Members":
            •► "Class", 
            •► "Properties", 
            •► "Methods", 
        → and "Other Entities" 
        → in the "Source Code". 



        ♦ "They" 
            → may "Contain Information" 
            → "About" the 
                •► "Purpose", 
                •► "Behavior" 
            → and  "Use" of that "Entity".



    ▬ By Using "XML Comments", 
        → we can "Generate Detailed Documentation" 
        → for our "C# Projects", 
        → which can then be "Accessed" 
        → and "Viewed" 
        → in "IDEs" 
        → or Other "Documentation Tools".

           
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/


namespace CSharp.xml_comments;




/// <summary>
/// This "XMLComments" Class represents a "Simple Example" of "XML Comments" in "C#".
/// </summary>
/// <remarks>
/// The "XMLComments" Class provides a "Basic Demonstration" of how "XML Comments" can be "Used"
/// to "Document C# Code". It Includes a "Method" to "Calculate" the "Sum" of "Two Integers".
/// </remarks>
public class XMLComments
{
    // ▼ "Property" ▼
    /// <summary>
    /// "Get" the "Value" of "Val".
    /// </summary>
    /// <value>"Get" the "Value" of "Val".</value>
    public static string Val { get; }

    
    // ▬ "Add()" Method ▬
    /// <summary>
    /// This "Method Calculates" the "Sum" of "Two Integers".
    /// </summary>
    /// <param name="a">The "First Integer".</param>
    /// <param name="b">The "Second Integer".</param>
    /// <returns>The "Sum" of the "Two Integers".</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    
    
    
    // ▬ "Divide()" Method ▬
    /// <summary>
    /// This "Method Calculates" the "Division" of "Two Integers".
    /// </summary>
    /// <param name="a">The "First Integer".</param>
    /// <param name="b">The "Second Integer".</param>
    /// <returns>The "Division" of the "Two Integers".</returns>
    /// <exception cref="DivideByZeroException">The "Second Integer" is "Zero".</exception>
    /// <see cref="Divide(int, int)"/>
    /// <seealso cref="Divide(int, int)"/>
    public int Divide(int a, int b)
    {
        return a / b;
    }


    // ▬ "PrintMessage()" Method ▬
    /// <summary>
    /// This "Method Prints" a "Message" to the "Console".
    /// </summary>
    /// <typeparam name="message">The Message to be "Printed".</typeparam>
    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
    
    

    // ▬ "RunXMLComments()" Method ▬
    /// <example>
    /// This "Example Demonstrates" how to "Use" the "Add()" Method to "Calculate" the "Sum" of "Two Numbers".
    /// <code>
    /// XMLComments example = new XMLComments ();
    /// int result = example.Add(5, 3);
    /// Console.WriteLine("The sum of 5 and 3 is: " + result);
    /// </code>
    /// </example>
    public static void RunXMLComments()
    {
        
        // ▼ "Create" an "Instance" of the "XMLComments" Class ▼
        XMLComments example = new XMLComments();

        // ▼ "Call" the "PrintMessage()" Method
        //      → to "Display" a "Message" to the "Console" ▼
        example.PrintMessage("This is a message printed from the XMLComments class.");
    }
} 