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

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("HelloWorld!");
        RunTypesDemo();
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

}






