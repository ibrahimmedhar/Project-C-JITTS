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
                //
                string roomID = ((dropDownItem)dropdownRoom.SelectedItem).HiddenValue;
                FillFields(roomID);
            }
        }

        public void FillFields(string room_id)
        {
            roomno_label.Visible = true;
            room_no.Visible = true;

            roomamountLabel.Visible = true;
            workplaces.Visible = true;

            locationLabel.Visible = true;
            location_zip.Visible = true;

            housenoLabel.Visible = true;
            location_no.Visible = true;

            locationnameLabel.Visible = true;
            location_name.Visible = true;


            btnSave.Visible = true;
        }

        public void HideFields()
        {
            roomno_label.Visible = false;
            room_no.Visible = false;
            roomamountLabel.Visible = false;
            workplaces.Visible = false;
            locationLabel.Visible = false;
            location_zip.Visible = false;
            housenoLabel.Visible = false;
            location_no.Visible = false;
            locationnameLabel.Visible = false;
            location_name.Visible = false;
            btnSave.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
