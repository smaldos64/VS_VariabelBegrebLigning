using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VariabelBegreb.Tools;

namespace VariabelBegreb.NumberSystems
{
    public class BinaryNumber : NumberSystem
    {
        //static char[] ValidCharactersArray = { '0', '1' };

        static Key[] ValidKeysArray = { Key.D0, Key.D1 };

        public override bool IsKeyValid(Key ThisKey)
        {
            return (ValidKeysArray.Contains(ThisKey) || KeyHelper.IsKeyPressedValicControlKey(ThisKey));
        }

        public string ConvertFromRadix10(int Radix10Number)
        {
            base.ConvertFromRadix10(Radix10Number, )
        }

        //public int ConvertToRadix10(string RadixStringToConvert)
        //{

        //}
    }
}
