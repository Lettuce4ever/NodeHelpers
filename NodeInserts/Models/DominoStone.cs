using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts.Models
{
    public class DominoStone
    {
        private int num1;
        private int num2;

        public DominoStone(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int GetNum1() { return num1; }
        public int GetNum2() { return num2; }
        public void SetNum1(int num) { num1=num; }
        public void SetNum2(int num) { num2 = num; }

        public bool IsExist(int num)
        {
            if (num==num1||num==num2)
            { return true; }
            return false;
        }
    }
}
