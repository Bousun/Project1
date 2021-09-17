using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class ContactDetails : IMenu
    {

        public void Display()
        {
            var skillsDict = FileOperations.returnFieldNameDictionary("ContactDetails");
            foreach (KeyValuePair<int, List<string>> item in skillsDict)
            {
                Console.WriteLine($"Surname:{item.Value[1]} Name:{item.Value[2]} Age:{item.Value[3]} Email:{item.Value[4]} Position:{item.Value[5]}");

            }
            UserMode.getSubsectionsGuestMode();
        }
    }
}
