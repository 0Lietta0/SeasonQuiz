
string? readResult;

//-welcome user
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

////-get username
//string userName = "";
//do
//{
//    Console.Write("\nWrite your username: ");
//    readResult = Console.ReadLine();
//    if (readResult != null)
//        userName = readResult.Trim();
//} while (userName == "");

//Console.WriteLine($"\nWelcome {userName}!");
//Console.WriteLine("\nPress enten to start.");

//Console.ReadLine();
//Console.Clear();

//-ask 5 questions(a, b, c, d)

Console.WriteLine("Which color do you like the most?.");
WriteAnswers("green", "yellow", "red", "blue\n");
do
{
    RightAnswers();

} while (RightAnswers() == false);



//- display result

void WriteAnswers(string a, string b, string c, string d)
{
    Console.WriteLine("a) {0}\tb) {1}\tc) {2}\td) {3}", a, b, c, d);
}

bool RightAnswers()
{
    string userAnswer = "";

    readResult = Console.ReadLine();
    if (readResult != null)
        userAnswer = readResult.Trim().ToLower();

    if (userAnswer == "a" || userAnswer == "b" || userAnswer == "c" || userAnswer == "d")
    {
        return true;
    }
    else
    {
        Console.WriteLine("\nSorry, you're answer is incorrect. Write: a, b, c or d to continue.\n");
        return false;
    }
}