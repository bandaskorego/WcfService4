using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceContract
{
    public class Operation1 : IOperation1
    {
        public int sumNumbersBetween(int a, int b)
        {
            Console.WriteLine("sumAllBetween(" + a + ", " + b + ")");

            int sum = 0;
            if (b == a)
            {
                Console.WriteLine("A = B");
                Console.WriteLine("Result = " + sum);
                return 0;
            }
            else if (b > a)
            {
                for (int i = a + 1; i < b; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Result = " + sum);
                return sum;
            }
            else
            {
                for (int i = b + 1; i < a; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Result = " + sum);
                return sum;
            }
        }

        public int modulo(int a, int b)
        {
            Console.WriteLine("modulo(" + a + ", " + b + ")");
            if (a == 0)
            {
                Console.WriteLine("A = 0");
                return 0;
            }
            else if (b == 0)
            {
                Console.WriteLine("B = 0");
                return 0;
            }
            else
            {
                Console.WriteLine("modulo =" + a % b);
                return a % b;
            }
        }

    }

    public class Operation2 : IOperation2
    {
        public string concat(string str1, string str2)
        {
            Console.WriteLine("concat(" + str1 + ", " + str2 + ")");
            Console.WriteLine("Result = "+ str1 + str2);

            return str1 + str2;
        }

        public string multiplay(string str, int a)
        {
            String res ="";
            Console.WriteLine("multiplay(" + str + ", " + a + ")");
            if (a < 0)
            {
                Console.WriteLine("A < 0");
                return str;
            }else if (str.Equals(""))
            {
                Console.WriteLine("String is empty");
                return str;
            }
            else
            {
                for(int i =0; i < a; i++)
                {
                    res += str;
                }
                Console.WriteLine("Result" + res);
                return res;
            }
        }

        public string reverse(string str)
        {
            Console.WriteLine("reverse(" + str + ")");
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            Console.WriteLine($"Reversed = {result}");
            return result;
        }
    }
}
