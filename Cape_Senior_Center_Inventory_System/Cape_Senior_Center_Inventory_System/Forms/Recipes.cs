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
    }

}
