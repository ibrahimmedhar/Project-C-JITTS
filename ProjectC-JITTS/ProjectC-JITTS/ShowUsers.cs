using ProjectC_JITTS.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectC_JITTS
{
    public partial class ShowUsers : Form
    {
        public ShowUsers()
        {
            InitializeComponent();

            DataGridView dta = new DataGridView();
            dta.Width = this.Width - 100;
            dta.Height = this.Height;
            dta.Location = new Point(0,0);

            AddToDTA();

            this.Controls.Add(dta);
            
        }

        public void AddToDTA()
        {

        }
    }
}
