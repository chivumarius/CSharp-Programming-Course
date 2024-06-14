// using Csharp.functions;
// using CSharp.functions;
// using CSharp.Functions;

// using CSharp.interfaces_and_abstract_classes;
// using CSharp.interfaces_and_abstract_classes.abstract_classes;
// using CSharp.interfaces_and_abstract_classes.interfaces;
// using CSharp.user_input_and_files;
// using Csharp.functions;
// using CSharp.functions;
// using CSharp.Functions;
// using CSharp.data_structures_and_collections;
// using CSharp.advanced;

// using CSharp.namespaces;
// using CSharp.regex;
// using CSharp.xml_comments;

// using CSharp.searching_and_sorting_algorithms.searching;
// using CSharp.searching_and_sorting_algorithms.sorting;
// using CSharp.oop;
// using CSharp.generics;
// using CSharp.bitwise_operations;
// using CSharp.threads;
// using CSharp.linq;
// using CSharp.debugging_exceptions_and_unit_tests;
// using CSharp.debugging_exceptions_and_unit_tests;
// using CSharp.reflection;
// using CSharp.algorithms;
// using CSharp.optimization;

// using CSharp.design_patterns.behavioral;
// using CSharp.design_patterns.creational;
// using CSharp.design_patterns.structural;

// using CSharp.version_8;

// using CSharp.version_10;
// using CSharp.version_11;
// using CSharp.version_12;
// using CSharp.version_9;
// using CSharp.writing_good_code;
// using CSharp.cryptography;
using CSharp.dependency_injection;

// ▼ "Directory" ▼
namespace CSharp;

// ▬▬ "Program" Class ▬▬
static class Program
{
    // ▬ "Main()" Method → the "First Executed Method" ▬
    static void Main()
    {
        // Console.WriteLine(); // ► Empty Line ◄


        // ▼ (1) "Accessing" the "Function" ▼
        // HelloWorld.SayHello();
        // Console.WriteLine(); // ► Empty Line ◄


        // ▼ (2) "Accessing" the "Variables" ▼
        // Variables.PrintVariables();
        // Console.WriteLine();    // ► Empty Line ◄


        // ▼ (3) "Accessing" the "Conditional Statements" ▼
        // ConditionalStatements
        //     .RunConditionalStatements();
        // Console.WriteLine();  // ► Empty Line ◄


        // ▼ (4) "Accessing" the "Loops" ▼
        // Loops.PrintVariables();
        // Console.WriteLine();  // ► Empty Line ◄


        // ▼ (5) "Accessing" the "Function" ▼
        // Functions.PrintHi();






        //Console.WriteLine("=================== OPERATORS ===============");

        // // ▼ (6-1) "Accessing" the "Modulus Operators" ("Remainder") ("%") ▼
        // Operators.Modulus();



        // // ▼ (6-2-1) "Accessing" the "Increment Operators" ("++") ▼
        // Operators.Increment();


        // // ▼ (6-2-2) "Accessing" the "Decrement Operators" ("--") ▼
        // Operators.Decrement();



        // // ▼ (6-3) "Accessing" the "is Operators" ("is") ▼
        // Operators.IsOfType();


        // // ▼ (6-4) "Accessing" the "As Operators" ("as") ▼
        // Operators.AsTypeCasting();



        // // ▼ (6-5) "Accessing" the "TernAry/Conditional Operators" ("Condition ? True : False")
        // Operators.TernaryOrConditional();



        // // ▼ (6-6) "Accessing" the "Null-Coalescing Operator"  (True ?? False")  ▼
        // Operators.NullCoalescing();


        // // ▼ (6-7) "Accessing" the "sizeof Operator" → that "Provides" the "Size" in "Bytes"  ▼
        // Operators.SizeOf();


        // // ▼ (6-8) "Accessing" the "typeof Operator" → that "Provides" the "System.Type" Object for a "Data Type" ▼
        // Operators.TypeOf();



        // // ▬ (9) The "Overloading Operator" (operator +) to "Add 2 Box" Objects ▬
        // // ▼ Creating "Box" Objects ▼
        // Box box1 = new Box(2, 2, 2);
        // Box box2 = new Box(2, 2, 2);

        // // ▼ "Adding" the "2 boxes" ▼
        // Box box3 = box1 + box2;


        // // ▼ Displaying the "box3" ▼
        // Console.WriteLine("Overloading Operator - Length: " + box3.GetLength());
        // Console.WriteLine("Overloading Operator - Width: " + box3.GetWidth());
        // Console.WriteLine("Overloading Operator - Height: " + box3.GetHeight());






        // Console.WriteLine("\n" + "=================== DATA TYPES ===============");
        // Basics_BuiltIn_DataTypes.AliasType();
        //
        //
        // Console.WriteLine("\n" + "--------------- INTEGERS --------------");
        // IntegerDataType.IntegerType();
        //
        //
        //
        //
        // Console.WriteLine("\n" + "--------------- FLOATING-POINTS --------------");
        // FloatingPointDataType.FloatType();
        //
        //
        //
        //
        // Console.WriteLine("\n" + "--------------- MATH CLASS --------------");
        // MathClass.MathMethod();
        //
        //
        //
        //
        //
        // Console.WriteLine("\n" + "--------------- STRINGS --------------");
        // StringDataType.StringType();
        //
        //
        //
        // Console.WriteLine("\n" + "--------------- STRING  BUILDER  CLASS --------------");
        // StringBuilderClass.StringBuilderMethod();
        //
        //
        // Console.WriteLine("\n" + "--------------- WORKING WITH STRING  --------------");
        // Working_with_Strings.WorkingWithString();
        //
        // Console.WriteLine("\n" + "--------------- STRING VALIDATION USING IS NULL OR EMPTY METHOD  --------------");
        // Strings_Validation_Using_IsNullOrEmpty.StringValidationUsingIsNullOrEmpty();
        //
        // Console.WriteLine("\n" + "--------------- CHARACTERS --------------");
        // CharacterDataType.CharacterType();
        //
        //
        //
        // Console.WriteLine("\n" + "--------------- BOOLEAN --------------");
        // BooleanDataType.BooleanType();
        //
        //
        // Console.WriteLine("\n" + "--------------- NULL VALUE TYPE --------------");
        // Null.NullValueType();
        //
        //
        // Console.WriteLine("\n" + "--------------- CONVERTING VARIABLES, BOXING & UNBOXING --------------");
        // ConvertingVariables_Boxing_and_Unboxing.ConvertingVariables();
        // ConvertingVariables_Boxing_and_Unboxing.Boxing();
        // ConvertingVariables_Boxing_and_Unboxing.Unboxing();
        //
        //
        // Console.WriteLine("\n" + "--------------- ANONYMOUS (VAR) & DYNAMIC (DYNAMIC)  DATA TYPES --------------");
        // Anonymous_And_Dynamic_DataTypes.AnonymousAndDynamicDataTypes();
        //
        //
        //
        // Console.WriteLine("\n" + "--------------- VALUE & REFERENCE DATA TYPES --------------");
        // Value_and_Reference_DataTypes.ValueDataTypes();
        // Value_and_Reference_DataTypes.ReferenceDataTypes();
        //



        // Console.WriteLine("\n" + "******************** DATE & TIME ********************");
        // Console.WriteLine("--------------- DATE TIME CLASS --------------");
        // DateTimeClass.DateTimeMethod();
        //
        //
        // Console.WriteLine("\n" + "--------------- TIME SPAN CLASS --------------");
        // TimeSpanClass.TimeSpanMethod();
        //
        //
        // Console.WriteLine("\n" + "--------------- FORMATTING DATES & TIMES --------------");
        // Formatting_Dates_and_Times.FormatDatesAndTime();
        //
        //
        // Console.WriteLine("\n" + "--------------- COORDINATED UNIVERSAL TIME (UTC) --------------");
        // UTC.UniversalTimeCoordinated();




        // Console.WriteLine("\n" + "******************** CONTROL FLOW STATEMENTS & LOOPS ********************");
        // Console.WriteLine("--------------- IF, ELSE IF, ELSE STATEMENT --------------");
        // If_ElseIf_Else_statement.IfElseIfElse();
        //
        //
        // Console.WriteLine("\n--------------- SWITCH STATEMENT --------------");
        // Switch_Statement.SwitchStatement();
        //
        //
        // Console.WriteLine("\n******************* FOR LOOP ********************");
        //
        // Console.WriteLine("--------------- FOR LOOP --------------");
        // For_Loop.ForLoop();
        //
        //
        // Console.WriteLine("\n" + "--------------- FOREACH LOOP --------------");
        // ForEach_Loop.ForEachMethod();
        //
        //
        // Console.WriteLine("\n" + "--------------- WHILE LOOP --------------");
        // While_Loop.WhileMethod();
        //
        //
        // Console.WriteLine("\n" + "--------------- DO-WHILE LOOP --------------");
        // Do_While_Loop.DoWhileMethod();
        //
        //
        // Console.WriteLine("\n" + "--------------- INFINITE LOOPS --------------");
        // Infinite_Loops.InfiniteLoops();
        //
        //
        // Console.WriteLine("\n" + "--------------- BREAK AND CONTINUE STATEMENTS --------------");
        // Break_and_Continue_Statements.BreakAndContinueStatements();




        // Console.WriteLine("\n" + "******************** USER INPUT & FILES ********************");
        // Console.WriteLine("\n" + "──────────────────── STRING AND CHAR USER INPUT ────────────────────");
        // Console.WriteLine("--------------- READ LINE() METHOD → TO GET USER INPUT --------------");
        // StringAndCharUserInput.ReadLineMethod();
        //
        //
        // Console.WriteLine("\n" + "--------------- READ() METHOD → TO GET USER INPUT --------------");
        // StringAndCharUserInput.ReadMethod();
        //
        // Console.WriteLine();
        //
        // StringAndCharUserInput.ReadMethod2();
        //
        // Console.WriteLine();
        //
        // StringAndCharUserInput.ReadKeyMethod();
        //
        //
        //
        // Console.WriteLine();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── NUMERIC USER INPUT ────────────────────");
        // NumericUserInput.NumericUserInputMethod();


        // Console.WriteLine("\n" + "──────────────────── PR. TIC, TAC, TOE ────────────────────");
        // Pr_TicTacToe.TicTacToe();



        // Console.WriteLine("\n" + "******************** FUNCTIONS ********************");
        // Console.WriteLine("\n" + "──────────────────── CONSTRUCTORS ────────────────────");
        // ConstructorsClass.ClassMethod();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── FINALIZE() METHOD ────────────────────");
        //
        // Console.WriteLine("\n" + "──────────────────── PROPERTIES ────────────────────");
        // Properties.RunProperties();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── ATTRIBUTES ────────────────────");
        // // ▼ "Creates" an "Object/Instance" of the "Attributes" Class
        // Attributes attributes = new Attributes();
        //
        // // ▼ "Call" the "RunAttribute()" Method on the "Attributes" Instance
        // attributes.RunAttribute();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── ANONYMOUS FUNCTIONS or LAMBDA EXPRESSIONS ────────────────────");
        // AnonymousFunctionsAndLambdaExpressions.RunAnonymousFunctionAndLambdaExpressions();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── DELEGATE TYPE ────────────────────");
        // DelegateType.RunDelegateType();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── OVERLOADING ────────────────────");
        //
        //
        // Console.WriteLine("\n" + "──────────────────── OVERRIDING ────────────────────");
        // Overriding2.RunOverriding2();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── FUNCTION WITH INFINITE NUMBER OF PARAMETERS ────────────────────");
        // FunctionWithInfiniteNumberOfParameters.RunFunctionWithInfiniteNumberOfParameters();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── OPTIONAL PARAMETERS ────────────────────");
        // OptionalParameters.RunOptionalParameters();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── EXTENSION METHODS ────────────────────");
        // ExtensionMethods.RunExtensionMethods();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── ASYNCHRONOUS FUNCTIONS ────────────────────");
        // AsynchronousFunctions.RunAsynchronousFunctions();





        // Console.WriteLine("\n" + "******************** INTERFACES  &  ABSTRACT  CLASSES ********************");
        // Console.WriteLine("\n" + "==================== INTERFACES  &  ABSTRACT  CLASSES ********************");
        // Console.WriteLine("\n" + "──────────────────── INTERFACES IMPLEMENTATION ────────────────────");
        //
        // // ▼ "Creating" an "Instance" of the "Class" ▼
        // MyClass myInstance = new MyClass();
        //
        // // ▼ "Calling" the "Method" ▼
        // string result = myInstance.RunMyClass();
        //
        // // ▼ "Displaying" the "Result" ▼
        // Console.WriteLine(result);
        //
        //
        //
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"I NOTIFY PROPERTY CHARGED\" INTERFACE ────────────────────");
        //
        // // Creating an instance of the NotifyPropertyChanged class
        // NotifyPropertyChanged notifier = new NotifyPropertyChanged();
        //
        // // Accessing the name property and setting a value
        // notifier.Name = "John Doe";
        //
        // // Example of displaying the value of the name property
        // Console.WriteLine("Name: " + notifier.Name);
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \" I COMPARABLE\" INTERFACE ────────────────────");
        // Comparable.RunComparable();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \" I COMPARER\" INTERFACE ────────────────────");
        // Comparer.RunComparer();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \" I EQUATABLE\" INTERFACE ────────────────────");
        // EquatableClass.RunEquatable();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \" I EQUALITY COMPARER\" INTERFACE ────────────────────");
        // EqualityComparer.RunEqualityComparer();
        //
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \" I ENUMERABLE\" INTERFACE ────────────────────");
        // EnumerableClass.RunEnumerable();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \" I ENUMERATOR\" INTERFACE ────────────────────");
        // EnumeratorClass.RunEnumerator();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \" I COLLECTION\" INTERFACE ────────────────────");
        // CollectionClass.RunCollectionClass();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"ABSTRACT\" CLASS ────────────────────");
        // AbstractClass.RunAbstractClass();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"VIRTUAL\",  \"OVERRIDE\" AND \"BASE\" KEYWORDS ────────────────────");
        // VirtualOverrideAndBaseKeywords.VirtualOverrideAndBase();






        // Console.WriteLine("\n" + "******************** DATA STRUCTURES  &  COLLECTIONS ********************");
        // Console.WriteLine("\n" + "──────────────────── (1) \"ARRAYS\" ────────────────────");
        // Arrays.RunArrays();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (2) \"LISTS\" ────────────────────");
        // Lists.RunLists();
        //
        //
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (3) \"STACKS\" ────────────────────");
        // Stacks.RunStacks();
        //
        //
        // Console.WriteLine("\n" + "─------------------- \"Balanced Braces\" Problem ──-------------------");
        // Stacks.RunStacks2();
        //
        //
        // Console.WriteLine("\n" + "─------------------- \"Last In First Out\" Principle ──-------------------");
        // Stacks.RunLastInFirstOut();
        //
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (4) \"QUEUES\" ────────────────────");
        // Queues.RunQueues();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (5) \"STRUCTS\" (STRUCTURES) ────────────────────");
        // Structs.RunStructs();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (6) \"ENUMS\" (ENUMERATIONS) ────────────────────");
        // Enums.RunEnums();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (7) \"DICTIONARY\" (KEY-VALUE PAIRS) ────────────────────");
        // Dictionaries.RunDictionaries();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (8) \"HASH SETS\" ────────────────────");
        // HashSets.RunHashSets();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (9) \"SORTED LISTS\" ────────────────────");
        // SortedLists.RunSortedLists();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (10) \"SORTED DICTIONARIES\" ────────────────────");
        // SortedDictionaries.RunSortedDictionaries();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (11) \"SORTED SETS\" ────────────────────");
        // SortedSets.RunSortedSets();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (12) \"TUPLES\" ────────────────────");
        // Tuples.RunTuples();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (13) \"LINKED LISTS\" ────────────────────");
        // LinkedLists.RunLinkedLists();
        //
        //
        // Console.WriteLine("\n" + "─------------------- \"DOUBLE LINKED LISTS\" ──-------------------");
        // DoubleLinkedLists.RunDoubleLinkedLists();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (14) \"TREES\" ────────────────────");
        // Trees.RunTrees();
        //
        //
        // Console.WriteLine("\n" + "─------------------- \"TRAVERSING\" A \"TREE\" ──-------------------");
        // TreeTraversing.RunTreeTraversing();
        //
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (15) \"GRAPHS\" ────────────────────");
        // Graphs.RunGraphs();
        //
        //
        // Console.WriteLine("\n" + "─------------------- \"GRAPH\" WITH \"ADJACENCY MATRIX\" ──-------------------");
        // GraphWithAdjacencyMatrix.RunGraphWithAdjacencyMatrix();








        // Console.WriteLine("\n" + "******************** C#  ADVANCED  &  COLLECTIONS ********************");
        // Console.WriteLine("\n" + "──────────────────── (1) \"PREPROCESSOR\" DIRECTIVES ────────────────────");
        // PreprocessorDirectives.RunPreprocessorDirectives();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (2) \"DELEGATES\" ────────────────────");
        // Delegates.RunDelegates();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (3) \"EVENTS\" ────────────────────");
        // Events.RunEvents();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (4) \"ACTIONS\" ────────────────────");
        // Actions.RunActions();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (5) \"RECURSION\" ────────────────────");
        // Console.WriteLine("─------------------- \"FIBONACCI\" PROBLEM ──-------------------");
        // FibonacciRecursionProblem.RunFibonacciRecursionProblem();
        //
        //
        // Console.WriteLine("\n" + "─------------------- \"TOWERS OF HANOI\" PROBLEM ──-------------------");
        // TowersOfHanoiRecursionProblem.RunTowersOfHanoiRecursionProblem();




        // Console.WriteLine("\n" + "******************** REGEX  (REGULAR  EXPRESSIONS) ********************");
        // RegEx.RunRegEx();



        // Console.WriteLine("\n" + "******************** NAME SPACES ********************");
        // NameSpaces.RunNameSpaces();


        // Console.WriteLine("\n" + "******************** XML COMMENTS ********************");
        // XMLComments.RunXMLComments();



        // Console.WriteLine("\n" + "******************** SEARCHING & SORTING ********************");
        // Console.WriteLine("─------------------- (I) \"SEARCHING\" ──-------------------");
        // Console.WriteLine("──────────────────── (1) \"LINEAR SEARCH\" ────────────────────");
        // LinearSearch.RunLinearSearch();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (2) \"BINARY SEARCH\" ────────────────────");
        // BinarySearch.RunBinarySearch();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"BINARY SEARCH()\" - \"BUILT-IN\" METHOD ────────────────────");
        // BinarySearchBuiltInMethod.RunBinarySearchBuiltInMethod();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (3) \"INTERPOLATION SEARCH\" ────────────────────");
        // InterpolationSearch.RunInterpolationSearch();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (4) \"HASHING SEARCH\" ────────────────────");
        // HashingSearch.RunHashingSearch();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (5) \"DEPTH-FIRST TRAVERSAL\" SEARCH ON TREES & GRAPHS ────────────────────");
        // DepthFirstTraversalSearchOnTreesAndGraphs.RunDepthFirstTraversalSearch();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (6) \"BREADTH-FIRST TRAVERSAL\" SEARCH ON TREES & GRAPHS ────────────────────");
        // BreadthFirstTraversalSearchOnTreesAndGraphs.RunBreadthFirstTraversalSearch();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (7) \"TREE TRAVERSAL\" ────────────────────────────");
        // TreeTraversal.RunTreeTraversal();
        //
        //
        //
        //
        // Console.WriteLine("\n\n" + "─------------------- (Ii) \"SORTING\" ──-------------------");
        // BuiltInSortMethod.RunBuiltInSortMethod();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (1) \"SELECTION  SORT\" ────────────────────");
        // SelectionSort.RunSelectionSort();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (2) \"BUBBLE  SORT\" ────────────────────");
        // BubbleSort.RunBubbleSort();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (3) \"QUICK  SORT\" ────────────────────");
        // QuickSort.RunQuickSort();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (4) \"MERGE  SORT\" ────────────────────");
        // MergeSort.RunMergeSort();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (5) \"INSERTION  SORT\" ────────────────────");
        // InsertionSort.RunInsertionSort();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (6) \"RADIX  SORT\" ────────────────────");
        // RadixSort.RunRadixSort();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (7) \"HEAP  SORT\" ────────────────────");
        // HeapSort.RunHeapSort();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (8) \"SHELL  SORT\" ────────────────────");
        // ShellSort.RunShellSort();






        // Console.WriteLine("\n" + "******************** OOP ********************");
        // Console.WriteLine("──────────────────── \"CLASSES\" AND \"OBJECTS\" ────────────────────");
        // ClassesAndObjects.RunClassesAndObjects();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (1) \"ENCAPSULATION\" ────────────────────");
        // Encapsulation.RunEncapsulation();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (2) \"ABSTRACTION\" ────────────────────");
        // Abstraction.RunAbstraction();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (3) \"INHERITANCE\" ────────────────────");
        // Inheritance.RunInheritance();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (4) \"POLYMORPHISM\" ────────────────────");
        // Polymorphism.RunPolymorphism();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"COVARIANCE\" ────────────────────");
        // Covariance.RunCovariance();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"PARTIAL CLASSES\" ────────────────────");
        // PartialClasses.RunPartialClasses();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"INDEXERS\" ────────────────────");
        // Indexers.RunIndexers();





        // Console.WriteLine("\n" + "******************** GENERICS ********************");
        // Generics<string>.RunGenerics();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"CONSTRAINTS OM TYPE PARAMETERS\" ────────────────────");
        // ConstraintsOnTypeParameters<Example, Example2>.RunConstraintsOnTypeParameters();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"GENERIC CLASSES & METHODS\" ────────────────────");
        // GenericClassesAndMethods<string>.RunGenericClassesAndMethods();




        // Console.WriteLine("\n" + "******************** BITWISE OPERATIONS ********************");
        // Console.WriteLine("──────────────────── (1) \"COMPLIMENT\" OPERATOR ('~') ────────────────────");
        // ComplimentOperator.RunComplimentOperator();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (2) \"LEFT-SHIFT\" OPERATOR ('<<') ────────────────────");
        // LeftShiftOperator.RunLeftShiftOperator();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (3) \"RIGHT-SHIFT\" OPERATOR ('>>') ────────────────────");
        // RightShiftOperator.RunRightShiftOperator();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (4) \"AND\" OPERATOR ('&') ────────────────────");
        // AndOperator.RunAndOperator();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (5) \"XOR\" OPERATOR ('^') ────────────────────");
        // XOrOperator.RunXOrOperator();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (6) LOGICAL \"OR\" OPERATOR ('|') ────────────────────");
        // OrOperator.RunOrOperator();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"COMPOUND ASSIGNMENT\" ('=') ────────────────────");
        // CompoundAssignment.RunCompoundAssignment();




        // Console.WriteLine("\n" + "******************** THREADS ********************");
        // Threads.RunThreads();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"FOREGROUND THREADS\" AND \"BACKGROUND THREAD\" ────────────────────");
        // ForegroundAndBackgroundThreads.RunForegroundAndBackgroundThreads();
        //
        //
        //
        // //Console.WriteLine("\n" + "──────────────────── \"THREAD PRIORITY\" ────────────────────");
        // ThreadPriority.RunThreadPriority();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"THREAD POOLING\" ────────────────────");
        // ThreadPooling.RunThreadPooling();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"SYNCHRONIZATION\" & \"BLOCKING\" & \"LOCKING\" ────────────────────");
        // SynchronizationAndBlockingAndLocking.RunSynchronizationAndBlockingAndLocking();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── \"PARALLEL PROGRAMMING\" ────────────────────");
        // ParallelProgramming.RunParallelProgramming();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"CONCURRENT COLLECTIONS\" ────────────────────");
        // ConcurrentCollections.RunConcurrentCollections();




        // Console.WriteLine("\n" + "******************** LINQ (LANGUAGE INTEGRATED QUERY) ********************");
        // LINQ.RunLINQ();
        //
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"CAST\" OPERATOR IN  \"LINQ\" ────────────────────");
        // CastOperator.RunCastOperator();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"SELECT()\" &  \"SELECT MANY()\" METHODS ────────────────────");
        // SelectAndSelectMany.RunSelectAndSelectMany();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"OF TYPE()\" &  \"WHERE()\" METHODS ────────────────────");
        // OfTypeAndWhere.RunOfTypeAndWhere();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"ORDER BY()\" &  \"THEN BY()\" &  \"REVERSE()\" METHODS ────────────────────");
        // OrderByAndThenByAndReverse.RunOrderByAndThenByAndReverse();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"GROUP BY()\" &  \"I GROUPING()\" METHODS ────────────────────");
        // GroupByAndIGrouping.RunGroupByAndIGrouping();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"DISTINCT()\", \"EXCEPT()\", \"INTERSECT()\" & \"UNION()\" METHODS ────────────────────");
        // DistinctAndExceptAndIntersectAndUnion.RunDistinctAndExceptAndIntersectAndUnion();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"SEQUENCE EQUAL()\" METHOD ────────────────────");
        // SequenceEqual.RunSequenceEqual();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"ALL()\" & \"ANY()\" & \"CONTAINS()\" METHODS ────────────────────");
        // AllAndAnyAndContains.RunAllAndAnyAndContains();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"SKIP()\" & \"TAKE()\" METHODS ────────────────────");
        // SkipAndTake.RunSkipAndTake();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"JOIN()\" & \"GROUP JOIN()\" METHODS ────────────────────");
        // JoinAndGroupJoin.RunJoinAndGroupJoin();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"FIRST()\", \"LAST()\", \"SINGLE()\" & \"ELEMENT AT()\" METHODS ────────────────────");
        // FirstAndLastAndSingleAndElementAt.RunFirstAndLastAndSingleAndElementAt();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"CONCAT()\" METHOD ────────────────────");
        // Concat.RunConcat();
        //
        //
        // Console.WriteLine("\n──────────────────── \"AGGREGATE()\" & \"COUNT()\" METHODS ────────────────────");
        // AggregateAndCount.RunAggregateAndCount();





        // Console.WriteLine("\n" + "******************** \"DEBUGGING EXCEPTIONS\" & \"UNIT TESTS\"  ********************");
        // Console.WriteLine("\n──────────────────── \"NULL REFERENCE EXCEPTION\" ────────────────────");
        // NullReferenceExceptionError.RunNullReferenceExceptionError();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"DIVIDE BY ZERO EXCEPTION\" ────────────────────");
        // DivideByZeroExceptionError.RunDivideByZeroExceptionError();
        //
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"STACK OVERFLOW EXCEPTION\" ────────────────────");
        // StackOverflowExceptionError.RunStackOverflowExceptionError();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"INDEX OUT OF RANGE EXCEPTION\" ────────────────────");
        // IndexOutOfRangeExceptionError.RunIndexOutOfRangeExceptionError();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"OVERLOAD  METHOD  NOT  COMPATIBLE\" ERROR ────────────────────");
        // OverloadMethodNotCompatibleError.RunOverloadMethodNotCompatibleError();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"SYMBOL EXPECTED\" ERROR ────────────────────");
        // SymbolExpectedError.RunSymbolExpectedError();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"OPERATOR  ...  CANNOT  BE  APPLIED  TO  OPERANDS\" ERROR ────────────────────");
        // OperatorCannotBeAppliedToOperandsError.RunOperatorCannotBeAppliedToOperandsError();
        //
        //
        // Console.WriteLine("\n──────────────────── \"CANNOT IMPLICITLY CONVERT TYPE ... TO A TYPE ...\" ERROR ────────────────────");
        // CannotImplicitlyConvertTypeToTypeError.RunCannotImplicitlyConvertTypeToTypeError();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"THE  NAME  DOES  NOT  EXIST  IN  THE  CURRENT  CONTEXT\" ERROR ────────────────────");
        // TheNameDoesNotExistInTheCurrentContextError.RunTheNameDoesNotExistInTheCurrentContextError();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"AN OBJECT REFERENCE IS REQUIRED TO ACCESS NON-STATIC  MEMBER\" ERROR ────────────────────");
        // AnObjectReferenceIsRequiredToAccessNonStaticMemberError.RunAnObjectReferenceIsRequiredToAccessNonStaticMemberError();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"TRY{}\", \"CATCH{}\", \"FINALLY{}\" BLOCKS & \"THROW ERROR MESSAGE\" ────────────────────");
        // TryCatchFinallyBlocksAndThrowErrorMessage.RunTryCatchFinallyBlocksAndThrowErrorMessage();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"EXCEPTION\" CLASS IN \"C#\" ────────────────────");
        // ExceptionClassInCSharp.RunExceptionClassInCSharp();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── \"BREAKPOINTS\" ────────────────────");
        // Breakpoints.RunBreakpoints();
        //
        //
        // Console.WriteLine("\n──────────────────── \"UNIT TESTS\" ────────────────────");
        // UnitTests.RunUnitTests();





        // Console.WriteLine("\n" + "******************** \"REFLECTION\" & \"METADATA\"    ********************");
        // Reflection.RunReflection();
        //
        //
        // Console.WriteLine("\n──────────────────── \"REFLECTIONS\" WITH \"GENERIC TYPES\"────────────────────");
        // ReflectionWithGenericTypes.RunReflectionWithGenericTypes();





        // Console.WriteLine("\n" + "******************** \"ALGORITHMS\" ********************");
        // Console.WriteLine(
        //     "──────────────────── (1) \"N CHOOSE K\" ALGORITHM (COMBINATORIAL ALGORITHM) ────────────────────");
        // NChooseK.RunNChooseK();
        //
        //
        //
        // Console.WriteLine(
        //     "\n──────────────────── (2-1) \"A*\" ALGORITHM (SHORTEST PATH ALGORITHM) ────────────────────");
        // // AStar.RunAStar();
        //
        //
        //
        // Console.WriteLine(
        //     "\n──────────────────── (2-2) \"LEE\" ALGORITHM (SHORTEST PATH ALGORITHM) ────────────────────");
        // Lee.RunLee();
        //
        //
        //
        // Console.WriteLine(
        //     "\n──────────────────── (2-3) \"DIJKSTRA\" ALGORITHM (SHORTEST PATH ALGORITHM) ────────────────────");
        // Dijkstra.RunDijkstra();
        //
        //
        //
        //
        // Console.WriteLine(
        //     "\n──────────────────── (2-4) \"FLOYD\" - \"WARSHALL\" ALGORITHM (SHORTEST PATH ALGORITHM) ────────────────────");
        // FloydWarshall.RunFloydWarshall();
        //
        //
        //
        // Console.WriteLine(
        //     "\n──────────────────── (3-1) \"KRUSKAL\" ALGORITHM (MINIMUM  SPANNING  TREE) ────────────────────");
        // Kruskal.RunKruskal();
        //
        //
        //
        // Console.WriteLine(
        //     "\n──────────────────── (3-2) \"PRIM\" ALGORITHM (MINIMUM  SPANNING  TREE) ────────────────────");
        // Prim.RunPrim();
        //
        //
        //
        // Console.WriteLine(
        //     "\n──────────────────── (4-1) \"FLOYD\" -  \"TORTOISE & HARE\" ALGORITHM (CYCLE DETECTION ALGORITHMS) ────────────────────");
        // FloydTortoiseAndHare.RunFloydTortoiseAndHare();
        //
        //
        //
        // Console.WriteLine(
        //     "\n──────────────────── (4-2) \"UNION FIND\" ALGORITHM (CYCLE DETECTION ALGORITHMS) ────────────────────");
        // UnionFind.RunUnionFind();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── (4-3) \"BRENT\" ALGORITHM (CYCLE DETECTION ALGORITHMS) ────────────────────");
        //
        //
        //
        // Console.WriteLine("\n──────────────────── (5-1) \"FLOOD FILL\" ALGORITHM (DYNAMIC  PROGRAMMING  &  MEMORIZATION ALGORITHMS) ────────────────────");
        // FloodFill.RunFloodFill();
        //
        //
        //
        // Console.WriteLine("\n──────────────────── (5-2) \"KADONE\" ALGORITHM (DYNAMIC  PROGRAMMING  &  MEMORIZATION ALGORITHMS) ────────────────────");
        // Kadone.RunKadone();





        // Console.WriteLine("\n" + "******************** \"OPTIMIZATION\" ********************");
        // Console.WriteLine("──────────────────── \"BIG 'O'\" NOTATION ────────────────────");
        // BigONotation.RunBigONotation();
        //
        //
        //
        // Console.WriteLine("──────────────────── \"OPTIMIZATION TECHNIQUES\" NOTATION ────────────────────");
        // OptimizationTechniques.RunOptimizationTechniques();
        //
        //
        //
        // Console.WriteLine("──────────────────── \"I DISPOSABLE\" INTERFACE ────────────────────");
        // IDisposableInterface.RunIDisposableInterface();





        // Console.WriteLine("\n" + "******************** \"DESIGN  PATTERNS\" ********************");
        // Console.WriteLine("==================== I. \"CREATIONAL'\" =====================");
        // Console.WriteLine("──────────────────── (1) \"ABSTRACT FACTORY'\" ────────────────────");
        // AbstractFactory.RunAbstractFactory();
        //
        //
        // Console.WriteLine("──────────────────── (2) \"BUILDER'\" ────────────────────");
        // Builder.RunBuilder();
        //
        //
        // Console.WriteLine("──────────────────── (3) \"FACTORY'\" ────────────────────");
        // FactoryMethod.RunFactoryMethod();
        //
        //
        // Console.WriteLine("──────────────────── (4) \"PROTOTYPE'\" ────────────────────");
        // Prototype.RunPrototype();
        //
        //
        // Console.WriteLine("──────────────────── (5) \"SINGLETON'\" ────────────────────");
        // SingletonDesignPattern.RunSingletonDesignPattern();
        //
        //
        //
        // Console.WriteLine("==================== II. \"STRUCTURAL'\" =====================");
        // Console.WriteLine("──────────────────── (1) \"ADAPTER'\" ────────────────────");
        // AdapterDesignPattern.RunAdapterDesignPattern();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (2) \"BRIDGE'\" ────────────────────");
        // Bridge.RunBridge();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (3) \"COMPOSITE'\" ────────────────────");
        // Composite.RunComposite();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (4) \"DECORATOR'\" ────────────────────");
        // Decorator.RunDecorator();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (5) \"FACADE'\" ────────────────────");
        // FaçadeDesignPattern.RunFaçadeDesignPattern();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (6) \"FLYWEIGHT'\" ────────────────────");
        // Flyweight.RunFlyweight();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (7) \"PROXY'\" ────────────────────");
        // ProxyDesignPattern.RunProxyDesignPattern();
        //
        //
        //
        //
        // Console.WriteLine("==================== III. \"BEHAVIORAL'\" =====================");
        // Console.WriteLine("──────────────────── (1) \"CHAIN OF  RESPONSIBILITY'\" ────────────────────");
        // ChainOfResponsibility.RunChainOfResponsibility();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (2) \"COMMAND'\" ────────────────────");
        // Command.RunCommand();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (3) \"INTERPRETER'\" ────────────────────");
        // Interpreter.RunInterpreter();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (4) \"ITERATOR'\" ────────────────────");
        // Iterator.RunIterator();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (5) \"MEDIATOR'\" ────────────────────");
        // Mediator.RunMediator();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (6) \"MEMENTO'\" ────────────────────");
        // MementoDesignPattern.RunMementoDesignPattern();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (7) \"OBSERVER'\" ────────────────────");
        // Observer.RunObserver();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (8) \"STATE'\" ────────────────────");
        // State.RunState();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (9) \"STRATEGY'\" ────────────────────");
        // Strategy.RunStrategy();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (10) \"TEMPLATE METHOD'\" ────────────────────");
        // Template.RunTemplate();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (11) \"VISITOR'\" ────────────────────");
        // Visitor.RunVisitor();
        //




        // Console.WriteLine("\n" + "******************** \"C# 8.0\" (2019) ********************");
        // Console.WriteLine("──────────────────── (1) \"READONLY\" MEMBERS IN \"STRUCTS\" ────────────────────");
        // ReadOnlyMembersInStructs.RunReadOnlyMembersInStructs();
        //
        //
        //
        // Console.WriteLine("──────────────────── (2) \"DEFAULT METHODS\" IN \"INTERFACES\" ────────────────────");
        // DefaultMethodsInInterfaces.RunDefaultMethodsInInterfaces();
        //
        //
        //
        // Console.WriteLine("──────────────────── (3) \"PATTERN MATCHING ENHANCEMENTS\" ────────────────────");
        // PatternMatchingEnhancements.RunPatternMatchingEnhancements();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (4) \"USING\" DECLARATIONS ────────────────────");
        // UsingDeclarations.RunUsingDeclarations();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (5) \"STATIC LOCAL FUNCTIONS\" ────────────────────");
        // StaticLocalFunctions.RunStaticLocalFunctions();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (6) \"DISPOSABLE REF STRUCTS\" ────────────────────");
        // DisposableRefStructs.RunDisposableRefStructs();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (7) \"NULLABLE\" REFERENCE TYPES ────────────────────");
        // NullableReferenceTypes.RunNullableReferenceTypes();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (8) \"ASYNCHRONOUS STREAMS\" ────────────────────");
        // AsynchronousStreams.RunAsynchronousStreams();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (9) \"INDICES\" & \"RANGES\"────────────────────");
        // IndicesAndRanges.RunIndicesAndRanges();
        //
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (10) \"NULL-COALESCING\" ASSIGNMENT (OPERATOR) ────────────────────");
        // NullCoalescingAssignment.RunNullCoalescingAssignment();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (11) \"UNMANAGED CONSTRUCTED TYPES\"  ────────────────────");
        // UnmanagedConstructedTypes.RunUnmanagedConstructedTypes();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (12) \"STACKALLOC\" IN \"NESTED EXPRESSIONS\" ─────────────────────");
        // StackallocInNestedExpressions.RunStackallocInNestedExpressions();
        //
        //
        // Console.WriteLine("\n" + "──────────────────── (13) \"ENHANCEMENT\" OF \"INTERPOLATED VERBATIM STRINGS\" ────────────────────");
        // EnhancementOfInterpolatedVerbatimStrings.RunEnhancementOfInterpolatedVerbatimStrings();



        // Console.WriteLine("\n" + "******************** \"C# 9.0\" (2020) ********************");
        // Console.WriteLine("──────────────────── (1) \"RECORD\" DATA TYPES ────────────────────");
        // RecordDataTypes.RunRecordDataTypes();
        //
        // Console.WriteLine("──────────────────── (2) \"TOP-LEVE STATEMENTS\" ────────────────────");
        //
        // Console.WriteLine(
        //     "──────────────────── (3) \"NEW()\" KEYWORD FOR \"OBJECT INITIALIZATION\" ────────────────────"
        // );
        // NewKeywordForObjectInitialization.RunNewKeywordForObjectInitialization();
        //
        // Console.WriteLine("\n" + "******************** \"C# 10.0\" (2021) ********************");
        // Console.WriteLine("──────────────────── \"GLOBAL USING\" DIRECTIVES ────────────────────");
        //
        // Console.WriteLine("\n" + "******************** \"C# 11.0\" (2022) ********************");
        // Console.WriteLine(
        //     "──────────────────── \"BEW FEATURES\" AND \"ENHANCEMENTS\" ────────────────────"
        // );
        // NewFeaturesAndEnhancements.RunNewFeaturesAndEnhancements();
        //
        // Console.WriteLine("\n" + "******************** \"C# 12.0\" (2022) ********************");
        // Console.WriteLine("──────────────────── (1) \"PRIMARY CONSTRUCTORS\" ────────────────────");
        // PrimaryConstructors.RunPrimaryConstructors();
        //
        // Console.WriteLine(
        //     "──────────────────── (2) \"COLLECTION EXTENSIONS\" ────────────────────"
        // );
        // CollectionExpressions.RunCollectionExpressions();
        //
        // Console.WriteLine(
        //     "──────────────────── (3) \"INLINE ARRAYS STRUCTURES\" ────────────────────"
        // );
        // InlineArraysStrucures.RunInlineArraysStrucures();
        //
        // Console.WriteLine(
        //     "──────────────────── (4) \"OPTIONAL PARAMETERS\" IN \"LAMBDA EXPRESSIONS\" RESTRICTION ────────────────────"
        // );
        // OptionalParametersInLambdaExpressionsRestriction.RunOptionalParametersInLambdaExpressionsRestriction();
        //
        // Console.WriteLine(
        //     "──────────────────── (5) \"REFERENCE READONLY PARAMETERS\" IN \"METHODS\" ────────────────────"
        // );
        // RefReadonlyParameters.RunRefReadonlyParameters();
        //
        // Console.WriteLine("──────────────────── (6) \"ALIAS ANY TYPES\" ────────────────────");
        // AnyTypeAlias.RunAnyTypeAlias();
        //
        // Console.WriteLine(
        //     "──────────────────── (7) \"EXPERIMENTAL\" ATTRIBUTES ─────────────────────"
        // );
        // ExperimentalAttributeExample.RunExperimentalAttribute();
        //
        // Console.WriteLine("──────────────────── (8) \"INTERCEPTORS\" ────────────────────");
        // Interceptors.RunInterceptors();




        // Console.WriteLine("\n" + "******************** \"WRITING GOOD CODE\" ********************");
        // Console.WriteLine("──────────────────── (1) \"REUSABLE DATA TYPES\" CODE ────────────────────");
        // Reusable.RunReusable();
        //
        // Console.WriteLine("──────────────────── (2) \"CLEAN\" CODE ────────────────────");
        // Clean.RunClean();
        //
        // Console.WriteLine("──────────────────── (3) \"SAFE\" CODE ────────────────────");
        // Safe.RunSafe();
        //
        // Console.WriteLine("──────────────────── (4) \"EFFICIENT\" CODE ────────────────────");
        // Efficient.RunEfficient();
        //
        // Console.WriteLine("──────────────────── (5) \"SCALABLE\" CODE ────────────────────");
        // Scalable.RunScalable();





        // Console.WriteLine(
        //     "\n" + "******************** \"CRYPTOGRAPHY\" CODE\" ********************"
        // );
        // Console.WriteLine(
        //     "──────────────────── (1) \"REVERSE CIPHER\" (\"DECRYPTION\") ────────────────────"
        // );
        // ReverseCipher.RunReverseCipher();
        //
        // Console.WriteLine("──────────────────── (2) \"CAESAR CIPHER\" ────────────────────");
        // CaesarCipher.RunCaesarCipher();
        //
        // Console.WriteLine("──────────────────── (3) \"ROT13 ALGORITHM\" ────────────────────");
        // ROT13_Algorithm.RunROT13_Algorithm();
        //
        // Console.WriteLine("──────────────────── (4) \"XOR PROCESS CIPHER\" ────────────────────");
        // XOR_ProcessCipher.Run_XOR_ProcessCipher();
        //
        // Console.WriteLine(
        //     "──────────────────── (5) \"MONOALPHABETIC CIPHER\" ────────────────────"
        // );
        // MonoalphabeticCipher.RunMonoalphabeticCipher();




        Console.WriteLine(
            "\n" + "******************** \"DEPENDENCY INJECTION\" ********************"
        );
        Console.WriteLine(
            "──────────────────── (1) \"DEPENDENCY INJECTION\" IMPLEMENTATION ────────────────────"
        );
        DependencyInjection.RunDependencyInjection();
    }
}
