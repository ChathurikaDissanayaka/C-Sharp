Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

// If the player scores greater or equal to 16, they'll win a new car.
// If the player scores greater or equal to 10, they'll win a new laptop.
// If the player scores exactly 7, they'll win a trip.
// Otherwise, the player wins a kitten.

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}