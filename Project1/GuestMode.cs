using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class GuestMode
    {

        private Dictionary<int, string> _optionsDict = new Dictionary<int, string>
        {
            {1 ,"Experience"},
            {2,"Education"},
            {3 ,"Skills"},
            {4 ,"Technological Skills"},
            {5 ,"Contact Details"}
        };

        public Dictionary<int, string> OptionsLists
        {
            get => _optionsDict;
        }

        public static void callDisplayMenu(int userChoice, string path)
        {
            
            switch (userChoice) 
            {
                case 1:
                    string exp = "Experience.csv";
                    var experienceDict = Experience.getpopulatedExperience(exp);
                    var result = Utilities.VerifyInput(experienceDict);
                   
                    string job = "JobDescription.csv";
                    JobDescription.DisplayDescription(job,result);
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case -1:

                    break;

            }


        }
        
    }
}
