using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project22;
using project2.mahat_test;

namespace project2
{
    public class Demo
    {
        public static void DisplaySomeMaterial()
        {

            Test.DoSomething2();
            Console.WriteLine("myx = " + Test.myX);
            Test.myX = 15;
            Console.WriteLine("myx = " + Test.myX);

            Test.ShowSolution();
            MahatTest.DontDoNothing();
            //MahatTest.PassTest();//
            //instance - שכפול

            MahatTest test1 = new MahatTest();
            MahatTest test2 = new MahatTest();


            test1.period = 'A';
            test1.season = "summer";
            test1.passGrade = 60;

            test2.period = 'B';
            test2.season = "winter";
            test2.passGrade = 70;

            Console.WriteLine("Pass test with grade 65 on test1?  " + test1.PassTest(65));

            Console.WriteLine("Pass test with grade 65 on test2?  " + test2.PassTest(65));
        }
    }
}
