namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();
            Console.WriteLine($"Once upon a time, {name} had a pet {favoriteAnimal} that was the color {favoriteColor}. " +
                $"\n{name}'s amazing {favoriteAnimal} became the mascot of {favoriteBand}.\nThe end.");
        }
    }
}