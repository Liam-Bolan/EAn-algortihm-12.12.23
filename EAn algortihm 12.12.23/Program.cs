using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAn_algortihm_12._12._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int evens;
            int odds;
            int evens2;
            int results;
            int CheckDigit;
            int CheckDigit2;
            string BarNum;
            Console.Write("Enter 12 digits of barcode: ");
            BarNum = Console.ReadLine();
            
            while(BarNum.Length != 12)
            {
                Console.Write("Invalid! Enter 12 digits of barcode: ");
                BarNum = Console.ReadLine();
            }
            odds = (BarNum[0]-48) + (BarNum[2]-48) + (BarNum[4]-48) + (BarNum[6]-48) + (BarNum[8]-48) + (BarNum[10]-48);
            
            evens = (BarNum[1]-48) + (BarNum[3]-48) + (BarNum[5]-48) + (BarNum[7]-48) + (BarNum[9]-48) + (BarNum[11]-48);
            
            evens2 = evens * 3;

            results = evens2 + odds;

            CheckDigit = results % 10;

            CheckDigit2 = 10- CheckDigit;
            if(CheckDigit2 == 10)
            {
                CheckDigit2 = 0;
            }
            Console.WriteLine(CheckDigit2);
            Console.ReadKey();
        }
    }
}
