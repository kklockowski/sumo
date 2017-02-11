namespace sumo
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericUpDownMinValue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxValue = new System.Windows.Forms.NumericUpDown();
            this.checkBoxWaitForGoodAnsw = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOperration = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxRounds = new System.Windows.Forms.GroupBox();
            this.numericUpDownRoundsCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxForTime = new System.Windows.Forms.GroupBox();
            this.numericUpDownTimePerRound = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGameType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOpenFromFile = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValue)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBoxRounds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoundsCount)).BeginInit();
            this.groupBoxForTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimePerRound)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 278);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDownMinValue);
            this.tabPage1.Controls.Add(this.numericUpDownMaxValue);
            this.tabPage1.Controls.Add(this.checkBoxWaitForGoodAnsw);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBoxOperration);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Działania";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMinValue
            // 
            this.numericUpDownMinValue.Location = new System.Drawing.Point(124, 55);
            this.numericUpDownMinValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMinValue.Name = "numericUpDownMinValue";
            this.numericUpDownMinValue.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownMinValue.TabIndex = 8;
            // 
            // numericUpDownMaxValue
            // 
            this.numericUpDownMaxValue.Location = new System.Drawing.Point(124, 85);
            this.numericUpDownMaxValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxValue.Name = "numericUpDownMaxValue";
            this.numericUpDownMaxValue.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownMaxValue.TabIndex = 7;
            this.numericUpDownMaxValue.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // checkBoxWaitForGoodAnsw
            // 
            this.checkBoxWaitForGoodAnsw.AutoSize = true;
            this.checkBoxWaitForGoodAnsw.Location = new System.Drawing.Point(10, 110);
            this.checkBoxWaitForGoodAnsw.Name = "checkBoxWaitForGoodAnsw";
            this.checkBoxWaitForGoodAnsw.Size = new System.Drawing.Size(202, 17);
            this.checkBoxWaitForGoodAnsw.TabIndex = 6;
            this.checkBoxWaitForGoodAnsw.Text = "Nie idź dalej dopóki dobra odpowiedź";
            this.checkBoxWaitForGoodAnsw.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wartość największa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wartość najmniejsza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wybierz działanie";
            // 
            // comboBoxOperration
            // 
            this.comboBoxOperration.FormattingEnabled = true;
            this.comboBoxOperration.Items.AddRange(new object[] {
            "Dodawnie",
            "Odejmowanie",
            "Mnożenie",
            "Dzielenie",
            "Losowo..."});
            this.comboBoxOperration.Location = new System.Drawing.Point(10, 30);
            this.comboBoxOperration.Name = "comboBoxOperration";
            this.comboBoxOperration.Size = new System.Drawing.Size(387, 21);
            this.comboBoxOperration.TabIndex = 2;
            this.comboBoxOperration.Text = "Dodawnie";
            this.comboBoxOperration.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperration_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxRounds);
            this.tabPage2.Controls.Add(this.groupBoxForTime);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBoxGameType);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Typ gry";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxRounds
            // 
            this.groupBoxRounds.Controls.Add(this.numericUpDownRoundsCount);
            this.groupBoxRounds.Controls.Add(this.label3);
            this.groupBoxRounds.Location = new System.Drawing.Point(11, 149);
            this.groupBoxRounds.Name = "groupBoxRounds";
            this.groupBoxRounds.Size = new System.Drawing.Size(387, 39);
            this.groupBoxRounds.TabIndex = 3;
            this.groupBoxRounds.TabStop = false;
            // 
            // numericUpDownRoundsCount
            // 
            this.numericUpDownRoundsCount.Location = new System.Drawing.Point(150, 10);
            this.numericUpDownRoundsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRoundsCount.Name = "numericUpDownRoundsCount";
            this.numericUpDownRoundsCount.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownRoundsCount.TabIndex = 3;
            this.numericUpDownRoundsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ilość rund:";
            // 
            // groupBoxForTime
            // 
            this.groupBoxForTime.Controls.Add(this.numericUpDownTimePerRound);
            this.groupBoxForTime.Controls.Add(this.label2);
            this.groupBoxForTime.Location = new System.Drawing.Point(10, 55);
            this.groupBoxForTime.Name = "groupBoxForTime";
            this.groupBoxForTime.Size = new System.Drawing.Size(387, 39);
            this.groupBoxForTime.TabIndex = 2;
            this.groupBoxForTime.TabStop = false;
            // 
            // numericUpDownTimePerRound
            // 
            this.numericUpDownTimePerRound.Location = new System.Drawing.Point(150, 10);
            this.numericUpDownTimePerRound.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownTimePerRound.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTimePerRound.Name = "numericUpDownTimePerRound";
            this.numericUpDownTimePerRound.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownTimePerRound.TabIndex = 1;
            this.numericUpDownTimePerRound.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ilość sekund trwania rundy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz typ gry";
            // 
            // comboBoxGameType
            // 
            this.comboBoxGameType.FormattingEnabled = true;
            this.comboBoxGameType.Items.AddRange(new object[] {
            "Bez limitu",
            "Na czas",
            "Ilość rund"});
            this.comboBoxGameType.Location = new System.Drawing.Point(10, 30);
            this.comboBoxGameType.Name = "comboBoxGameType";
            this.comboBoxGameType.Size = new System.Drawing.Size(387, 21);
            this.comboBoxGameType.TabIndex = 0;
            this.comboBoxGameType.Text = "Bez limitu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonOpenFromFile);
            this.groupBox1.Controls.Add(this.buttonSaveToFile);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Location = new System.Drawing.Point(4, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 64);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(345, 27);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOpenFromFile
            // 
            this.buttonOpenFromFile.Location = new System.Drawing.Point(9, 38);
            this.buttonOpenFromFile.Name = "buttonOpenFromFile";
            this.buttonOpenFromFile.Size = new System.Drawing.Size(99, 23);
            this.buttonOpenFromFile.TabIndex = 10;
            this.buttonOpenFromFile.Text = "Otwórz z  pliku";
            this.buttonOpenFromFile.UseVisualStyleBackColor = true;
            this.buttonOpenFromFile.Click += new System.EventHandler(this.buttonOpenFromFile_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(9, 12);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(99, 23);
            this.buttonSaveToFile.TabIndex = 9;
            this.buttonSaveToFile.Text = "Zapisz do pliku";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(182, 27);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "OK";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "sumo file|*.sumo";
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(sumo.Settings);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValue)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxRounds.ResumeLayout(false);
            this.groupBoxRounds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoundsCount)).EndInit();
            this.groupBoxForTime.ResumeLayout(false);
            this.groupBoxForTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimePerRound)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxRounds;
        private System.Windows.Forms.GroupBox groupBoxForTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOpenFromFile;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.NumericUpDown numericUpDownRoundsCount;
        public System.Windows.Forms.NumericUpDown numericUpDownTimePerRound;
        public System.Windows.Forms.CheckBox checkBoxWaitForGoodAnsw;
        public System.Windows.Forms.ComboBox comboBoxOperration;
        public System.Windows.Forms.NumericUpDown numericUpDownMinValue;
        public System.Windows.Forms.NumericUpDown numericUpDownMaxValue;
        public System.Windows.Forms.ComboBox comboBoxGameType;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}