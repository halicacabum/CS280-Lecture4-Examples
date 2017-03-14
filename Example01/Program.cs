using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Status response = Status.Success;

            switch (response)
            {
                case Status.Success:
                    Console.WriteLine("狀態是成功");
                    Console.WriteLine(response);
                    break;

                case Status.Error:
                    Console.WriteLine("狀態是錯誤");
                    Console.WriteLine(response);
                    break;

                default:
                    Console.WriteLine("狀態不明");
                    Console.WriteLine(response);
                    break;
            }
        }
    }
}