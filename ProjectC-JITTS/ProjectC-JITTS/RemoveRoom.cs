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
    public partial class RemoveRoom : Form
    {
        public RemoveRoom()
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
            roomInfo.Text = "Selected room info:" +
            "\nLocation selected : " + locationDropdown.SelectedItem;

            dropdownRoom.Items.Clear();
            GetData GD = new GetData();
            if (locationDropdown.SelectedIndex > -1)
            {
                removeroomBtn.Visible = false;
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
            roomInfo.Text = "Selected room info:" +
            "\nLocation selected : " + locationDropdown.SelectedItem +
            "\nRoom Selected : " + dropdownRoom.SelectedItem;

            if (dropdownRoom.SelectedIndex > -1)
            {
                removeroomBtn.Visible = true;
            }
        }

        private void removeroomBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this room?", "Are you sure", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string roomID = ((dropDownItem)dropdownRoom.SelectedItem).HiddenValue;
                UpdateData UD = new UpdateData();
                if (UD.RemoveRoom(Int32.Parse(roomID)))
                {
                    MessageBox.Show("Succesfully removed the room");
                    this.Hide();
                    this.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Failed to remove the room");
            }
        }
    }
}
