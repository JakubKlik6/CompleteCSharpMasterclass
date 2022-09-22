using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            generalException:
            Console.WriteLine("\nHello new user!!");
            Console.WriteLine("Press 1 to login or 2 to register you account");

            string userInput = Console.ReadLine();
            
            try
            {
                int userIpnutAsNumber = int.Parse(userInput);

                if (userIpnutAsNumber == 1) 
                {
                    Console.Write("Please eneter your login: ");
                    string userLogin = Console.ReadLine();
                    Console.Write("Please eneter your login: ");
                    string userPassword = Console.ReadLine();
                    Console.WriteLine("You are not registered");
                    goto generalException;
                }

                else if (userIpnutAsNumber == 2)
                {
                    Console.Write("Please eneter your login: ");
                    string userNewLogin = Console.ReadLine();
                    Console.Write("Please eneter your Password: ");
                    string userNewPassword = Console.ReadLine();

                    validNumber:
                    Console.WriteLine("You have successfuly registered, now press 1 to login");

                    string registeredUserInput = Console.ReadLine();
                    int registeredUserInputAsNumber = int.Parse(registeredUserInput);

                    if (int.TryParse(registeredUserInput,out registeredUserInputAsNumber))
                    {
                        if (registeredUserInputAsNumber == 1)
                        {
                            wrongLoginOrPassword:
                            Console.Write("Please eneter your login: ");
                            string userLogin = Console.ReadLine();
                            Console.Write("Please eneter your login: ");
                            string userPassword = Console.ReadLine();

                            if ((userLogin == userNewLogin) && (userPassword == userNewPassword))
                            {
                                Console.WriteLine("You have successfuly login");
                                return;
                            }

                            else
                                Console.WriteLine("Incorrect login or password, try again");
                            goto wrongLoginOrPassword;
                        }
                        else
                            Console.WriteLine("You choose valid number, please choos 1 or press enter to quit");
                            goto validNumber;
                    }
                }
                else
                    Console.WriteLine("You choose valid number, please choos 1 or 2, or press enter to quit");
            }
            catch (Exception)
            {
                Console.WriteLine("General exception, plese choose the correct number");
                goto generalException;
            }
            Console.ReadKey();
        }
    }
}
