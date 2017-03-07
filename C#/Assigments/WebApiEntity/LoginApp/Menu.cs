using BI;
using System;
using System.Threading.Tasks;
using WebApiEntity;
namespace LoginApp
{
    
    class Menu
    {
        /// <summary>
        /// Displays the menu and returns the option selected
        /// </summary>
        /// <returns></returns>
        internal Choice SelectChoice()
        {
            Console.WriteLine(@"Please select one of the following
            1.Regester a new user. 
            2.Login.
            3.Forgot password.
                             ");

            return (Choice)Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Executes the selected option for the particular user
        /// </summary>
        /// <param name="selectedOption"></param>
        /// <param name="user"></param>
        internal async Task Execute(Choice selectedOption)
        {
            AuthDetail userCredentials ;

            Authenticate authenticateObj = new Authenticate("http://localhost:51689/");

            switch (selectedOption)
            {
                case Choice.SIGNUP:
                                            userCredentials = GetUserInput();

                                            if (await authenticateObj.RegisterAsync(userCredentials))
                                            {
                                                Console.WriteLine("New user " + userCredentials.username + " has been added");
                                            }

                                            else
                                            {
                                                Console.WriteLine("user already exists");
                                            }

                                            break;

                case Choice.LOGIN:
                                            userCredentials = GetUserInput();

                                            if (await authenticateObj.LoginAsync(userCredentials))
                                            {
                                                Console.WriteLine("Logined as " + userCredentials.username);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid login");
                                            }

                                            break;

                case Choice.FORGOTPASSWORD:                    
                                            Console.Write("Enter your username : ");
                                            string name = Console.ReadLine();

                                            Console.Write("Enter new password : ");
                                            string newpassword = Console.ReadLine();

                                            if (authenticateObj.UpdatePassword(name, newpassword))
                                            {
                                                Console.WriteLine("password updated sucessfully");
                                            }

                                            else
                                            {
                                                Console.WriteLine("Invalid user name");
                                            }

                                            break;

            }
        }
        
        /// <summary>
        /// Gets the data from the console and returns the user account
        /// </summary>
        /// <returns></returns>
        internal AuthDetail GetUserInput()
        {
            AuthDetail user = new AuthDetail();

            Console.Write("Enter your username : ");
            user.username = Console.ReadLine();

            Console.Write("Enter your password : ");
            user.password = Console.ReadLine();

            return user;
        }
        
        /// <summary>
        /// Continues to the menu page again based on the input data given
        /// </summary>
        /// <returns></returns>
        internal bool IterationFlag()
        {
            Console.WriteLine("Do you want to continue ?(Y/N)");
            
            return (Console.ReadLine() ==  "y" || Console.ReadLine() == "Y") ? true : false;
        }

    }
}
