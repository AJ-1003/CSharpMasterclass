using MasterclassLibrary.Section_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.Exercises
{
    public class Section3Exercises
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
            var friends = new GreetFriends();
            var listOfFriends = new List<string>();
            Console.WriteLine("Enter the names of three friends.");
            for (var i = 1; i <= 3; i++)
            {
                Console.Write("-> ");
                listOfFriends.Add(Console.ReadLine());
            }

            foreach (var friend in listOfFriends)
            {
                Console.WriteLine(friends.GreetFriend(friend));
            }
        }
    }
}
