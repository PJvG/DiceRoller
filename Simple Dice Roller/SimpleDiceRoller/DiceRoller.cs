// Project created: 2016-01-24
// By: Pieterjan P.J.G. van Gastel

namespace SimpleDiceRoller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DiceRoller : IDiceRoller
    {
        #region Properties

        public bool Explosive { get; set; }

        #endregion Properties

        #region Methods

        public string RollDice(string strInput)
        {
            string strReturn = "";
            int iTotal = 0;
            string strCalculation = "";
            Operator eOperator = Operator.Add;
            bool bParseFailure = false;

            // parse to dice, operators and integers
            string[] substrings = ParseString(strInput);

            foreach (string strString in substrings)
            {
                uint uiIntegerParseResult;
                // check if operator
                if (0 == strString.CompareTo("+"))
                {
                    eOperator = Operator.Add;
                    strCalculation += "+";
                }
                else if (0 == strString.CompareTo("-"))
                {
                    eOperator = Operator.Substract;
                    strCalculation += "-";
                }
                // check if dice
                else if (strString.Contains('d'))
                {
                    Char cDelimiter = 'd';
                    string[] straParts = strString.Split(cDelimiter);
                    if (2 != straParts.Count<string>())
                    {
                        bParseFailure = true;
                        break;
                    }

                    uint uiDiceNumber;
                    uint uiDiceSize;
                    if ((UInt32.TryParse(straParts[0], out uiDiceNumber)) && (UInt32.TryParse(straParts[1], out uiDiceSize)))
                    {
                        // avoid infinite loop
                        if (this.Explosive && ((1 >= uiDiceSize) || ( 0 == uiDiceNumber)))
                        {
                            bParseFailure = true;
                            break;
                        }

                        bool bCritical = false;
                        DiceBase dbDice = new DiceBase(uiDiceNumber, uiDiceSize);
                        do
                        {
                            RollResult rrResult = dbDice.RollDice();

                            if ((uiDiceNumber * uiDiceSize) == rrResult.TotalResult)
                            {
                                bCritical = true;
                            }
                            else
                            {
                                bCritical = false;
                            }

                            switch (eOperator)
                            {
                                case Operator.Add:
                                    iTotal += (int)rrResult.TotalResult;
                                    break;
                                case Operator.Substract:
                                    iTotal -= (int)rrResult.TotalResult;
                                    break;
                                default:
                                    bParseFailure = true;
                                    break;
                            }
                            if (1 < uiDiceNumber)
                            {
                                strCalculation += "(" + rrResult.ToString() + ")";
                            }
                            else
                            {
                                strCalculation += rrResult.ToString();
                            }
                            if (this.Explosive && bCritical)
                            {
                                switch (eOperator)
                                {
                                    case Operator.Add:
                                        strCalculation += "+";
                                        break;
                                    case Operator.Substract:
                                        strCalculation += "-";
                                        break;
                                    default:
                                        bParseFailure = true;
                                        break;
                                }
                            }
                        }
                        while (this.Explosive && bCritical);
                    }
                    else
                    {
                        bParseFailure = true;
                        break;
                    }
                }
                // check if integer
                else if (UInt32.TryParse(strString, out uiIntegerParseResult))
                {
                    switch (eOperator)
                    {
                        case Operator.Add:
                            iTotal += (int) uiIntegerParseResult;
                            break;
                        case Operator.Substract:
                            iTotal -= (int) uiIntegerParseResult;
                            break;
                        default:
                            bParseFailure = true;
                            break;
                    }
                    strCalculation += uiIntegerParseResult.ToString();
                }
                else
                {
                    bParseFailure = true;
                    break;
                }
            }

            if (bParseFailure)
            {
                strReturn = "Parsing error";
            }
            else
            {
                strReturn = iTotal.ToString() + " " + strCalculation;
            }
            
            return strReturn;
        }

        private string[] ParseString(string stringToParse)
        {
            List<String> substrings = new List<String>();
            int iPositionPlus = 0;
            int iPositionMinus = 0;
            int iPosition = 0;
            int iStart = 0;

            do
            {
                iPositionPlus = stringToParse.IndexOf('+', iStart);
                iPositionMinus = stringToParse.IndexOf('-', iStart);

                if ((0 <= iPositionPlus) && ((iPositionPlus < iPositionMinus) || (0 > iPositionMinus)))
                {
                    iPosition = iPositionPlus;
                }
                else if ((0 <= iPositionMinus) && ((iPositionPlus > iPositionMinus) || (0 > iPositionPlus)))
                {
                    iPosition = iPositionMinus;
                }
                else
                {
                    iPosition = -1;
                    substrings.Add(stringToParse.Substring(iStart).Trim());
                }

                if ( 0 < iPosition )
                {
                    substrings.Add(stringToParse.Substring(iStart, iPosition - iStart).Trim());
                    substrings.Add(stringToParse.Substring(iPosition, 1));
                    iStart = iPosition + 1;
                }
                else if ( 0 == iPosition )
                {
                    substrings.Add(stringToParse.Substring(iPosition, 1));
                    iStart = iPosition + 1;
                }
            } while ( 0 <= iPosition );

            return substrings.ToArray<string>();
        }

        #endregion Methods
    }
}
