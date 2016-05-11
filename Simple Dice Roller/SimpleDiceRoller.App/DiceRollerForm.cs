// Project created: 2016-01-24
// By: Pieterjan P.J.G. van Gastel

namespace SimpleDiceRoller.App
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class DiceRollerForm : Form
    {
        #region Fields

        private IDiceRoller drRoller;

        private uint uiNumberOfDice = 1;

        #endregion Fields

        #region Constructors

        public DiceRollerForm()
        {
            InitializeComponent();
            drRoller = new DiceRoller();
        }

        #endregion Constructors

        #region Methods

        private void btnRollSimple_Click(object sender, EventArgs e)
        {
            uint uiXValue;
            uint uiYValue;

            if (UInt32.TryParse(tbX.Text, out uiXValue) && UInt32.TryParse(tbY.Text, out uiYValue))
            {
                // avoid infinite loop
                if (cbExplosiveDice.Checked && ((1 >= uiYValue) || (0 == uiXValue)))
                {
                    tbSimpleRollResult.Text = "Parsing error";
                }
                else
                {
                    bool bCritical = false;
                    uint uiTotal = 0;
                    string strCalculation = "";
                    DiceBase dbDice = new DiceBase(uiXValue, uiYValue);
                    do
                    {
                        RollResult rrResult = dbDice.RollDice();

                        uiTotal += rrResult.TotalResult;
                        strCalculation += rrResult.ToString();

                        if ((uiXValue * uiYValue) == rrResult.TotalResult)
                        {
                            bCritical = true;
                            if (cbExplosiveDice.Checked)
                            {
                                strCalculation += "+";
                            }
                        }
                        else
                        {
                            bCritical = false;
                        }
                    }
                    while (cbExplosiveDice.Checked && bCritical);

                    tbSimpleRollResult.Text = uiTotal.ToString() + " " + strCalculation;
                }
            }
            else
            {
                tbSimpleRollResult.Text = "Parsing error";
            }
        }

        private void btnRollAdvanced_Click(object sender, EventArgs e)
        {
            tbRollResult.Text = drRoller.RollDice(tbInput.Text);
        }

        private void cbExplosiveDice_CheckedChanged(object sender, EventArgs e)
        {
            drRoller.Explosive = cbExplosiveDice.Checked;
        }

        private void tbNumberOfDice_TextChanged(object sender, EventArgs e)
        {
            uint uiValue;
            if (UInt32.TryParse(tbNumberOfDice.Text, out uiValue) && ( 0 < uiValue ))
            {
                uiNumberOfDice = uiValue;

                btnD4.Text = uiNumberOfDice + "d4";
                btnD6.Text = uiNumberOfDice + "d6";
                btnD8.Text = uiNumberOfDice + "d8";
                btnD10.Text = uiNumberOfDice + "d10";
                btnD12.Text = uiNumberOfDice + "d12";
                btnD20.Text = uiNumberOfDice + "d20";
                btnD30.Text = uiNumberOfDice + "d30";
                btnD100.Text = uiNumberOfDice + "d100";
            }
            else
            {
                uiNumberOfDice = 0;

                btnD4.Text = "?d4";
                btnD6.Text = "?d6";
                btnD8.Text = "?d8";
                btnD10.Text = "?d10";
                btnD12.Text = "?d12";
                btnD20.Text = "?d20";
                btnD30.Text = "?d30";
                btnD100.Text = "?d100";
            }
        }

        private string PresetDiceButtonClick(uint uiDiceSize)
        {
            string strReturnValue;

            if (0 < uiNumberOfDice)
            {
                DiceBase dbDice = new DiceBase(uiNumberOfDice, uiDiceSize);
                RollResult rrResult = dbDice.RollDice();
                strReturnValue = rrResult.TotalResult.ToString() + " " + rrResult.ToString();
            }
            else
            {
                strReturnValue = "Parsing error";
            }

            return strReturnValue;
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            tbD4.Text = PresetDiceButtonClick(4);
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            tbD6.Text = PresetDiceButtonClick(6);
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            tbD8.Text = PresetDiceButtonClick(8);
        }

        private void btnD10_Click(object sender, EventArgs e)
        {
            tbD10.Text = PresetDiceButtonClick(10);
        }

        private void btnD12_Click(object sender, EventArgs e)
        {
            tbD12.Text = PresetDiceButtonClick(12);
        }

        private void btnD20_Click(object sender, EventArgs e)
        {
            tbD20.Text = PresetDiceButtonClick(20);
        }

        private void btnD30_Click(object sender, EventArgs e)
        {
            tbD30.Text = PresetDiceButtonClick(30);
        }

        private void btnD100_Click(object sender, EventArgs e)
        {
            tbD100.Text = PresetDiceButtonClick(100);
        }

        #endregion Methods
    }
}
