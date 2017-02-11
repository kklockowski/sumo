namespace sumo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelTask = new System.Windows.Forms.Label();
            this.textBoxSolve = new System.Windows.Forms.TextBox();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBarRundaTime = new System.Windows.Forms.ProgressBar();
            this.timerRunda = new System.Windows.Forms.Timer(this.components);
            this.buttonNewRound = new System.Windows.Forms.Button();
            this.timerRundaStart = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxMan = new System.Windows.Forms.PictureBox();
            this.pictureBoxSumo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSumo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTask.Location = new System.Drawing.Point(1, 240);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(0, 108);
            this.labelTask.TabIndex = 0;
            // 
            // textBoxSolve
            // 
            this.textBoxSolve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSolve.Enabled = false;
            this.textBoxSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSolve.Location = new System.Drawing.Point(4, 376);
            this.textBoxSolve.Name = "textBoxSolve";
            this.textBoxSolve.Size = new System.Drawing.Size(790, 38);
            this.textBoxSolve.TabIndex = 1;
            this.textBoxSolve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSolve.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSolve_KeyUp);
            // 
            // listViewHistory
            // 
            this.listViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewHistory.Location = new System.Drawing.Point(625, 0);
            this.listViewHistory.MultiSelect = false;
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.ShowGroups = false;
            this.listViewHistory.Size = new System.Drawing.Size(169, 341);
            this.listViewHistory.TabIndex = 3;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 133;
            // 
            // progressBarRundaTime
            // 
            this.progressBarRundaTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarRundaTime.Location = new System.Drawing.Point(4, 347);
            this.progressBarRundaTime.Name = "progressBarRundaTime";
            this.progressBarRundaTime.Size = new System.Drawing.Size(790, 23);
            this.progressBarRundaTime.TabIndex = 5;
            // 
            // timerRunda
            // 
            this.timerRunda.Interval = 150;
            this.timerRunda.Tick += new System.EventHandler(this.timerRunda_Tick);
            // 
            // buttonNewRound
            // 
            this.buttonNewRound.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonNewRound.Location = new System.Drawing.Point(0, 420);
            this.buttonNewRound.Name = "buttonNewRound";
            this.buttonNewRound.Size = new System.Drawing.Size(794, 23);
            this.buttonNewRound.TabIndex = 6;
            this.buttonNewRound.Text = "Nowa runda";
            this.buttonNewRound.UseVisualStyleBackColor = true;
            this.buttonNewRound.Click += new System.EventHandler(this.buttonNewRound_Click);
            // 
            // timerRundaStart
            // 
            this.timerRundaStart.Interval = 500;
            this.timerRundaStart.Tick += new System.EventHandler(this.timerRundaStart_Tick);
            // 
            // pictureBoxMan
            // 
            this.pictureBoxMan.BackColor = System.Drawing.Color.White;
            this.pictureBoxMan.Image = global::sumo.Properties.Resources.sumo3;
            this.pictureBoxMan.Location = new System.Drawing.Point(0, 37);
            this.pictureBoxMan.Name = "pictureBoxMan";
            this.pictureBoxMan.Size = new System.Drawing.Size(169, 200);
            this.pictureBoxMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMan.TabIndex = 7;
            this.pictureBoxMan.TabStop = false;
            this.pictureBoxMan.Click += new System.EventHandler(this.pictureBoxMan_Click);
            // 
            // pictureBoxSumo
            // 
            this.pictureBoxSumo.BackColor = System.Drawing.Color.White;
            this.pictureBoxSumo.Location = new System.Drawing.Point(175, 37);
            this.pictureBoxSumo.Name = "pictureBoxSumo";
            this.pictureBoxSumo.Size = new System.Drawing.Size(444, 200);
            this.pictureBoxSumo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSumo.TabIndex = 8;
            this.pictureBoxSumo.TabStop = false;
            this.pictureBoxSumo.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSumo_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 443);
            this.Controls.Add(this.pictureBoxSumo);
            this.Controls.Add(this.pictureBoxMan);
            this.Controls.Add(this.buttonNewRound);
            this.Controls.Add(this.progressBarRundaTime);
            this.Controls.Add(this.listViewHistory);
            this.Controls.Add(this.textBoxSolve);
            this.Controls.Add(this.labelTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Main";
            this.Text = "Sumo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.TextBox textBoxSolve;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ProgressBar progressBarRundaTime;
        private System.Windows.Forms.Timer timerRunda;
        private System.Windows.Forms.Button buttonNewRound;
        private System.Windows.Forms.PictureBox pictureBoxMan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer timerRundaStart;
        private System.Windows.Forms.PictureBox pictureBoxSumo;
    }
}

