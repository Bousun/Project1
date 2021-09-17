using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class TechnologicalSkills : IMenu
    {

        public void Display()
        {
            var skillsDict = FileOperations.returnFieldNameDictionary("TechnologicalSkills");
            foreach (KeyValuePair<int, List<string>> item in skillsDict)
            {

                for (int i = 1; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"{item.Value[i]}");
                }
                
            }
            UserMode.getSubsectionsGuestMode();
        }
    }
}
