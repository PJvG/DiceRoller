namespace Simple_Dice_Roller
{
    partial class DiceRollerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnRollSimple = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSimpleRollResult = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnRollAdvanced = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRollResult = new System.Windows.Forms.TextBox();
            this.btnD4 = new System.Windows.Forms.Button();
            this.cbExplosiveDice = new System.Windows.Forms.CheckBox();
            this.btnD6 = new System.Windows.Forms.Button();
            this.btnD8 = new System.Windows.Forms.Button();
            this.btnD10 = new System.Windows.Forms.Button();
            this.btnD12 = new System.Windows.Forms.Button();
            this.btnD20 = new System.Windows.Forms.Button();
            this.btnD30 = new System.Windows.Forms.Button();
            this.tbD4 = new System.Windows.Forms.TextBox();
            this.tbD6 = new System.Windows.Forms.TextBox();
            this.tbD8 = new System.Windows.Forms.TextBox();
            this.tbD10 = new System.Windows.Forms.TextBox();
            this.tbD12 = new System.Windows.Forms.TextBox();
            this.tbD20 = new System.Windows.Forms.TextBox();
            this.tbD30 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumberOfDice = new System.Windows.Forms.TextBox();
            this.btnD100 = new System.Windows.Forms.Button();
            this.tbD100 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(12, 12);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(60, 20);
            this.tbX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "d";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(97, 12);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(60, 20);
            this.tbY.TabIndex = 2;
            // 
            // btnRollSimple
            // 
            this.btnRollSimple.Location = new System.Drawing.Point(163, 10);
            this.btnRollSimple.Name = "btnRollSimple";
            this.btnRollSimple.Size = new System.Drawing.Size(75, 23);
            this.btnRollSimple.TabIndex = 3;
            this.btnRollSimple.Text = "Roll";
            this.btnRollSimple.UseVisualStyleBackColor = true;
            this.btnRollSimple.Click += new System.EventHandler(this.btnRollSimple_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Roll result:";
            // 
            // tbSimpleRollResult
            // 
            this.tbSimpleRollResult.Location = new System.Drawing.Point(306, 12);
            this.tbSimpleRollResult.Name = "tbSimpleRollResult";
            this.tbSimpleRollResult.ReadOnly = true;
            this.tbSimpleRollResult.Size = new System.Drawing.Size(266, 20);
            this.tbSimpleRollResult.TabIndex = 5;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 61);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(145, 20);
            this.tbInput.TabIndex = 6;
            this.tbInput.Text = "2d6+1d4-3";
            // 
            // btnRollAdvanced
            // 
            this.btnRollAdvanced.Location = new System.Drawing.Point(163, 59);
            this.btnRollAdvanced.Name = "btnRollAdvanced";
            this.btnRollAdvanced.Size = new System.Drawing.Size(75, 23);
            this.btnRollAdvanced.TabIndex = 7;
            this.btnRollAdvanced.Text = "Roll";
            this.btnRollAdvanced.UseVisualStyleBackColor = true;
            this.btnRollAdvanced.Click += new System.EventHandler(this.btnRollAdvanced_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Roll result:";
            // 
            // tbRollResult
            // 
            this.tbRollResult.Location = new System.Drawing.Point(306, 61);
            this.tbRollResult.Name = "tbRollResult";
            this.tbRollResult.ReadOnly = true;
            this.tbRollResult.Size = new System.Drawing.Size(266, 20);
            this.tbRollResult.TabIndex = 9;
            // 
            // btnD4
            // 
            this.btnD4.Location = new System.Drawing.Point(12, 153);
            this.btnD4.Name = "btnD4";
            this.btnD4.Size = new System.Drawing.Size(50, 23);
            this.btnD4.TabIndex = 10;
            this.btnD4.Text = "1d4";
            this.btnD4.UseVisualStyleBackColor = true;
            this.btnD4.Click += new System.EventHandler(this.btnD4_Click);
            // 
            // cbExplosiveDice
            // 
            this.cbExplosiveDice.AutoSize = true;
            this.cbExplosiveDice.Location = new System.Drawing.Point(12, 87);
            this.cbExplosiveDice.Name = "cbExplosiveDice";
            this.cbExplosiveDice.Size = new System.Drawing.Size(94, 17);
            this.cbExplosiveDice.TabIndex = 12;
            this.cbExplosiveDice.Text = "Explosive dice";
            this.cbExplosiveDice.UseVisualStyleBackColor = true;
            this.cbExplosiveDice.CheckedChanged += new System.EventHandler(this.cbExplosiveDice_CheckedChanged);
            // 
            // btnD6
            // 
            this.btnD6.Location = new System.Drawing.Point(68, 153);
            this.btnD6.Name = "btnD6";
            this.btnD6.Size = new System.Drawing.Size(50, 23);
            this.btnD6.TabIndex = 13;
            this.btnD6.Text = "1d6";
            this.btnD6.UseVisualStyleBackColor = true;
            this.btnD6.Click += new System.EventHandler(this.btnD6_Click);
            // 
            // btnD8
            // 
            this.btnD8.Location = new System.Drawing.Point(124, 153);
            this.btnD8.Name = "btnD8";
            this.btnD8.Size = new System.Drawing.Size(50, 23);
            this.btnD8.TabIndex = 14;
            this.btnD8.Text = "1d8";
            this.btnD8.UseVisualStyleBackColor = true;
            this.btnD8.Click += new System.EventHandler(this.btnD8_Click);
            // 
            // btnD10
            // 
            this.btnD10.Location = new System.Drawing.Point(180, 153);
            this.btnD10.Name = "btnD10";
            this.btnD10.Size = new System.Drawing.Size(50, 23);
            this.btnD10.TabIndex = 15;
            this.btnD10.Text = "1d10";
            this.btnD10.UseVisualStyleBackColor = true;
            this.btnD10.Click += new System.EventHandler(this.btnD10_Click);
            // 
            // btnD12
            // 
            this.btnD12.Location = new System.Drawing.Point(236, 153);
            this.btnD12.Name = "btnD12";
            this.btnD12.Size = new System.Drawing.Size(50, 23);
            this.btnD12.TabIndex = 16;
            this.btnD12.Text = "1d12";
            this.btnD12.UseVisualStyleBackColor = true;
            this.btnD12.Click += new System.EventHandler(this.btnD12_Click);
            // 
            // btnD20
            // 
            this.btnD20.Location = new System.Drawing.Point(292, 153);
            this.btnD20.Name = "btnD20";
            this.btnD20.Size = new System.Drawing.Size(50, 23);
            this.btnD20.TabIndex = 17;
            this.btnD20.Text = "1d20";
            this.btnD20.UseVisualStyleBackColor = true;
            this.btnD20.Click += new System.EventHandler(this.btnD20_Click);
            // 
            // btnD30
            // 
            this.btnD30.Location = new System.Drawing.Point(348, 153);
            this.btnD30.Name = "btnD30";
            this.btnD30.Size = new System.Drawing.Size(50, 23);
            this.btnD30.TabIndex = 18;
            this.btnD30.Text = "1d30";
            this.btnD30.UseVisualStyleBackColor = true;
            this.btnD30.Click += new System.EventHandler(this.btnD30_Click);
            // 
            // tbD4
            // 
            this.tbD4.Location = new System.Drawing.Point(12, 182);
            this.tbD4.Name = "tbD4";
            this.tbD4.ReadOnly = true;
            this.tbD4.Size = new System.Drawing.Size(50, 20);
            this.tbD4.TabIndex = 19;
            // 
            // tbD6
            // 
            this.tbD6.Location = new System.Drawing.Point(68, 182);
            this.tbD6.Name = "tbD6";
            this.tbD6.ReadOnly = true;
            this.tbD6.Size = new System.Drawing.Size(50, 20);
            this.tbD6.TabIndex = 20;
            // 
            // tbD8
            // 
            this.tbD8.Location = new System.Drawing.Point(124, 182);
            this.tbD8.Name = "tbD8";
            this.tbD8.ReadOnly = true;
            this.tbD8.Size = new System.Drawing.Size(50, 20);
            this.tbD8.TabIndex = 21;
            // 
            // tbD10
            // 
            this.tbD10.Location = new System.Drawing.Point(180, 182);
            this.tbD10.Name = "tbD10";
            this.tbD10.ReadOnly = true;
            this.tbD10.Size = new System.Drawing.Size(50, 20);
            this.tbD10.TabIndex = 22;
            // 
            // tbD12
            // 
            this.tbD12.Location = new System.Drawing.Point(236, 182);
            this.tbD12.Name = "tbD12";
            this.tbD12.ReadOnly = true;
            this.tbD12.Size = new System.Drawing.Size(50, 20);
            this.tbD12.TabIndex = 23;
            // 
            // tbD20
            // 
            this.tbD20.Location = new System.Drawing.Point(292, 182);
            this.tbD20.Name = "tbD20";
            this.tbD20.ReadOnly = true;
            this.tbD20.Size = new System.Drawing.Size(50, 20);
            this.tbD20.TabIndex = 24;
            // 
            // tbD30
            // 
            this.tbD30.Location = new System.Drawing.Point(348, 182);
            this.tbD30.Name = "tbD30";
            this.tbD30.ReadOnly = true;
            this.tbD30.Size = new System.Drawing.Size(50, 20);
            this.tbD30.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Number of dice:";
            // 
            // tbNumberOfDice
            // 
            this.tbNumberOfDice.Location = new System.Drawing.Point(97, 127);
            this.tbNumberOfDice.Name = "tbNumberOfDice";
            this.tbNumberOfDice.Size = new System.Drawing.Size(75, 20);
            this.tbNumberOfDice.TabIndex = 27;
            this.tbNumberOfDice.Text = "1";
            this.tbNumberOfDice.TextChanged += new System.EventHandler(this.tbNumberOfDice_TextChanged);
            // 
            // btnD100
            // 
            this.btnD100.Location = new System.Drawing.Point(404, 153);
            this.btnD100.Name = "btnD100";
            this.btnD100.Size = new System.Drawing.Size(50, 23);
            this.btnD100.TabIndex = 28;
            this.btnD100.Text = "1d100";
            this.btnD100.UseVisualStyleBackColor = true;
            this.btnD100.Click += new System.EventHandler(this.btnD100_Click);
            // 
            // tbD100
            // 
            this.tbD100.Location = new System.Drawing.Point(404, 182);
            this.tbD100.Name = "tbD100";
            this.tbD100.ReadOnly = true;
            this.tbD100.Size = new System.Drawing.Size(50, 20);
            this.tbD100.TabIndex = 29;
            // 
            // DiceRollerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 218);
            this.Controls.Add(this.tbD100);
            this.Controls.Add(this.btnD100);
            this.Controls.Add(this.tbNumberOfDice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbD30);
            this.Controls.Add(this.tbD20);
            this.Controls.Add(this.tbD12);
            this.Controls.Add(this.tbD10);
            this.Controls.Add(this.tbD8);
            this.Controls.Add(this.tbD6);
            this.Controls.Add(this.tbD4);
            this.Controls.Add(this.btnD30);
            this.Controls.Add(this.btnD20);
            this.Controls.Add(this.btnD12);
            this.Controls.Add(this.btnD10);
            this.Controls.Add(this.btnD8);
            this.Controls.Add(this.btnD6);
            this.Controls.Add(this.cbExplosiveDice);
            this.Controls.Add(this.btnD4);
            this.Controls.Add(this.tbRollResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRollAdvanced);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.tbSimpleRollResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRollSimple);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbX);
            this.Name = "DiceRollerForm";
            this.Text = "Simple Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnRollSimple;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSimpleRollResult;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnRollAdvanced;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRollResult;
        private System.Windows.Forms.Button btnD4;
        private System.Windows.Forms.CheckBox cbExplosiveDice;
        private System.Windows.Forms.Button btnD6;
        private System.Windows.Forms.Button btnD8;
        private System.Windows.Forms.Button btnD10;
        private System.Windows.Forms.Button btnD12;
        private System.Windows.Forms.Button btnD20;
        private System.Windows.Forms.Button btnD30;
        private System.Windows.Forms.TextBox tbD4;
        private System.Windows.Forms.TextBox tbD6;
        private System.Windows.Forms.TextBox tbD8;
        private System.Windows.Forms.TextBox tbD10;
        private System.Windows.Forms.TextBox tbD12;
        private System.Windows.Forms.TextBox tbD20;
        private System.Windows.Forms.TextBox tbD30;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumberOfDice;
        private System.Windows.Forms.Button btnD100;
        private System.Windows.Forms.TextBox tbD100;
    }
}

