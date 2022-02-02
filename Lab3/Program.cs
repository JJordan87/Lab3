

bool runProgram = true;
string userGoAgain;
int i;

Console.WriteLine("Learn your squares & cubes!");
while(true)
{
    Console.Write("Enter a integer between 1 and 1289: ");
    int choosenNum = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (choosenNum <= 0)
    {
        Console.WriteLine("Please choose a positive integer.");
        continue;
    }
    else if (choosenNum > 1290)
    {
        Console.WriteLine("Please select a smaller number");
        continue;
    }

    Console.WriteLine(String.Format("{0,6} {1,12} {2,18}", "Number", "Squared", "Cubed"));
    Console.WriteLine(String.Format("{0,6} {1,12} {2,18}", "=======", "=======", "======"));
    for (i = 1; i <= choosenNum; i++)
    {
        int cube = cubed(i);
        int square = squared(i);
        Console.WriteLine(String.Format("{0,6} {1,12} {2,18}", i, square, cube));
    }
    if (i >= choosenNum)
    {
        Console.WriteLine();
        Console.WriteLine("Would you like to run the program again? Enter [y]or[n]");
        userGoAgain = Console.ReadLine().ToLower();
        if (userGoAgain == "y")
        {
            runProgram = true;
            continue;
        }
        else if (userGoAgain == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("not a valid input");
        }
    }
}

//methods
static int cubed(int x)
{
    return (int)Math.Pow(x, 3);
}
static int squared(int y)
{
    return (int)Math.Pow(y, 2);
}
