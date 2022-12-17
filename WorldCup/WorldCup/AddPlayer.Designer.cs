namespace WorldCup
{
    partial class AddPlayer
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
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.PlayerPositionLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PlayerPositionComboBox = new System.Windows.Forms.ComboBox();
            this.PlayerJerseyNoLabel = new System.Windows.Forms.Label();
            this.PlayerJerseyNoComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.DisplayPlayersBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.Location = new System.Drawing.Point(375, 149);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(192, 22);
            this.PlayerNameTextBox.TabIndex = 0;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(254, 155);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(86, 16);
            this.PlayerNameLabel.TabIndex = 3;
            this.PlayerNameLabel.Text = "Player Name";
            // 
            // PlayerPositionLabel
            // 
            this.PlayerPositionLabel.AutoSize = true;
            this.PlayerPositionLabel.Location = new System.Drawing.Point(254, 209);
            this.PlayerPositionLabel.Name = "PlayerPositionLabel";
            this.PlayerPositionLabel.Size = new System.Drawing.Size(97, 16);
            this.PlayerPositionLabel.TabIndex = 3;
            this.PlayerPositionLabel.Text = "Player Position";
            // 
            // PlayerPositionComboBox
            // 
            this.PlayerPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerPositionComboBox.FormattingEnabled = true;
            this.PlayerPositionComboBox.Items.AddRange(new object[] {
            "Forward",
            "Defender",
            "Keeper",
            "Midfielder"});
            this.PlayerPositionComboBox.Location = new System.Drawing.Point(375, 206);
            this.PlayerPositionComboBox.Name = "PlayerPositionComboBox";
            this.PlayerPositionComboBox.Size = new System.Drawing.Size(192, 24);
            this.PlayerPositionComboBox.TabIndex = 4;
            // 
            // PlayerJerseyNoLabel
            // 
            this.PlayerJerseyNoLabel.AutoSize = true;
            this.PlayerJerseyNoLabel.Location = new System.Drawing.Point(254, 267);
            this.PlayerJerseyNoLabel.Name = "PlayerJerseyNoLabel";
            this.PlayerJerseyNoLabel.Size = new System.Drawing.Size(69, 16);
            this.PlayerJerseyNoLabel.TabIndex = 5;
            this.PlayerJerseyNoLabel.Text = "Jersey No";
            // 
            // PlayerJerseyNoComboBox
            // 
            this.PlayerJerseyNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerJerseyNoComboBox.FormattingEnabled = true;
            this.PlayerJerseyNoComboBox.Location = new System.Drawing.Point(375, 259);
            this.PlayerJerseyNoComboBox.Name = "PlayerJerseyNoComboBox";
            this.PlayerJerseyNoComboBox.Size = new System.Drawing.Size(192, 24);
            this.PlayerJerseyNoComboBox.TabIndex = 6;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(375, 316);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 7;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // DisplayPlayersBtn
            // 
            this.DisplayPlayersBtn.Location = new System.Drawing.Point(94, 40);
            this.DisplayPlayersBtn.Name = "DisplayPlayersBtn";
            this.DisplayPlayersBtn.Size = new System.Drawing.Size(182, 23);
            this.DisplayPlayersBtn.TabIndex = 8;
            this.DisplayPlayersBtn.Text = "Display Players";
            this.DisplayPlayersBtn.UseVisualStyleBackColor = true;
            this.DisplayPlayersBtn.Click += new System.EventHandler(this.DisplayPlayersBtn_Click);
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 496);
            this.Controls.Add(this.DisplayPlayersBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.PlayerJerseyNoComboBox);
            this.Controls.Add(this.PlayerJerseyNoLabel);
            this.Controls.Add(this.PlayerPositionComboBox);
            this.Controls.Add(this.PlayerPositionLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Name = "AddPlayer";
            this.Text = "Add Player";
            this.Load += new System.EventHandler(this.AddPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label PlayerPositionLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox PlayerPositionComboBox;
        private System.Windows.Forms.Label PlayerJerseyNoLabel;
        private System.Windows.Forms.ComboBox PlayerJerseyNoComboBox;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button DisplayPlayersBtn;
    }
}

