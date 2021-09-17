using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public static class FileOperations
    {

        public static Dictionary<int, List<string>> returnFieldNameDictionary(string fieldname)
        {

            Dictionary<int, List<string>> fieldnameDict = new();
            var path = "UserInformation.csv";
            var allDetails = SplittingLine(path);
            var index = 0;
            foreach (var detail in allDetails)
            {
                //Console.WriteLine(detail);
                if (detail[0] == fieldname)
                {
                    index++;
                    fieldnameDict.Add(index, detail);

                }

            }

            return fieldnameDict;
        }
        public static List<List<string>> SplittingLine(string path)
        {
            var lines = ReadFile(path);
            List<List<string>> stringList = new();

            foreach (var line in lines)
            {
                //Console.WriteLine(line);
                var element = line.Split(',').ToList();
                stringList.Add(element);
                //Console.WriteLine();
            }
            return stringList;
        }
        public static List<string> ReadFile(string path)
        {
            using (var reader = new StreamReader(path))
            {
                List<string> listOfEachLineRetrieve = new List<string>();
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    listOfEachLineRetrieve.Add(line);
                    
                }
                return listOfEachLineRetrieve;
            }
        }
    }
}
