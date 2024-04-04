using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.mahat_test
{


    public class MahatTest
    {

        //instance member (איבריים לא סטטיים אלא שכפוליים) 
        public int year = 0;
        public string season = "";
        public char period = ' ';

        public int passGrade = 0;

        //instance method - פעולה ששייכת רק לכל שכפול
        public bool PassTest(int grade)
        {
            return grade >= passGrade;
        }

        //some static 

        public static void DontDoNothing()
        {

        }


    }
}
