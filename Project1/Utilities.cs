using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Utilities
    {
        public static int VerifyInput(Dictionary<int, string> inputDict)
        {
            bool isValid = false;
            var choice = "";
            int returnval = 0;

            Console.WriteLine("Select from the following : (-1 to go back/exit)");


            foreach (KeyValuePair<int, string> item in inputDict)
                Console.WriteLine($"{item.Key} : {item.Value}");

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
                    break;
                }

                if (parseSuccess && inputDict.ContainsKey(choiceInt))
                {
                    isValid = true;
                    returnval = choiceInt;
                }
                else
                    Console.WriteLine("Invalid Input..enter again!");

            } while (isValid == false);

            return returnval;
        }
            
            
        
    }
}
