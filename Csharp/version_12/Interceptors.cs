/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 12.0" (2023) •
                    ──────────────────────
                      • "INTERCEPTORS" •

       


    ▬ "Interceptors" in "C# 12"
        → allow "Programmers"
        → to "Add Additional Behavior"
        → around "Method Calls"
        → and "Property Accesses"
        → at "Runtime"
        → without "Changing" the "Original Code".
    
    
    ▬ "Interceptors" are "Useful"
        → for "Adding Functionality"
        → such as:
            •► "Logging",
            •► "Validation" or
            •► "Caching" to "Applications".
    
    
    ▬ Through "Interceptors",
        → "Developers" can "Manipulate"
        → and "Control" the "Flow"
        → of "Code Execution"
        → in a "Flexible" and "Dynamic Way".
    


    ▬ "See":
      •► https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12
  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

using System.Reflection;

namespace CSharp.version_12;

//──────────────────────────────────────────────────────────────
// ▬ "ICalculator" Interface ▬
public interface ICalculator
{
    int Add(int a, int b);
}

//──────────────────────────────────────────────────────────────
// ▬ "Calculator" Class ▬
public class Calculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

//──────────────────────────────────────────────────────────────
// ▬ "CalculatorInterceptor" Class ▬
public class CalculatorInterceptor : DispatchProxy
{
    private object _target;

    public static T Create<T>(T target)
        where T : class
    {
        object proxy = Create<T, CalculatorInterceptor>();
        ((CalculatorInterceptor)proxy).SetTarget(target);
        return (T)proxy;
    }

    private void SetTarget(object target)
    {
        _target = target;
    }

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        // Logic before method execution
        Console.WriteLine(
            $"Intercepting call to {targetMethod.Name} with arguments: {string.Join(", ", args)}"
        );

        // Execute the actual method
        var result = targetMethod.Invoke(_target, args);

        // Logic after method execution
        Console.WriteLine($"Method {targetMethod.Name} returned: {result}");

        return result;
    }
}

//──────────────────────────────────────────────────────────────
// ▬ "Interceptors" Class ▬
public class Interceptors
{
    // ▬ "RunInterceptors()" Method ▬
    public static void RunInterceptors()
    {
        // Create an instance of Calculator
        ICalculator calculator = new Calculator();

        // Create a proxy instance of Calculator using CalculatorInterceptor
        ICalculator proxiedCalculator = CalculatorInterceptor.Create(calculator);

        // Call the intercepted method
        int result = proxiedCalculator.Add(3, 4);
        Console.WriteLine($"Result: {result}");
    }
}
