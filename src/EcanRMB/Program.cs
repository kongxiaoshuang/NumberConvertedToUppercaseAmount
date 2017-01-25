using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcanRMB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;
            Console.Write("请输入金额：\n");
            input = Console.ReadLine().ToString();
           string result= CapitalHelper.CmycurD(input);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}