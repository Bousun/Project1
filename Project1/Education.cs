using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Education : IMenu
    {

        public void Display()
        {
            Console.WriteLine("Select from the following : (-1 to go back/exit)");
            var path = "UserInformation.csv";

            var allDetails = FileOperations.SplittingLine(path);

            Dictionary<int, List<string>> dict = FileOperations.returnFieldNameDictionary("Education");
            foreach (KeyValuePair<int, List<string>> item in dict)
            {
                Console.WriteLine($"{item.Key}. {item.Value[1]} ({item.Value[2]})");
            }

            bool isValid = false;
            var choice = "";
            int returnval = 0;

            Console.WriteLine();
            Console.WriteLine("Enter your choice : ");
            do
            {
                choice = Console.ReadLine();
                int choiceInt;
                bool parseSuccess = int.TryParse(choice, out choiceInt);

                if (choiceInt == -1)
                {
                    Console.WriteLine("end");

                    returnval = -1;
                    Subsections.SelectSubsectionGuestMode(returnval);
                    break;
                }

                if (parseSuccess && (choiceInt - 1) < allDetails.Count)
                {
                    //Console.WriteLine($"Your choice is {choiceInt}");
                    isValid = true;
                    returnval = choiceInt;
                    //display job description
                    lastStep(returnval, "Education");

                }
                else
                    Console.WriteLine("Invalid Input..enter again!");

            } while (isValid == false);
        }

        public static void lastStep(int choice, string fieldname)
        {

            Utilities.getDescriptionOrModule(choice, fieldname);
            Education edu = new Education();
            edu.Display();
        }


    }
}
