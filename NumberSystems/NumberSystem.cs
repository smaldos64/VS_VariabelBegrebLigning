using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VariabelBegreb.Tools;

namespace VariabelBegreb.NumberSystems
{
    public abstract class NumberSystem
    {
        public int ConvertNumberToRadix10(string Text)
        {
            return (1);
        }

        public abstract bool IsKeyValid(Key ThisKey);

        public virtual string ConvertFromRadix10(int NumberToConvert, int Radix, int RadixSpaceCounter)
        {
            int NumberCalculated = 0;
            int Carry = 0;
            string OutputString = "";
            int StringCounter = 0;

            do
            {
                StringCounter++;
                NumberCalculated = NumberToConvert / Radix;
                Carry = NumberToConvert % Radix;
                OutputString += Carry.ToString("X");

                if (0 == StringCounter % RadixSpaceCounter)
                {
                    OutputString += " ";
                }

                NumberToConvert = NumberCalculated;
            } while (NumberCalculated > 0);

            return (StringHelper.ReverseString(OutputString));
        }
    }
}
