// Program.cs => is where you can write your C# code. The code will be executed when you run the application.
// .csproj => is the project file that contains information (target framework and language version) about the project, such as its name, version, and dependencies
// .bin => is the folder where the compiled output of the project is stored. It contains the executable file and Intermediate Language (IL) code (.dll).
// .obj => is the folder where the intermediate files generated during the build process are stored




// File-scoped namespaces (;) eliminate the extra indentation caused by namespace braces.
namespace CSharpBasicsAssignment;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("HelloWorld!");
    }
}


/* my project uses .slnx because 
1) .slnx is simpler so it's easier to understand what projects are included in the solution
2)  Better for Git
*/
