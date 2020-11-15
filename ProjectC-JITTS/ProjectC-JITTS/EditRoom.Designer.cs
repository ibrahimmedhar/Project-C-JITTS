namespace ProjectC_JITTS
{
    partial class EditRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.locationDropdown = new System.Windows.Forms.ComboBox();
            this.roomLabel = new System.Windows.Forms.Label();
            this.dropdownRoom = new System.Windows.Forms.ComboBox();
            this.roomno_label = new System.Windows.Forms.Label();
            this.roomamountLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.location_zip = new System.Windows.Forms.TextBox();
            this.housenoLabel = new System.Windows.Forms.Label();
            this.location_no = new System.Windows.Forms.NumericUpDown();
            this.locationnameLabel = new System.Windows.Forms.Label();
            this.location_name = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.workplaces = new System.Windows.Forms.TextBox();
            this.room_no = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.location_no)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select a location";
            // 
            // locationDropdown
            // 
            this.locationDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationDropdown.FormattingEnabled = true;
            this.locationDropdown.Location = new System.Drawing.Point(41, 94);
            this.locationDropdown.Name = "locationDropdown";
            this.locationDropdown.Size = new System.Drawing.Size(299, 33);
            this.locationDropdown.TabIndex = 1;
            this.locationDropdown.SelectedIndexChanged += new System.EventHandler(this.locationDropdown_SelectedIndexChanged);
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLabel.Location = new System.Drawing.Point(442, 42);
            this.roomLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(214, 37);
            this.roomLabel.TabIndex = 10;
            this.roomLabel.Text = "Select a room";
            this.roomLabel.Visible = false;
            // 
            // dropdownRoom
            // 
            this.dropdownRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownRoom.FormattingEnabled = true;
            this.dropdownRoom.Location = new System.Drawing.Point(449, 94);
            this.dropdownRoom.Name = "dropdownRoom";
            this.dropdownRoom.Size = new System.Drawing.Size(299, 33);
            this.dropdownRoom.TabIndex = 2;
            this.dropdownRoom.Visible = false;
            this.dropdownRoom.SelectedIndexChanged += new System.EventHandler(this.dropdownRoom_SelectedIndexChanged);
            // 
            // roomno_label
            // 
            this.roomno_label.AutoSize = true;
            this.roomno_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomno_label.Location = new System.Drawing.Point(34, 166);
            this.roomno_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roomno_label.Name = "roomno_label";
            this.roomno_label.Size = new System.Drawing.Size(220, 37);
            this.roomno_label.TabIndex = 13;
            this.roomno_label.Text = "Room number";
            this.roomno_label.Visible = false;
            // 
            // roomamountLabel
            // 
            this.roomamountLabel.AutoSize = true;
            this.roomamountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomamountLabel.Location = new System.Drawing.Point(34, 282);
            this.roomamountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roomamountLabel.Name = "roomamountLabel";
            this.roomamountLabel.Size = new System.Drawing.Size(334, 37);
            this.roomamountLabel.TabIndex = 16;
            this.roomamountLabel.Text = "Amount of workplaces";
            this.roomamountLabel.Visible = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(34, 398);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(400, 37);
            this.locationLabel.TabIndex = 18;
            this.locationLabel.Text = "Location ZIP (eg. 3011WZ)";
            this.locationLabel.Visible = false;
            // 
            // location_zip
            // 
            this.location_zip.Location = new System.Drawing.Point(41, 441);
            this.location_zip.Margin = new System.Windows.Forms.Padding(6);
            this.location_zip.Name = "location_zip";
            this.location_zip.Size = new System.Drawing.Size(432, 31);
            this.location_zip.TabIndex = 5;
            this.location_zip.Visible = false;
            // 
            // housenoLabel
            // 
            this.housenoLabel.AutoSize = true;
            this.housenoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.housenoLabel.Location = new System.Drawing.Point(34, 520);
            this.housenoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.housenoLabel.Name = "housenoLabel";
            this.housenoLabel.Size = new System.Drawing.Size(353, 37);
            this.housenoLabel.TabIndex = 22;
            this.housenoLabel.Text = "Location house number";
            this.housenoLabel.Visible = false;
            // 
            // location_no
            // 
            this.location_no.Location = new System.Drawing.Point(41, 560);
            this.location_no.Name = "location_no";
            this.location_no.Size = new System.Drawing.Size(120, 31);
            this.location_no.TabIndex = 6;
            this.location_no.Visible = false;
            // 
            // locationnameLabel
            // 
            this.locationnameLabel.AutoSize = true;
            this.locationnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationnameLabel.Location = new System.Drawing.Point(34, 626);
            this.locationnameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.locationnameLabel.Name = "locationnameLabel";
            this.locationnameLabel.Size = new System.Drawing.Size(228, 37);
            this.locationnameLabel.TabIndex = 24;
            this.locationnameLabel.Text = "Location name";
            this.locationnameLabel.Visible = false;
            // 
            // location_name
            // 
            this.location_name.Location = new System.Drawing.Point(41, 669);
            this.location_name.Margin = new System.Windows.Forms.Padding(6);
            this.location_name.Name = "location_name";
            this.location_name.Size = new System.Drawing.Size(432, 31);
            this.location_name.TabIndex = 7;
            this.location_name.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(37, 728);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(436, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // workplaces
            // 
            this.workplaces.Location = new System.Drawing.Point(41, 325);
            this.workplaces.Margin = new System.Windows.Forms.Padding(6);
            this.workplaces.Name = "workplaces";
            this.workplaces.ReadOnly = true;
            this.workplaces.Size = new System.Drawing.Size(124, 31);
            this.workplaces.TabIndex = 25;
            this.workplaces.Visible = false;
            // 
            // room_no
            // 
            this.room_no.Location = new System.Drawing.Point(37, 209);
            this.room_no.Margin = new System.Windows.Forms.Padding(6);
            this.room_no.Name = "room_no";
            this.room_no.ReadOnly = true;
            this.room_no.Size = new System.Drawing.Size(124, 31);
            this.room_no.TabIndex = 26;
            this.room_no.Visible = false;
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1129);
            this.Controls.Add(this.room_no);
            this.Controls.Add(this.workplaces);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.location_name);
            this.Controls.Add(this.locationnameLabel);
            this.Controls.Add(this.location_no);
            this.Controls.Add(this.housenoLabel);
            this.Controls.Add(this.location_zip);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.roomamountLabel);
            this.Controls.Add(this.roomno_label);
            this.Controls.Add(this.dropdownRoom);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.locationDropdown);
            this.Controls.Add(this.label1);
            this.Name = "EditRoom";
            this.Text = "EditRoom";
            ((System.ComponentModel.ISupportInitialize)(this.location_no)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox locationDropdown;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.ComboBox dropdownRoom;
        private System.Windows.Forms.Label roomno_label;
        private System.Windows.Forms.Label roomamountLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox location_zip;
        private System.Windows.Forms.Label housenoLabel;
        private System.Windows.Forms.NumericUpDown location_no;
        private System.Windows.Forms.Label locationnameLabel;
        private System.Windows.Forms.TextBox location_name;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox workplaces;
        private System.Windows.Forms.TextBox room_no;
    }
}