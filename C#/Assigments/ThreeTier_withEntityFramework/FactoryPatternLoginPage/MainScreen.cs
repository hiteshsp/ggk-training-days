using BLL;
using System;
namespace FactoryPatternLoginPage
{
    /// <summary>
    ///  The Presentation logic.
    /// </summary>
   public class MainScreen
    {
        /// <summary>
        /// Constructor which contains the logic of the Main Screen.
        /// </summary>
        public MainScreen()
        {
            string userName, password;
            char choice;
            
            do
            {
                ConcreteFactoryBLL loginObj = new ConcreteFactoryBLL();
                IAuthenticate authenticationObj = loginObj.GetAuthenticateInstance();
                Console.Clear();
                Console.WriteLine("Press 1 for Login, Press 2 to Register and Press 3 to Forgot Password");
                int option = Convert.ToInt32(Console.ReadLine());
                switch ((EnumChoice)option)
                {
                    case EnumChoice.ONE:
                        Console.WriteLine("Login");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Enter UserName");
                        userName = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter Password");
                        password = Console.ReadLine();
                        if (authenticationObj.Login(userName, password))
                        {
                            Console.WriteLine("Hi " + userName);
                        }
                        else
                        {
                            Console.WriteLine("Username/Password is incorrect !");
                        }
                        break;
                    case EnumChoice.TWO:
                        Console.WriteLine("Register");
                        Console.WriteLine("--------------");
                        Console.WriteLine("Enter UserName");
                        userName = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter Password");
                        password = Console.ReadLine();

                        if(authenticationObj.Register(userName, password))
                        {
                            Console.WriteLine("Registered!");
                        }

                        break;
                    case EnumChoice.THREE:
                        Console.WriteLine("Forgot Password");
                        Console.WriteLine("-------------");
                        Console.WriteLine("Enter UserName");
                        userName = Console.ReadLine();
                        Console.WriteLine("Enter the new Password");
                        password = Console.ReadLine();

                        if(authenticationObj.ForgotPassword(userName, password))
                        {
                            Console.WriteLine("Password Changed !");
                        }
                        
                        break;
                }
                Console.WriteLine("Enter a choice (Y/N)");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'Y');
        }
    }
}
