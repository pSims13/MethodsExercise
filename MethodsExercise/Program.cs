namespace MethodsExercise
{
    public class Program
    {
        //Method to collect persons favourite arcade game
        public static string GetPersonsFavouriteArcadeGame()
        {
            Console.WriteLine("What is your favourite arcade game?");

            string arcadeGame = Console.ReadLine();
            return arcadeGame;

        }
        
        //Method to collect how much money the person has
        public static decimal GetNumberOfDollarsFromPerson()
        {
            Console.WriteLine("How many dollars do you have?");

            decimal dollars = decimal.Parse(Console.ReadLine()); 
            return dollars;
        }
        
        //Method to collect what the persons favourite color is
        public static string GetPersonsFavouriteColor()
        {
            Console.WriteLine("What is your favourite color?");

            string color = Console.ReadLine();
            return color;
        }
        
        //Method to collect the persons name
        public static string GetPersonNameFromUser()
        {
            Console.WriteLine("Please give me your name:");

            string name = Console.ReadLine();
            return name;

        }
        static void Main(string[] args)
        {

            //Assigning values to variables by calling their respective methods
            string name = GetPersonNameFromUser();
            string color = GetPersonsFavouriteColor();
            decimal dollars = GetNumberOfDollarsFromPerson();
            string arcadeGame = GetPersonsFavouriteArcadeGame();
            
            //Used string interpolation to creat a short story from the info collected from user
            Console.WriteLine($"Hello my name is {name}. Growing up and still today my favourite color has always been {color}.");
            Console.WriteLine($"I've been working really hard and managed to save up ${dollars}. That should be enough to play several games of my favourite arcade game {arcadeGame}!");


        }
    }
}
