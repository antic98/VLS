using System.Windows.Forms;

namespace UserInterface.Dialogs.PlayerDialogs
{
    partial class FrmAddPlayer
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
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCountry
            // 
            this.cbCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cbCountry.DropDownHeight = 100;
            this.cbCountry.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.ForeColor = System.Drawing.Color.White;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.IntegralHeight = false;
            this.cbCountry.Location = new System.Drawing.Point(386, 286);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(241, 29);
            this.cbCountry.TabIndex = 41;
            // 
            // cbTeam
            // 
            this.cbTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cbTeam.DropDownHeight = 100;
            this.cbTeam.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeam.ForeColor = System.Drawing.Color.White;
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.IntegralHeight = false;
            this.cbTeam.Location = new System.Drawing.Point(386, 229);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(241, 29);
            this.cbTeam.TabIndex = 40;
            // 
            // cbPosition
            // 
            this.cbPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cbPosition.DropDownHeight = 100;
            this.cbPosition.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.ForeColor = System.Drawing.Color.White;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.IntegralHeight = false;
            this.cbPosition.Location = new System.Drawing.Point(386, 170);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(241, 29);
            this.cbPosition.TabIndex = 39;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnAddPlayer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer.ForeColor = System.Drawing.Color.White;
            this.btnAddPlayer.Location = new System.Drawing.Point(386, 356);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(241, 57);
            this.btnAddPlayer.TabIndex = 38;
            this.btnAddPlayer.Text = "Add player";
            this.btnAddPlayer.UseVisualStyleBackColor = false;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point(283, 289);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(80, 21);
            this.lblCountry.TabIndex = 37;
            this.lblCountry.Text = "Country:";
            // 
            // lblTeam
            // 
            this.lblTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.Color.White;
            this.lblTeam.Location = new System.Drawing.Point(283, 232);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(61, 21);
            this.lblTeam.TabIndex = 36;
            this.lblTeam.Text = "Team:";
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(283, 173);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(77, 21);
            this.lblPosition.TabIndex = 35;
            this.lblPosition.Text = "Position:";
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.White;
            this.txtSurname.Location = new System.Drawing.Point(386, 114);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(241, 28);
            this.txtSurname.TabIndex = 34;
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(283, 117);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(86, 21);
            this.lblSurname.TabIndex = 33;
            this.lblSurname.Text = "Surname:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(386, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 28);
            this.txtName.TabIndex = 32;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(283, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 21);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Name:";
            // 
            // FrmAddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(929, 476);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.cbTeam);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "FrmAddPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbTeam;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;

        public ComboBox CbCountry { get => cbCountry; set => cbCountry = value; }
        public ComboBox CbTeam { get => cbTeam; set => cbTeam = value; }
        public ComboBox CbPosition { get => cbPosition; set => cbPosition = value; }
        public Button BtnAddPlayer { get => btnAddPlayer; set => btnAddPlayer = value; }
        public Label LblCountry { get => lblCountry; set => lblCountry = value; }
        public Label LblTeam { get => lblTeam; set => lblTeam = value; }
        public Label LblPosition { get => lblPosition; set => lblPosition = value; }
        public TextBox TxtSurname { get => txtSurname; set => txtSurname = value; }
        public Label LblSurname { get => lblSurname; set => lblSurname = value; }
        public TextBox TxtName { get => txtName; set => txtName = value; }
        public Label LblName { get => lblName; set => lblName = value; }
    }
}