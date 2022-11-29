using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devizAuto
{
    public class deviz
    {
        public int codunicdeviz;
        public DateTime data;
        public string denumire;
        public int codunicpersoana;
        public int codunicmasina;

        public float costtotal;
        public float tvatotal;

        public devizextended theextendedlist = new devizextended();

        public deviz() { }
        public deviz(int pcodunicdeviz, DateTime pdata, string pdenumire, int pcodunicpersoana, int pcodunicmasina)
        {
            this.codunicpersoana = pcodunicpersoana;
            this.data = pdata;
            this.denumire = pdenumire;
            this.codunicdeviz = pcodunicdeviz;
            this.codunicmasina = pcodunicmasina;
        }
    }
}
