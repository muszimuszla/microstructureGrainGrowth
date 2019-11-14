namespace MicrostructureGrainGrowth
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfGrainsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumberOfStatesTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.JTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NumberOfStepsTextBox = new System.Windows.Forms.TextBox();
            this.CAMethodCheckBox = new System.Windows.Forms.CheckBox();
            this.MCMethodCheckBox = new System.Windows.Forms.CheckBox();
            this.NucleateButton = new System.Windows.Forms.Button();
            this.GrowthButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.ChangeViewButton = new System.Windows.Forms.Button();
            this.grainTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.boundaryTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EverywhereCheckBox = new System.Windows.Forms.CheckBox();
            this.OnlyOnBoundariesCheckBox = new System.Windows.Forms.CheckBox();
            this.ConstantCheckBox = new System.Windows.Forms.CheckBox();
            this.IncreasingCheckBox = new System.Windows.Forms.CheckBox();
            this.AtTheBeginingCheckBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numberOfRGrainsTextBox = new System.Windows.Forms.TextBox();
            this.increaseOfGrainsTextBox = new System.Windows.Forms.TextBox();
            this.increaseStepIntervalTextBox = new System.Windows.Forms.TextBox();
            this.RecrystalizationCheckBox = new System.Windows.Forms.CheckBox();
            this.HomogenousCheckBox = new System.Windows.Forms.CheckBox();
            this.HeterogenousCheckBox = new System.Windows.Forms.CheckBox();
            this.NumberOfRStepsTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.addEnergyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moore Neighborhood";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Absorbing Boundary Condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CA Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of grains";
            // 
            // numberOfGrainsTextBox
            // 
            this.numberOfGrainsTextBox.Location = new System.Drawing.Point(439, 89);
            this.numberOfGrainsTextBox.Name = "numberOfGrainsTextBox";
            this.numberOfGrainsTextBox.Size = new System.Drawing.Size(47, 20);
            this.numberOfGrainsTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "MC Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Number of states";
            // 
            // NumberOfStatesTextBox
            // 
            this.NumberOfStatesTextBox.Location = new System.Drawing.Point(663, 89);
            this.NumberOfStatesTextBox.Name = "NumberOfStatesTextBox";
            this.NumberOfStatesTextBox.Size = new System.Drawing.Size(47, 20);
            this.NumberOfStatesTextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "J < 0.1 - 1.0 >";
            // 
            // JTextBox
            // 
            this.JTextBox.Location = new System.Drawing.Point(663, 167);
            this.JTextBox.Name = "JTextBox";
            this.JTextBox.Size = new System.Drawing.Size(47, 20);
            this.JTextBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(564, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Number of steps";
            // 
            // NumberOfStepsTextBox
            // 
            this.NumberOfStepsTextBox.Location = new System.Drawing.Point(663, 115);
            this.NumberOfStepsTextBox.Name = "NumberOfStepsTextBox";
            this.NumberOfStepsTextBox.Size = new System.Drawing.Size(47, 20);
            this.NumberOfStepsTextBox.TabIndex = 12;
            // 
            // CAMethodCheckBox
            // 
            this.CAMethodCheckBox.AutoSize = true;
            this.CAMethodCheckBox.Location = new System.Drawing.Point(341, 45);
            this.CAMethodCheckBox.Name = "CAMethodCheckBox";
            this.CAMethodCheckBox.Size = new System.Drawing.Size(79, 17);
            this.CAMethodCheckBox.TabIndex = 13;
            this.CAMethodCheckBox.Text = "CA Method";
            this.CAMethodCheckBox.UseVisualStyleBackColor = true;
            // 
            // MCMethodCheckBox
            // 
            this.MCMethodCheckBox.AutoSize = true;
            this.MCMethodCheckBox.Location = new System.Drawing.Point(567, 45);
            this.MCMethodCheckBox.Name = "MCMethodCheckBox";
            this.MCMethodCheckBox.Size = new System.Drawing.Size(81, 17);
            this.MCMethodCheckBox.TabIndex = 14;
            this.MCMethodCheckBox.Text = "MC Method";
            this.MCMethodCheckBox.UseVisualStyleBackColor = true;
            // 
            // NucleateButton
            // 
            this.NucleateButton.Location = new System.Drawing.Point(345, 401);
            this.NucleateButton.Name = "NucleateButton";
            this.NucleateButton.Size = new System.Drawing.Size(141, 23);
            this.NucleateButton.TabIndex = 15;
            this.NucleateButton.Text = "Nucleate";
            this.NucleateButton.UseVisualStyleBackColor = true;
            this.NucleateButton.Click += new System.EventHandler(this.NucleateButton_Click);
            // 
            // GrowthButton
            // 
            this.GrowthButton.Location = new System.Drawing.Point(345, 454);
            this.GrowthButton.Name = "GrowthButton";
            this.GrowthButton.Size = new System.Drawing.Size(218, 23);
            this.GrowthButton.TabIndex = 16;
            this.GrowthButton.Text = "Growth";
            this.GrowthButton.UseVisualStyleBackColor = true;
            this.GrowthButton.Click += new System.EventHandler(this.GrowthButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(495, 401);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(141, 23);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(642, 401);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(141, 23);
            this.ClearAllButton.TabIndex = 18;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // ChangeViewButton
            // 
            this.ChangeViewButton.Location = new System.Drawing.Point(565, 454);
            this.ChangeViewButton.Name = "ChangeViewButton";
            this.ChangeViewButton.Size = new System.Drawing.Size(218, 23);
            this.ChangeViewButton.TabIndex = 19;
            this.ChangeViewButton.Text = "Change View";
            this.ChangeViewButton.UseVisualStyleBackColor = true;
            this.ChangeViewButton.Click += new System.EventHandler(this.ChangeViewButton_Click);
            // 
            // grainTextBox
            // 
            this.grainTextBox.Location = new System.Drawing.Point(444, 170);
            this.grainTextBox.Name = "grainTextBox";
            this.grainTextBox.Size = new System.Drawing.Size(47, 20);
            this.grainTextBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Grain energy H";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Grain <1 - 10>";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Boundary <1 - 10>";
            // 
            // boundaryTextBox
            // 
            this.boundaryTextBox.Location = new System.Drawing.Point(444, 196);
            this.boundaryTextBox.Name = "boundaryTextBox";
            this.boundaryTextBox.Size = new System.Drawing.Size(47, 20);
            this.boundaryTextBox.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(609, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Recrystalization";
            // 
            // EverywhereCheckBox
            // 
            this.EverywhereCheckBox.AutoSize = true;
            this.EverywhereCheckBox.Location = new System.Drawing.Point(533, 283);
            this.EverywhereCheckBox.Name = "EverywhereCheckBox";
            this.EverywhereCheckBox.Size = new System.Drawing.Size(82, 17);
            this.EverywhereCheckBox.TabIndex = 27;
            this.EverywhereCheckBox.Text = "Everywhere";
            this.EverywhereCheckBox.UseVisualStyleBackColor = true;
            // 
            // OnlyOnBoundariesCheckBox
            // 
            this.OnlyOnBoundariesCheckBox.AutoSize = true;
            this.OnlyOnBoundariesCheckBox.Location = new System.Drawing.Point(533, 260);
            this.OnlyOnBoundariesCheckBox.Name = "OnlyOnBoundariesCheckBox";
            this.OnlyOnBoundariesCheckBox.Size = new System.Drawing.Size(117, 17);
            this.OnlyOnBoundariesCheckBox.TabIndex = 28;
            this.OnlyOnBoundariesCheckBox.Text = "Only on boundaries";
            this.OnlyOnBoundariesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConstantCheckBox
            // 
            this.ConstantCheckBox.AutoSize = true;
            this.ConstantCheckBox.Location = new System.Drawing.Point(533, 311);
            this.ConstantCheckBox.Name = "ConstantCheckBox";
            this.ConstantCheckBox.Size = new System.Drawing.Size(68, 17);
            this.ConstantCheckBox.TabIndex = 29;
            this.ConstantCheckBox.Text = "Constant";
            this.ConstantCheckBox.UseVisualStyleBackColor = true;
            // 
            // IncreasingCheckBox
            // 
            this.IncreasingCheckBox.AutoSize = true;
            this.IncreasingCheckBox.Location = new System.Drawing.Point(533, 334);
            this.IncreasingCheckBox.Name = "IncreasingCheckBox";
            this.IncreasingCheckBox.Size = new System.Drawing.Size(75, 17);
            this.IncreasingCheckBox.TabIndex = 30;
            this.IncreasingCheckBox.Text = "Increasing";
            this.IncreasingCheckBox.UseVisualStyleBackColor = true;
            // 
            // AtTheBeginingCheckBox
            // 
            this.AtTheBeginingCheckBox.AutoSize = true;
            this.AtTheBeginingCheckBox.Location = new System.Drawing.Point(533, 358);
            this.AtTheBeginingCheckBox.Name = "AtTheBeginingCheckBox";
            this.AtTheBeginingCheckBox.Size = new System.Drawing.Size(97, 17);
            this.AtTheBeginingCheckBox.TabIndex = 31;
            this.AtTheBeginingCheckBox.Text = "At the begining";
            this.AtTheBeginingCheckBox.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(660, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Number of grains";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(660, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Increase of grains";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(660, 358);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Increase step interval";
            // 
            // numberOfRGrainsTextBox
            // 
            this.numberOfRGrainsTextBox.Location = new System.Drawing.Point(769, 302);
            this.numberOfRGrainsTextBox.Name = "numberOfRGrainsTextBox";
            this.numberOfRGrainsTextBox.Size = new System.Drawing.Size(48, 20);
            this.numberOfRGrainsTextBox.TabIndex = 35;
            // 
            // increaseOfGrainsTextBox
            // 
            this.increaseOfGrainsTextBox.Location = new System.Drawing.Point(769, 327);
            this.increaseOfGrainsTextBox.Name = "increaseOfGrainsTextBox";
            this.increaseOfGrainsTextBox.Size = new System.Drawing.Size(48, 20);
            this.increaseOfGrainsTextBox.TabIndex = 36;
            // 
            // increaseStepIntervalTextBox
            // 
            this.increaseStepIntervalTextBox.Location = new System.Drawing.Point(769, 352);
            this.increaseStepIntervalTextBox.Name = "increaseStepIntervalTextBox";
            this.increaseStepIntervalTextBox.Size = new System.Drawing.Size(48, 20);
            this.increaseStepIntervalTextBox.TabIndex = 37;
            // 
            // RecrystalizationCheckBox
            // 
            this.RecrystalizationCheckBox.AutoSize = true;
            this.RecrystalizationCheckBox.Location = new System.Drawing.Point(610, 229);
            this.RecrystalizationCheckBox.Name = "RecrystalizationCheckBox";
            this.RecrystalizationCheckBox.Size = new System.Drawing.Size(100, 17);
            this.RecrystalizationCheckBox.TabIndex = 38;
            this.RecrystalizationCheckBox.Text = "Recrystalization";
            this.RecrystalizationCheckBox.UseVisualStyleBackColor = true;
            // 
            // HomogenousCheckBox
            // 
            this.HomogenousCheckBox.AutoSize = true;
            this.HomogenousCheckBox.Location = new System.Drawing.Point(343, 234);
            this.HomogenousCheckBox.Name = "HomogenousCheckBox";
            this.HomogenousCheckBox.Size = new System.Drawing.Size(89, 17);
            this.HomogenousCheckBox.TabIndex = 39;
            this.HomogenousCheckBox.Text = "Homogenous";
            this.HomogenousCheckBox.UseVisualStyleBackColor = true;
            // 
            // HeterogenousCheckBox
            // 
            this.HeterogenousCheckBox.AutoSize = true;
            this.HeterogenousCheckBox.Location = new System.Drawing.Point(343, 257);
            this.HeterogenousCheckBox.Name = "HeterogenousCheckBox";
            this.HeterogenousCheckBox.Size = new System.Drawing.Size(93, 17);
            this.HeterogenousCheckBox.TabIndex = 40;
            this.HeterogenousCheckBox.Text = "Heterogenous";
            this.HeterogenousCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumberOfRStepsTextBox
            // 
            this.NumberOfRStepsTextBox.Location = new System.Drawing.Point(769, 258);
            this.NumberOfRStepsTextBox.Name = "NumberOfRStepsTextBox";
            this.NumberOfRStepsTextBox.Size = new System.Drawing.Size(48, 20);
            this.NumberOfRStepsTextBox.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(667, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Number of steps";
            // 
            // addEnergyButton
            // 
            this.addEnergyButton.Location = new System.Drawing.Point(345, 293);
            this.addEnergyButton.Name = "addEnergyButton";
            this.addEnergyButton.Size = new System.Drawing.Size(141, 23);
            this.addEnergyButton.TabIndex = 43;
            this.addEnergyButton.Text = "Add energy";
            this.addEnergyButton.UseVisualStyleBackColor = true;
            this.addEnergyButton.Click += new System.EventHandler(this.addEnergyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 544);
            this.Controls.Add(this.addEnergyButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.NumberOfRStepsTextBox);
            this.Controls.Add(this.HeterogenousCheckBox);
            this.Controls.Add(this.HomogenousCheckBox);
            this.Controls.Add(this.RecrystalizationCheckBox);
            this.Controls.Add(this.increaseStepIntervalTextBox);
            this.Controls.Add(this.increaseOfGrainsTextBox);
            this.Controls.Add(this.numberOfRGrainsTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.AtTheBeginingCheckBox);
            this.Controls.Add(this.IncreasingCheckBox);
            this.Controls.Add(this.ConstantCheckBox);
            this.Controls.Add(this.OnlyOnBoundariesCheckBox);
            this.Controls.Add(this.EverywhereCheckBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.boundaryTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grainTextBox);
            this.Controls.Add(this.ChangeViewButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GrowthButton);
            this.Controls.Add(this.NucleateButton);
            this.Controls.Add(this.MCMethodCheckBox);
            this.Controls.Add(this.CAMethodCheckBox);
            this.Controls.Add(this.NumberOfStepsTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.JTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberOfStatesTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numberOfGrainsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberOfGrainsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumberOfStatesTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox JTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NumberOfStepsTextBox;
        private System.Windows.Forms.CheckBox CAMethodCheckBox;
        private System.Windows.Forms.CheckBox MCMethodCheckBox;
        private System.Windows.Forms.Button NucleateButton;
        private System.Windows.Forms.Button GrowthButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button ChangeViewButton;
        private System.Windows.Forms.TextBox grainTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boundaryTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox EverywhereCheckBox;
        private System.Windows.Forms.CheckBox OnlyOnBoundariesCheckBox;
        private System.Windows.Forms.CheckBox ConstantCheckBox;
        private System.Windows.Forms.CheckBox IncreasingCheckBox;
        private System.Windows.Forms.CheckBox AtTheBeginingCheckBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox numberOfRGrainsTextBox;
        private System.Windows.Forms.TextBox increaseOfGrainsTextBox;
        private System.Windows.Forms.TextBox increaseStepIntervalTextBox;
        private System.Windows.Forms.CheckBox RecrystalizationCheckBox;
        private System.Windows.Forms.CheckBox HomogenousCheckBox;
        private System.Windows.Forms.CheckBox HeterogenousCheckBox;
        private System.Windows.Forms.TextBox NumberOfRStepsTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button addEnergyButton;
    }
}

