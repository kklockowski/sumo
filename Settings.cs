using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace sumo
{
    public partial class Settings : Form
    {

        public decimal maxValue;

        public Settings()
        {
            InitializeComponent();

        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = string.Empty;
            saveFileDialog1.Filter = "sumo file|.sumo";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string strSettingsToSave = buildStringSettings();
                saveSettings(saveFileDialog1.FileName, strSettingsToSave);
                MessageBox.Show("Zapisano.");
            }
        }

        private string buildStringSettings()
        {
            string result = string.Empty;

            StringBuilder sb = new StringBuilder();

            sb.Append("numericUpDownMinValue=" + numericUpDownMinValue.Value.ToString() + "\n");
            sb.Append("numericUpDownMaxValue=" + numericUpDownMaxValue.Value.ToString() + "\n");
            sb.Append("checkBoxWaitForGoodAnsw=" + (checkBoxWaitForGoodAnsw.Checked ? "1" : "0") + "\n");
            sb.Append("comboBoxOperration=" + comboBoxOperration.SelectedIndex.ToString() + "\n");
            sb.Append("comboBoxGameType=" + comboBoxGameType.SelectedIndex.ToString() + "\n");
            sb.Append("numericUpDownTimePerRound=" + numericUpDownTimePerRound.Value.ToString() + "\n");
            sb.Append("numericUpDownRoundsCount=" + numericUpDownRoundsCount.Value.ToString());

            result = sb.ToString();

            return result;
        }

        private void buttonOpenFromFile_Click(object sender, EventArgs e)
        {           

            string filePath = string.Empty;
            openFileDialog1.FileName = filePath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                readSettingsFromFile(filePath);
                MessageBox.Show("Wczytano.");
            }
        }

        private void readSettingsFromFile(string filePath)
        {

            StreamReader sr = new StreamReader(filePath);

            string strSettings = sr.ReadToEnd();

            readSettingsFromString(strSettings);

        }

        private void setControl(string ctrName, string value)
        {
            int val;
            switch (ctrName)
            {
                case ("numericUpDownMinValue"):

                    if (int.TryParse(value, out val))
                    {
                        numericUpDownMinValue.Value = val;
                        
                    }
                    break;

                case ("numericUpDownMaxValue"):

                    if (int.TryParse(value, out val))
                    {
                        numericUpDownMaxValue.Value = val;
                    }
                    break;

                case ("checkBoxWaitForGoodAnsw"):

                    if (int.TryParse(value, out val))
                    {
                        checkBoxWaitForGoodAnsw.Checked = (val == 1);
                    }
                    break;

                case ("comboBoxOperration"):
                    if (int.TryParse(value, out val))
                    {
                        comboBoxOperration.SelectedIndex = val;
                    }
                    break;

                case ("comboBoxGameType"):

                    if (int.TryParse(value, out val))
                    {
                        comboBoxGameType.SelectedIndex = val;
                    }
                    break;

                case ("numericUpDownTimePerRound"):

                    if (int.TryParse(value, out val))
                    {
                        numericUpDownTimePerRound.Value = val;
                    }
                    break;

                case ("numericUpDownRoundsCount"):

                    if (int.TryParse(value, out val))
                    {
                        numericUpDownRoundsCount.Value = val;
                    }
                    break;

            }

        }

        private void saveSettings(string path,string strSettingsToSave)
        {

            StreamWriter sw = new StreamWriter(path);
            sw.Write(strSettingsToSave);

            sw.Flush();
            sw.Close();
        }

        private void comboBoxOperration_SelectedIndexChanged(object sender, EventArgs e)
        {
            EOpperationType epp;
            switch(comboBoxOperration.SelectedIndex)
            {
                case(0):
                    epp = EOpperationType.Add;
                    break;

                case (1):
                    epp = EOpperationType.Diff;
                    if(numericUpDownMinValue.Minimum==0) numericUpDownMinValue.Minimum= 1;
                    break;

                case (2):
                    epp = EOpperationType.Mult;
                    if (numericUpDownMinValue.Minimum == 0) numericUpDownMinValue.Minimum = 1;
                    break;

                case (3):
                    epp = EOpperationType.Div;
                    if (numericUpDownMinValue.Minimum == 0) numericUpDownMinValue.Minimum = 1;
                    break;

                case (4):
                    epp = EOpperationType.Random;
                    if (numericUpDownMinValue.Minimum == 0) numericUpDownMinValue.Minimum = 1;
                    break;
            }
            
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LastSettings= buildStringSettings();
            Properties.Settings.Default.Save();
        }

        public void OpenDefaultSettings()
        {
            readSettingsFromString(Properties.Settings.Default.LastSettings);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            readSettingsFromString(Properties.Settings.Default.LastSettings);
        }

        private void readSettingsFromString(string strSettings)
        {
            if (!string.IsNullOrEmpty(strSettings))
            {
                string[] lines = strSettings.Split(Environment.NewLine.ToCharArray());

                if (lines.Length > 0)
                {
                    foreach (string line in lines)
                    {
                        string[] sett = line.Trim().Split('=');

                        if (sett.Length == 2)
                        {
                            setControl(sett[0], sett[1]);
                        }
                    }
                }
            }
        }

    }


}
