using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Class_Structure
{
    public class Test1/*שם המחלקה */
    {
        public /*accessor modifier - בקר שליטה */ //private/protected
            static /*Set this variable as static - מגדיר את המשתנה הזה בתור סטטי - כלומר קשור למחלקה ולא לשכפולים */
            int /* Type of the variable - הטיפוס של המשתנה */  

            myInt /* Name of the variable - שם המשתנה */
                        = 7; /*The value that I give it - הערך שניתן למשתנה */
        public static int myInt2 = 10;


        /**ראו למעלה בעברית */ 
        public/*accessor*/ 
        static/* set it as static */
            void /* the method type */
            DoSomething()
        {

        }

        public static String DoSomething2()
        {

            Console.WriteLine("DoSomething2 sadasd");
            return "";
        }
    }
}
