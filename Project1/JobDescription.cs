using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class JobDescription
    {
        public static Dictionary<int, string> descriptionDict = new Dictionary<int, string>() ;
        string job = "JobDescription.csv";
        public JobDescription()
        {
            populateDescription(job);
        }

        public static Dictionary<int, string> populateDescription(string path)
        {
            var details = ProcessCSV(path);

            
            foreach (var detail in details)
            {
                descriptionDict.Add(Int32.Parse(detail.index),detail.description);
                //Console.WriteLine($"{detail.index} : {detail.description}");
            }
            return descriptionDict;
        }

        public Dictionary<int, string> OptionsLists
        {
            get => descriptionDict;
        }

        public static void DisplayDescription(string path, int choice)
        {
            Dictionary<int, string> dict;
            //dict = populateDescription(path);

            foreach (KeyValuePair<int, string> item in descriptionDict)
            {
                if(choice == item.Key)
                    Console.WriteLine($"{item.Key} : {item.Value}");
                
            }


        }

        private static List<DetailsJob> ProcessCSV(string path)
        {
            return File.ReadAllLines(path)
                .Where(row => row.Length > 0)
                .Select(DetailsJob.ParseRow).ToList();
        }
    }

    public class DetailsJob
    {
        public string index { get; set; }
        public string description { get; set; }
        internal static DetailsJob ParseRow(string row)
        {
            var columns = row.Split(',');
            return new DetailsJob()
            {
                index = columns[0],
                description = columns[1],
            };
        }
    }
}
