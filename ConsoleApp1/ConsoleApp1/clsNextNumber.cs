using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class clsNextNumber
    {
        internal static int getNextNumberRook(int currentNumber, string[,] keypad)
        {
            try
            {
                int length = keypad.GetLength(0);
                int width = keypad.GetLength(1);
                int myI = 0;
                int myJ = 0;
                for (int i = 0; i < keypad.GetLength(0); i++)
                {
                    for (int j = 0; j < keypad.GetLength(1); j++)
                    {
                        if (keypad[i, j].ToString() == currentNumber.ToString())
                        {
                            myI = i;
                            myJ = j;
                        }
                    }
                }
                string combination = string.Empty;
                for (int i = 0; i < keypad.GetLength(1); i++)
                {
                    combination += keypad[myI, i].ToString() + ",";
                }
                for (int i = 0; i < keypad.GetLength(0); i++)
                {
                    combination += keypad[i, myJ].ToString() + ",";
                }
                string[] combinationArray = combination.TrimEnd(',').Split(',');

                return clsRandom.getRandom(combinationArray, currentNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }       
    }
}
