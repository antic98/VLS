namespace UserInterface.Dialogs.GameDialogs
{
    partial class FrmGetFixtures
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
            this.dgvTeamsGroupA = new System.Windows.Forms.DataGridView();
            this.dgvTeamsGroupB = new System.Windows.Forms.DataGridView();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.btnGroupA = new System.Windows.Forms.Button();
            this.btnGroupB = new System.Windows.Forms.Button();
            this.btnGetFixtures = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamsGroupA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamsGroupB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeamsGroupA
            // 
            this.dgvTeamsGroupA.AllowUserToAddRows = false;
            this.dgvTeamsGroupA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamsGroupA.Location = new System.Drawing.Point(56, 60);
            this.dgvTeamsGroupA.Name = "dgvTeamsGroupA";
            this.dgvTeamsGroupA.ReadOnly = true;
            this.dgvTeamsGroupA.RowHeadersWidth = 51;
            this.dgvTeamsGroupA.RowTemplate.Height = 24;
            this.dgvTeamsGroupA.Size = new System.Drawing.Size(240, 150);
            this.dgvTeamsGroupA.TabIndex = 0;
            // 
            // dgvTeamsGroupB
            // 
            this.dgvTeamsGroupB.AllowUserToAddRows = false;
            this.dgvTeamsGroupB.AllowUserToDeleteRows = false;
            this.dgvTeamsGroupB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamsGroupB.Location = new System.Drawing.Point(497, 60);
            this.dgvTeamsGroupB.Name = "dgvTeamsGroupB";
            this.dgvTeamsGroupB.ReadOnly = true;
            this.dgvTeamsGroupB.RowHeadersWidth = 51;
            this.dgvTeamsGroupB.RowTemplate.Height = 24;
            this.dgvTeamsGroupB.Size = new System.Drawing.Size(240, 150);
            this.dgvTeamsGroupB.TabIndex = 1;
            // 
            // dgvTeams
            // 
            this.dgvTeams.AllowUserToAddRows = false;
            this.dgvTeams.AllowUserToDeleteRows = false;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Location = new System.Drawing.Point(56, 226);
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.ReadOnly = true;
            this.dgvTeams.RowHeadersWidth = 51;
            this.dgvTeams.RowTemplate.Height = 24;
            this.dgvTeams.Size = new System.Drawing.Size(681, 138);
            this.dgvTeams.TabIndex = 2;
            // 
            // btnGroupA
            // 
            this.btnGroupA.Location = new System.Drawing.Point(327, 60);
            this.btnGroupA.Name = "btnGroupA";
            this.btnGroupA.Size = new System.Drawing.Size(142, 55);
            this.btnGroupA.TabIndex = 3;
            this.btnGroupA.Text = "button1";
            this.btnGroupA.UseVisualStyleBackColor = true;
            this.btnGroupA.Click += new System.EventHandler(this.btnGroupA_Click);
            // 
            // btnGroupB
            // 
            this.btnGroupB.Location = new System.Drawing.Point(327, 135);
            this.btnGroupB.Name = "btnGroupB";
            this.btnGroupB.Size = new System.Drawing.Size(142, 55);
            this.btnGroupB.TabIndex = 4;
            this.btnGroupB.Text = "button2";
            this.btnGroupB.UseVisualStyleBackColor = true;
            this.btnGroupB.Click += new System.EventHandler(this.btnGroupB_Click);
            // 
            // btnGetFixtures
            // 
            this.btnGetFixtures.Location = new System.Drawing.Point(518, 383);
            this.btnGetFixtures.Name = "btnGetFixtures";
            this.btnGetFixtures.Size = new System.Drawing.Size(142, 55);
            this.btnGetFixtures.TabIndex = 5;
            this.btnGetFixtures.Text = "Get fixtures";
            this.btnGetFixtures.UseVisualStyleBackColor = true;
            this.btnGetFixtures.Click += new System.EventHandler(this.btnGetFixtures_Click);
            // 
            // FrmGetFixtures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetFixtures);
            this.Controls.Add(this.btnGroupB);
            this.Controls.Add(this.btnGroupA);
            this.Controls.Add(this.dgvTeams);
            this.Controls.Add(this.dgvTeamsGroupB);
            this.Controls.Add(this.dgvTeamsGroupA);
            this.Name = "FrmGetFixtures";
            this.Text = "FrmGetFixtures";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamsGroupA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamsGroupB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeamsGroupA;
        private System.Windows.Forms.DataGridView dgvTeamsGroupB;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.Button btnGroupA;
        private System.Windows.Forms.Button btnGroupB;
        private System.Windows.Forms.Button btnGetFixtures;
    }
}