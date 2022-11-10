using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qwerty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                array.Add(random.Next(1, 50));
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Qwert(array));    


            Console.ReadKey();

        }
        public static int Qwert(List<int>array)
        {
            int count = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i]<25)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
