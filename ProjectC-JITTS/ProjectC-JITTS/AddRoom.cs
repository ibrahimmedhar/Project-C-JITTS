using System;
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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddData AD = new AddData();
            bool succesInsert;

            string roomlocation = location_zip.Text + location_no.Value.ToString();
            
            succesInsert = AD.AddRoom(Int32.Parse(room_no.Value.ToString()), Int32.Parse(workplaces.Value.ToString()), roomlocation, location_name.Text);
            
            if (succesInsert)
            {
                MessageBox.Show("Room was added");
                /*Home home = new Home();
                home.Initialize();*/
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Room was not added");
            }

        }
    }
}
