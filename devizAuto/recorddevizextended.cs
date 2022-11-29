using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devizAuto
{
    public  class recorddevizextended
    {
        public int codrecord;
        public string operatia;
        public int ore;
        public int minute;
        public float cost;
        public float tva;
        public recorddevizextended() { }
        public recorddevizextended(int pcodrecord, string poperatia, int pore, int pminute, float pcost, float ptva) 
        { 
            this.codrecord = pcodrecord;
            this.operatia = poperatia;
            this.ore = pore;
            this.minute = pminute;
            this.cost = pcost;
            this.tva = ptva;
        }
    }
}
