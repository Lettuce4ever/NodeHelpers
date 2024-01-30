using NodeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts.Models
{
    public class Bus
    {
        private int line;
        private double pricePerStation;
        private Node<Station> stations;

        public int GetLine() { return line; }



        public double Cost(Station org, Station des)
        {
            double amount = 0;
            bool desExist = false;
            Node<Station>  stops = stations;
            while (stops.GetValue()!=null&&!stops.GetValue().Equals(org))
            {
                stops=stops.GetNext();
            }
            while (stops!=null&&!stops.GetValue().Equals(des))
            {
                amount++;
                stops = stops.GetNext();
                if (stops.GetValue().Equals(des))
                {
                    desExist= true;
                }
            }
            if (desExist)
            {
                return amount * pricePerStation;
            }
            else return -1;
        }
    }
}
