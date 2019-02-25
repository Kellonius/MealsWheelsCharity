using Cape_Senior_Center_Inventory_System.DataContext.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.Entity;

namespace Cape_Senior_Center_Inventory_System.Forms
{
    public partial class UserPreferences : Form
    {
        public DataContext.DataContext context = new DataContext.DataContext();

        public UserPreferences()
        {
            InitializeComponent();
        }

        #region Load

        private void UserPreferences_Load(object sender, EventArgs e)
        {
            //get existing preferences
            var preferences = context.Preferences;
            var defaultPreferences = context.Preferences.FirstOrDefault(x => x.isDefault);

            //Declare types for drop down
            List<string> types = new List<string>();
            types.Add("All");
            types.Add("Frozen, Cooler");
            types.Add("Frozen, Dry");
            types.Add("Cooler, Dry");
            types.Add("Frozen");
            types.Add("Cooler");
            types.Add("Dry");

            //Current Inventory Control
            currentInventoryDropDown.SelectedIndex = 0;
            oneDrop.Items.AddRange(types.ToArray());
            twoDrop.Items.AddRange(types.ToArray());
            threeDrop.Items.AddRange(types.ToArray());
            fourDrop.Items.AddRange(types.ToArray());
            oneDrop.SelectedIndex = 0;

            //Master Inventry Controls
            masterInventoryDropDown.SelectedIndex = 0;
            masterOneDrop.Items.AddRange(types.ToArray());
            masterTwoDrop.Items.AddRange(types.ToArray());
            masterThreeDrop.Items.AddRange(types.ToArray());
            masterFourDrop.Items.AddRange(types.ToArray());
            masterOneDrop.SelectedIndex = 0;

            var savedNames = context.Preferences.Select(x => x.PreferencesName).ToArray();
            preferencesNameBox.Items.AddRange(savedNames);

            if (defaultPreferences == null)
            {
                return;
            }
            else
            {

                preferencesNameBox.Text = defaultPreferences.PreferencesName;
                defaultCheckBox.Checked = true;

                currentInventoryDropDown.SelectedIndex = defaultPreferences.NumCurrentGrids;
                oneDrop.Text = defaultPreferences.CurrentColumnOne;
                twoDrop.Text = defaultPreferences.CurrentColumnTwo;
                threeDrop.Text = defaultPreferences.CurrentColumnThree;
                fourDrop.Text = defaultPreferences.CurrentColumnFour;

                masterInventoryDropDown.SelectedIndex = defaultPreferences.NumMasterGrids;
                masterOneDrop.Text = defaultPreferences.MasterColumnOne;
                masterTwoDrop.Text = defaultPreferences.MasterColumnTwo;
                masterThreeDrop.Text = defaultPreferences.MasterColumnThree;
                masterFourDrop.Text = defaultPreferences.MasterColumnFour;

            }
        }

        #endregion

        #region DropdownControls

        private void currentInventoryDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var caseSwitch = currentInventoryDropDown.SelectedIndex;
            switch (caseSwitch)
            {
                case 0:
                    currentInventoryImage.Image = Cape_Senior_Center_Inventory_System.Properties.Resources.one;
                    oneDrop.Enabled = false;
                    twoDrop.Visible = false;
                    threeDrop.Visible = false;
                    fourDrop.Visible = false;
                    twoLabel.Visible = true;
                    threeLabel.Visible = false;
                    fourLabel.Visible = false;
                    twoLabel.Visible = false;
                    threeLabel.Visible = false;
                    fourLabel.Visible = false;
                    break;
                case 1:
                    currentInventoryImage.Image = Cape_Senior_Center_Inventory_System.Properties.Resources.two;
                    oneDrop.Enabled = true;
                    twoDrop.Visible = true;
                    threeDrop.Visible = false;
                    fourDrop.Visible = false;
                    twoLabel.Visible = true;
                    threeLabel.Visible = false;
                    fourLabel.Visible = false;
                    break;
                case 2:
                    currentInventoryImage.Image = Cape_Senior_Center_Inventory_System.Properties.Resources.three;
                    oneDrop.Enabled = true;
                    twoDrop.Visible = true;
                    threeDrop.Visible = true;
                    fourDrop.Visible = false;
                    twoLabel.Visible = true;
                    threeLabel.Visible = true;
                    fourLabel.Visible = false;
                    break;
                case 3:
                    currentInventoryImage.Image = Cape_Senior_Center_Inventory_System.Properties.Resources.four;
                    oneDrop.Enabled = true;
                    twoDrop.Visible = true;
                    threeDrop.Visible = true;
                    fourDrop.Visible = true;
                    twoLabel.Visible = true;
                    threeLabel.Visible = true;
                    fourLabel.Visible = true;
                    break;
            }
        }

        private void masterInventoryDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var caseSwitch = masterInventoryDropDown.SelectedIndex;
            switch (caseSwitch)
            {
                case 0:
                    masterImage.Image = Cape_Senior_Center_Inventory_System.Properties.Resources.one;
                    masterOneDrop.Enabled = false;
                    masterTwoDrop.Visible = false;
                    masterThreeDrop.Visible = false;
                    masterFourDrop.Visible = false;
                    masterTwoLabel.Visible = true;
                    masterThreeLabel.Visible = false;
                    masterFourLabel.Visible = false;
                    masterTwoLabel.Visible = false;
                    masterThreeLabel.Visible = false;
                    masterFourLabel.Visible = false;
                    break;
                case 1:
                    masterImage.Image = Cape_Senior_Center_Inventory_System.Properties.Resources.two;
                    masterOneDrop.Enabled = true;
                    masterTwoDrop.Visible = true;
                    masterThreeDrop.Visible = false;
                    masterFourDrop.Visible = false;
                    masterTwoLabel.Visible = true;
                    masterThreeLabel.Visible = false;
                    masterFourLabel.Visible = false;
                    break;
                case 2:
                    masterImage.Image = Cape_Senior_Center_Inventory_System.Properties.Resources.three;
                    masterOneDrop.Enabled = true;
                    masterTwoDrop.Visible = true;
                    masterThreeDrop.Visible = true;
                    masterFourDrop.Visible = false;
                    masterTwoLabel.Visible = true;
                    masterThreeLabel.Visible = true;
                    masterFourLabel.Visible = false;
                    break;
                case 3:
                    masterImage.Image = Cape_Senior_Center_Inventory_System.Properties.Resources.four;
                    masterOneDrop.Enabled = true;
                    masterTwoDrop.Visible = true;
                    masterThreeDrop.Visible = true;
                    masterFourDrop.Visible = true;
                    masterTwoLabel.Visible = true;
                    masterThreeLabel.Visible = true;
                    masterFourLabel.Visible = true;
                    break;
            }
        }

        #endregion

        #region Buttons

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var saveName = preferencesNameBox.Text;
            Preferences newPreferences = new Preferences();

            // if default remove all others

            if (defaultCheckBox.Checked)
            {
                context.Preferences.ToList().ForEach(c => c.isDefault = false);
            }

            //check for existing name
            var preferencesExists = context.Preferences.Any(x => x.PreferencesName == saveName);
            if (preferencesExists)
            {
                var existingPreferences = context.Preferences.FirstOrDefault(x => x.PreferencesName == saveName);
                existingPreferences.CurrentColumnOne = oneDrop.Text;
                existingPreferences.CurrentColumnTwo = twoDrop.Text;
                existingPreferences.CurrentColumnThree = threeDrop.Text;
                existingPreferences.CurrentColumnFour = fourDrop.Text;

                existingPreferences.MasterColumnOne = masterOneDrop.Text;
                existingPreferences.MasterColumnTwo = masterTwoDrop.Text;
                existingPreferences.MasterColumnThree = masterThreeDrop.Text;
                existingPreferences.MasterColumnFour = masterFourDrop.Text;

                existingPreferences.PreferencesName = preferencesNameBox.Text.Trim();

                existingPreferences.NumCurrentGrids = currentInventoryDropDown.SelectedIndex;
                existingPreferences.NumMasterGrids = masterInventoryDropDown.SelectedIndex;
                existingPreferences.isDefault = defaultCheckBox.Checked;
                context.Entry(existingPreferences).State = EntityState.Modified;
                context.SaveChanges();
            }
            else
            {
                //add new
                newPreferences.CurrentColumnOne = oneDrop.Text;
                newPreferences.CurrentColumnTwo = twoDrop.Text;
                newPreferences.CurrentColumnThree = threeDrop.Text;
                newPreferences.CurrentColumnFour = fourDrop.Text;

                newPreferences.MasterColumnOne = masterOneDrop.Text;
                newPreferences.MasterColumnTwo = masterTwoDrop.Text;
                newPreferences.MasterColumnThree = masterThreeDrop.Text;
                newPreferences.MasterColumnFour = masterFourDrop.Text;

                newPreferences.PreferencesName = preferencesNameBox.Text.Trim();

                newPreferences.NumCurrentGrids = currentInventoryDropDown.SelectedIndex;
                newPreferences.NumMasterGrids = masterInventoryDropDown.SelectedIndex;
                newPreferences.isDefault = defaultCheckBox.Checked;
                context.Preferences.Add(newPreferences);
                context.SaveChanges();
            }

          

         

        }

        #endregion

        private void preferencesNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var preferences = context.Preferences.FirstOrDefault(x => x.PreferencesName == preferencesNameBox.Text);

            if (preferences == null)
                return;

            preferencesNameBox.Text = preferences.PreferencesName;
            defaultCheckBox.Checked = preferences.isDefault;

            currentInventoryDropDown.SelectedIndex = preferences.NumCurrentGrids;
            oneDrop.Text = preferences.CurrentColumnOne;
            twoDrop.Text = preferences.CurrentColumnTwo;
            threeDrop.Text = preferences.CurrentColumnThree;
            fourDrop.Text = preferences.CurrentColumnFour;

            masterInventoryDropDown.SelectedIndex = preferences.NumMasterGrids;
            masterOneDrop.Text = preferences.MasterColumnOne;
            masterTwoDrop.Text = preferences.MasterColumnTwo;
            masterThreeDrop.Text = preferences.MasterColumnThree;
            masterFourDrop.Text = preferences.MasterColumnFour;

            deleteButton.Enabled = true;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this user profile? This cannot be undone!", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                var itemToDelete =
                    context.Preferences.FirstOrDefault(x => x.PreferencesName == preferencesNameBox.Text);
                context.Preferences.Remove(itemToDelete);
                context.SaveChanges();
                refresh(false);
            }
        }

        private void refresh(bool clear)
        {
            //get existing preferences
            var preferences = context.Preferences;
            var defaultPreferences = context.Preferences.FirstOrDefault(x => x.isDefault);

            preferencesNameBox.Text = "";
            preferencesNameBox.Items.Clear();
            var savedNames = context.Preferences.Select(x => x.PreferencesName).ToArray();
            preferencesNameBox.Items.AddRange(savedNames);

            if (defaultPreferences == null || clear)
            {
                currentInventoryDropDown.SelectedIndex = 0;
                oneDrop.SelectedIndex = 0;
                twoDrop.Text = "";
                twoDrop.Hide();
                threeDrop.Text = "";
                threeDrop.Hide();
                fourDrop.Text = "";
                fourDrop.Hide();

                masterInventoryDropDown.SelectedIndex = 0;
                masterOneDrop.SelectedIndex = 0;
                masterTwoDrop.Text = "";
                masterTwoDrop.Hide();
                masterThreeDrop.Text = "";
                masterThreeDrop.Hide();
                masterFourDrop.Text = "";
                masterFourDrop.Hide();
                defaultCheckBox.Checked = false;

            }
            else
            {

                preferencesNameBox.Text = defaultPreferences.PreferencesName;
                defaultCheckBox.Checked = true;

                currentInventoryDropDown.SelectedIndex = defaultPreferences.NumCurrentGrids;
                oneDrop.Text = defaultPreferences.CurrentColumnOne;
                twoDrop.Text = defaultPreferences.CurrentColumnTwo;
                threeDrop.Text = defaultPreferences.CurrentColumnThree;
                fourDrop.Text = defaultPreferences.CurrentColumnFour;

                masterInventoryDropDown.SelectedIndex = defaultPreferences.NumMasterGrids;
                masterOneDrop.Text = defaultPreferences.MasterColumnOne;
                masterTwoDrop.Text = defaultPreferences.MasterColumnTwo;
                masterThreeDrop.Text = defaultPreferences.MasterColumnThree;
                masterFourDrop.Text = defaultPreferences.MasterColumnFour;

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            refresh(true);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var saveName = Interaction.InputBox("Enter a name for your profile", "Add New Profile", "");
            if (saveName != string.Empty)
            {
                refresh(true);
                preferencesNameBox.Items.Add(saveName);
                preferencesNameBox.SelectedIndex = preferencesNameBox.Items.Count - 1;
            }
        }
    }
}
