namespace ProjectC_JITTS
{
    partial class RemoveRoom
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
            this.locationDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dropdownRoom = new System.Windows.Forms.ComboBox();
            this.roomLabel = new System.Windows.Forms.Label();
            this.roomInfo = new System.Windows.Forms.Label();
            this.removeroomBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locationDropdown
            // 
            this.locationDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationDropdown.FormattingEnabled = true;
            this.locationDropdown.Location = new System.Drawing.Point(29, 112);
            this.locationDropdown.Name = "locationDropdown";
            this.locationDropdown.Size = new System.Drawing.Size(299, 33);
            this.locationDropdown.TabIndex = 0;
            this.locationDropdown.SelectedIndexChanged += new System.EventHandler(this.locationDropdown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a location";
            // 
            // dropdownRoom
            // 
            this.dropdownRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownRoom.FormattingEnabled = true;
            this.dropdownRoom.Location = new System.Drawing.Point(414, 112);
            this.dropdownRoom.Name = "dropdownRoom";
            this.dropdownRoom.Size = new System.Drawing.Size(299, 33);
            this.dropdownRoom.TabIndex = 8;
            this.dropdownRoom.Visible = false;
            this.dropdownRoom.SelectedIndexChanged += new System.EventHandler(this.dropdownRoom_SelectedIndexChanged);
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLabel.Location = new System.Drawing.Point(407, 56);
            this.roomLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(214, 37);
            this.roomLabel.TabIndex = 9;
            this.roomLabel.Text = "Select a room";
            this.roomLabel.Visible = false;
            // 
            // roomInfo
            // 
            this.roomInfo.AutoSize = true;
            this.roomInfo.Location = new System.Drawing.Point(1225, 65);
            this.roomInfo.Name = "roomInfo";
            this.roomInfo.Size = new System.Drawing.Size(268, 25);
            this.roomInfo.TabIndex = 14;
            this.roomInfo.Text = "Room info will display here";
            // 
            // removeroomBtn
            // 
            this.removeroomBtn.Location = new System.Drawing.Point(693, 966);
            this.removeroomBtn.Name = "removeroomBtn";
            this.removeroomBtn.Size = new System.Drawing.Size(247, 91);
            this.removeroomBtn.TabIndex = 15;
            this.removeroomBtn.Text = "Remove room";
            this.removeroomBtn.UseVisualStyleBackColor = true;
            this.removeroomBtn.Visible = false;
            this.removeroomBtn.Click += new System.EventHandler(this.removeroomBtn_Click);
            // 
            // RemoveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1129);
            this.Controls.Add(this.removeroomBtn);
            this.Controls.Add(this.roomInfo);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.dropdownRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationDropdown);
            this.Name = "RemoveRoom";
            this.Text = "RemoveRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox locationDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropdownRoom;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label roomInfo;
        private System.Windows.Forms.Button removeroomBtn;
    }
}