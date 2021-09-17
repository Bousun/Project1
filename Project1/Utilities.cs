﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Utilities
    {
        
        public static int VerifyInputList(List<string> inputList)
        {
            bool isValid = false;
            var choice = "";
            int returnval = 0;

            Console.WriteLine("Select from the following : (-1 to go back/exit)");


            foreach (var item in inputList)
            {
                var index = inputList.FindIndex(a => a == item);
                Console.WriteLine($"{index +1} : {item}");
            }

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

                if (parseSuccess && (choiceInt - 1) < inputList.Count)
                {
                    isValid = true;
                    returnval = choiceInt;
                }
                else
                    Console.WriteLine("Invalid Input..enter again!");

            } while (isValid == false);

            return returnval;
        }

        public static void getDescriptionOrModule(int choice, string fieldname)
        {
            Dictionary<int, List<string>> dict = FileOperations.returnFieldNameDictionary(fieldname);

            foreach (KeyValuePair<int, List<string>> item in dict)
            {
                if (choice == item.Key)
                    Console.WriteLine($"{item.Value[3]}");

            }

        }

    }
}
