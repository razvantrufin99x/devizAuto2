using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devizAuto
{
    public class companie
    {
        public int coduniccompania;
        public string denumire;
        public string cui;
        public string logo;
        public int codunicpersoana;

        public List<deviz> devize = new List<deviz>();

        public companie() { }

        public companie(int pcoduniccompania, string pdenumire, string pcui, string plogo, int pcodunicpersoana) 
        {
            this.coduniccompania = pcoduniccompania;
            this.denumire = pdenumire;
            this.cui = pcui;
            this.logo = plogo;
            this.codunicpersoana = pcodunicpersoana;
        }

    }
}
