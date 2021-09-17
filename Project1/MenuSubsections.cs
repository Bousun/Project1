using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class MenuSubsections
    {
        private List<string> _subsections = new List<string>
        {
            {"Experience"},
            {"Education"},
            {"Skills"},
            {"Technological Skills"},
            {"Contact Details"}
        };

        public List<string> getSubsectionList
        {
            get => _subsections;
        }

        private List<string> _operations = new List<string>
        {

            {"Create new Record"},
            {"Read Record"},
            {"Update Record"},
            {"Delete Record"},
        };

        public List<string> getOperationList
        {
            get => _operations;
        }


        
    }
}
