using System.Windows.Forms;

namespace UserInterface
{
    partial class FrmMain
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topScorersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(929, 476);
            this.pnlMain.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.teamToolStripMenuItem,
            this.fixturesToolStripMenuItem,
            this.resultsToolStripMenuItem,
            this.topScorersToolStripMenuItem,
            this.standingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(98, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(689, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(97, 31);
            this.playerToolStripMenuItem.Text = "Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click_1);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(90, 31);
            this.teamToolStripMenuItem.Text = "Team";
            this.teamToolStripMenuItem.Click += new System.EventHandler(this.teamToolStripMenuItem_Click_1);
            // 
            // fixturesToolStripMenuItem
            // 
            this.fixturesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fixturesToolStripMenuItem.Name = "fixturesToolStripMenuItem";
            this.fixturesToolStripMenuItem.Size = new System.Drawing.Size(107, 31);
            this.fixturesToolStripMenuItem.Text = "Fixtures";
            this.fixturesToolStripMenuItem.Click += new System.EventHandler(this.fixturesToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(101, 31);
            this.resultsToolStripMenuItem.Text = "Results";
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
            // 
            // topScorersToolStripMenuItem
            // 
            this.topScorersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.topScorersToolStripMenuItem.Name = "topScorersToolStripMenuItem";
            this.topScorersToolStripMenuItem.Size = new System.Drawing.Size(151, 31);
            this.topScorersToolStripMenuItem.Text = "Top scorers";
            this.topScorersToolStripMenuItem.Click += new System.EventHandler(this.topScorersToolStripMenuItem_Click_1);
            // 
            // standingsToolStripMenuItem
            // 
            this.standingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.standingsToolStripMenuItem.Name = "standingsToolStripMenuItem";
            this.standingsToolStripMenuItem.Size = new System.Drawing.Size(135, 31);
            this.standingsToolStripMenuItem.Text = "Standings";
            this.standingsToolStripMenuItem.Click += new System.EventHandler(this.standingsToolStripMenuItem_Click_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(929, 476);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private MenuStrip menuStrip;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem teamToolStripMenuItem;
        private ToolStripMenuItem fixturesToolStripMenuItem;
        private ToolStripMenuItem resultsToolStripMenuItem;
        private ToolStripMenuItem topScorersToolStripMenuItem;
        private ToolStripMenuItem standingsToolStripMenuItem;

        public Panel PnlMain { get => pnlMain; set => pnlMain = value; }
        public MenuStrip MenuStrip { get => menuStrip; set => menuStrip = value; }
        public ToolStripMenuItem PlayerToolStripMenuItem { get => playerToolStripMenuItem; set => playerToolStripMenuItem = value; }
        public ToolStripMenuItem TeamToolStripMenuItem { get => teamToolStripMenuItem; set => teamToolStripMenuItem = value; }
        public ToolStripMenuItem FixturesToolStripMenuItem { get => fixturesToolStripMenuItem; set => fixturesToolStripMenuItem = value; }
        public ToolStripMenuItem ResultsToolStripMenuItem { get => resultsToolStripMenuItem; set => resultsToolStripMenuItem = value; }
        public ToolStripMenuItem TopScorersToolStripMenuItem { get => topScorersToolStripMenuItem; set => topScorersToolStripMenuItem = value; }
        public ToolStripMenuItem StandingsToolStripMenuItem { get => standingsToolStripMenuItem; set => standingsToolStripMenuItem = value; }
    }
}