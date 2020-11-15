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

            GetData GD = new GetData();

            foreach (string location in GD.ShowLocations())
            {
                dropdownLocation.Items.Add(location);
            }

            dropdownLocation.Items.Add("Add new location..");
        }

        public void LockFields()
        {
            GetData GD = new GetData();
            string locationname = GD.ShowLocationInfoByLocation(dropdownLocation.SelectedItem.ToString());

            location_zip.ReadOnly = true;
            location_zip.Text = dropdownLocation.SelectedItem.ToString().Substring(0,6);

            location_no.ReadOnly = true;
            location_no.Value = Int32.Parse(dropdownLocation.SelectedItem.ToString().Substring(6));
            location_no.Controls[0].Visible = false;

            location_name.ReadOnly = true;
            location_name.Text = locationname;

        }

        public void UnlockFields()
        {
            location_zip.Text = "";
            location_zip.ReadOnly = false;
            location_no.Value = 0;
            location_no.ReadOnly = false;
            location_no.Controls[0].Visible = true;
            location_name.Text = "";
            location_name.ReadOnly = false;
        }

        private void dropdownLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownLocation.SelectedIndex > -1)
            {
                if (dropdownLocation.SelectedItem.ToString() == "Add new location..")
                {
                    UnlockFields();
                }
                else 
                {
                    LockFields();
                }
            }
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
