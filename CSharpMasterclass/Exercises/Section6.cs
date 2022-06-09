using MasterclassLibrary.Section_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.Exercises
{
    public class Section6
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
            var basicHuman = new Human();
            basicHuman.Introduction();

            var human1 = new Human("AJ", "Jordaan");
            human1.Introduction();

            var human2 = new Human("Dewald", "Jordaan", 15);
            human2.Introduction();

            var human3 = new Human("Chante", "Neethling", "brown");
            human3.Introduction();

            var ian = new Human("Ian", "Jordaan", "Blue", 27);
            ian.Introduction();
        }

        public void Exercise2()
        {
            var box = new Box();

            //box.length = 5;
            box.SetLength(5);
            box.Width = 7;
            box.Height = 9;
            box.DisplayInfo();
        }
    }
}
