using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts.Models
{
    internal class Participant
    {
        private string name;
        private double weigtBefore;
        private double weigtAfter;

        public Participant(string name, double weigtBefore, double weigtAfter)
        {
            this.name = name;
            this.weigtBefore = weigtBefore;
            this.weigtAfter = weigtAfter;
        }

        public string GetName() { return name; }
        public double GetWeightBefore () { return weigtBefore; }
        public double GetWeightAfter () {  return weigtAfter; }

    }
}
