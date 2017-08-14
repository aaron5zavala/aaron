using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcel
{
    class insertUser
    {
        public string action { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public int password { get; set; }

        public insertUser (string name, string lastname, string email, int pass)
        {
            action = "insertUsuario";
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            password = pass;
        }
    }

    class resultInsert
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public int password { get; set; }
    };
}
