internal class Program
{
    private static void Main(string[] args)
    {
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        if ((roll1 == roll2 || (roll2 == roll3) || (roll1 == roll3)))
        {
            Console.WriteLine("Aye, you got doubles. You get 2 extra nuggets!");
            total += 2;
        }

        if ((roll1 == roll2) && (roll2 == roll3)) 
        {
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        }

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if (total >= 10)
        {
            Console.WriteLine("You Win. Go you, yayyy");
        }

        else
        {
            Console.WriteLine("Sucks to be you, loser");
        }
        
    }
}