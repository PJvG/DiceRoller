namespace SimpleDiceRoller
{
    using System;

    public class DiceBase
    {
        // Fields
        private uint uiNumberOfDice;
        private uint uiDieSize;
        private Random rRandom;

        // Properties
        public uint NumberOfDice
        {
            get
            {
                return uiNumberOfDice;
            }
        }

        public uint DieSize
        {
            get
            {
                return uiDieSize;
            }
        }

        // Constructors
        public DiceBase()
            : this( 6 )
        {
        }

        public DiceBase( uint dieSize )
            : this ( 1, dieSize )
        {
        }

        public DiceBase( uint numberOfDice, uint dieSize )
        {
            uiNumberOfDice = numberOfDice;
            uiDieSize = dieSize;
            rRandom = RandomSingleton.Instance.Random;
        }

        // Methods
        public RollResult RollDice()
        {
            RollResult rrResult = new RollResult((int)uiNumberOfDice);

            if (0 < uiDieSize)
            {
                for (int iIndex = 0; uiNumberOfDice > iIndex; ++iIndex)
                {
                    int iRollResult = rRandom.Next(1, (int)(uiDieSize + 1));
                    rrResult.AddResult(iRollResult);
                }
            }

            return rrResult;
        }
    }
}
