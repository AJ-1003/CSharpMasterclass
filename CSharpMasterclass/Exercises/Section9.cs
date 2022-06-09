using MasterclassLibrary.Exercise_Classes.Section_9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.Exercises
{
    public class Section9
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
            var radio = new Radio(false, "Sony");
            radio.SwitchOn();
            radio.ListenToTheRadio();

            var tv = new TV(false, "Samsung");
            tv.SwitchOn();
            tv.WatchTV();
        }

        public void Exercise2()
        {
            var dog = new Dog("Milo", 4);
            dog.Eat();
            dog.Play();
        }

        public void Exercise3()
        {
            var post1 = new Post("Thanks", "Ian", true);
            Console.WriteLine(post1.ToString());

            var post2 = new Post();
            Console.WriteLine(post2.ToString());

            var imagePost1 = new ImagePost("Check my new car", "Ian", true, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.topgear.com%2Fsites%2Fdefault%2Ffiles%2F2021%2F07%2F5054-SwiftSportHybrid.jpg&imgrefurl=https%3A%2F%2Fwww.topgear.com%2Fcar-reviews%2Fsuzuki%2Fswift&tbnid=sQCMvz3AOEc5OM&vet=12ahUKEwjQ87GpvI74AhUPqRoKHZx3BEAQMygEegUIARDeAQ..i&docid=dMoirW9p4bDZvM&w=3000&h=1688&q=suzuki%20swift&ved=2ahUKEwjQ87GpvI74AhUPqRoKHZx3BEAQMygEegUIARDeAQ");
            Console.WriteLine(imagePost1.ToString());

            var videoPost = new VideoPost("Video", "Ian", true, "https://www.youtube.com", 360);
            Console.WriteLine(videoPost.ToString());
            videoPost.PlayVideo();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost.StopVideo();
            Console.ReadKey();
        }

        public void Exercise4()
        {
            Console.WriteLine("----- Employee ----- ");
            var employee = new Employee("Ian Jordaan", "Ian", 5000);
            employee.Work();
            employee.Pause();
            Console.WriteLine();

            Console.WriteLine("----- Boss ----- ");
            var boss = new Boss("Big Boss", "Boss", 20000, true);
            boss.Work();
            boss.Lead();
            boss.Pause();
            Console.WriteLine();

            Console.WriteLine("----- Trainee ----- ");
            var trainee = new Trainee("Trainee One", "Trainee", 1000, 4, 4);
            trainee.Work();
            trainee.Pause();
            trainee.Learn();
        }
    }
}
