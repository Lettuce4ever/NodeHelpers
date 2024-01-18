using NodeClass;
using NodeInserts.Models;

namespace NodeInserts
{
    internal class Program
    {
        static public bool AreThereRecivers(Node<ShabatRecievers> lst, int day, int month, int year)
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
        static public Node<ShabatRecievers> DeleteShabatReciever(Node<ShabatRecievers> lst, string name)
        {
            return NodeHelper.Delete(, name);
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