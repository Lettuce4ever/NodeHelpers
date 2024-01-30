using NodeClass;
using NodeInserts.Models;

namespace NodeInserts
{
    internal class Program
    {
        public static bool AreThereRecivers(Node<ShabatRecievers> lst, int day, int month, int year)
        {
            while (lst != null)
            {
                if (lst.GetValue().GetDay()==day&& lst.GetValue().GetMonth()== month&& lst.GetValue().GetYear()== year)
                {
                    return true;
                }
                lst=lst.GetNext();
            }
            return false;
        }
       public static int HowManyMatches(Node<DominoStone> lst, DominoStone stone)
        {
            int counter =0;
            while (lst != null)
            {
                if (stone.IsExist(lst.GetValue().GetNum1())|| stone.IsExist(lst.GetValue().GetNum2()) )
                {
                    counter++;
                }
                lst = lst.GetNext();
            }
            return counter;
        }

        public static string Winner(Node<Participant> lst)
        {
            double bestWeightLost=0;
            string winner = null;

            while (lst != null)
            {
                if ((lst.GetValue().GetWeightBefore()- lst.GetValue().GetWeightAfter())/ lst.GetValue().GetWeightBefore()*100>bestWeightLost)
                {
                    bestWeightLost= lst.GetValue().GetWeightBefore() - lst.GetValue().GetWeightAfter()/ lst.GetValue().GetWeightBefore() * 100;
                    winner = lst.GetValue().GetName();
                }
                lst = lst.GetNext();
            }
            return winner;
        }
        public static int CheapestLine(CityBuses Buses, Station org, Station des)
        {
            int cheapestLine = 0;
            double cheapestPrice = -1;
            while (Buses != null)
            {
                if (Buses.GetBuses().GetValue().Cost(org, des)<cheapestPrice&& Buses.GetBuses().GetValue().Cost(org, des)>0)
                {
                    cheapestPrice = Buses.GetBuses().GetValue().Cost(org, des);
                    cheapestLine = Buses.GetBuses().GetValue().GetLine();
                }
            }
            return cheapestLine;
        }
        static void Main(string[] args)
        {
            Node<ShabatRecievers> shabatShalom = new Node<ShabatRecievers>(new ShabatRecievers("Shiri","Shira",18,1,2024));
            Node<ShabatRecievers> nextShabat = new Node<ShabatRecievers>(new ShabatRecievers("Ofek", "Aviv", 25, 1, 2024));
            shabatShalom.SetNext(nextShabat);

            ShabatRecievers sh = shabatShalom.GetValue();
            string p1 = sh.GetParent1();


        }
    }
}