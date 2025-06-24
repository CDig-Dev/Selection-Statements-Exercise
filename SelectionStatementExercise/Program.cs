namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
          var random = new Random();
          var favNumber = random.Next(1, 11);
          
          Console.WriteLine("Give me a number:");
          int response = int.Parse(Console.ReadLine());

          if (response < favNumber)

          {
           Console.WriteLine($"Too Low!\n Your guess: {response}");
          }
          else if (response > favNumber)

          {
              Console.WriteLine($"Too High!\n Your guess: {response}");
          }
          else
          {
              Console.WriteLine($"You guessed it!\nThe favorite number was {favNumber}");
          }
          
        }
    }
}
