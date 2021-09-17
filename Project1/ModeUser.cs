using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class ModeUser
    {   
        private List<string> _modeUserList = new List<string>
        {
            {"Guest"},
            {"Admin"}
        };

        public List<string> getmodeUserList
        {
            get => _modeUserList;
        }

    }
}
