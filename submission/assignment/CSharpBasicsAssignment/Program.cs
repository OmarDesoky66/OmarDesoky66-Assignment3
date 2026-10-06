// Program.cs => is where you can write your C# code. The code will be executed when you run the application.
// .csproj => is the project file that contains information (target framework and language version) about the project, such as its name, version, and dependencies
// .bin => is the folder where the compiled output of the project is stored. It contains the executable file and Intermediate Language (IL) code (.dll).
// .obj => is the folder where the intermediate files generated during the build process are stored


/* my project uses .slnx because :
1) .slnx is simpler so it's easier to understand what projects are included in the solution
2)  Better for Git
*/


// File-scoped namespaces (;) eliminate the extra indentation caused by namespace braces.



namespace CSharpBasicsAssignment;

struct Point
{
    public int X;
    public int Y;
}



class Program
{
    //Add a private field to your Program/class and read it from two different methods (field scope).
    private static int number = 100; //both methods(1,2) can access it:

    static void MethodOne()
    {
        Console.WriteLine(number);
    }

    static void MethodTwo()
    {
        Console.WriteLine(number);
    }
    // Write a method with a local variable that is not visible outside that method(method scope).
    static void MethodScopeDemo()
    {
        int localNumber = 50; // only visible in this method

        Console.WriteLine(localNumber);
    }

    
    static void Main(string[] args)
    {

        

        Order o1 = new Order
        {
            OrderId = 1001,
            CustomerName = "Omar",
            Quantity = 2,
            UnitPrice = 100m,
            TotalPrice = 0m,
            IsPaid = false,
            DiscountPercent = 10,
            ShippingCity = "BeniSuef",
            Priority = 'H',
            ItemCode = 123456L
        };

        o1.CalculateTotal();

        Order o2 = o1;
        o2.IsPaid = true;

        // Order is a reference type, so assigning o1 to o2 copies the reference.
        Console.WriteLine($"o1.IsPaid = {o1.IsPaid}");
        Console.WriteLine($"o2.IsPaid = {o2.IsPaid}");

        object boxedOrder = o1;
        Order o3 = (Order)boxedOrder;

        Console.WriteLine(object.ReferenceEquals(o1, o3));

        o2.PrintSummary();

        /*
         Value types store their actual values, while reference types store a reference
         to an object that lives on the heap. Assigning a value type copies the value,
         so changing the copy does not affect the original. Assigning a reference type
         copies the reference, so both variables point to the same object. Storing a
         reference type in an object variable does not create a new object; it stores
         the same reference.
         */

        RunTypesDemo();
        RunValueVsReferenceDemo();


        for (int i = 0; i < 2; i++)
        {

            // local variables, only visible in this loop iteration
            int localVar = i * 10;
            Console.WriteLine(i);
            Console.WriteLine(localVar);
        }

        for (int i = 0; i < 2; i++)
        {

            // local variables, only visible in this loop iteration
            int localVar = i * 10;

        }
        // Console.WriteLine(i);                            // Error: 'i' does not exist in the current context {}
        // Console.WriteLine(localVar);                     // Error: 'localVar' does not exist in the current context {}


        int total = 100;
        total += 5;       // means total = total + 5;
        Console.WriteLine(total);

        total -= 10;      // means total = total - 10;
        Console.WriteLine(total);

        total *= 2;         // means total = total * 2;
        Console.WriteLine(total);

        total /= 5;       // means total = total / 5;   
        Console.WriteLine(total);

        total %= 7;         // means total = total % 7;
        Console.WriteLine(total);


        int a = 12; // 1100 in binary
        int b = 10; // 1010 in binary
        //Print a & b, a | b, and a ^ b, and in a comment show the binary of each operand and the bit-by-bit result.
        Console.WriteLine($"a & b = {a & b}"); // 12 & 10 = 8 => 1100 & 1010 = 1000
        
        Console.WriteLine($"a | b = {a | b}"); // 12 | 10 = 14 => 1100 | 1010 = 1110

        Console.WriteLine($"a ^ b = {a ^ b}"); // 12 ^ 10 = 6 => 1100 ^ 1010 = 0110



        
        //In one sentence, explain the practical difference between & (bitwise) and && (logical) — specifically, what happens differently when the left operand is false in an if-condition.
       
        
        // The bitwise AND (&) operator performs a bit-by-bit comparison of two operands, while the logical AND (&&) operator evaluates the second operand only if the first is true.

    }

    static void RunTypesDemo()
    {
        //  Declare a variable of every type:
        //int, long, double, decimal, bool, char, string, and one inferred with var 
        //— print each value and its runtime type using .GetType().
        int myInt = 42;
        long myLong = 1234567890123456789;
        double myDouble = 3.14159d;
        decimal myDecimal = 19.99m;
        bool myBool = true;
        char myChar = 'A';
        string myString = "Omar";
        var myVar = 100;

        Console.WriteLine($"int: {myInt}, Type: {myInt.GetType()}");
        Console.WriteLine($"long: {myLong}, Type: {myLong.GetType()}");
        Console.WriteLine($"double: {myDouble}, Type: {myDouble.GetType()}");
        Console.WriteLine($"decimal: {myDecimal}, Type: {myDecimal.GetType()}");
        Console.WriteLine($"bool: {myBool}, Type: {myBool.GetType()}");
        Console.WriteLine($"char: {myChar}, Type: {myChar.GetType()}");
        Console.WriteLine($"string: {myString}, Type: {myString.GetType()}");
        Console.WriteLine($"var: {myVar}, Type: {myVar.GetType()}");

        Console.WriteLine("=============================");

        Console.WriteLine(" Implicit Conversion ");

        int smallNumber = 100;
        long largeNumber = smallNumber;

        char letter = 'A';
        int characterNumber = letter;

        // no cast is required because these conversions are implicit and safe.
        // Implicit conversion from int to long is safe because long has a larger range than int.
        Console.WriteLine($"int to long: {largeNumber}");
        // Implicit conversion from char to int is safe because char can be represented as an integer value (ASCII).
        Console.WriteLine($"char to int: {characterNumber}");

        Console.WriteLine("=============================");


        Console.WriteLine("Explicit Conversion");

        //cast a double to an int with (int)

        double Test = 3.5;
        int test2 = (int)Test;
        //with Convert.ToInt32
        int test3 = Convert.ToInt32(Test);



        // The explicit cast (int) truncates the decimal part, while Convert.ToInt32 rounds the value to the nearest integer
        Console.WriteLine($"double to int (cast): {test2}");
        Console.WriteLine($"double to int (Convert.ToInt32): {test3}");


        Console.WriteLine("=============================");

        Console.WriteLine("Integer Division");

        int num = 5 / 2;
        double num2 = 5.0 / 2;


        // Integer division discards the decimal part, while double division does not.
        Console.WriteLine($"5 / 2 = {num} (integer division)");
        Console.WriteLine($"5.0 / 2 = {num2} (floating-point division)");

        //Boxing and Unboxing
        Console.WriteLine("=============================");

        int x = 5;
        object obj = x; // Boxing

        Console.WriteLine($"Boxing: int {x} is boxed into object {obj}");
        int y = (int)obj; // Unboxing
        Console.WriteLine($"Unboxing: object {obj} is unboxed into int {y}");


        Console.WriteLine("=============================");

        Console.WriteLine("Parsing");
        // can not be a null value because int.Parse() will throw an exception if the input string is null or not a valid integer representation.
        string numberString = "123";
        int parsedNumber = int.Parse(numberString);
        Console.WriteLine($"Parsed number: {parsedNumber}");

        // Bad String
        string badNumberString = "abc";

        bool success = int.TryParse(badNumberString, out int result);
        Console.WriteLine($"TryParse success: {success}, result: {result}");

        Console.WriteLine("=============================");

        Console.WriteLine("Float to Decimal");

        float value = 3.14f;
        decimal decimalValue = (decimal)value;
        Console.WriteLine($"Float {value} converted to Decimal: {decimalValue}");


        /* Why the compiler refuses the implicit version ??
        // Answer : because the representation format of float and decimal are different
        , and implicit conversion could lead to loss of precision or unexpected behavior.
        */
    }
    static void RunValueVsReferenceDemo()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;

        p2.X = 99;
        Console.WriteLine($"p1.X = {p1.X}, p2.X = {p2.X}"); // they must differ
        //Explain why in a comment
        // Answer: Because Point is a value type (struct), when we assign p1 to p2, a copy of the data is made.
    }


}






