using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VariabelBegreb.Tools
{
    public enum RadixNumber_ENUM
    {
        ROMER_NUMBER,
        DECIMAL_NUMBER,
        BINARY_NUMBER = 2,
        OCTAL_NUMBER = 8,
        HEXADECIMAL_NUMBER = 16
    }

    public class ConstRadixSystem
    {
        public RadixNumber_ENUM RadixNumber { get; set; }
        public int RadixSpaceCounter { get; set; }
        public char RadixSpaceCharacter { get; set; }

        public ConstRadixSystem(RadixNumber_ENUM RadixNumber, int RadixSpaceCounter, char RadixSpaceCharacter)
        {
            this.RadixNumber = RadixNumber;
            this.RadixSpaceCounter = RadixSpaceCounter;
            this.RadixSpaceCharacter = RadixSpaceCharacter;
        }
    }

    public class Const
    {
        public static readonly ConstRadixSystem[] RadixSystemArray =
        {
            new ConstRadixSystem(RadixNumber : RadixNumber_ENUM.BINARY_NUMBER, RadixSpaceCounter : 4, RadixSpaceCharacter : ' '),
            new ConstRadixSystem(RadixNumber : RadixNumber_ENUM.OCTAL_NUMBER, RadixSpaceCounter : 3, RadixSpaceCharacter : ' '),
            new ConstRadixSystem(RadixNumber : RadixNumber_ENUM.HEXADECIMAL_NUMBER, RadixSpaceCounter : 4, RadixSpaceCharacter : ' '),
            new ConstRadixSystem(RadixNumber : RadixNumber_ENUM.DECIMAL_NUMBER, RadixSpaceCounter : 3, RadixSpaceCharacter : '.')
        };

        public static ConstRadixSystem FindRadixSystem(RadixNumber_ENUM RadixNumber)
        {
            int RadixSystemCounter = 0;

            do
            {
                if (RadixNumber == RadixSystemArray[RadixSystemCounter].RadixNumber)
                {
                    return (RadixSystemArray[RadixSystemCounter]);
                }
                else
                {
                    RadixSystemCounter++;
                }
            } while (RadixSystemCounter < RadixSystemArray.Length);

            return (null);
        }

        #region General_Stuff
        public const int NumberFormatError = -1;
        public const int RadixNumberNotFound = -1;
        #endregion

        #region Const_FirstOrderEquation
        public const string txtParametersFor1OrderLineString = "Her kommer karakteristika for den rette linje beskrevet ved de 2 punkter herover";
        #endregion

        #region Const_SecondOrderEquation
        public const string txtParametersForParabelString = "Her kommer karakteristika for parablen beskrevet ved de 3 punkter herover";
        public const string txtParametersForParabelByCoefficientsString = "Her kommer rødder og toppunkt for parablen beskrevet herover";
        #endregion

        #region Const_EquationSystem
        public const int Min_Order_Of_Equations = 2;
        public const int Max_Order_Of_Equations = 10;
        
        public const int Min_Number_Of_Decimals = 2;
        public const int Max_Number_Of_Decimals = 10;
        
        public const string EqutionSystemDirectory = "EquationSystem";
        public const string EquationSystemExtension = "equ";
        public const string EquationSystemSolvedString = "Løsning til Ligningssystem : ";
        public const string EquationSystemNotSolvedString = "Her kommer løsningen på ligningssystemet.";
        #endregion

        #region Const_PercentageCalculations
        public const string lblPercentageOfBaseAmountText = "x % af y er : ";

        public static void SetDefaultUpDownLabelContent(Label UpDownLabel)
        {
            UpDownLabel.Content = lblPercentageOfBaseAmountText;
        }
        #endregion

        #region Const_FractionCalculations
        public const string lblPlusFractionsDefaultText = "Addition af Brøker : ";
        public const string lblMinusFractionsDefaultText = "Subtraktion af Brøker : ";
        public const string lblMultiplyFractionsDefaultText = "Multiplikation af Brøker : ";
        public const string lblDivideFractionsDefaultText = "Division af Brøker : ";

        public static void SetDefaultFractionsLabelsContent(Label PlusLabel,
                                                            Label MinusLabel,
                                                            Label MultiPlyLabel,
                                                            Label DivideLabel)
        {
            PlusLabel.Content = lblPlusFractionsDefaultText;
            MinusLabel.Content = lblMinusFractionsDefaultText;
            MultiPlyLabel.Content = lblMultiplyFractionsDefaultText;
            DivideLabel.Content = lblDivideFractionsDefaultText;
        }
        #endregion

        #region Const_General_Code
        public static int DefaultNumberOfDecimals = 3;

        public static void SetDefaultNumberOfDecimals(int DefaultNumberOfDecimalsSet)
        {
            DefaultNumberOfDecimals = DefaultNumberOfDecimalsSet;
        }

        public static int GetDefaultNumberOfDecimals()
        {
            return (DefaultNumberOfDecimals);
        }
        #endregion
    }
}
