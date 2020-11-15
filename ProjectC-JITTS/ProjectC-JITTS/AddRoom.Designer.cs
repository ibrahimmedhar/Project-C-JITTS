namespace ProjectC_JITTS
{
    partial class AddRoom
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.location_zip = new System.Windows.Forms.TextBox();
            this.locationzip_label = new System.Windows.Forms.Label();
            this.room_no = new System.Windows.Forms.NumericUpDown();
            this.location_name = new System.Windows.Forms.TextBox();
            this.locationname_label = new System.Windows.Forms.Label();
            this.locationno_label = new System.Windows.Forms.Label();
            this.location_no = new System.Windows.Forms.NumericUpDown();
            this.workplaces = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dropdownLocation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.room_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.location_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workplaces)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 645);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(436, 44);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Room number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Amount of workplaces";
            // 
            // location_zip
            // 
            this.location_zip.Location = new System.Drawing.Point(40, 392);
            this.location_zip.Margin = new System.Windows.Forms.Padding(6);
            this.location_zip.Name = "location_zip";
            this.location_zip.Size = new System.Drawing.Size(431, 31);
            this.location_zip.TabIndex = 4;
            // 
            // locationzip_label
            // 
            this.locationzip_label.AutoSize = true;
            this.locationzip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationzip_label.Location = new System.Drawing.Point(31, 346);
            this.locationzip_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.locationzip_label.Name = "locationzip_label";
            this.locationzip_label.Size = new System.Drawing.Size(400, 37);
            this.locationzip_label.TabIndex = 10;
            this.locationzip_label.Text = "Location ZIP (eg. 3011WZ)";
            // 
            // room_no
            // 
            this.room_no.Location = new System.Drawing.Point(40, 84);
            this.room_no.Name = "room_no";
            this.room_no.Size = new System.Drawing.Size(120, 31);
            this.room_no.TabIndex = 1;
            // 
            // location_name
            // 
            this.location_name.Location = new System.Drawing.Point(40, 588);
            this.location_name.Margin = new System.Windows.Forms.Padding(6);
            this.location_name.Name = "location_name";
            this.location_name.Size = new System.Drawing.Size(432, 31);
            this.location_name.TabIndex = 6;
            // 
            // locationname_label
            // 
            this.locationname_label.AutoSize = true;
            this.locationname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationname_label.Location = new System.Drawing.Point(32, 542);
            this.locationname_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.locationname_label.Name = "locationname_label";
            this.locationname_label.Size = new System.Drawing.Size(228, 37);
            this.locationname_label.TabIndex = 19;
            this.locationname_label.Text = "Location name";
            // 
            // locationno_label
            // 
            this.locationno_label.AutoSize = true;
            this.locationno_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationno_label.Location = new System.Drawing.Point(33, 438);
            this.locationno_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.locationno_label.Name = "locationno_label";
            this.locationno_label.Size = new System.Drawing.Size(353, 37);
            this.locationno_label.TabIndex = 21;
            this.locationno_label.Text = "Location house number";
            // 
            // location_no
            // 
            this.location_no.Location = new System.Drawing.Point(40, 494);
            this.location_no.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.location_no.Name = "location_no";
            this.location_no.Size = new System.Drawing.Size(120, 31);
            this.location_no.TabIndex = 5;
            // 
            // workplaces
            // 
            this.workplaces.Location = new System.Drawing.Point(41, 191);
            this.workplaces.Name = "workplaces";
            this.workplaces.Size = new System.Drawing.Size(120, 31);
            this.workplaces.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 37);
            this.label6.TabIndex = 22;
            this.label6.Text = "Location";
            // 
            // dropdownLocation
            // 
            this.dropdownLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownLocation.FormattingEnabled = true;
            this.dropdownLocation.Location = new System.Drawing.Point(41, 293);
            this.dropdownLocation.MaxDropDownItems = 3;
            this.dropdownLocation.Name = "dropdownLocation";
            this.dropdownLocation.Size = new System.Drawing.Size(433, 33);
            this.dropdownLocation.TabIndex = 23;
            this.dropdownLocation.SelectedIndexChanged += new System.EventHandler(this.dropdownLocation_SelectedIndexChanged);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1129);
            this.Controls.Add(this.dropdownLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.workplaces);
            this.Controls.Add(this.location_no);
            this.Controls.Add(this.locationno_label);
            this.Controls.Add(this.location_name);
            this.Controls.Add(this.locationname_label);
            this.Controls.Add(this.room_no);
            this.Controls.Add(this.location_zip);
            this.Controls.Add(this.locationzip_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            ((System.ComponentModel.ISupportInitialize)(this.room_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.location_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workplaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox location_zip;
        private System.Windows.Forms.Label locationzip_label;
        private System.Windows.Forms.NumericUpDown room_no;
        private System.Windows.Forms.TextBox location_name;
        private System.Windows.Forms.Label locationname_label;
        private System.Windows.Forms.Label locationno_label;
        private System.Windows.Forms.NumericUpDown location_no;
        private System.Windows.Forms.NumericUpDown workplaces;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dropdownLocation;
    }
}