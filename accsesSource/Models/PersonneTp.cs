using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesSource.Models
{
    class PersonneTp
    {
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Prenom { get; set; }

        public PersonneTp()
        {
            Nom = "";
            Prenom = "";
            Age = 0;
        }
    }
}
