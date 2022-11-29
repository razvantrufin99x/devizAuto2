using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devizAuto
{
    public  class persoana
    {
        public int codunicpersoana;
        public string nume;
        public string prenume;
        public string adresa;
        public string telefon;
        public string email;
        public string codID;

        public persoana() { }
        public persoana(int pcodunicpersoana, string pnume, string pprenume, string padresa, string ptelefon, string pemail, string pcodID)
        { 
            this.codunicpersoana = pcodunicpersoana;
            this.nume = pnume;
            this.prenume = pprenume;
            this.adresa = padresa;
            this.telefon = ptelefon;
            this.email = pemail;

        }

    }
}
