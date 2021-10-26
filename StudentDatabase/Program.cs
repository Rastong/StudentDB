using System;
using System.Linq;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateDB();
            ClassContext classContext = new ClassContext();
            bool runProgram = true;
            while (runProgram)
            {
                classContext.DisplayAIIDB();
                DisplayStudentDB();
                runProgram = Validator.Validator.getContinue("Would you like learn more about another student?");
            }
        }
        public static void CreateDB()
        {
            using (ClassContext context = new ClassContext())
            {
                for (int i = 0; 1 < 14; i++)
                {
                    Student student = new Student();
                    student.Name = NameOfStudent(i);
                    student.Food = FavFood(i);
                    student.Hometown = hometown(i);

                    context.students.Add(student);

                    context.SaveChanges();
                }
            }
        }
        public static string NameOfStudent(int x)
        {
            string[] Names = {
                "Justin",
                "Matt",
                "Logan",
                "Raston",
                "Yousif",
                "Yash",
                "Chris",
                "Radeen",
                "Josh",
                "Aron",
                "Kasean",
                "Scott",
                "Delmar",
                "Brandon"
            };
            string Student = Names[x];
            return Student;
        }

        public static string hometown(int x)
        {
            string[] town =
            {
                "Wyoming",
                "Flint",
                "Plymouth",
                "Zeeland",
                "Oak Park",
                "Detroit",
                "Novi",
                "Warren",
                "Northville",
                "Berea",
                "Detroit",
                "Lansing",
                "Detroit",
                "Novi"
            };
            string home = town[x];
            return home;
        }

        public static string FavFood(int x)
        {
            string[] Food =
            {
                "Baja Blast",
                "Hot Wings",
                "Funyuns",
                "Instant Vanilla Pudding",
                "Deep Dish Pizza",
                "Hot Cheetos",
                "Tacos",
                "Mexican",
                "Nalesniki",
                "Sushi",
                "Steak",
                "Nashville Chicken",
                "Vietnamese Food",
                "Sushi"
            };
            string favorite = Food[x];
            return favorite;
        }

        public static void DisplayStudentDB()
        {
            Console.WriteLine("Please enter one of the Student ID.");
            int input = Validator.Validator.GetInt(1, 14);
            using (ClassContext context = new ClassContext())
            {
                // Student x = context.students.Where(s => s.StudentId == input).First();
                // using find to look thorugh DB
                Student exists = context.students.Find(input);
                Console.WriteLine(exists.Name);
                Console.WriteLine($"Favorite Food: {exists.Food}; Hometown: {exists.Hometown}");
            }
        }
    }
}
