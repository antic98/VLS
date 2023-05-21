using System.Windows.Forms;

namespace UserInterface.UserControls
{
    partial class UCScheduleGame
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnScheduleGame = new System.Windows.Forms.Button();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.btnInsertResult = new System.Windows.Forms.Button();
            this.lblCaption = new System.Windows.Forms.Label();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.btnMakeFixtures = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.SuspendLayout();
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
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search:";
            // 
            // btnScheduleGame
            // 
            this.btnScheduleGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnScheduleGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnScheduleGame.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleGame.ForeColor = System.Drawing.Color.White;
            this.btnScheduleGame.Location = new System.Drawing.Point(787, 205);
            this.btnScheduleGame.Name = "btnScheduleGame";
            this.btnScheduleGame.Size = new System.Drawing.Size(141, 64);
            this.btnScheduleGame.TabIndex = 3;
            this.btnScheduleGame.Text = "Schedule game";
            this.btnScheduleGame.UseVisualStyleBackColor = false;
            this.btnScheduleGame.Click += new System.EventHandler(this.btnScheduleGame_Click);
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnDeleteGame.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGame.ForeColor = System.Drawing.Color.White;
            this.btnDeleteGame.Location = new System.Drawing.Point(787, 353);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(141, 64);
            this.btnDeleteGame.TabIndex = 4;
            this.btnDeleteGame.Text = "Delete game";
            this.btnDeleteGame.UseVisualStyleBackColor = false;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // btnInsertResult
            // 
            this.btnInsertResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnInsertResult.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertResult.ForeColor = System.Drawing.Color.White;
            this.btnInsertResult.Location = new System.Drawing.Point(787, 279);
            this.btnInsertResult.Name = "btnInsertResult";
            this.btnInsertResult.Size = new System.Drawing.Size(141, 64);
            this.btnInsertResult.TabIndex = 5;
            this.btnInsertResult.Text = "Insert result";
            this.btnInsertResult.UseVisualStyleBackColor = false;
            this.btnInsertResult.Click += new System.EventHandler(this.btnInsertResult_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblCaption.Location = new System.Drawing.Point(372, 54);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(152, 39);
            this.lblCaption.TabIndex = 6;
            this.lblCaption.Text = "FIXTURES";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGames.ColumnHeadersHeight = 30;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGames.EnableHeadersVisualStyles = false;
            this.dgvGames.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvGames.Location = new System.Drawing.Point(3, 165);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.RowHeadersVisible = false;
            this.dgvGames.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGames.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGames.RowTemplate.Height = 24;
            this.dgvGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGames.Size = new System.Drawing.Size(780, 296);
            this.dgvGames.TabIndex = 7;
            // 
            // btnMakeFixtures
            // 
            this.btnMakeFixtures.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMakeFixtures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnMakeFixtures.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeFixtures.ForeColor = System.Drawing.Color.White;
            this.btnMakeFixtures.Location = new System.Drawing.Point(787, 125);
            this.btnMakeFixtures.Name = "btnMakeFixtures";
            this.btnMakeFixtures.Size = new System.Drawing.Size(141, 64);
            this.btnMakeFixtures.TabIndex = 8;
            this.btnMakeFixtures.Text = "Make fixtures";
            this.btnMakeFixtures.UseVisualStyleBackColor = false;
            this.btnMakeFixtures.Click += new System.EventHandler(this.btnAddFixtures_Click);
            // 
            // UCScheduleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btnMakeFixtures);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.btnInsertResult);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.btnScheduleGame);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCScheduleGame";
            this.Size = new System.Drawing.Size(931, 464);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnScheduleGame;
        private System.Windows.Forms.Button btnDeleteGame;
        private Button btnInsertResult;
        private Label lblCaption;
        private DataGridView dgvGames;
        private Button btnMakeFixtures;

        public TextBox TxtSearch { get => txtSearch; set => txtSearch = value; }
        public Label LblSearch { get => lblSearch; set => lblSearch = value; }
        public DataGridView DgvGames { get => dgvGames; set => dgvGames = value; }
        public Button BtnScheduleGame { get => btnScheduleGame; set => btnScheduleGame = value; }
        public Button BtnDeleteGame { get => btnDeleteGame; set => btnDeleteGame = value; }
        public DataGridView DgvGames1 { get => dgvGames; set => dgvGames = value; }
    }
}
