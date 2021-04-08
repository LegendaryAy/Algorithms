using System;

namespace Algorithms
{
    class Program
    {
        public static void Main(string [] args)
        {
            Maskify("2345677899764");
        }

        public static string Maskify(string cc)
        {

            var newArr = cc.ToCharArray();
            var len = cc;
            if (newArr.Length > 4)
            {
                for (int i = 0; i < newArr.Length - 4; i++)
                {
                    newArr[i] = '#';
                }
                len = new string(newArr);
            }
            return len;

        }
    }
}
