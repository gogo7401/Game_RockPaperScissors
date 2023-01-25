// This is a simple console game Rock Paper Scissors.

const string rock = "Rock";
const string paper = "Paper";
const string scissors = "Scissors";

while (true)
{
    Console.Clear();

    // input Player Move
    Console.Write("Choice [r]ock, [p]aper, [s]cissors or [q]uit: ");
    
    string? playerMove = Console.ReadLine();

    bool isValid = false;
    string outcome = "";
    // Validate player choice
    while (!isValid)
    {
        if (playerMove == "r" || playerMove == "rock" || playerMove == "Rock" || playerMove == "ROCK")
        {
            playerMove = rock;
            isValid = true;
        }
        else if (playerMove == "p" || playerMove == "paper" || playerMove == "Paper" || playerMove == "PAPER")
        {
            playerMove = paper;
            isValid = true;
        }
        else if (playerMove == "s" || playerMove == "scissors" || playerMove == "Scissors" || playerMove == "SCISSORS")
        {
            playerMove = scissors;
            isValid = true;
        }
        else if (playerMove == "q" || playerMove == "quit" || playerMove == "Quit" || playerMove == "QUIT")
        {
            Console.WriteLine("Good bye!");
            return;
        }
        else
        {
            Console.WriteLine("Invalid choice!");
            Console.WriteLine("You can choose between [r]ock, [p]aper, [s]cissors or [q]uit. Try again!");
            Console.Write("Please choose: ");
            playerMove = Console.ReadLine();
            if (playerMove == "q" || playerMove == "quit" || playerMove == "Quit" || playerMove == "QUIT")
            {
                Console.WriteLine("Good bye!");
                return;
            }
        }
    }


    // Generate Computer Move
    Random random = new Random();
    string computerMove = "";
    int computerChoice = random.Next(1, 4);
    switch (computerChoice)
    {
        case 1:
            computerMove = rock;
            break;
        case 2:
            computerMove = paper;
            break;
        case 3:
            computerMove = scissors;
            break;
    }

    // Check for Winner
    if (playerMove == rock)
    {
        if (computerMove == rock)
        {
            outcome = "Draw";
        }
        else if (computerMove == paper)
        {
            outcome = "You lose";
        }
        else if (computerMove == scissors)
        {
            outcome = "You win";
        }
    }
    else if (playerMove == paper)
    {
        if (computerMove == rock)
        {
            outcome = "You win";
        }
        else if (computerMove == paper)
        {
            outcome = "Draw";
        }
        else if (computerMove == scissors)
        {
            outcome = "You lose";
        }
    }
    else if (playerMove == scissors)
    {
        if (computerMove == rock)
        {
            outcome = "You lose";
        }
        else if (computerMove == paper)
        {
            outcome = "You win";
        }
        else if (computerMove == scissors)
        {
            outcome = "Draw";
        }
    }

    // Print Winner
    Console.WriteLine($"Your choice: {playerMove}");
    Console.WriteLine($"Computer choice: {computerMove}");
    Console.WriteLine(outcome);

    // Let's play again?
    Console.Write("Let's play again? ([Y]es or [N]o): ");
    string? playerChoice = Console.ReadLine();
    while (true)
    {
        if (playerChoice == "N" || playerChoice == "n" || playerChoice == "No" || playerChoice == "NO")
        {
            Console.WriteLine("Good bye!");
            return;
        }
        else if (playerChoice != "Y" && playerChoice != "y" && playerChoice != "Yes" && playerChoice != "YES")
        {
            Console.WriteLine("Your choice is incomprehensible to me!");
            Console.Write("Let's play again? ([Y]es or [N]o): ");
            playerChoice = Console.ReadLine();
        }
        else
        {
            break;
        }

    }
}

