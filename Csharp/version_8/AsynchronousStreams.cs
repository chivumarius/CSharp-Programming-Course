/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ─────────────────────
                 • "ASYNCHRONOUS STREAMS" •

       


  ▬ "Asynchronous Streams" 
      → included in "C# 8.0" 
      → are "Methods" 
      → that "Combine" 
        •► "Asynchronous Features" 
      → with the "Concept" of 
        •► "Data Streams". 
  



  ▬ "Asynchronous Streams" 
    → allow the "Definition" 
    → and "Use" of "Methods" 
    → that "Return" 
    → an "Asynchronous Stream" 
    → of "Elements", 
    → "Making" it "Easy" 
    → to "Read" 
    → and "Process Data Asynchronously". 




  ▬ These are "Useful" 
    → in "Situations" 
    → where "Reading" or "Processing Data" 
    → is "Expensive" 
    → and "Might Block" 
    → the "Main Application Thread", 
    → but can be "Better Handled" 
    → in an "Asynchronous Fashion".



  ▬ With "Asynchronous Streams", 
      → we can "Asynchronously Iterate" 
      → through the "Elements" 
      → of a "Data Stream" 
      → using the 
        •► "await foreach" Statement. 


        ♦ It "Provides" 
          → a "Simple" and "Efficient Interface" 
          → for "Working" with "Large Volumes" 
          → of "Data" 
          → or "Operations" involving "Significant Delays". 

  ▬ Essentially, "Asynchronous Streams" 
      → bring "Flexibility" 
      → and "Performance" 
      → to "C# Application Development" 
      → by allowing "Data" 
      → to be "Manipulated" 
      → as an "Asynchronous Stream".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


//──────────────────────────────────────────────────────────────
// ▬ "AsynchronousStreams" Class ▬
public class AsynchronousStreams
{
  // ▬ "GenerateSequenceOfIntegers()" Method ▬
  public static async IAsyncEnumerable<int> GenerateSequenceOfIntegers()
  {
    // ▼ "For Loop" ▼
    for (int i = 0; i < 10; i++)
    {
      await Task.Delay(50);
      yield return i;  
    }
  }
   
  // ▬ "RunAsynchronousStreams()" Method ▬
  public static async Task RunAsynchronousStreams()
  {
    await foreach (var number in GenerateSequenceOfIntegers())
    {
      Console.Write(number + ", ");
    }
  }
    
  // ▬ "Main" Method ▬
  public static async Task Main(string[] args)
  {
    await RunAsynchronousStreams();
  }
  
  
  
  // ▬ "RunAsynchronousStreams()" Method ▬
  public static void RRunAsynchronousStreams()
  {
    RunAsynchronousStreams().Wait();
  }
}