using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project22
{
    public class Test
    {

        public static int myX = 10;

        public static void DoSomething2()
        {
            Console.WriteLine("Do something 2 ");

            int result = Test2.Add10(20);

            Console.WriteLine("The result is:" + result);
        }

        public static void ShowSolution()
        {
            Console.WriteLine("ShowSolution");
            int[] array = { 1, 2, 3 };
            What(array , 4);
        }

        public static void What(int[] arr, int num)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left != right)
            {
                if (arr[left] < num)
                    left++;
                else
                if (arr[right] > num)
                    right--;
                else
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
            }
        }
    }

    public class Test2
    {
        public static int Add10(int num)
        {


            return num + 10;
        }
    }

}
