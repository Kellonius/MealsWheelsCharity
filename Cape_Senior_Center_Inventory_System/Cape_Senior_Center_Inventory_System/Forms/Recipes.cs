using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cape_Senior_Center_Inventory_System.DTOs;

namespace Cape_Senior_Center_Inventory_System
{
    public partial class Recipes : Form
    {
        public Recipes()
        {
            InitializeComponent();
        }

        private void Recipes_Load(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Controls.Add(mainWindow.menuStrip);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label3.Text =
                    "Recipe for Bacon and Eggs\nIngredients:\nEggs: 1\nBacon: 1\n\nScramble Eggs medium heat for 4 minutes.\nBake Bacon at 375 for 17 minutes.";

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label3.Text =
                    "Recipe for Avocado Toast\nIngredients:\nBread: 2\nAvocado: 1\n\nToast Bread.\nSlice Avocado and place on toast.";

            }
        }
    }

}
