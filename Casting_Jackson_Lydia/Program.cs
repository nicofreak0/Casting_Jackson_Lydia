namespace Casting_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Whole Number");
            int myFavNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Favorite Number is " + myFavNum);

            Console.WriteLine("Do You Like Cats? (please enter 'true' or 'false')");
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"It is {isTrue} that I like cats!");


        }
    }
}