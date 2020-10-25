﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectC_JITTS.Database;

namespace ProjectC_JITTS
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();

			Button AddUserButton = new Button();
			AddUserButton.Width = 150;
			AddUserButton.Height = 50;
			AddUserButton.Location = new Point(10, 50);
			AddUserButton.Text = "Add user";

			AddUser AU = new AddUser();

			AddUserButton.Click += (s, p) => {
				this.Hide();
				AU.ShowDialog();
				this.Close();
			};

			this.Controls.Add(AddUserButton);
		}
    }
}
