using System.Windows.Forms;

namespace UserInterface.Dialogs.GameDialogs
{
    partial class FrmInsertGameResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.numericHost = new System.Windows.Forms.NumericUpDown();
            this.numericGuest = new System.Windows.Forms.NumericUpDown();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnSaveHostStriker = new System.Windows.Forms.Button();
            this.btnSaveGuestStriker = new System.Windows.Forms.Button();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.lblHostStrikers = new System.Windows.Forms.Label();
            this.lblGuestStrikers = new System.Windows.Forms.Label();
            this.dgvHostPlayers = new System.Windows.Forms.DataGridView();
            this.dgvGuestPlayers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericHost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHost
            // 
            this.lblHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.ForeColor = System.Drawing.Color.White;
            this.lblHost.Location = new System.Drawing.Point(190, 64);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(52, 23);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host";
            this.lblHost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGuest
            // 
            this.lblGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGuest.AutoSize = true;
            this.lblGuest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuest.ForeColor = System.Drawing.Color.White;
            this.lblGuest.Location = new System.Drawing.Point(623, 64);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(67, 23);
            this.lblGuest.TabIndex = 1;
            this.lblGuest.Text = "Guest";
            // 
            // numericHost
            // 
            this.numericHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.numericHost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericHost.ForeColor = System.Drawing.Color.White;
            this.numericHost.Location = new System.Drawing.Point(359, 60);
            this.numericHost.Name = "numericHost";
            this.numericHost.Size = new System.Drawing.Size(58, 32);
            this.numericHost.TabIndex = 2;
            // 
            // numericGuest
            // 
            this.numericGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.numericGuest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericGuest.ForeColor = System.Drawing.Color.White;
            this.numericGuest.Location = new System.Drawing.Point(500, 60);
            this.numericGuest.Name = "numericGuest";
            this.numericGuest.Size = new System.Drawing.Size(58, 32);
            this.numericGuest.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(366, 105);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 23);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnResult
            // 
            this.btnResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.Location = new System.Drawing.Point(377, 141);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(159, 61);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "Enter result";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnSaveHostStriker
            // 
            this.btnSaveHostStriker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveHostStriker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSaveHostStriker.Enabled = false;
            this.btnSaveHostStriker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHostStriker.ForeColor = System.Drawing.Color.White;
            this.btnSaveHostStriker.Location = new System.Drawing.Point(300, 224);
            this.btnSaveHostStriker.Name = "btnSaveHostStriker";
            this.btnSaveHostStriker.Size = new System.Drawing.Size(138, 61);
            this.btnSaveHostStriker.TabIndex = 8;
            this.btnSaveHostStriker.Text = "Save host scorer";
            this.btnSaveHostStriker.UseVisualStyleBackColor = false;
            this.btnSaveHostStriker.Click += new System.EventHandler(this.btnSaveHostStriker_Click);
            // 
            // btnSaveGuestStriker
            // 
            this.btnSaveGuestStriker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveGuestStriker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSaveGuestStriker.Enabled = false;
            this.btnSaveGuestStriker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGuestStriker.ForeColor = System.Drawing.Color.White;
            this.btnSaveGuestStriker.Location = new System.Drawing.Point(482, 224);
            this.btnSaveGuestStriker.Name = "btnSaveGuestStriker";
            this.btnSaveGuestStriker.Size = new System.Drawing.Size(138, 61);
            this.btnSaveGuestStriker.TabIndex = 9;
            this.btnSaveGuestStriker.Text = "Save guest scorer";
            this.btnSaveGuestStriker.UseVisualStyleBackColor = false;
            this.btnSaveGuestStriker.Click += new System.EventHandler(this.btnSaveGuestStriker_Click);
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSaveResult.Enabled = false;
            this.btnSaveResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveResult.ForeColor = System.Drawing.Color.White;
            this.btnSaveResult.Location = new System.Drawing.Point(359, 336);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(191, 75);
            this.btnSaveResult.TabIndex = 10;
            this.btnSaveResult.Text = "Save result";
            this.btnSaveResult.UseVisualStyleBackColor = false;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // lblHostStrikers
            // 
            this.lblHostStrikers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHostStrikers.AutoSize = true;
            this.lblHostStrikers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostStrikers.ForeColor = System.Drawing.Color.White;
            this.lblHostStrikers.Location = new System.Drawing.Point(38, 336);
            this.lblHostStrikers.Name = "lblHostStrikers";
            this.lblHostStrikers.Size = new System.Drawing.Size(114, 21);
            this.lblHostStrikers.TabIndex = 11;
            this.lblHostStrikers.Text = "Host scorers:";
            this.lblHostStrikers.Visible = false;
            // 
            // lblGuestStrikers
            // 
            this.lblGuestStrikers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGuestStrikers.AutoSize = true;
            this.lblGuestStrikers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestStrikers.ForeColor = System.Drawing.Color.White;
            this.lblGuestStrikers.Location = new System.Drawing.Point(623, 336);
            this.lblGuestStrikers.Name = "lblGuestStrikers";
            this.lblGuestStrikers.Size = new System.Drawing.Size(127, 21);
            this.lblGuestStrikers.TabIndex = 12;
            this.lblGuestStrikers.Text = "Guest scorers:";
            this.lblGuestStrikers.Visible = false;
            // 
            // dgvHostPlayers
            // 
            this.dgvHostPlayers.AllowUserToAddRows = false;
            this.dgvHostPlayers.AllowUserToDeleteRows = false;
            this.dgvHostPlayers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvHostPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHostPlayers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvHostPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHostPlayers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHostPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHostPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHostPlayers.ColumnHeadersHeight = 30;
            this.dgvHostPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHostPlayers.EnableHeadersVisualStyles = false;
            this.dgvHostPlayers.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvHostPlayers.Location = new System.Drawing.Point(42, 128);
            this.dgvHostPlayers.Name = "dgvHostPlayers";
            this.dgvHostPlayers.ReadOnly = true;
            this.dgvHostPlayers.RowHeadersVisible = false;
            this.dgvHostPlayers.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHostPlayers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHostPlayers.RowTemplate.Height = 24;
            this.dgvHostPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHostPlayers.Size = new System.Drawing.Size(252, 200);
            this.dgvHostPlayers.TabIndex = 13;
            // 
            // dgvGuestPlayers
            // 
            this.dgvGuestPlayers.AllowUserToAddRows = false;
            this.dgvGuestPlayers.AllowUserToDeleteRows = false;
            this.dgvGuestPlayers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvGuestPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuestPlayers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvGuestPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGuestPlayers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGuestPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuestPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGuestPlayers.ColumnHeadersHeight = 30;
            this.dgvGuestPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGuestPlayers.EnableHeadersVisualStyles = false;
            this.dgvGuestPlayers.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvGuestPlayers.Location = new System.Drawing.Point(626, 128);
            this.dgvGuestPlayers.Name = "dgvGuestPlayers";
            this.dgvGuestPlayers.ReadOnly = true;
            this.dgvGuestPlayers.RowHeadersVisible = false;
            this.dgvGuestPlayers.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGuestPlayers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGuestPlayers.RowTemplate.Height = 24;
            this.dgvGuestPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuestPlayers.Size = new System.Drawing.Size(252, 200);
            this.dgvGuestPlayers.TabIndex = 14;
            // 
            // FrmInsertGameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(929, 476);
            this.Controls.Add(this.dgvGuestPlayers);
            this.Controls.Add(this.dgvHostPlayers);
            this.Controls.Add(this.lblGuestStrikers);
            this.Controls.Add(this.lblHostStrikers);
            this.Controls.Add(this.btnSaveResult);
            this.Controls.Add(this.btnSaveGuestStriker);
            this.Controls.Add(this.btnSaveHostStriker);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.numericGuest);
            this.Controls.Add(this.numericHost);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.lblHost);
            this.Name = "FrmInsertGameResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmInsertGameResult";
            this.Load += new System.EventHandler(this.FrmInsertGameResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericHost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.NumericUpDown numericHost;
        private System.Windows.Forms.NumericUpDown numericGuest;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnSaveHostStriker;
        private System.Windows.Forms.Button btnSaveGuestStriker;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.Label lblHostStrikers;
        private System.Windows.Forms.Label lblGuestStrikers;
        private DataGridView dgvHostPlayers;
        private DataGridView dgvGuestPlayers;

        public Label LblHost { get => lblHost; set => lblHost = value; }
        public Label LblGuest { get => lblGuest; set => lblGuest = value; }
        public NumericUpDown NumericHost { get => numericHost; set => numericHost = value; }
        public NumericUpDown NumericGuest { get => numericGuest; set => numericGuest = value; }
        public Label LblDate { get => lblDate; set => lblDate = value; }
        public DataGridView DgvHostPlayers { get => dgvHostPlayers; set => dgvHostPlayers = value; }
        public DataGridView DgvGuestPlayers { get => dgvGuestPlayers; set => dgvGuestPlayers = value; }
        public Button BtnResult { get => btnResult; set => btnResult = value; }
        public Button BtnSaveHostStriker { get => btnSaveHostStriker; set => btnSaveHostStriker = value; }
        public Button BtnSaveGuestStriker { get => btnSaveGuestStriker; set => btnSaveGuestStriker = value; }
        public Button BtnSaveResult { get => btnSaveResult; set => btnSaveResult = value; }
        public Label LblHostStrikers { get => lblHostStrikers; set => lblHostStrikers = value; }
        public Label LblGuestStrikers { get => lblGuestStrikers; set => lblGuestStrikers = value; }
    }
}