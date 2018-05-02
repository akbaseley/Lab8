using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            LearnAboutStudent();
        }
        static void LearnAboutStudent()
        {
            //1. Set up databases
            string[] Names = { "John", "Dan", "Emily", "Ethan", "Mara",
                "Jacob", "Max", "Ben", "Katherine", "Juliana",
                "Peter", "Steven", "Tim", "Kelly", "Elisabeth",
                "David", "Olivia", "Clara", "Joel", "Barbara"};

            string[] HomeTowns = {"Madison", "St. Louis", "Duluth", "Minneapolis", "St. Paul",
                "Winger", "Alexandria", "Brainard", "Billings", "Peekskill",
                "Long Island", "Dearborn", "Livonia", "Dayton", "Fort Wayne",
                "Chicago", "Columbus", "Baltimore", "Milwaukee", "Saux Center"};

            string[] FavoriteFoods = {"Carrots", "Apples", "Celery", "Bacon", "Cauliflower",
                "Chips", "Salmon", "Cheeseburger", "Fries", "Bananas",
                "Pineapple", "Pickles", "Avocado", "Cheese", "Peanut Butter",
                "Pancakes", "Salad", "Steak", "Spaghetti", "Pot Roast"};

            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine($"{i + 1,-10}{Names[i],-15}{HomeTowns[i],-15}{FavoriteFoods[i]}");
            }

            //2. Input of Int (ask User for the index of person).
            int StudentIndex = int.Parse(GetUserInput($"Which Student would you like to learn about?  Enter a number between 1 and 20!"));
            StudentIndex = VerifyStudentIndex("I'm sorry!  That's not an option.  Please select a student 1-20!", StudentIndex);
            Console.WriteLine($"Great! Student #{StudentIndex} is {Names[StudentIndex - 1]}.");

            //4. ask about hometown or favorite food (using "if" statement)
            string UserInterest = GetUserInput($"Would you like to know {Names[StudentIndex - 1]}'s favorite food or hometown?");
            UserInterest = VerifyUserInterest(UserInterest, $"I'm sorry. I dont have that information.  Please type 'hometown' or 'favorite food' to find out more about {Names[StudentIndex - 1]}.");

            if (UserInterest == "hometown")
            {
                Console.WriteLine($"{Names[StudentIndex - 1]}'s hometown is {HomeTowns[StudentIndex - 1]}.");

            }
            else if (UserInterest == "favorite food")
            {
                Console.WriteLine($"{Names[StudentIndex - 1]}'s favorite food is {FavoriteFoods[StudentIndex - 1]}");
            }

            //5. Ask if user would like to continue
            if (!UserContinue("Would you like to keep learning about the students?"))
            {
                return;
            }
            else
            {
                LearnAboutStudent();
            }
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }
        public static int VerifyStudentIndex(string message, int StudentIndex)
        {
            while (StudentIndex < 1 && StudentIndex > 20)
            {
                Console.WriteLine(message);
                StudentIndex = int.Parse(Console.ReadLine());
            }
            return StudentIndex;

        }
        public static string VerifyUserInterest(string UserInterest, string message)
        {
            while (UserInterest != "hometown" && UserInterest != "favorite food")
            {
                Console.WriteLine(message);
                UserInterest = Console.ReadLine();
            }
            return UserInterest;
        }
        public static bool UserContinue(string message)
        {
            Console.WriteLine(message);
            String Response = Console.ReadLine().ToLower();

            while (Response != "n" && Response != "y")
            {
                Console.WriteLine("What was that?  Would you like to learn more? y/n");
                Response = Console.ReadLine();
            }

            if (Response == "n")
            {
                Console.WriteLine("Okay!  See you next time.");
                return false;
            }
            else
                return true;
        }
    }
}
