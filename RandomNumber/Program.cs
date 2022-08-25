Console.WriteLine("Random Number Game");
Console.WriteLine("Give a number : ");
string userInput = Console.ReadLine();
int userNumber, randomNumber, counter = 1;
Random random = new Random();
randomNumber = random.Next(8, 69);
do
{
    if (!int.TryParse(userInput, out userNumber))
    {
        Console.WriteLine("Wrong Input! Try again");
    }
    else
    {
        if(userNumber < 8 || userNumber > 69)
        {
            Console.WriteLine("Number out of range! Try again");
        }
        else
        {
            if (randomNumber == userNumber)
            {
                
                Console.WriteLine("You won!", Console.ForegroundColor = ConsoleColor.Red);
                break;
            }
            else if (randomNumber < userNumber)
            {
                Console.WriteLine("My number is smaller then yours!", Console.ForegroundColor = ConsoleColor.Yellow);
            }
            else if (randomNumber > userNumber)
            {
                Console.WriteLine("My number is greater then yours", Console.ForegroundColor = ConsoleColor.Cyan);
            }
            counter++;
        }
    }
    Console.ForegroundColor = ConsoleColor.White;
    userInput = Console.ReadLine();
} while (randomNumber != userNumber);

if(counter == 0)
{
    Console.WriteLine("You guess in the first try! Congratulations!", Console.ForegroundColor = ConsoleColor.Red);
}
else
{
    Console.WriteLine("It took you " + counter + " rounds to guess the number", Console.ForegroundColor = ConsoleColor.Red);
}

Console.ForegroundColor = ConsoleColor.White;

