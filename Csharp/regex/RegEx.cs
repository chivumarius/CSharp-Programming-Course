/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "REGEX" •
                ("REGULAR EXPRESSIONS") -
                ───────────────────────

       

    ▬ "RegEx" or "Regular Expression"
        → is a "Special Text String"
        → that Describes a "Search Pattern".
       

    ▬ "Used"
        → to perform 
        →"Find" and "Replace Text" 
        → in "Strings".
        

    
    ▬ "There" are "12 Characters Recognized" 
        → for "REGEX":
        
        "There" are "12 Characters Recognized" 
        → for "REGEX":
        
        1. "\" ("Backslash") 
                → indicates a "Special Character" 
                → or "Overrides" the "Special Meaning" 
                → of a "Character".  


                •► "\d"
                        → "Find" the "Digits" 
                        → in a "String".      
        


        2. "^" ("Caret") 
                → indicates the "Beginning" 
                → of a "Character String",
                → "Find" a "String", 
                → that "Start" with a "Specified Character"
                    
                    •► ^marius 
                        → will be "Selected"
                        → if we "Specify": ^m
                
                → or "Excludes" the "Selection" 
                → of "One" or "More Letters" 
                → in a "Given Range"
                    
                    •► [^c-f]
                        → from the "abcdefghij" String
                        → "cdef" will be "Excluded".
        


                    •► [^\d]
                        → from the "abc123" String
                        → the "123" Digits 
                        → will be "Excluded".




        3. "$" ("Dollar Sign") 
                → indicates the "End" 
                → of a "Character String"
                    
                    •► .*ius$
                        → from the "marius" String
                        → will select "All Strings"
                        → which "End" 
                        → in the" Specified Characters". 



        4. "." ("Dot"/"Period") 
                → represents "Any Character" 
                → "Except" a "New Character",
                → it "Selects All Characters" 
                → on a "Line"

                    •► .
                        → if the Line Contain: abc 123 def
                        → the "Entire Line" 
                        → is "Selected".



        5. "|" ("Vertical Bar"/"Pipe")
                → indicates an "Alternative" 
                → between "Two Expressions":

                    •► ab | d
                        → from the "abcdefg" String
                        → the "abd" Characters
                        → will be "Selected"
                        → from the "Given String".



        6. "?" ("Question Mark")
                → the "Preceding Character" 
                → is "Optional",
                → it "Finds All Characters" 
                → "Added After It":

                    •► I am[n]? Marius
                        → it will "Finnd" 
                        → "I am Marius" String
                        → but will "Not Find"
                        → "I am not Marius" String



        7. "*" ("Asterisk")          
                → indicates that the "Preceding symbol" 
                → or "Group" of "Symbols" 
                → may "Occur" 
                → "Zero" or "More Times". 
                

                ♦ For Example: 
                        •► "a*b" 

                    → would "Find Any String" 
                    → "Starting" with "Zero": 
                        •► "ab" String 
                    → or "More Occurrences" 
                    → of the "a" Letter:
                        •► "abb"
                        •► "aab"
                        •► "aaabbb"



        8. "+" ("Plus Sign")          
                → the "Preceding Character" 
                → may "Appear One" 
                → or "More Times".

                ♦ For Example: 
                        •► "a+b" 

                    → "Finds" the "1st Character" 
                    → and its Duplicates,                  
                    → to which it "Adds" 
                    → cthe "2nd character Found"
                        •► ab
                        •► aab
                        •► aaaab




        9. "(" ("Opening/Left Parenthesis") 
                → "Grouping" a "Regular Expression".



        10. ")" ("Closing/Right Parenthesis") 
                → "Close" the "Group Started",
                → allowing to "Find" a "Character" 
                → or "String" of "Characters" 
                → between "Them": 
                    •► (abc)

                → from the "Strings": 
                    •► "abcdefg"
                    •► "defabcghij"
                → only "abc" 
                → will be "Selected".
                




        11. "[" ("Opening/Left Square Bracket") 
                → "Begins" a "Character Class".



        12. "]" ("Closing/Right Square Bracket")
                → "Closes" the "Character Class" Specified,
                → "Finds" Each "Individual Character", 
                → "Specified" between "Them":
                    
                
                ♦ For Example:                
                        •► [ai]

                    → from the "Marius" String
                    → "ai" Characters
                    → will be "Selected".


     
     
 
 
    ▬ "Tool"
        → to "Build Regex", 
        → "Test Regex" 
        → and "Debug Regex":
            •► https://regex101.com
            
         
     
     ▬ "@" Symbol
            → is "Used:
            → to "Treat" an "Escape Sequence"  
            → as a "String".    



    ▬ "Match" Data Type
        → is "Used"
        → to "Store" the "Result"
        → of a "Regular Expression Match". 
  
  
    ▬ "MatchCollection" Data Type  
        → is "Used"
        → to "Store Collection" of "Matches".
           
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

using System.Text.RegularExpressions;

namespace CSharp.regex;


public class RegEx
{

    // ▬ "RunRegEx()" Method ▬
    public static void RunRegEx()
    {
        // ▼ "Creating" a "Regular Expression Pattern"
        //      → to "Find Digits"/ "Match Digits" 
        //      → in a "String" ▼
        string pattern = @"\d";
        
        
        // ▼ "Creating" an "Object/Instance" of "Regex" Class ▼
        Regex regex = new Regex(pattern);
        
        
        // ▼ "Checking" if "2" Match the "Pattern" ▼
        Console.WriteLine("Finding '2' in the 'ReeEx Pattern' for 'Finding All Digits' in a 'String': " + regex.IsMatch("2"));
        Console.WriteLine("Finding 'a' in the 'ReeEx Pattern' for 'Finding All Digits' in a 'String': " + regex.IsMatch("a"));
        
        
        
        
        //-----------------------------------------------
        // ••• The "Match" Data Type •••
        // ▼ "Creating" a "Regular Expression Pattern"
        //      → to "Find"/ "Match" s String ▼
        string pattern2 = "(the)"; 
        
        
        // ▼ "Creating" an "Object/Instance" of "Regex" Class ▼
        Regex regex2 = new Regex(pattern2);
        
        
        // ▼ "Variable" of "String" Date Type ▼
        string text = "the quick brown fox jumps over the lazy dog.";
        
        
        // ▼ "Variable" of "Match" Date Type
        //      → to "Store" the "Result"
        //      → of a "Regular Expression Match" ▼
        Match match = regex2.Match(text);
        
        
        // ▼ "Variable" of "MatchCollection" Date Type
        //      → to "Store Collection" of "Matches" ▼
        MatchCollection matches = regex2.Matches(text);
        
        
        
        // ▼ "Print" the "Original Text" ▼
        Console.WriteLine("\nOriginal Text:");
        Console.WriteLine(" " + text);
          
        
        
        // ▼ "Print" the "Matches" ▼
        Console.WriteLine("\nMatches Found:");
        foreach (Match m in matches)
        {
            Console.WriteLine(" " + m.Value);
        }
    }
} 