using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcel
{
    class ParamsLogin
    {
        public string action { get; set; }
        public string email { get; set; }
        public int password { get; set; }

        public ParamsLogin(string email, int pass)
        {
            action = "selectandinsert";
            this.email = email;
            this.password = pass;
        }
    }

    //get the log in...
    class resultLogin
    {
        public string email { get; set; }
        public int password { get; set; }
    };
}
