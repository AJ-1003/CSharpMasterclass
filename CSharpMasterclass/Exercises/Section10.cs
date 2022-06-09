using MasterclassLibrary.Exercise_Classes.Section_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.Exercises
{
    public class Section10
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
            var bmw = new BMW("M3", 250, "Silver");
            bmw.SetCarIdInfo(1, "Ian");
            bmw.ShowDetails();
            bmw.Repair();

            var audi = new Audi("RS3", 285, "Red");
            audi.SetCarIdInfo(2, "Alicia");
            audi.ShowDetails();
            audi.Repair();

            var cars = new List<Car>
            {
                new Audi("S3", 185, "Blue"),
                new BMW("135i", 178, "White")
            };

            foreach (var car in cars)
            {
                car.ShowDetails();
            }

            Car bmwM5 = new BMW("M5", 298, "Black");
            Car audiA3 = new Audi("A3", 165, "Red");

            bmwM5.ShowDetails();
            bmwM5.SetCarIdInfo(3, "Dewald");
            audiA3.ShowDetails();
            audiA3.SetCarIdInfo(4, "Chante");

            var bmwX5 = new BMW("X5", 385, "White");
            bmwX5.SetCarIdInfo(5, "AJ");
            bmwX5.ShowDetails();

            Car someCar = (Car)bmwX5;
            someCar.SetCarIdInfo(6, "Jorrie");
            someCar.ShowDetails();

            var newM3 = new M3("M3 Motorsport", 426, "Silver");
            newM3.SetCarIdInfo(7, "Hanlie");
            newM3.Repair();

            bmw.GetCarIdInfo();
            audi.GetCarIdInfo();
            bmwM5.GetCarIdInfo();
            audiA3.GetCarIdInfo();
            bmwX5.GetCarIdInfo();
            someCar.GetCarIdInfo();
            newM3.GetCarIdInfo();
        }

        public void Exercise2()
        {
            Shape cube = new Cube(5.5);
            cube.GetInfo();

            Shape sphere = new Sphere(2.6);
            sphere.GetInfo();
            Console.WriteLine();

            Shape[] shapes =
            {
                new Cube(6),
                new Sphere(2)
            };

            foreach (var shape in shapes)
            {
                shape.GetInfo();

                Cube? iceCube = shape as Cube;
                if (iceCube == null)
                {
                    Console.WriteLine("This is not a Cube!");
                }

                if (shape is Cube)
                {
                    Console.WriteLine("This is a Cube!");
                }
                Console.WriteLine();

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;
                Console.WriteLine($"{cube2.Name} has a volume of {cube2.Volume()}");
            }
        }

        public void Exercise3()
        {
            var filePath = @"C:\Users\iajor\source\isometrix training repos\CSharpMasterclass\CSharpMasterclass\Section 10 Text Files\TextFile1.txt";

            string text = File.ReadAllText(filePath);
            Console.WriteLine(text);

            string[] lines = File.ReadAllLines(filePath);
            Array.ForEach(lines, Console.WriteLine);
        }

        public void Exercise4()
        {
            var filePath = @"C:\Users\iajor\source\isometrix training repos\CSharpMasterclass\CSharpMasterclass\Section 10 Text Files\TextFile2.txt";

            string[] lines = { "first line", "second line", "third line" };
            File.WriteAllLines(filePath, lines);

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                foreach (var line in lines)
                {
                    if (line.Contains("third"))
                    {
                        sw.WriteLine($"This line is appended: {line}");
                    }
                }
            }
        }
    }
}
