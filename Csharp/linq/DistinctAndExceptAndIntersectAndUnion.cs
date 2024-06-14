/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                            • "LINQ - LANGUAGE INTEGRATED QUERY" •
                            ──────────────────────────────────────
                • "DISTINCT()", "EXCEPT()", "INTERSECT()" & "UNION()" METHODS •               
            
       
       


    ▬ "Distinct()" Method in "LINQ"
        → is "Used" 
        → to "Remove Duplicates" 
        → from a "Sequence" of "Elements". 
        
        
    ▬ "Distinct()" Method 
        → "Returns" a "New Sequence" 
        → "Containing Only Distinct Elements", 
        → Without "Replicas". 
    
    
    ▬ "Distinct()" Method is "Useful" 
        → when we "Want" to "Work" 
        → "Only" with the "Unique Elements" 
        → in a "Collection" or "Dataset".




    ▬ "Except()" Method in "LINQ"
        → is "Used" 
        → to "Return" the "Difference" 
        → between "Two Sequences". 
    
    
    ▬ "Except()" Method 
        → "Removes" from the "First Sequence" 
        → the "Elements" 
        → that are "Also Present" ("Duplicates") 
        → in the "Second Sequence", 
        → "Returning" a "New Sequence" 
        → that "Contains" 
        → "Only" the "Elements" 
        → that are in the "First Sequence" 
        → and "Not" in the "Second". 
        
        
        
    ▬ "Except()" Method is "Useful" 
        → for "Filtering Elements" 
        → in "One Sequence" 
        → "Based" on the "Contents" 
        → of "Another Sequence".




    ▬ "Intersect()" Method in "LINQ" 
        → "Returns Elements" 
        → that are "Common" to "Two Distinct Sequences",
        → it "Returns" a "Sequence" 
        → that "Contains" 
        → "Only" the "Elements" 
        → that "Appear" in "both" 
        → of the "Original Sequences". 
    
        
        ♦ If an "Element" 
            → "Occurs" in "Both sSequences", 
            → "It" will be "Present" 
            → "Only Once" in the "Resulting Sequence". 
    
    
    
    
    ▬ "Intersect()" Method 
        → is "Useful" 
        → when you "Want" to "Find" 
        → the "Intersection" of T"wo Data Sets".




    ▬ "Union()" Method in "LINQ" 
        → is "Used" 
        → to "Join Two Sequences" 
        → into a "Single Distinct Sequence", 
        → "Eliminating Duplicates". 
    
    
    ▬ "Union()" Method 
        → "Returns" a "New Sequence" 
        → Containing "All Distinct Elements" 
        → from "Both Original Sequences". 
        
        
        ♦ In "Other Words", "Union"  
            → "Combines" the "Elements" 
            → of the "Two Sequences" 
            → and "Removes" the "Duplicates" 
            → to "Produce" a "Single Sequence". 
    
    
    
    ▬ "Union()" Method is "Useful" 
        → when we "Want" to "Combine" 
        → "Two Datasets" into "One" 
        → "Without" having "Duplicate Items" 
        → in the "Result".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;


//──────────────────────────────────────────────────────────────
// ▬ "DistinctAndExceptAndIntersectAndUnion" Class ▬
public class DistinctAndExceptAndIntersectAndUnion
{
    
    // ▬ "RunDistinctAndExceptAndIntersectAndUnion()" Method ▬
    public static void RunDistinctAndExceptAndIntersectAndUnion()
    {
        // ▼  Creating "Lists" of "Integers"  ▼
        List<int> collection1 = new List<int> { 1, 1, 2, 2, 3, 4, 5 };
        List<int> collection2 = new List<int> { 4, 5, 6, 7, 8 };
        
        
        
        //--------------- "UNION()" METHOD ---------------
        Console.WriteLine("Union() Method -> to Combine 'Two Collection' without 'Duplicates' into a 'Single Collection': ");
        
        
        // ▼  "Union()" Method  ▼
        IEnumerable<int> union = collection1.Union(collection2);
        
        // ▼  "Print" Method  ▼
        foreach (int item in union)
        {
            Console.Write(item + ", ");
        }
        
        
        
        
        
        //--------------- "INTERSECT()" METHOD ---------------
        Console.WriteLine("\n\nIntersect() Method -> to 'Find' the 'Common Elements' of 'Two Collections' : ");
         
        // ▼  "Intersect()" Method  ▼
        IEnumerable<int> intersect = collection1.Intersect(collection2);
        
        // ▼  "Print" Method  ▼
        foreach (int item in intersect)
        {
            Console.Write(item + ", ");
        }
        
        
        
        
        //--------------- "EXCEPT()" METHOD ---------------
        Console.WriteLine("\n\nExcept() Method -> to 'Find' the 'Unique Elements' of a 'First Collection' that are 'Not' in the 'Second Collection': ");
        
        // ▼  "Except()" Method  ▼
        IEnumerable<int> except = collection1.Except(collection2);
        
        // ▼  "Print" Method  ▼
        foreach (int item in except)
        {
            Console.Write(item + ", ");
        }
        
        
        
        
        //--------------- "DISTINCT()" METHOD ---------------
        Console.WriteLine("\n\nDistinct() Method -> to 'Remove Duplicates' from a 'Collection': ");
        
        // ▼  "Distinct()" Method  ▼
        IEnumerable<int> distinct = collection1.Distinct();
        
        // ▼  "Print" Method  ▼
        foreach (int item in distinct)
        {
            Console.Write(item + ", ");
        }
        
        
        
        Console.WriteLine();
    }
} 