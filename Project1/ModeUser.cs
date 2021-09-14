using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class ModeUser
    {
        private Dictionary<int, string> _modeUserDict = new Dictionary<int, string>
        {
            {1 ,"Guest"},
            {2,"Admin"}
        };

        public Dictionary<int, string> OptionsLists
        {
            get => _modeUserDict;
        }

    }
}
