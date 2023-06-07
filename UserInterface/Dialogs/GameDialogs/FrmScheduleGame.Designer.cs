using System.Windows.Forms;

namespace UserInterface.Dialogs.GameDialogs
{
    partial class FrmScheduleGame
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnScheduleGame = new System.Windows.Forms.Button();
            this.cmbGuest = new System.Windows.Forms.ComboBox();
            this.lblGuest = new System.Windows.Forms.Label();
            this.cmbHost = new System.Windows.Forms.ComboBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblDateError = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.numericRound = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericRound)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.CustomFormat = "dd.MM.yyyy. HH:mm";
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(375, 281);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(324, 30);
            this.dtpDate.TabIndex = 34;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(214, 281);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(143, 21);
            this.lblDate.TabIndex = 33;
            this.lblDate.Text = "Date and time:";
            // 
            // btnScheduleGame
            // 
            this.btnScheduleGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnScheduleGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnScheduleGame.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleGame.ForeColor = System.Drawing.Color.White;
            this.btnScheduleGame.Location = new System.Drawing.Point(317, 347);
            this.btnScheduleGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScheduleGame.Name = "btnScheduleGame";
            this.btnScheduleGame.Size = new System.Drawing.Size(272, 61);
            this.btnScheduleGame.TabIndex = 32;
            this.btnScheduleGame.Text = "Schedule game";
            this.btnScheduleGame.UseVisualStyleBackColor = false;
            this.btnScheduleGame.Click += new System.EventHandler(this.btnScheduleGame_Click);
            // 
            // cmbGuest
            // 
            this.cmbGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cmbGuest.DropDownHeight = 100;
            this.cmbGuest.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGuest.ForeColor = System.Drawing.Color.White;
            this.cmbGuest.FormattingEnabled = true;
            this.cmbGuest.IntegralHeight = false;
            this.cmbGuest.Location = new System.Drawing.Point(493, 145);
            this.cmbGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGuest.Name = "cmbGuest";
            this.cmbGuest.Size = new System.Drawing.Size(220, 29);
            this.cmbGuest.TabIndex = 31;
            // 
            // lblGuest
            // 
            this.lblGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGuest.AutoSize = true;
            this.lblGuest.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuest.ForeColor = System.Drawing.Color.White;
            this.lblGuest.Location = new System.Drawing.Point(489, 106);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(68, 21);
            this.lblGuest.TabIndex = 30;
            this.lblGuest.Text = "Guest:";
            // 
            // cmbHost
            // 
            this.cmbHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cmbHost.DropDownHeight = 100;
            this.cmbHost.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHost.ForeColor = System.Drawing.Color.White;
            this.cmbHost.FormattingEnabled = true;
            this.cmbHost.IntegralHeight = false;
            this.cmbHost.Location = new System.Drawing.Point(203, 145);
            this.cmbHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHost.Name = "cmbHost";
            this.cmbHost.Size = new System.Drawing.Size(220, 29);
            this.cmbHost.TabIndex = 29;
            // 
            // lblHost
            // 
            this.lblHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.ForeColor = System.Drawing.Color.White;
            this.lblHost.Location = new System.Drawing.Point(199, 106);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(53, 21);
            this.lblHost.TabIndex = 28;
            this.lblHost.Text = "Host:";
            // 
            // lblDateError
            // 
            this.lblDateError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateError.AutoSize = true;
            this.lblDateError.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateError.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblDateError.Location = new System.Drawing.Point(371, 309);
            this.lblDateError.Name = "lblDateError";
            this.lblDateError.Size = new System.Drawing.Size(0, 21);
            this.lblDateError.TabIndex = 35;
            // 
            // lblRound
            // 
            this.lblRound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.White;
            this.lblRound.Location = new System.Drawing.Point(285, 227);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(72, 21);
            this.lblRound.TabIndex = 37;
            this.lblRound.Text = "Round:";
            // 
            // numericRound
            // 
            this.numericRound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.numericRound.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericRound.ForeColor = System.Drawing.Color.White;
            this.numericRound.Location = new System.Drawing.Point(380, 223);
            this.numericRound.Name = "numericRound";
            this.numericRound.Size = new System.Drawing.Size(43, 32);
            this.numericRound.TabIndex = 38;
            // 
            // FrmScheduleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(929, 476);
            this.Controls.Add(this.numericRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblDateError);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnScheduleGame);
            this.Controls.Add(this.cmbGuest);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.cmbHost);
            this.Controls.Add(this.lblHost);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmScheduleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New fixture";
            ((System.ComponentModel.ISupportInitialize)(this.numericRound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnScheduleGame;
        private System.Windows.Forms.ComboBox cmbGuest;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.ComboBox cmbHost;
        private System.Windows.Forms.Label lblHost;
        private Label lblDateError;
        private Label lblRound;
        private NumericUpDown numericRound;

        public DateTimePicker DtpDate { get => dtpDate; set => dtpDate = value; }
        public Label LblDate { get => lblDate; set => lblDate = value; }
        public Button BtnScheduleGame { get => btnScheduleGame; set => btnScheduleGame = value; }
        public ComboBox CmbGuest { get => cmbGuest; set => cmbGuest = value; }
        public Label LblGuest { get => lblGuest; set => lblGuest = value; }
        public ComboBox CmbHost { get => cmbHost; set => cmbHost = value; }
        public Label LblHost { get => lblHost; set => lblHost = value; }
        public Label LblDateError { get => lblDateError; set => lblDateError = value; }
        public NumericUpDown NumericRound { get => numericRound; set => numericRound = value; }
    }
}