namespace SimpleDiceRoller
{
    public interface IDiceRoller
    {
        #region Properties

        bool Explosive { get; set; }

        #endregion Properties

        #region Methods

        string RollDice(string strInput);

        #endregion Methods
    }
}
