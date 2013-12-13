using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int _i=i;
            int k = (_i % 10)*1000;
            _i =_i/ 10;
            k = k+(_i % 10)*100;
            _i = _i / 10;
            k = k + (_i % 10) * 10;
            _i = _i / 10;
            k = k + (_i % 10);
            if (i == k)
                Console.WriteLine("Число читается одинаково слево направо и справа на лево");
            Console.ReadKey();

        }
    }
}
