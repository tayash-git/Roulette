using System.Text;

byte[] introData = {
    36, 36, 36, 36, 36, 36, 36,
    92, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    36, 36, 92, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 36, 36, 92, 32, 32, 32,
    32, 32, 36, 36, 92, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 13, 10, 36,
    36, 32, 32, 95, 95, 36, 36,
    92, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 36,
    36, 32, 124, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    36, 36, 32, 124, 32, 32, 32,
    32, 36, 36, 32, 124, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 13, 10, 36,
    36, 32, 124, 32, 32, 36, 36,
    32, 124, 32, 36, 36, 36, 36,
    36, 36, 92, 32, 32, 36, 36,
    92, 32, 32, 32, 36, 36, 92,
    32, 36, 36, 32, 124, 32, 36,
    36, 36, 36, 36, 36, 92, 32,
    36, 36, 36, 36, 36, 36, 92,
    32, 36, 36, 36, 36, 36, 36,
    92, 32, 32, 32, 32, 36, 36,
    36, 36, 36, 36, 92, 32, 32,
    13, 10, 36, 36, 36, 36, 36,
    36, 36, 32, 32, 124, 36, 36,
    32, 32, 95, 95, 36, 36, 92,
    32, 36, 36, 32, 124, 32, 32,
    36, 36, 32, 124, 36, 36, 32,
    124, 36, 36, 32, 32, 95, 95,
    36, 36, 92, 92, 95, 36, 36,
    32, 32, 95, 124, 92, 95, 36,
    36, 32, 32, 95, 124, 32, 32,
    36, 36, 32, 32, 95, 95, 36,
    36, 92, 32, 13, 10, 36, 36,
    32, 32, 95, 95, 36, 36, 60,
    32, 36, 36, 32, 47, 32, 32,
    36, 36, 32, 124, 36, 36, 32,
    124, 32, 32, 36, 36, 32, 124,
    36, 36, 32, 124, 36, 36, 36,
    36, 36, 36, 36, 36, 32, 124,
    32, 36, 36, 32, 124, 32, 32,
    32, 32, 36, 36, 32, 124, 32,
    32, 32, 32, 36, 36, 36, 36,
    36, 36, 36, 36, 32, 124, 13,
    10, 36, 36, 32, 124, 32, 32,
    36, 36, 32, 124, 36, 36, 32,
    124, 32, 32, 36, 36, 32, 124,
    36, 36, 32, 124, 32, 32, 36,
    36, 32, 124, 36, 36, 32, 124,
    36, 36, 32, 32, 32, 95, 95,
    95, 95, 124, 32, 36, 36, 32,
    124, 36, 36, 92, 32, 36, 36,
    32, 124, 36, 36, 92, 32, 36,
    36, 32, 32, 32, 95, 95, 95,
    95, 124, 13, 10, 36, 36, 32,
    124, 32, 32, 36, 36, 32, 124,
    92, 36, 36, 36, 36, 36, 36,
    32, 32, 124, 92, 36, 36, 36,
    36, 36, 36, 32, 32, 124, 36,
    36, 32, 124, 92, 36, 36, 36,
    36, 36, 36, 36, 92, 32, 32,
    92, 36, 36, 36, 36, 32, 32,
    124, 92, 36, 36, 36, 36, 32,
    32, 124, 92, 36, 36, 36, 36,
    36, 36, 36, 92, 32, 13, 10,
    92, 95, 95, 124, 32, 32, 92,
    95, 95, 124, 32, 92, 95, 95,
    95, 95, 95, 95, 47, 32, 32,
    92, 95, 95, 95, 95, 95, 95,
    47, 32, 92, 95, 95, 124, 32,
    92, 95, 95, 95, 95, 95, 95,
    95, 124, 32, 32, 92, 95, 95,
    95, 95, 47, 32, 32, 92, 95,
    95, 95, 95, 47, 32, 32, 92,
    95, 95, 95, 95, 95, 95, 95,
    124, 13, 10, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 13, 10,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 13, 10,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32,
    32, 32, 32, 32, 32, 32, 32
};

int cash = 500;

Random rand = new Random();
Logger logger = new Logger();

logger.InformationLog("Locating data.dat");

Thread.Sleep(500);

try
{
    if (!File.Exists("data/data.dat"))
    {
        logger.WarningLog("data.dat not found. Setting up new file");

        Directory.CreateDirectory("data");

        using (FileStream fs = File.Create("data/data.dat"))

        Thread.Sleep(2500);

        File.WriteAllBytes("data/data.dat", Encoding.UTF8.GetBytes(cash.ToString()));

        Thread.Sleep(2000);

        logger.GeneralLog("Success", "data.dat created", ConsoleColor.DarkGreen, ConsoleColor.White);

        Thread.Sleep(3000);
    }
    else
    {
        logger.GeneralLog("Success", "data.dat found", ConsoleColor.DarkGreen, ConsoleColor.White);
        Thread.Sleep(200);

        logger.InformationLog("Loading data");

        cash = Convert.ToInt32(Encoding.UTF8.GetString(File.ReadAllBytes("data/data.dat")));

        logger.GeneralLog("Success", "Loaded data", ConsoleColor.DarkGreen, ConsoleColor.White);

        Thread.Sleep(3000);
    }
}
catch (Exception ex)
{
    logger.CriticalLog(ex.Message + " Closing application.");

    Thread.Sleep(5000);

    Environment.Exit(0);
}

Console.Clear();

Console.ForegroundColor = ConsoleColor.Magenta;

Console.WriteLine(Encoding.UTF8.GetString(introData));

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.White;

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

        byte input = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("");

        switch (input)
        {
            case 1:
                Console.Clear();

                logger.InformationLog("Bet on a number between 0 and 36");
                int bet = Convert.ToInt32(Console.ReadLine());

                logger.InformationLog("Insert amount to bet");
                int amountToBet = Convert.ToInt32(Console.ReadLine());

                if (amountToBet <= 0)
                {
                    logger.ErrorLog("Amount can not be 0 or negative");

                    Thread.Sleep(5000);

                    Console.Clear();

                    goto start;
                } else if (amountToBet > cash)
                {
                    logger.ErrorLog("Insufficient funds");

                    Thread.Sleep(5000);

                    Console.Clear();

                    goto start;
                } else if (amountToBet == cash)
                {
                    Console.Clear();
                    logger.WarningLog("Confirm betting all funds");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("[Y] ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" [N]");

                    Console.WriteLine("");

                    logger.InputLog();

                    string choice = Console.ReadLine().ToLower();

                    switch (choice)
                    {
                        case "y":
                            cash -= amountToBet;

                            Console.Clear();
                            logger.InformationLog("Spinning.");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning..");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning...");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning.");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning..");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning...");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning.");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning..");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning...");
                            Thread.Sleep(500);
                            Console.Clear();

                            int chosenNumber = rand.Next(1, 37);

                            logger.GeneralLog("Result", chosenNumber.ToString(), ConsoleColor.DarkCyan, ConsoleColor.White);

                            Console.WriteLine();

                            if (bet == chosenNumber)
                            {
                                logger.GeneralLog("Win", $"You've won ${amountToBet * 35}", ConsoleColor.DarkGreen, ConsoleColor.White);

                                cash += amountToBet * 35;
                            } else
                            {
                                logger.GeneralLog("Loss", $"You've lost ${amountToBet}", ConsoleColor.DarkRed, ConsoleColor.White);
                            }

                            Console.WriteLine();

                            logger.GeneralLog("Balance", $"${cash}", ConsoleColor.DarkGreen, ConsoleColor.White);

                            File.WriteAllBytes("data/data.dat", Encoding.UTF8.GetBytes(cash.ToString()));

                            Thread.Sleep(3000);

                            Console.Clear();
                            break;

                        case "n":
                            logger.InformationLog("Returning to main menu.");

                            Thread.Sleep(3000);

                            goto start;

                        default:
                            logger.ErrorLog("Invalid input. Returning to main menu.");

                            Thread.Sleep(5000);

                            goto start;
                    }
                } else
                {
                    cash -= amountToBet;

                    Console.Clear();
                    logger.InformationLog("Spinning.");
                    Thread.Sleep(500);
                    Console.Clear();
                    logger.InformationLog("Spinning..");
                    Thread.Sleep(500);
                    Console.Clear();
                    logger.InformationLog("Spinning...");
                    Thread.Sleep(500);
                    Console.Clear();
                    logger.InformationLog("Spinning.");
                    Thread.Sleep(500);
                    Console.Clear();
                    logger.InformationLog("Spinning..");
                    Thread.Sleep(500);
                    Console.Clear();
                    logger.InformationLog("Spinning...");
                    Thread.Sleep(500);
                    Console.Clear();
                    logger.InformationLog("Spinning.");
                    Thread.Sleep(500);
                    Console.Clear();
                    logger.InformationLog("Spinning..");
                    Thread.Sleep(500);
                    Console.Clear();
                    logger.InformationLog("Spinning...");
                    Thread.Sleep(500);
                    Console.Clear();

                    int chosenNumber = rand.Next(1, 37);

                    logger.GeneralLog("Result", chosenNumber.ToString(), ConsoleColor.DarkCyan, ConsoleColor.White);

                    Console.WriteLine();

                    if (bet == chosenNumber)
                    {
                        logger.GeneralLog("Win", $"You've won ${amountToBet * 35}", ConsoleColor.DarkGreen, ConsoleColor.White);

                        cash += amountToBet * 35;
                    }
                    else
                    {
                        logger.GeneralLog("Loss", $"You've lost ${amountToBet}", ConsoleColor.DarkRed, ConsoleColor.White);
                    }

                    Console.WriteLine();

                    logger.GeneralLog("Balance", $"${cash}", ConsoleColor.DarkGreen, ConsoleColor.White);

                    File.WriteAllBytes("data/data.dat", Encoding.UTF8.GetBytes(cash.ToString()));

                    Thread.Sleep(3000);

                    Console.Clear();
                }

                break;

            case 2:
                Console.Clear();
                logger.InformationLog("Bet on a color");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("[Black]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" /");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" [Red]");

                logger.InputLog();

                string choice2 = Console.ReadLine().ToLower();

                Random rand2 = new Random();

                int ran = rand2.Next(1, 3);

                switch (choice2)
                {
                    case "black":
                        logger.InformationLog("Insert amount to bet");
                        int amountToBet2 = Convert.ToInt32(Console.ReadLine());

                        if (amountToBet2 <= 0)
                        {
                            logger.ErrorLog("Amount can not be 0 or negative");

                            Thread.Sleep(5000);

                            Console.Clear();

                            goto start;
                        } else if (amountToBet2 > cash)
                        {
                            logger.ErrorLog("Insufficient funds");

                            Thread.Sleep(5000);

                            Console.Clear();

                            goto start;
                        } else if (amountToBet2 == cash)
                        {
                            Console.Clear();
                            logger.WarningLog("Confirm betting all funds");

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("[Y] ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("/");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" [N]");

                            Console.WriteLine("");

                            logger.InputLog();

                            string confirmbet = Console.ReadLine().ToLower();

                            switch (confirmbet)
                            {
                                case "y":
                                    cash -= amountToBet2;

                                    Console.Clear();
                                    logger.InformationLog("Spinning.");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning..");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning...");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning.");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning..");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning...");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning.");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning..");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning...");
                                    Thread.Sleep(500);
                                    Console.Clear();

                                    if (ran == 1)
                                    {
                                        logger.GeneralLog("Result", "Black", ConsoleColor.DarkCyan, ConsoleColor.White);
                                    } else if (ran == 2)
                                    {
                                        logger.GeneralLog("Result", "Red", ConsoleColor.DarkCyan, ConsoleColor.White);
                                    } else
                                    {
                                        logger.GeneralLog("Result", "undefined", ConsoleColor.DarkCyan, ConsoleColor.White);
                                    }

                                    Console.WriteLine();

                                    if (ran == 1)
                                    {
                                        logger.GeneralLog("Win", $"You've won ${amountToBet2 * 2}", ConsoleColor.DarkGreen, ConsoleColor.White);

                                        cash += amountToBet2 * 2;
                                    } else
                                    {
                                        logger.GeneralLog("Loss", $"You've lost ${amountToBet2}", ConsoleColor.DarkRed, ConsoleColor.White);
                                    }

                                    Console.WriteLine();

                                    logger.GeneralLog("Balance", $"${cash}", ConsoleColor.DarkGreen, ConsoleColor.White);

                                    File.WriteAllBytes("data/data.dat", Encoding.UTF8.GetBytes(cash.ToString()));

                                    Thread.Sleep(3000);

                                    Console.Clear();

                                    break;

                                case "n":
                                    logger.InformationLog("Returning to main menu.");

                                    Thread.Sleep(3000);

                                    Console.Clear();

                                    goto start;

                                default:
                                    logger.ErrorLog("Invalid input. Returning to main menu.");

                                    Thread.Sleep(3000);

                                    Console.Clear();

                                    goto start;
                            }
                        } else
                        {
                            cash -= amountToBet2;

                            Console.Clear();
                            logger.InformationLog("Spinning.");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning..");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning...");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning.");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning..");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning...");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning.");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning..");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning...");
                            Thread.Sleep(500);
                            Console.Clear();

                            if (ran == 1)
                            {
                                logger.GeneralLog("Result", "Black", ConsoleColor.DarkCyan, ConsoleColor.White);
                            }
                            else if (ran == 2)
                            {
                                logger.GeneralLog("Result", "Red", ConsoleColor.DarkCyan, ConsoleColor.White);
                            }
                            else
                            {
                                logger.GeneralLog("Result", "undefined", ConsoleColor.DarkCyan, ConsoleColor.White);
                            }

                            Console.WriteLine();

                            if (ran == 1)
                            {
                                logger.GeneralLog("Win", $"You've won ${amountToBet2 * 2}", ConsoleColor.DarkGreen, ConsoleColor.White);

                                cash += amountToBet2 * 2;
                            }
                            else
                            {
                                logger.GeneralLog("Loss", $"You've lost ${amountToBet2}", ConsoleColor.DarkRed, ConsoleColor.White);
                            }

                            Console.WriteLine();

                            logger.GeneralLog("Balance", $"${cash}", ConsoleColor.DarkGreen, ConsoleColor.White);

                            File.WriteAllBytes("data/data.dat", Encoding.UTF8.GetBytes(cash.ToString()));

                            Thread.Sleep(3000);

                            Console.Clear();

                            break;
                        }

                        break;

                    case "red":
                        logger.InformationLog("Insert amount to bet");
                        int amountToBet3 = Convert.ToInt32(Console.ReadLine());

                        if (amountToBet3 <= 0)
                        {
                            logger.ErrorLog("Amount can not be 0 or negative");

                            Thread.Sleep(5000);

                            Console.Clear();

                            goto start;
                        }
                        else if (amountToBet3 > cash)
                        {
                            logger.ErrorLog("Insufficient funds");

                            Thread.Sleep(5000);

                            Console.Clear();

                            goto start;
                        }
                        else if (amountToBet3 == cash)
                        {
                            Console.Clear();
                            logger.WarningLog("Confirm betting all funds");

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("[Y] ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("/");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" [N]");

                            Console.WriteLine("");

                            logger.InputLog();

                            string confirmbet = Console.ReadLine().ToLower();

                            switch (confirmbet)
                            {
                                case "y":
                                    cash -= amountToBet3;

                                    Console.Clear();
                                    logger.InformationLog("Spinning.");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning..");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning...");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning.");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning..");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning...");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning.");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning..");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    logger.InformationLog("Spinning...");
                                    Thread.Sleep(500);
                                    Console.Clear();

                                    if (ran == 1)
                                    {
                                        logger.GeneralLog("Result", "Black", ConsoleColor.DarkCyan, ConsoleColor.White);
                                    }
                                    else if (ran == 2)
                                    {
                                        logger.GeneralLog("Result", "Red", ConsoleColor.DarkCyan, ConsoleColor.White);
                                    }
                                    else
                                    {
                                        logger.GeneralLog("Result", "undefined", ConsoleColor.DarkCyan, ConsoleColor.White);
                                    }

                                    Console.WriteLine();

                                    if (ran == 2)
                                    {
                                        logger.GeneralLog("Win", $"You've won ${amountToBet3 * 2}", ConsoleColor.DarkGreen, ConsoleColor.White);

                                        cash += amountToBet3 * 2;
                                    }
                                    else
                                    {
                                        logger.GeneralLog("Loss", $"You've lost ${amountToBet3}", ConsoleColor.DarkRed, ConsoleColor.White);
                                    }

                                    Console.WriteLine();

                                    logger.GeneralLog("Balance", $"${cash}", ConsoleColor.DarkGreen, ConsoleColor.White);

                                    File.WriteAllBytes("data/data.dat", Encoding.UTF8.GetBytes(cash.ToString()));

                                    Thread.Sleep(3000);

                                    Console.Clear();

                                    break;

                                case "n":
                                    logger.InformationLog("Returning to main menu.");

                                    Thread.Sleep(3000);

                                    Console.Clear();

                                    goto start;

                                default:
                                    logger.ErrorLog("Invalid input. Returning to main menu.");

                                    Thread.Sleep(3000);

                                    Console.Clear();

                                    goto start;
                            }
                        } else
                        {
                            cash -= amountToBet3;

                            Console.Clear();
                            logger.InformationLog("Spinning.");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning..");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning...");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning.");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning..");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning...");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning.");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning..");
                            Thread.Sleep(500);
                            Console.Clear();
                            logger.InformationLog("Spinning...");
                            Thread.Sleep(500);
                            Console.Clear();

                            if (ran == 1)
                            {
                                logger.GeneralLog("Result", "Black", ConsoleColor.DarkCyan, ConsoleColor.White);
                            }
                            else if (ran == 2)
                            {
                                logger.GeneralLog("Result", "Red", ConsoleColor.DarkCyan, ConsoleColor.White);
                            }
                            else
                            {
                                logger.GeneralLog("Result", "undefined", ConsoleColor.DarkCyan, ConsoleColor.White);
                            }

                            Console.WriteLine();

                            if (ran == 2)
                            {
                                logger.GeneralLog("Win", $"You've won ${amountToBet3 * 2}", ConsoleColor.DarkGreen, ConsoleColor.White);

                                cash += amountToBet3 * 2;
                            }
                            else
                            {
                                logger.GeneralLog("Loss", $"You've lost ${amountToBet3}", ConsoleColor.DarkRed, ConsoleColor.White);
                            }

                            Console.WriteLine();

                            logger.GeneralLog("Balance", $"${cash}", ConsoleColor.DarkGreen, ConsoleColor.White);

                            File.WriteAllBytes("data/data.dat", Encoding.UTF8.GetBytes(cash.ToString()));

                            Thread.Sleep(3000);

                            Console.Clear();
                        }

                        break;

                    default:
                        logger.ErrorLog("Invalid color");

                        Thread.Sleep(5000);

                        Console.Clear();

                        goto start;
                }

                break;

            case 3:
                Console.Clear();

                logger.InformationLog("Closing application");

                Thread.Sleep(3000);
                Environment.Exit(0);

                break;

            case 4:
                Console.Clear();

                logger.WarningLog("Are you sure you want to reset your data?");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("[Y] ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" [N]");

                Console.WriteLine("");

                logger.InputLog();

                string confirm = Console.ReadLine().ToLower();

                switch (confirm)
                {
                    case "y":
                        Console.Clear();

                        logger.InformationLog("Locating data.dat");

                        Thread.Sleep(350);

                        if (File.Exists("data/data.dat"))
                        {
                            logger.InformationLog("Resetting data.dat");
                            File.Delete("data/data.dat");
                        } else
                        {
                            logger.ErrorLog("data.dat not found!");

                            Thread.Sleep(5000);

                            goto start;
                        }

                        Thread.Sleep(1000);

                        logger.GeneralLog("Success", "Data reset successfully, please restart the application", ConsoleColor.DarkGreen, ConsoleColor.White);

                        while (true)
                        {
                            Console.ReadKey();
                        }
                }
                break;

            default:
                logger.ErrorLog("Input beyond valid range");

                Thread.Sleep(5000);

                Console.Clear();

                goto start;
        }
    } catch (Exception ex)
    {
        Console.WriteLine("");
        logger.CriticalLog(ex.Message);
        Thread.Sleep(5000);

        Console.Clear();
    }
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