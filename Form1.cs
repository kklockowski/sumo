using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sumo
{
    public partial class Main : Form
    {
        int scale = 300;
        int minValue;
        int maxValue;
        EOpperationType opperatorType;
        EGameType gameType;
        public bool roundStarted { get; set; }
        int roundTicksCount = 0;

        private System.Drawing.Font font;

        string[] startMessage = { "Gotów?", "Uwaga!", "Start", "" };
        int msgIdx = 0;

        private Settings settings;
        private Runda runda;

        private string lastMsg;
        private bool enterUsed=false;

        public Main()
        {
            InitializeComponent();
            listViewHistory.View = View.Details;
            listViewHistory.HeaderStyle = ColumnHeaderStyle.None;
            listViewHistory.Scrollable = true;
            listViewHistory.FullRowSelect = true;
            this.settings = new Settings();
            settings.OpenDefaultSettings();
        }

        private void NextTask()
        {
            string sTask = RandomTask();
            labelTask.Text = sTask;
        }

        private void CheckMySolved()
        {
            if (textBoxSolve.Text.Length > 0)
            {
                string yourSolved = labelTask.Text + " = " + textBoxSolve.Text;

                ListViewItem item = new ListViewItem(yourSolved);
                listViewHistory.Items.Add(item);
                listViewHistory.EnsureVisible(listViewHistory.Items.Count - 1);
                runda.Add(labelTask.Text, textBoxSolve.Text);

                double dSolve = 0.0;
                bool isDouble = double.TryParse(textBoxSolve.Text, out dSolve);
                if (!isDouble)
                {
                    item.ForeColor = Color.Orange;
                    NextTask();
                    return;
                }

                bool res = checkSolved(labelTask.Text, textBoxSolve.Text);

                if (res)
                {
                    item.ForeColor = Color.Green;
                    NextTask();
                }
                else
                {
                    if (!settings.checkBoxWaitForGoodAnsw.Checked)
                    {
                        NextTask();
                    }
                    item.ForeColor = Color.Red;
                }
            }
        }

        private string RandomTask()
        {
            string result = string.Empty;

            int max = getMax();

            Random r = new Random();
            
            int il = 0;
            int ir = 0;

            bool noCondidtion = true;
            do
            {
                do
                {
                    il = r.Next(max);
                } while (il <= minValue);
                do
                {
                    ir = r.Next(max);
                } while (ir >= maxValue);

                noCondidtion = checkCondition(ref ir, ref il);
            }
            while (!noCondidtion);

            string Opperation = getOpperation();
            result = il.ToString() + " " +  Opperation + " " + ir.ToString();

            return result;
        }

        private string getOpperation()
        {
            string result = string.Empty;

            switch (opperatorType)
            {
                case (EOpperationType.Add):

                    result = "+";
                    break;

                case (EOpperationType.Diff):
                    result = "-";
                    break;

                case (EOpperationType.Div):
                    result = "/";
                    break;

                case (EOpperationType.Mult):
                    result = "*";
                    break;

                case (EOpperationType.Random):
                    result = "+";
                    break;

            }

            return result;
        }

        private int getMax()
        {
            int max = 0;

            switch (opperatorType)
            {
                case (EOpperationType.Add):

                    max = maxValue + minValue;
                    break;

                case (EOpperationType.Diff):
                    max = maxValue - minValue;
                    break;

                case (EOpperationType.Div):
                    max = maxValue / minValue;
                    break;

                case (EOpperationType.Mult):
                    max = maxValue * minValue;
                    break;

                case (EOpperationType.Random):
                    max = maxValue + minValue;
                    break;

            }

            return max;
        }

        private bool checkCondition(ref int ir, ref int il)
        {
            bool result = false;
            int max;

            switch (opperatorType)
            {
                case (EOpperationType.Add):

                    max = maxValue + minValue;
                    result = (max >= ir + il);
                    break;

                case (EOpperationType.Diff):
                    max = maxValue - minValue;
                    result = (max >= Math.Abs(il - ir));

                    if (il < ir)
                    {
                        int buf = il;
                        il = ir;
                        ir = buf;
                    }
                    break;

                case (EOpperationType.Div):
                    max = maxValue / minValue;
                    result = (max >= ir / il);
                    break;

                case (EOpperationType.Mult):
                    max = maxValue * minValue;
                    result = (max >= ir * il);
                    break;

                case (EOpperationType.Random):
                    max = maxValue + minValue;
                    result = (max >= ir + il);
                    break;

            }

            return result;
        }

        private bool checkSolved(string task, string solve)
        {
            double dSolve = 0;
            double _solve = -1;
            bool isDouble = double.TryParse(solve, out dSolve);


            if (!isDouble)
            {
                return false;
            }

            string[] seq = task.Split(' ');

            if (seq.Length == 3)
            {
                string left = seq[0].Trim();
                string act = seq[1].Trim();
                string right = seq[2].Trim();

                double dLeft = 0;
                double dRight = 0;

                if (!double.TryParse(left, out dLeft))
                {
                    return false;
                }

                if (!double.TryParse(right, out dRight))
                {
                    return false;
                }

                if (!Helpers.IsOpperant(act,ref opperatorType))
                {
                    return false;
                }


                _solve = Helpers.GetSolved(dLeft, dRight,opperatorType);

            }

            bool isSolved = (dSolve == _solve); 

            return isSolved;

        }

        private bool isOpperant(string act)
        {
            bool result = false;

            if (act == "+") result = true;
            else if (act == "-") result = true;
            else if (act == "/") result = true;
            else if (act == "*") result = true;


            return result;
        }

        private double getSolved(double dLeft, double dRight)
        {
            double result = 0;

            switch (opperatorType)
            {
                case (EOpperationType.Add):

                    result = dLeft + dRight;
                    break;

                case (EOpperationType.Diff):
                    result = dLeft - dRight;
                    break;

                case (EOpperationType.Div):
                    result = dLeft / dRight;
                    break;

                case (EOpperationType.Mult):
                    result = dLeft * dRight;
                    break;

                case (EOpperationType.Random):
                    result = dLeft + dRight;
                    break;

            }

            return result;
        }

        private void textBoxSolve_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckMySolved();

                this.enterUsed = true;

                timerRunda_Tick(this, null);
               
                textBoxSolve.Text = string.Empty;
            }
        }

        private void rundaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RundaStart();            
        }

        private void RundaStart()
        {
            runda = new Runda();
            textBoxSolve.Text = string.Empty;
            progressBarRundaTime.Value = 0;
            progressBarRundaTime.Minimum = 0;
            progressBarRundaTime.Maximum = 60000;
            timerRunda.Enabled = true;

            while (!textBoxSolve.Focus());
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerRunda_Tick(object sender, EventArgs e)
        {

            int d = 0;
            if (isTick(ref d))
            {
                progressBarRundaTime.Value += d;
            }
            else
            {
                clearControls();
                //drawMsg("Koniec rundy!");

                if (runda != null)
                {
                    lastMsg = "Koniec rundy!\nDobrych: " + runda.solvedCount.ToString() + "\nBłędnych: " + runda.badCount.ToString();
                    drawMsg(lastMsg, pictureBoxSumo.CreateGraphics());
                }

                timerRunda.Enabled = false;
                textBoxSolve.Enabled = false;
                buttonNewRound.Text = "Nowa runda";
                roundStarted = false;            
                
            }

        }

        private bool isTick(ref int d)
        {

            switch (gameType)
            {
                case (EGameType.ForTime):
                    d = timerRunda.Interval;
                    break;

                case (EGameType.Rounds):
                    bool a = this.enterUsed;
                    if (a)
                    {
                        d = 1;
                    }
                    else
                    {
                        d = 0;
                    }
                    this.enterUsed = false;

                    break;

                default:
                    d = 0;
                    break;

            }
            int max = getMaxiumFromType();
            progressBarRundaTime.Maximum = max;


            return ((gameType==EGameType.NoLimit) || progressBarRundaTime.Value < progressBarRundaTime.Maximum - d);


            bool result = false;

            int len = progressBarRundaTime.Maximum;

            int tick = timerRunda.Interval;

            result = (roundTicksCount * tick <= max);

            d = roundTicksCount;

            return result;
        }

        private int getMaxiumFromType()
        {
            int result=0;

            switch(gameType)
            {
                case(EGameType.NoLimit):
                    result = 0;
                    break;

                case (EGameType.ForTime):
                    result = 1000 * (int)settings.numericUpDownTimePerRound.Value;
                    break;

                case (EGameType.Rounds):
                    result = (int)settings.numericUpDownRoundsCount.Value;
                    break;
            }
                 
            return result;

        }

        private void buttonNewRound_Click(object sender, EventArgs e)
        {
            setRound();           
            RoundForTimeStart();           

        }

        private void setRound()
        {
            bool repatUntilGood = settings.checkBoxWaitForGoodAnsw.Checked;
            
            minValue = (int)settings.numericUpDownMinValue.Value;
            
            maxValue = (int)settings.numericUpDownMaxValue.Value;

            int timePerRound = (int)settings.numericUpDownTimePerRound.Value;
            int roundCount = (int)settings.numericUpDownRoundsCount.Value;
            gameType = (EGameType)settings.comboBoxGameType.SelectedIndex;
            opperatorType = (EOpperationType)settings.comboBoxOperration.SelectedIndex;
        }

        private void RoundForTimeStart()
        {

            // Jeśli jesteśmy w trakcie rundy
            if (roundStarted)
            {

                if (MessageBox.Show("Zatrzymać?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CloseRound();
                }

            }
            // Gdy włączenie rundy
            else
            {
                timerRundaStart.Enabled = true;
            }
        }

        private void CloseRound()
        {
            timerRunda.Enabled = false;
            roundStarted = false;
            buttonNewRound.Text = "Nowa runda";

            clearControls();
            lastMsg = "Koniec rundy!\nDobrych: " + runda.solvedCount.ToString() + "\nBłędnych: " + runda.badCount.ToString();
            drawMsg(lastMsg,pictureBoxSumo.CreateGraphics());           
            
        }

        private void clearControls()
        {
            lastMsg = string.Empty;
            drawMsg(string.Empty,pictureBoxSumo.CreateGraphics());
            progressBarRundaTime.Value = 0;
            textBoxSolve.Text = string.Empty;
            labelTask.Text = string.Empty;

        }
        
        private void timerRundaStart_Tick(object sender, EventArgs e)
        {
            // Gdy wyczerpała się tablica powitalna to...
            if (msgIdx == startMessage.Length)
            {
                //wyłącz się
                timerRundaStart.Enabled = false;
                msgIdx = 0;

                // Uruchom runde
                RunRound();
            }
            else
            {
                drawMsg(startMessage[msgIdx],pictureBoxSumo.CreateGraphics());
                ++msgIdx;
            }

        }

        private void RunRound()
        {
            NextTask();
            textBoxSolve.Enabled = true; ;
            buttonNewRound.Text = "Stop...?";
            roundStarted = true;
            RundaStart();


            timerRunda.Enabled = true;
            listViewHistory.Items.Add(new ListViewItem("--nowa runda--"));
        }

        private void drawMsg(string msg,Graphics grOrg)
        {
            Graphics gr = grOrg;
            gr.Clear(Color.White);
            font = new System.Drawing.Font("Arial", 30, FontStyle.Bold);
            Point point = new Point(10, 50);

            gr.DrawString(msg, font, Brushes.Black, point);
        }

        private void pictureBoxMan_Click(object sender, EventArgs e)
        {
            this.settings.ShowDialog();
        }

        private void pictureBoxSumo_Paint(object sender, PaintEventArgs e)
        {

            drawMsg(lastMsg, e.Graphics);
        }

    }
}
