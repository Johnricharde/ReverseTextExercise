namespace ReverseTextExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            char[] charArray = userInput.ToCharArray();

            Array.Reverse(charArray);

            string reversedString = new string(charArray);

            Console.WriteLine($"{reversedString}");
        }
    }
}
