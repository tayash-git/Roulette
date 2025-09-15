using System.Runtime.Serialization.Formatters.Binary;

int cash = 500;

Random rand = new Random();
Logger logger = new Logger();

while (true)
{
    start:

    try
    {
        logger.GeneralLog("Balance", $"${cash}", ConsoleColor.DarkGreen, ConsoleColor.White);

        Console.WriteLine("");

        logger.GeneralLog("1", "Bet on a number (1 - 36)", ConsoleColor.Cyan, ConsoleColor.White);
        logger.GeneralLog("2", "Bet on a color (red / black)", ConsoleColor.Cyan, ConsoleColor.White);
        logger.GeneralLog("3", "Exit", ConsoleColor.Cyan, ConsoleColor.White);
        logger.GeneralLog("4", "Reset data", ConsoleColor.Red, ConsoleColor.White);

        Console.WriteLine("");

        logger.InputLog();

        byte choice = Convert.ToByte(Console.ReadKey().KeyChar);

        if (choice > 4 || choice < 1)
        {
            logger.ErrorLog("Input beyond valid range");

            Thread.Sleep(5000);

            Console.Clear();

            goto start;
        }

        Console.WriteLine("");
    } catch (Exception ex)
    {
        Console.WriteLine("");
        logger.ErrorLog(ex.Message);
        Thread.Sleep(5000);

        Console.Clear();
    }
}

Console.WriteLine("Bet on a number between 0 and 36");
int bet = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bet amount");
int amount = Convert.ToInt32(Console.ReadLine());

if (amount <= cash)
{
    cash -= amount;

    int choosenNumber = rand.Next(1, 2);

    if (bet == choosenNumber)
    {
        amount *= 2;
    } else
    {
        amount = 0;
    }

    cash += amount;

    Console.WriteLine("Number: " + choosenNumber);

    Console.WriteLine("New balance: $" + cash);
} else
{
    Console.WriteLine("Insufficient funds!");
}

class Logger
{
    public void InformationLog(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("[Information]: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(message);
    }

    public void ErrorLog(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("[Error]: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(message);
    }

    public void CriticalLog(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("[Critical]: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
    }

    public void WarningLog(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("[Warning]: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(message);
    }

    public void GeneralLog(string label, string message, ConsoleColor labelColor, ConsoleColor messageColor)
    {
        Console.ForegroundColor = labelColor;
        Console.Write($"[{label}]: ");
        Console.ForegroundColor = messageColor;
        Console.WriteLine(message);
    }

    public void InputLog()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("[>] ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}