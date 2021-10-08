using System;
using HouseFunction;
// Comment

/*

    Will be a comment
    - We use Paselcase for the most part and that means naming artifacts as EverythingWillBeCapitalized
    - We use camelCase for naming fields and that means naming artifacts as onlyOnceYouHaveALowerCaseWordAtTheBeginning

*/
namespace HelloWorld
{
    class Program
    {
        /*
            - Main method is the first method that will called/run. (The complier will look for this method)
            - Static means, I don't have to instantiate the profram class to use that method
        */
        static void Main(string[] args)
        {
            // It will print the test inside the parenthesis onto the terminal
            Console.WriteLine("Hello World!");

        // This is if you don't make the method static you have to instantiate it    
        //Program test = new Program(); //This will instantiate the obj
        //test.Example();

        Program.Example();

        House JaMia = new House();
        // Console.WriteLine(JaMia.owner);
        JaMia.Micename = "Jerry";
        Console.WriteLine(JaMia.Micename);

        }

        public static int Example()

        {
            return 10;
        }
    }
}
