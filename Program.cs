
using System.Xml;

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

string userAnswer = "";
int answerA = 0;
int answerB = 0;
int answerC = 0;
int answerD = 0;
string userResult = "";

Console.WriteLine("Which color do you like the most?.");
WriteAnswers("green", "yellow", "red", "blue\n");
CheckAnswer();
CountPoints();


CheckResult();

//- display result

ShowResult();

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
    Console.WriteLine();
    switch (userResult)
    {
        case "spring":
            Console.WriteLine("spring");
            break;
        case "summer":
            Console.WriteLine("summer");
            break;
        case "autumn":
            Console.WriteLine("autumn");
            break;
        case "winter":
            Console.WriteLine("winter");
            break;
        case "mixed":
            Console.WriteLine("mixed");
            break;
    }
}