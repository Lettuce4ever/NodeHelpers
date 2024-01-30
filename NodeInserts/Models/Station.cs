using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts.Models
{
    public class Station
    {
        private string street;//הרחוב בו התחנה נמצאת
        private int num;//מספר הבית בו התחנה נמצאת
        
        public Station(string street, int num) 
        { 
            this.street = street;
            this.num = num;
        }



        public string GetSteet()
        {
            return street;
        }

        public int GetNum()
        {
            return num;
        }

        public void SetNum(int num)
        {
            this.num = num;
        }
        public void SetStreet(string street) 
        {
            this.street=street;
        }

        public bool Equals (Station s)
        {
            if (this.num== s.num && this.street==s.street) 
                return true;
            else return false;
        }
    }
}
