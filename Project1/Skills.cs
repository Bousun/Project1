using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Skills : IMenu
    {
        public void Display()
        {
            //display skills from csv and return to UserMode

            //Console.WriteLine("Skillsssss");

            var skillsDict = FileOperations.returnFieldNameDictionary("Skills");
            foreach (KeyValuePair<int, List<string>> item in skillsDict)
            {
                Console.WriteLine($"{item.Value[1]}");
            }

            UserMode.getSubsectionsGuestMode();


        }


    }
}
