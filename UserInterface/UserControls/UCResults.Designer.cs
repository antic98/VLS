﻿using System.Windows.Forms;

namespace UserInterface.UserControls
{
    partial class UCResults
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.numericRound = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRound)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnDeleteGame.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGame.ForeColor = System.Drawing.Color.White;
            this.btnDeleteGame.Location = new System.Drawing.Point(787, 304);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(141, 64);
            this.btnDeleteGame.TabIndex = 9;
            this.btnDeleteGame.Text = "Delete game";
            this.btnDeleteGame.UseVisualStyleBackColor = false;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(19, 114);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 21);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(104, 113);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(526, 28);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnDetails.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.Location = new System.Drawing.Point(787, 217);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(141, 64);
            this.btnDetails.TabIndex = 10;
            this.btnDetails.Text = "Game details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // dgvGames
            // 
            this.dgvGames.AllowUserToAddRows = false;
            this.dgvGames.AllowUserToDeleteRows = false;
            this.dgvGames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGames.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvGames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGames.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGames.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGames.ColumnHeadersHeight = 30;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGames.EnableHeadersVisualStyles = false;
            this.dgvGames.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvGames.Location = new System.Drawing.Point(3, 168);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.RowHeadersVisible = false;
            this.dgvGames.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGames.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGames.RowTemplate.Height = 24;
            this.dgvGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGames.Size = new System.Drawing.Size(780, 296);
            this.dgvGames.TabIndex = 11;
            // 
            // lblCaption
            // 
            this.lblCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblCaption.Location = new System.Drawing.Point(372, 54);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(137, 39);
            this.lblCaption.TabIndex = 12;
            this.lblCaption.Text = "RESULTS";
            // 
            // lblRound
            // 
            this.lblRound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.White;
            this.lblRound.Location = new System.Drawing.Point(645, 114);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(72, 21);
            this.lblRound.TabIndex = 14;
            this.lblRound.Text = "Round:";
            // 
            // numericRound
            // 
            this.numericRound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.numericRound.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericRound.ForeColor = System.Drawing.Color.White;
            this.numericRound.Location = new System.Drawing.Point(723, 110);
            this.numericRound.Name = "numericRound";
            this.numericRound.Size = new System.Drawing.Size(43, 32);
            this.numericRound.TabIndex = 13;
            this.numericRound.ValueChanged += new System.EventHandler(this.numericRound_ValueChanged);
            // 
            // UCResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.numericRound);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "UCResults";
            this.Size = new System.Drawing.Size(931, 464);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private Button btnDetails;
        private DataGridView dgvGames;
        private Label lblCaption;
        private Label lblRound;
        private NumericUpDown numericRound;

        public Button BtnDeleteGame { get => btnDeleteGame; set => btnDeleteGame = value; }
        public DataGridView DgvGames { get => dgvGames; set => dgvGames = value; }
        public Label LblSearch { get => lblSearch; set => lblSearch = value; }
        public TextBox TxtSearch { get => txtSearch; set => txtSearch = value; }
        public Button BtnDetails { get => btnDetails; set => btnDetails = value; }
        public DataGridView DgvGames1 { get => dgvGames; set => dgvGames = value; }
        public NumericUpDown NumericRound { get => numericRound; set => numericRound = value; }
    }
}
