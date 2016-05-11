namespace SimpleDiceRoller
{
    using System.Collections.Generic;

    public class RollResult
    {
        // Fields
        private uint uiTotalResult;
        private List<uint> lDiceResults;

        // Properties
        public uint TotalResult
        {
            get
            {
                return uiTotalResult;
            }
        }

        public List<uint> DiceResults
        {
            get
            {
                return new List<uint>( lDiceResults );
            }
        }

        // Constructors
        public RollResult( int numberOfDice )
        {
            uiTotalResult = 0;
            lDiceResults = new List<uint>( numberOfDice );
        }

        // Methods
        public void AddResult(uint resultToAdd)
        {
            uiTotalResult += resultToAdd;
            lDiceResults.Add(resultToAdd);
        }

        public void AddResult(int resultToAdd)
        {
            AddResult((uint)resultToAdd);
        }

        public override string ToString()
        {
            string strReturnString = "";

            foreach (uint result in lDiceResults)
            {
                strReturnString += "+(" + result + ")";
            }

            return strReturnString.TrimStart('+');
        }
    }
}
