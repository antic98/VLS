using System.Windows.Forms;

namespace UserInterface.Dialogs.GameDialogs
{
    partial class FrmAddGames
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
            this.dgvAllTeams = new System.Windows.Forms.DataGridView();
            this.dgvSelectedTeams = new System.Windows.Forms.DataGridView();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnAddGames = new System.Windows.Forms.Button();
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllTeams
            // 
            this.dgvAllTeams.AllowUserToAddRows = false;
            this.dgvAllTeams.AllowUserToDeleteRows = false;
            this.dgvAllTeams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAllTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllTeams.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvAllTeams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllTeams.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllTeams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllTeams.ColumnHeadersHeight = 30;
            this.dgvAllTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllTeams.EnableHeadersVisualStyles = false;
            this.dgvAllTeams.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAllTeams.Location = new System.Drawing.Point(30, 31);
            this.dgvAllTeams.Name = "dgvAllTeams";
            this.dgvAllTeams.ReadOnly = true;
            this.dgvAllTeams.RowHeadersVisible = false;
            this.dgvAllTeams.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAllTeams.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllTeams.RowTemplate.Height = 24;
            this.dgvAllTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllTeams.Size = new System.Drawing.Size(315, 409);
            this.dgvAllTeams.TabIndex = 14;
            // 
            // dgvSelectedTeams
            // 
            this.dgvSelectedTeams.AllowUserToAddRows = false;
            this.dgvSelectedTeams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSelectedTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedTeams.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvSelectedTeams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelectedTeams.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSelectedTeams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectedTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSelectedTeams.ColumnHeadersHeight = 30;
            this.dgvSelectedTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSelectedTeams.EnableHeadersVisualStyles = false;
            this.dgvSelectedTeams.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvSelectedTeams.Location = new System.Drawing.Point(563, 31);
            this.dgvSelectedTeams.Name = "dgvSelectedTeams";
            this.dgvSelectedTeams.ReadOnly = true;
            this.dgvSelectedTeams.RowHeadersVisible = false;
            this.dgvSelectedTeams.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSelectedTeams.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSelectedTeams.RowTemplate.Height = 24;
            this.dgvSelectedTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedTeams.Size = new System.Drawing.Size(341, 409);
            this.dgvSelectedTeams.TabIndex = 15;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnAddTeam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.Color.White;
            this.btnAddTeam.Location = new System.Drawing.Point(351, 101);
            this.btnAddTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(192, 61);
            this.btnAddTeam.TabIndex = 33;
            this.btnAddTeam.Text = "===>";
            this.btnAddTeam.UseVisualStyleBackColor = false;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click_1);
            // 
            // btnAddGames
            // 
            this.btnAddGames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnAddGames.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGames.ForeColor = System.Drawing.Color.White;
            this.btnAddGames.Location = new System.Drawing.Point(351, 293);
            this.btnAddGames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddGames.Name = "btnAddGames";
            this.btnAddGames.Size = new System.Drawing.Size(192, 61);
            this.btnAddGames.TabIndex = 34;
            this.btnAddGames.Text = "Add games";
            this.btnAddGames.UseVisualStyleBackColor = false;
            this.btnAddGames.Click += new System.EventHandler(this.btnAddGames_Click_1);
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnRemoveTeam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTeam.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTeam.Location = new System.Drawing.Point(351, 197);
            this.btnRemoveTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(192, 61);
            this.btnRemoveTeam.TabIndex = 35;
            this.btnRemoveTeam.Text = "<===";
            this.btnRemoveTeam.UseVisualStyleBackColor = false;
            this.btnRemoveTeam.Click += new System.EventHandler(this.btnRemoveTeam_Click);
            // 
            // FrmAddGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(929, 476);
            this.Controls.Add(this.btnRemoveTeam);
            this.Controls.Add(this.btnAddGames);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.dgvSelectedTeams);
            this.Controls.Add(this.dgvAllTeams);
            this.Name = "FrmAddGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add games";
            this.Load += new System.EventHandler(this.FrmAddGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedTeams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllTeams;
        private System.Windows.Forms.DataGridView dgvSelectedTeams;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnAddGames;
        private Button btnRemoveTeam;

        public DataGridView DgvAllTeams { get => dgvAllTeams; set => dgvAllTeams = value; }
        public DataGridView DgvSelectedTeams { get => dgvSelectedTeams; set => dgvSelectedTeams = value; }
        public Button BtnAddTeam { get => btnAddTeam; set => btnAddTeam = value; }
        public Button BtnAddGames { get => btnAddGames; set => btnAddGames = value; }
    }
}