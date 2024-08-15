using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class clsRandom
    {
        internal static int getRandom(string[] combinationArray, int currentNumber)
        {
            try
            {
                Random random = new Random();
                int index = random.Next(0, combinationArray.Length);
                if (combinationArray[index] == "*" || combinationArray[index] == "#" || combinationArray[index] == currentNumber.ToString())
                {
                    return getRandom(combinationArray, currentNumber);
                }
                return Convert.ToInt32(combinationArray[index]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
