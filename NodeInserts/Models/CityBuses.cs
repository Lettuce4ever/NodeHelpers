using NodeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts.Models
{
    public class CityBuses
    {
        private string name;
        private Node<Bus> buses;

        public Node<Bus> GetBuses()
        {
            return buses;
        }
    }
}
