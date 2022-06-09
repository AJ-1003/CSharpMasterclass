using CSharpMasterclass.Exercise_Classes.Section_7;
using System.Collections;
namespace MasterclassLibrary.Section_7
{
    public class InsertValuesIntoHashTable
    {
        public void InsertValues(Student[] students)
        {
            var studentsTable = new Hashtable();
            var errorCount = 0;

            foreach (var student in students)
            {
                if (studentsTable.ContainsKey(student.Id))
                {
                    Console.WriteLine($"Sorry, a Student with the same ID as '{student.Name}({student.Id})', already exists!");
                    errorCount++;
                }
                else
                {
                    studentsTable.Add(student.Id, student);
                    Console.WriteLine($"Student with Id '{student.Id}' added successfully!");
                }
            }

            if (errorCount < 1)
            {
                Console.WriteLine("All students were added successfully!");
            }
            else
            {
                Console.WriteLine("There has been an error adding some students!");
            }

        }
    }
}
