﻿using System;
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
        public abstract bool IsKeyValid(Key ThisKey);

        public abstract string ConvertFromRadix10(int Radix10Number);

        public virtual string ConvertFromRadix10(int NumberToConvert, int RadixValue, int RadixSpaceCounter,
                                                 char RadixSeperationCharacter)
        {
            int NumberCalculated = 0;
            int Carry = 0;
            string OutputString = "";
            int StringCounter = 0;

            do
            {
                StringCounter++;
                NumberCalculated = NumberToConvert / RadixValue;
                Carry = NumberToConvert % RadixValue;
                OutputString += Carry.ToString("X");

                if (0 == StringCounter % RadixSpaceCounter)
                {
                    OutputString += RadixSeperationCharacter;
                }

                NumberToConvert = NumberCalculated;
            } while (NumberCalculated > 0);

            return (StringHelper.ReverseString(OutputString));
        }

        public abstract int ConvertToRadix10(string RadixStringToConvert);

        public virtual int ConvertToRadix10(string RadixStringToConvert, RadixNumber_ENUM Radix)
        {
            //string RadixOutputString;
            int Radix10Value = 0;

            RadixStringToConvert = StringHelper.ReverseString(RadixStringToConvert);

            for (int Counter = 0; Counter < RadixStringToConvert.Length; Counter++)
            {
                if (RadixNumber_ENUM.HEXADECIMAL_NUMBER == Radix)
                {
                    Radix10Value += (int)Math.Pow((int)Radix, Counter) * int.Parse(RadixStringToConvert[Counter].ToString(),
                        System.Globalization.NumberStyles.HexNumber);
                }
                else
                {
                    Radix10Value += (int)Math.Pow((int)Radix, Counter) * (int)Char.GetNumericValue(RadixStringToConvert[Counter]);
                }
            }

            return (Radix10Value);
            //RadixOutputString = DecimalValue.ToString();

            //return (RadixOutputString);
        }
    }
}
