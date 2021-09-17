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

        public void Create(string field2, string field3, string field4)
        {
            var delimiter = ",";      

            var newline = String.Concat("Experience", delimiter, field2, delimiter, field3, delimiter, field4);
            try
            {
                var path = @"C:/Users/p128612/source/repos/Project1/Project1/UserInformation.csv";
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(newline);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException();
            }
        }
    }
}
