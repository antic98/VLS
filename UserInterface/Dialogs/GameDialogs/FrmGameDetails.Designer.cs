using System.Windows.Forms;

namespace UserInterface.Dialogs.GameDialogs
{
    partial class FrmGameDetails
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.lblHostStrikers = new System.Windows.Forms.Label();
            this.lblGuestStrikers = new System.Windows.Forms.Label();
            this.lblHostGoals = new System.Windows.Forms.Label();
            this.lblGuestGoals = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(320, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(106, 34);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "datum";
            // 
            // lblHost
            // 
            this.lblHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.ForeColor = System.Drawing.Color.White;
            this.lblHost.Location = new System.Drawing.Point(185, 162);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(109, 25);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "domacin";
            this.lblHost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGuest
            // 
            this.lblGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGuest.AutoSize = true;
            this.lblGuest.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuest.ForeColor = System.Drawing.Color.White;
            this.lblGuest.Location = new System.Drawing.Point(572, 162);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(58, 25);
            this.lblGuest.TabIndex = 2;
            this.lblGuest.Text = "gost";
            // 
            // lblHostStrikers
            // 
            this.lblHostStrikers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHostStrikers.AutoSize = true;
            this.lblHostStrikers.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostStrikers.ForeColor = System.Drawing.Color.White;
            this.lblHostStrikers.Location = new System.Drawing.Point(185, 270);
            this.lblHostStrikers.Name = "lblHostStrikers";
            this.lblHostStrikers.Size = new System.Drawing.Size(0, 21);
            this.lblHostStrikers.TabIndex = 3;
            // 
            // lblGuestStrikers
            // 
            this.lblGuestStrikers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGuestStrikers.AutoSize = true;
            this.lblGuestStrikers.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestStrikers.ForeColor = System.Drawing.Color.White;
            this.lblGuestStrikers.Location = new System.Drawing.Point(573, 270);
            this.lblGuestStrikers.Name = "lblGuestStrikers";
            this.lblGuestStrikers.Size = new System.Drawing.Size(0, 21);
            this.lblGuestStrikers.TabIndex = 4;
            // 
            // lblHostGoals
            // 
            this.lblHostGoals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHostGoals.AutoSize = true;
            this.lblHostGoals.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostGoals.ForeColor = System.Drawing.Color.White;
            this.lblHostGoals.Location = new System.Drawing.Point(399, 162);
            this.lblHostGoals.Name = "lblHostGoals";
            this.lblHostGoals.Size = new System.Drawing.Size(27, 25);
            this.lblHostGoals.TabIndex = 5;
            this.lblHostGoals.Text = "g";
            this.lblHostGoals.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGuestGoals
            // 
            this.lblGuestGoals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGuestGoals.AutoSize = true;
            this.lblGuestGoals.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestGoals.ForeColor = System.Drawing.Color.White;
            this.lblGuestGoals.Location = new System.Drawing.Point(456, 162);
            this.lblGuestGoals.Name = "lblGuestGoals";
            this.lblGuestGoals.Size = new System.Drawing.Size(27, 25);
            this.lblGuestGoals.TabIndex = 6;
            this.lblGuestGoals.Text = "g";
            this.lblGuestGoals.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(432, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(185, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Host scorers:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(573, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Guest scorers:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmGameDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(929, 476);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGuestGoals);
            this.Controls.Add(this.lblHostGoals);
            this.Controls.Add(this.lblGuestStrikers);
            this.Controls.Add(this.lblHostStrikers);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblDate);
            this.Name = "FrmGameDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmGameDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.Label lblHostStrikers;
        private System.Windows.Forms.Label lblGuestStrikers;
        private System.Windows.Forms.Label lblHostGoals;
        private System.Windows.Forms.Label lblGuestGoals;
        private Label label1;
        private Label label2;
        private Label label3;

        public Label LblDate { get => lblDate; set => lblDate = value; }
        public Label LblHost { get => lblHost; set => lblHost = value; }
        public Label LblGuest { get => lblGuest; set => lblGuest = value; }
        public Label LblHostStrikers { get => lblHostStrikers; set => lblHostStrikers = value; }
        public Label LblGuestStrikers { get => lblGuestStrikers; set => lblGuestStrikers = value; }
        public Label LblHostGoals { get => lblHostGoals; set => lblHostGoals = value; }
        public Label LblGuestGoals { get => lblGuestGoals; set => lblGuestGoals = value; }
    }
}