namespace ProjectC_JITTS
{
    partial class AddDate
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dropdownLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dropdownRoom = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.roomInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(57, 82);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(420, 31);
            this.datePicker.TabIndex = 0;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // dropdownLocation
            // 
            this.dropdownLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownLocation.FormattingEnabled = true;
            this.dropdownLocation.Location = new System.Drawing.Point(57, 194);
            this.dropdownLocation.Name = "dropdownLocation";
            this.dropdownLocation.Size = new System.Drawing.Size(236, 33);
            this.dropdownLocation.TabIndex = 1;
            this.dropdownLocation.SelectedIndexChanged += new System.EventHandler(this.dropdownLocation_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select a date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select a location and room";
            // 
            // dropdownRoom
            // 
            this.dropdownRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownRoom.FormattingEnabled = true;
            this.dropdownRoom.Location = new System.Drawing.Point(365, 194);
            this.dropdownRoom.Name = "dropdownRoom";
            this.dropdownRoom.Size = new System.Drawing.Size(112, 33);
            this.dropdownRoom.TabIndex = 10;
            this.dropdownRoom.Visible = false;
            this.dropdownRoom.SelectedIndexChanged += new System.EventHandler(this.dropdownRoom_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(57, 274);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(420, 44);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // roomInfo
            // 
            this.roomInfo.AutoSize = true;
            this.roomInfo.Location = new System.Drawing.Point(1129, 82);
            this.roomInfo.Name = "roomInfo";
            this.roomInfo.Size = new System.Drawing.Size(268, 25);
            this.roomInfo.TabIndex = 13;
            this.roomInfo.Text = "Room info will display here";
            // 
            // AddDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1129);
            this.Controls.Add(this.roomInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dropdownRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropdownLocation);
            this.Controls.Add(this.datePicker);
            this.Name = "AddDate";
            this.Text = "AddWorkplace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox dropdownLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dropdownRoom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label roomInfo;
    }
}