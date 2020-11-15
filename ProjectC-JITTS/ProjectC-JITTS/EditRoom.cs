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
    public partial class EditRoom : Form
    {
        public EditRoom()
        {
            InitializeComponent();

            GetData GD = new GetData();

            foreach (string location in GD.ShowLocations())
            {
                locationDropdown.Items.Add(location);
            }
            
            location_options.Items.Add("Keep old location");
            location_options.Items.Add("Change location..");
            location_options.SelectedIndex = 0;
        }

        private void locationDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideFields();
            dropdownRoom.Items.Clear();
            GetData GD = new GetData();
            if (locationDropdown.SelectedIndex > -1)
            {
                roomLabel.Visible = true;
                dropdownRoom.Visible = true;
                foreach (Tuple<string, string> roomnumberid in GD.ShowRoomNoByLocation(locationDropdown.SelectedItem.ToString()))
                {
                    dropdownRoom.Items.Add(new dropDownItem(roomnumberid.Item1, roomnumberid.Item2));
                }
            }
        }

        private void dropdownRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownRoom.SelectedIndex > -1)
            {
                string roomID = ((dropDownItem)dropdownRoom.SelectedItem).HiddenValue;
                FillFields(roomID);
            }
        }

        public void FillFields(string room_id)
        {
            GetData GD = new GetData();
            Tuple<string, string, string, string> roomInfobyID = GD.ShowRoomByID(Int32.Parse(room_id));

            roomno_label.Visible = true;
            room_no.Visible = true;
            room_no.Text = roomInfobyID.Item1;

            roomamountLabel.Visible = true;
            workplaces.Visible = true;
            workplaces.Value = Int32.Parse(roomInfobyID.Item2);

            optionsLabel.Visible = true;
            location_options.Visible = true;

            locationLabel.Visible = true;
            location_zip.Visible = true;
            location_zip.Text = roomInfobyID.Item3.Substring(0, 6);

            housenoLabel.Visible = true;
            location_no.Visible = true;
            location_no.Text = roomInfobyID.Item3.Substring(6);
            location_no.Controls[0].Visible = true;

            locationnameLabel.Visible = true;
            location_name.Visible = true;
            location_name.Text = roomInfobyID.Item4;

            btnSave.Visible = true;


        }

        public void HideFields()
        {
            roomno_label.Visible = false;
            room_no.Visible = false;
            roomamountLabel.Visible = false;
            workplaces.Visible = false;
            optionsLabel.Visible = false;
            location_options.Visible = false;
            locationLabel.Visible = false;
            location_zip.Visible = false;
            housenoLabel.Visible = false;
            location_no.Visible = false;
            locationnameLabel.Visible = false;
            location_name.Visible = false;
            btnSave.Visible = false;
        }

        public void UnlockFields()
        {
            location_zip.ReadOnly = false;
            location_no.ReadOnly = false;
            location_no.Controls[0].Visible = true;
            location_name.ReadOnly = false;
        }

        public void LockFields()
        {
            location_zip.ReadOnly = true;
            location_no.ReadOnly = true;
            location_no.Controls[0].Visible = false;
            location_name.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string roomID = ((dropDownItem)dropdownRoom.SelectedItem).HiddenValue;

            GetData GD = new GetData();
            Tuple<string, string, string, string> roomInfobyID = GD.ShowRoomByID(Int32.Parse(roomID));
            
            int oldamountwp = Int32.Parse(roomInfobyID.Item2);
            string addedworkplaces = (workplaces.Value - oldamountwp).ToString();
            UpdateData UD = new UpdateData();

            string roomlocation = location_zip.Text + location_no.Value.ToString();

            bool succesInsert = UD.EditRoom(addedworkplaces, roomlocation, location_name.Text, roomID);

            if (succesInsert)
            {
                MessageBox.Show("Saved changes");
            }
            else
            {
                MessageBox.Show("Failed to save changes");
            }

        }

        private void location_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (location_options.SelectedIndex > -1)
            {
                if (location_options.SelectedItem.ToString() == "Add new location..")
                {
                    UnlockFields();
                }
                else
                {
                    LockFields();
                }
            }
        }
    }
}
