namespace ProjectC_JITTS
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.nameSwitch = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.surnameSwitch = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.emailSwitch = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // nameSwitch
            // 
            this.nameSwitch.BackColor = System.Drawing.Color.Transparent;
            this.nameSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameSwitch.BackgroundImage")));
            this.nameSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nameSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameSwitch.Location = new System.Drawing.Point(9, 62);
            this.nameSwitch.Name = "nameSwitch";
            this.nameSwitch.OffColor = System.Drawing.Color.Gray;
            this.nameSwitch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.nameSwitch.Size = new System.Drawing.Size(43, 25);
            this.nameSwitch.TabIndex = 0;
            this.nameSwitch.Value = false;
            this.nameSwitch.OnValueChange += new System.EventHandler(this.nameSwitch_OnValueChange);
            // 
            // surnameSwitch
            // 
            this.surnameSwitch.BackColor = System.Drawing.Color.Transparent;
            this.surnameSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("surnameSwitch.BackgroundImage")));
            this.surnameSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.surnameSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.surnameSwitch.Location = new System.Drawing.Point(9, 112);
            this.surnameSwitch.Name = "surnameSwitch";
            this.surnameSwitch.OffColor = System.Drawing.Color.Gray;
            this.surnameSwitch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.surnameSwitch.Size = new System.Drawing.Size(43, 25);
            this.surnameSwitch.TabIndex = 1;
            this.surnameSwitch.Value = false;
            this.surnameSwitch.OnValueChange += new System.EventHandler(this.surnameSwitch_OnValueChange);
            // 
            // emailSwitch
            // 
            this.emailSwitch.BackColor = System.Drawing.Color.Transparent;
            this.emailSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emailSwitch.BackgroundImage")));
            this.emailSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emailSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailSwitch.Location = new System.Drawing.Point(9, 162);
            this.emailSwitch.Name = "emailSwitch";
            this.emailSwitch.OffColor = System.Drawing.Color.Gray;
            this.emailSwitch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.emailSwitch.Size = new System.Drawing.Size(43, 25);
            this.emailSwitch.TabIndex = 2;
            this.emailSwitch.Value = false;
            this.emailSwitch.OnValueChange += new System.EventHandler(this.emailSwitch_OnValueChange);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(59, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(370, 25);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSurname
            // 
            this.txtSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurname.Enabled = false;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSurname.HintForeColor = System.Drawing.Color.Empty;
            this.txtSurname.HintText = "";
            this.txtSurname.isPassword = false;
            this.txtSurname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSurname.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSurname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSurname.LineThickness = 3;
            this.txtSurname.Location = new System.Drawing.Point(59, 112);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(370, 25);
            this.txtSurname.TabIndex = 5;
            this.txtSurname.Text = "surname";
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(59, 162);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(370, 25);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.MediumPurple;
            this.btnEdit.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "EDIT USER";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEdit.Iconimage")));
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 90D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(588, 305);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnEdit.OnHovercolor = System.Drawing.Color.MediumPurple;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(148, 32);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "EDIT USER";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 349);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.emailSwitch);
            this.Controls.Add(this.surnameSwitch);
            this.Controls.Add(this.nameSwitch);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuiOSSwitch nameSwitch;
        private Bunifu.Framework.UI.BunifuiOSSwitch surnameSwitch;
        private Bunifu.Framework.UI.BunifuiOSSwitch emailSwitch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSurname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
    }
}