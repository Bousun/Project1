using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Project1
{
    public class Experience
    {
        
        
        public static Dictionary<int, string> experienceDict = new Dictionary<int, string>();
        string exp = "Experience.csv";
        public Experience()
        {
            getpopulatedExperience(exp);
        }

        public static Dictionary<int, string> getpopulatedExperience(string path) 
        {
            Console.WriteLine("Select the user experience :");
            var details = ProcessCSV(path);
            
            foreach (var detail in details)
            {
                experienceDict.Add(Int32.Parse(detail.index), detail.company_name);
            }
            return experienceDict;
        }

        public Dictionary<int, string> OptionsLists
        {
            get => experienceDict;
        }

        private static List<ExperienceDetails> ProcessCSV(string path)
        {
            return File.ReadAllLines(path)
               .Where(row => row.Length > 0)
               .Select(ExperienceDetails.ParseRow).ToList();
        }
    }

    public class ExperienceDetails
    {
        public string index { get; set; }

        public string company_name { get; set; }

        internal static ExperienceDetails ParseRow(string row)
        {
            var columns = row.Split(',');

            return new ExperienceDetails()
            {
                index = columns[0],
                company_name = columns[1],
            };
        }
    }
}
