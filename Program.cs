using NumberGuessingGame;

var running = true;

// Main app loop
while (running)
{
    gameRules();
    
    try
    {
        var level = Console.ReadLine();
        string difficulty;
        int attempts;
        if(level == "exit")
        {
            Console.WriteLine("Are you sure you want to exit? Y/N");
            var confirmExit = Console.ReadLine().ToLower();
            
            if(confirmExit == "y")
            {
                running = false;
                break;
            }
            else if (confirmExit == "n")
            {
                resetApp();
                continue;
            }
            else
            {
                Console.WriteLine("Invalid input try again.");
                resetApp();
                continue;
            }
        }

        switch (Convert.ToInt32(level))
        {
            case 1:
                attempts = 10;
                difficulty = "Easy";
                gameLogic(attempts,difficulty);
                break;
            case 2:
                attempts = 5;
                difficulty = "Medium";
                gameLogic(attempts, difficulty);
                break;
            case 3:
                attempts = 3;
                difficulty = "Hard";
                gameLogic(attempts, difficulty);
                break;
            default:
                Console.WriteLine("Invalid Input.Try again");
                resetApp();
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Invalid Input.Try again");
        resetApp();

    }

    
 
}

// Function for clearing console and avoid unnecessary scroll
void resetApp()
{
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}

// Function for main game rules avoid repetition 
void gameRules()
{
    Console.WriteLine("Hello & Welcome to Number Guessing Game.\n\nThe Rules are as follows:\n");
    Console.WriteLine("Computer will Choose a Random number between 1 to 100.");
    Console.WriteLine("You have only limited chances to guess.");
    Console.WriteLine("You have to guess the number in minimum attempts to win.");
    Console.WriteLine("If you can't guess the number game will say that the number is higher or lower than your guess.");
    Console.WriteLine("The number of the chances you have depends on the difficulty level you choose.\n");
    Console.WriteLine("1. Easy (10 attempts)");
    Console.WriteLine("2. Medium (5 attempts)");
    Console.WriteLine("3. Hard (3 attempts)\n");
    Console.WriteLine("You can restart the game by typing 'restart' instead of a number.");
    Console.WriteLine("You can exit the application any time by typing 'exit' instead of a number\n");
    Console.WriteLine("First, Choose the difficulty level by entering 1, 2 or 3.");
}

// Reminder of game rules avoid repetition
void gameRulesReminder()
{
    Console.WriteLine("Computer will Choose a Random number between 1 to 100.");
    Console.WriteLine("You have only limited chances to guess.");
    Console.WriteLine("You have to guess the number in minimum attempts to win.");
    Console.WriteLine("You can restart the game by typing 'restart' instead of a number. ");
    Console.WriteLine("You Can exit the game anytime by entering 'exit' instead of a number.\n");
}

// Main game logic
void gameLogic(int attempts,string difficulty)
{
    var computerNumber = Computer.chooseANumber();
    var userTrys = 0;
    while (attempts > 0)
    {

        Console.WriteLine($"Your difficulty is set to {difficulty}. You have {attempts} attempts to guess the number.");
        Console.WriteLine("Enter your guess:");
        var userInput = Console.ReadLine();
        if (userInput.ToLower() == "exit")
        {
            Console.WriteLine("Are you sure you want to exit? Y/N");

            var confirmExit = Console.ReadLine().ToLower();
            // logic for confirming exit
            if (confirmExit == "y")
            {
                running = false;
                break;
            }
            else if (confirmExit == "n")
            {
                resetApp();
                gameRulesReminder();
                continue;
            }
            else
            {
                Console.WriteLine("Invalid input try again.");
                resetApp();
                gameRulesReminder();
                continue;
            } 
            // logic for application game reset
        }
        else if (userInput.ToLower() == "restart")
        {

            Console.WriteLine("Are you sure you want to reset the game ? Y/N");

            var confirmReset = Console.ReadLine().ToLower();

            if (confirmReset == "y")
            {
                resetApp();
                return;
            }else if(confirmReset == "n")
            {
                resetApp();
                gameRulesReminder();
                continue;
            }
            else
            {
                Console.WriteLine("Invalid input try again.");
                resetApp();
                gameRulesReminder();
                continue;
            }
        }
            try
            {
                var userGuess = Convert.ToInt16(userInput);
                if (userGuess < 1 || userGuess > 100)
                {
                    Console.WriteLine("Your guess is out of range. Please enter a number between 1 and 100.");
                    resetApp();
                    gameRulesReminder();
                    continue;
                }
                if (userGuess == computerNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number {computerNumber} correctly in {userTrys} attempts!");
                    resetApp();
                    break;
                }
                else if (userGuess < computerNumber)
                {
                    attempts--;
                    userTrys++;
                    Console.WriteLine($"The number is higher than {userGuess}. You have {attempts} attempts left.");
                    resetApp();
                    gameRulesReminder();
                }
                else
                {
                    attempts--;
                    userTrys++;
                    Console.WriteLine($"The number is lower than {userGuess}. You have {attempts} attempts left.");
                    resetApp();
                    gameRulesReminder();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input.Try again");
                resetApp();
                gameRulesReminder();
            }
        if (attempts == 0)
        {
            Console.WriteLine($"Sorry, you've used all your attempts. The correct number was {computerNumber}.");
            resetApp();
        }
    }
}
