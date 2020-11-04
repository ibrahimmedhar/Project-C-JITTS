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
    public partial class AddDate : Form
    {
        public AddDate()
        {
            InitializeComponent();


            
            GetData GD = new GetData();

            foreach (string location in GD.ShowLocations())
            {
                dropdownLocation.Items.Add(location);
            }

        }
        public void datePicker_ValueChanged(object sender, EventArgs e)
        {
            roomInfo.Text = "Selected room info:" +
                "\nDate selected : " + datePicker.Value.ToString("dd-MM-yyyy");
        }

        private void dropdownLocation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            roomInfo.Text = "Selected room info:" +
                "\nDate selected : " + datePicker.Value.ToString("dd-MM-yyyy") +
            "\nLocation selected : " + dropdownLocation.SelectedItem;

            dropdownRoom.Items.Clear();
            GetData GD = new GetData();
            if (dropdownLocation.SelectedIndex > -1)
            {
                dropdownRoom.Visible = true;
                foreach (Tuple<string, string> roomnumberid in GD.ShowRoomNoByLocation(dropdownLocation.SelectedItem.ToString()))
                {
                    dropdownRoom.Items.Add(new dropDownItem(roomnumberid.Item1, roomnumberid.Item2));
                }
            }
        }
        private void dropdownRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomInfo.Text = "Selected room info:" +
                "\nDate selected : " + datePicker.Value.ToString("dd-MM-yyyy") +
            "\nLocation selected : " + dropdownLocation.SelectedItem +
            "\nRoom number selected : " + dropdownRoom.SelectedItem;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetData GD = new GetData();
            AddData AD = new AddData();

            string sqlFormattedDate = datePicker.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //check if a room is selected. if not this means that also a location cannot be selected
            if (dropdownRoom.SelectedIndex > -1)
            {
                string roomID = ((dropDownItem)dropdownRoom.SelectedItem).HiddenValue;
                Tuple<string, string, string, string> roomInfobyID = GD.ShowRoomByID(Int32.Parse(roomID));
                
                string workplacesavailable = roomInfobyID.Item2;

                if (AD.AddDateWithRoom(workplacesavailable, sqlFormattedDate, roomID))
                {
                    MessageBox.Show("Date added succesfully");
                    this.Hide();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all values");
            }
        }
    }
}
