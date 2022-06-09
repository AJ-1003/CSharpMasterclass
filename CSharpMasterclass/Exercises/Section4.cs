using MasterclassLibrary.Section_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.Exercises
{
    public class Section4
    {
        public void ExecuteExercise(string exerciseName)
        {
            if (GetType().GetMethod(exerciseName) != null)
            {
                MethodInfo method = GetType().GetMethod(exerciseName);
                method.Invoke(this, null);
            }
        }

        public void Exercise1()
        {
            string registerUsername;
            string registerPassword;

            Console.WriteLine("Please enter a username and password to register.");
            Console.Write("Username: ");
            registerUsername = Console.ReadLine().ToLower();
            Console.Write("Password: ");
            registerPassword = Console.ReadLine().ToLower();

            var checkUser = new RegisterUser(registerUsername, registerPassword);
            string loginUsername;
            string loginPassword;

            Console.WriteLine("Please enter your username and password to login.");
            Console.Write("Username: ");
            loginUsername = Console.ReadLine().ToLower();
            Console.Write("Password: ");
            loginPassword = Console.ReadLine().ToLower();

            Console.WriteLine("===================================================================");
            Console.WriteLine(checkUser.CheckLogin(loginUsername, loginPassword));
            Console.WriteLine("===================================================================");
        }

        public void Exercise2()
        {
            var playerScore = new CheckHighScore();
            int score;
            string playerName;

            Console.WriteLine("Enter the score and name of current player:");
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());
            Console.Write("Player name: ");
            playerName = Console.ReadLine();
            Console.WriteLine("===================================================================");
            Console.WriteLine(playerScore.CheckForNewHighScore(score, playerName));
            Console.WriteLine("===================================================================");
        }

        public void Exercise3()
        {
            var temperatureCheck = new CheckTemperature();
            string temperatureInput;
            int temperature;

            Console.WriteLine("Enter the current temperature.");
            Console.Write("-> ");
            temperatureInput = Console.ReadLine();

            try
            {
                temperature = Convert.ToInt32(temperatureInput);
                Console.WriteLine("===================================================================");
                Console.WriteLine(temperatureCheck.CheckTemperatureValue(temperature));
                Console.WriteLine("===================================================================");
            }
            catch
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("The current input is not a valid temperature.");
            }
        }
    }
}
