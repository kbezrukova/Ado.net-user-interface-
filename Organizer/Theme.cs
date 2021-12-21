using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    class Theme
    {
        int _iD;
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
