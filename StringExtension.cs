using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            int[] legthwordinstring = new int[array.Length];
            bool ch;
            void swap(int[] a, string[] b, int i)
            {
                int tempInt = a[i];
                string tempStr = b[i];
                a[i] = a[i - 1];
                a[i - 1] = tempInt;
                b[i] = b[i - 1];
                b[i - 1] = tempStr;
            }
            for (int i = 0; i < array.Length; i++)
            {
                legthwordinstring[i] = (array[i].ToCharArray()).Length;
            }
            do
            {
                ch = true;
                for (int i = 1; i < legthwordinstring.Length; i++)
                {
                    if (legthwordinstring[i] < legthwordinstring[i - 1])
                    {
                        swap(legthwordinstring, array, i);
                        ch = false;
                    }
                }
            } while (ch == false);
        }
    }
}
