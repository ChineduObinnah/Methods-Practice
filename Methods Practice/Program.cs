internal class Program
{
        public static void Main(string[] args)
        {
            MadLib();
        
        }
    public static void MadLib()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName} what is your favorite color? ");
        string favColor = Console.ReadLine();
        Console.WriteLine("That's a cool color!");
        Console.WriteLine("Alright next, pick a number between 1- infinite!");
        string favNumb = Console.ReadLine();
        Console.WriteLine(" I totally knew you were going to pick that number");
        Console.WriteLine("What are you thoughts on trees?");
        string favTrees = Console.ReadLine();

        Console.WriteLine($"One day,{userName} went skydiving they were wearing their favorite{favColor} shirt. " +
            $"They were{favNumb} years old when they jumped and they thought that trees were {favTrees}");


    }
}