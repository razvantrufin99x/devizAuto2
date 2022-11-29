using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace devizAuto
{
    public class masina
    {
        public int codunicmasina;
        public string marca;
        public Color culoare;
        public string tipauto;
        public int codunicpersoana;

        public masina() { }
        public masina(int pcodunicmasina, string pmarca, Color pculoare, string ptipauto, int pcodunicpersoana)
        { 
            this.codunicmasina = pcodunicmasina;
            this.marca = pmarca;
            this.culoare = pculoare;
            this.tipauto = ptipauto;
            this.codunicpersoana = pcodunicpersoana;
        }


    }
}
