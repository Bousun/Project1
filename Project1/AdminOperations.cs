using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class AdminOperations : IOperationsOfAdmin
    {

        public void Create(string field1, string field2, string field3, string field4)
        {
            var filePath = "C:/Users/p128612/source/repos/Project1/Project1/UserInformation.csv";
            var delimiter = ",";
            var csv = new StringBuilder();

            var newline = String.Concat("Experience", delimiter, field2, delimiter, field3, delimiter, field4);

            csv.AppendLine(newline);

            File.AppendAllText(filePath, newline.ToString());
            Console.WriteLine("Entry Successful");
        }
    }
}
