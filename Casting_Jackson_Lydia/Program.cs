namespace Casting_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asks the user to enter a whole number
            Console.WriteLine("Enter a Whole Number");
            // assigns input to integer
            int myFavNum = Convert.ToInt32(Console.ReadLine());

            // prints favorite number to console
            Console.WriteLine("Your Favorite Number is " + myFavNum);

            // asks user true or false question and assigns response to boolean
            Console.WriteLine("Do You Like Cats? (please enter 'true' or 'false')");
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            // print the result of the question being asked
            Console.WriteLine($"It is {isTrue} that I like cats!");


        }
    }
}