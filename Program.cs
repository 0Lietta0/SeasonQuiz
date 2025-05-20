
using System.Xml;

string? readResult;

//welcome user - colored text
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\tQ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("U");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("I");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Z");
Console.ResetColor();
Console.WriteLine("\nWhich season are you?");

//get username
string userName = "";
do
{
    Console.Write("\nWrite your username: ");
    readResult = Console.ReadLine();
    if (readResult != null)
        userName = readResult.Trim();
} while (userName == "");

Console.WriteLine($"\nWelcome {userName}!");
Console.WriteLine("\nPress enter to start.");

Console.ReadLine();
Console.Clear();

//ask 5 questions(a, b, c, d)

//defining variables
string userAnswer = "";
int answerA = 0;
int answerB = 0;
int answerC = 0;
int answerD = 0;
string userResult = "";

//asking questions
AskQuestion("Which color do you like the most?", "green", "yellow", "red", "blue");
AskQuestion("Which weather is the best for you?", "sunny", "extremaly hot", "rainy", "freezing cold");
AskQuestion("Choose an activity you like the most?", "gardening", "sunbathing", "walking", "skiing");
AskQuestion("Which drink do you enjoy the most?", "green tea", "cold lemonade", "pumpkin spice latte", "hot cocoa");
AskQuestion("What is your favourite thing to wear?", "practical raincoat", "cool sunglasses", "high-end jacket", "cozy scarf");

CheckResult();

//display result

ShowResult();

Console.WriteLine($"\nThank you {userName} for taking the quiz! I hope you had fun! ");
Console.WriteLine("\nIf you would like to retake the quiz, just launch the application one more time.");
Console.ReadLine();

void AskQuestion(string question, string answerA, string answerB, string answerC, string answerD)
{
    Console.WriteLine($"{question}\n");
    WriteAnswers(answerA, answerB, answerC, answerD);
    Console.WriteLine();
    CheckAnswer();
    CountPoints();
    Console.Clear();
}
void WriteAnswers(string a, string b, string c, string d)
{
    Console.WriteLine("a) {0}\tb) {1}\tc) {2}\td) {3}", a, b, c, d);
}
void CheckAnswer()
{
    bool rightAnswer = false;

    do
    {
        readResult = Console.ReadLine();
        if (readResult != null)
            userAnswer = readResult.Trim().ToLower();

        if (userAnswer == "a" || userAnswer == "b" || userAnswer == "c" || userAnswer == "d")
        {
            rightAnswer = true;
        }
        else
        {
            Console.WriteLine("\nSorry, you're answer is incorrect. Write: a, b, c or d to continue.\n");
        }
    } while (rightAnswer == false);
}
void CountPoints()
{
    switch(userAnswer)
    {
        case "a": answerA++;
            break;
        case "b": answerB++;
            break;
        case "c": answerC++;
            break;
        case "d": answerD++;
            break;
    }
}
void CheckResult()
{
    if(answerA>answerB && answerA>answerC && answerA>answerD)
    {
        userResult = "spring";
    }
    else if (answerB>answerA && answerB>answerC && answerB>answerD)
    {
        userResult = "summer";
    }
    else if (answerC > answerA && answerC > answerB && answerC > answerD)
    {
        userResult = "autumn";
    }
    else if (answerD > answerA && answerD > answerB && answerD > answerC)
    {
        userResult = "winter";
    }
    else
    {
        userResult = "mixed";
    }
}
void ShowResult()
{
    switch (userResult)
    {
        case "spring":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You are a Spring! Just like this season, you bring " +
                "a sense of renewal and growth wherever you go. Your vibrant personality " +
                "and enthusiasm for new beginnings make you a breath of fresh air in any situation.");
            break;
        case "summer":
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are a Summer! Much like this warm and sunny season, " +
                "you radiate positivity and energy. Your outgoing nature and love " +
                "for adventure make you the life of the party, always ready to soak up " +
                "the sun and create unforgettable memories.");
            break;
        case "autumn":
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You are an Autumn! Much like this season of change and harvest, " +
                "you have a reflective and grounded personality. Your ability to find beauty " +
                "in both the vibrant and fading aspects of life sets you apart. Your thoughtfulness and " +
                "appreciation for life's transitions make you a reassuring presence during times of change.");
            break;
        case "winter":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You are a Winter! Similar to this time of cozy snowfalls " +
                "and warm beverages, you have a calm and introspective demeanor. " +
                "Your thoughtfulness and ability to find beauty in simplicity make you " +
                "a comforting presence during the chilly days of life.");
            break;
        case "mixed":
            Console.WriteLine("Your result is Mixed! Just like the changing seasons, " +
                "you embody a bit of everything. You're adaptable and open-minded, " +
                "able to connect with people from all walks of life. Your versatility and " +
                "willingness to embrace change make you a true chameleon.");
            break;
    }
    Console.ResetColor();
}
