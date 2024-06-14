/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "FUNCTIONS" •
                     ───────────────
                     • "ATTRIBUTES" •


       

    ▬ "Attributes" in "C#":
        ♦ "Attributes" 
            → are "Metadata Attached" 
            → to "Program Elements", such as:
                •► "Classes", 
                •► "Methods", 
                •► "Properties", 
            → or even "Other Attributes".
        
        
        ♦ "They" 
            → Provide "Additional Information" 
            → about "Program Elements" 
            → and "Allow Programmers" 
            → to "Add Specific Metadata".
        
        
        ♦ "They" 
            → are "Used" 
            → to "Control Behavior" 
            → During: 
                •► "Compilation", 
                •► "Code Generation", or 
                •► "Program Execution".



    1. "Defining" an "Attribute":
        ♦ An "Attribute" 
            → is "Defined" 
            → "Using" a "Class" 
            → that "Inherits" 
            → from the `System.Attribute` Class.


    2. Using "Predefined Attributes":
        ♦ "C#" comes with "Predefined Attributes" 
            → that "Can" be "Used" 
            → to "Provide Specific Information" 
            → about "Program Elements", such as:
                •► `[Obsolete]`: 
                    → which "Indicates" 
                    → that an "Element" 
                    → is "Outdated" 
                    → and should "Not Be Used";
                    
                •► `[Serializable]`: 
                    → which "Indicates" 
                    → that a "Class" 
                    → can be "Serialized";
                
                •► `[DllImport]`: 
                    → which "Specifies" 
                    → that a "Method" 
                    → is "Implemented" 
                    → in a "Dynamic-Link" Library.


    3. Defining "Custom Attributes":
        ♦ "Programmers" 
            → can "Define"  
            → their "Own Custom Attributes" 
            → by "Inheriting" 
            → from the `System.Attribute` Class.
        
        
        ♦ These "Custom Attributes" 
            → can be "Used" 
            → to "Add Specific Metadata" 
            → to "Projects" 
            → and can "Control Behavior" 
            → "During": 
                •► "Compilation" or 
                •► "Execution".


    4. "Using Attributes":
        ♦ "Attributes" 
            → are "Applied" to "Program Elements"
            → by "Adding" them 
            → "Before"  the "Declaration" 
            → of the "Corresponding Element".
        
        
        ♦ "They" 
            → are "Specified" 
            → within "Square Brackets" [] 
            → and can have "Optional Arguments".


    5. "Accessing Attributes":
        ♦ "Information Provided" 
            → by "Attributes" 
            → can be "Accessed" 
            → during "Program Execution" 
            → using "Reflection".
        
        
        ♦ Thus, "Programmers" 
            → can "Obtain Information" 
            → about "Program Elements" 
            → and can "Adapt" 
            → their "Behavior" 
            → "Based" on the "Attached Attributes".


    6. "Role" of "Attributes":
        ♦ "Attributes" 
            → are "Used" 
            → to "Add Additional Meaning" 
            → to "Program Elements" 
            → and to "Control" their "Behavior" 
            → in "Different Contexts".
        
        
        ♦ "They" 
            → can be "Used" 
            → to "Add Information" about:
                •► "Serialization", 
                •► "Interoperability", 
                •► "Security", 
                •► "Testing" 
            → and much "More".


    7. "Benefits" of "Using Attributes":
        ♦ "Attributes Help" 
            → in "Organizing" 
            → and "Documenting Code" 
            → by "Providing" 
            → Meaningful "Metadata".
        
        
        ♦ "They" 
            → can "Improve" 
                •► the "Modularity" 
                •► and "Extensibility" 
            → of the "Program" 
            → by "Controlling" 
            → the "Dynamic Behavior" 
            → of "Elements".


    ▬ "Proper Use" of "Attributes" in "C# "
        → can "Contribute" 
        → to "Clearer Code Design" 
        → and more "Efficient Program Management".

     ▬ "Syntax" of "Attributes":
        ─────────────────────────
        
            [Attribute_Name(Attribute_Arguments)]
            public class TargetElement
            {
                // Class, Method, Property, or Other Elements
            }
        ─────────────────────────
     
         
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

using System.Diagnostics;
using System.Reflection;

namespace CSharp.Functions;

public class Attributes
{
    // ▼ "Obsolete" Attribute ▼
    [Obsolete("This Method is Obsolete. Please use the NewMethod() Method instead.")]
    void OldMethod()
    {
    }

    void NewMethod()
    {
    }

    // ▼ "Conditional" Attribute ▼
    [Conditional("CONDITION1")]
    void ConditionalAttributeMethod()
    {
    }

    // ▬ "Custom Attribute"
    //      → specifies that "Attribute"
    //      → can be "Used" on "Any Element"
    //      → (Fields, Methods etc) ▬
    [AttributeUsage(AttributeTargets.All)]
    class CustomAttribute : Attribute { }

    // ▼ Using "Custom Attribute" ▼
    class Example
    {
        [CustomAttribute]
        private object exampleObj;
    }

    public void RunAttribute()
    {
        // ▼ Get "Method Type" → using "Reflection" ▼
        MethodInfo methodInfo = typeof(Attributes).GetMethod("OldMethod", BindingFlags.Instance | BindingFlags.NonPublic);

        if (methodInfo != null)
        {
            // ▼ "Gets" the "Attributes Associated" with the "Method" ▼
            object[] attributes = methodInfo.GetCustomAttributes(true);

            // ▼ "Displays Information" about "Each Attribute" ▼
            foreach (object attribute in attributes)
            {
                if (attribute is ObsoleteAttribute)
                {
                    ObsoleteAttribute obsoleteAttribute = (ObsoleteAttribute)attribute;
                    Console.WriteLine("Obsolete Message: " + obsoleteAttribute.Message);
                }
            }
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}
