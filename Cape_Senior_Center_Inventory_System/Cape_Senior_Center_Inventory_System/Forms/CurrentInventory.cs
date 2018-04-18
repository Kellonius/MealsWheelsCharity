using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cape_Senior_Center_Inventory_System
{
    public partial class CurrentInventory : Form
    {
        public CurrentInventory()
        {
            InitializeComponent();
        }

        private void CurrentInventory_Load(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Controls.Add(mainWindow.menuStrip);


            dataGridView1.Rows.Add(3);
            dataGridView1.Rows[0].Cells[0].Value = "Bread";
            dataGridView1.Rows[0].Cells[1].Value = "Bunny";
            dataGridView1.Rows[0].Cells[2].Value = "042543262";
            dataGridView1.Rows[0].Cells[3].Style.BackColor = Color.Yellow;
            dataGridView1.Rows[0].Cells[3].Value = "10";

            dataGridView1.Rows[1].Cells[0].Value = "Chicken Breast";
            dataGridView1.Rows[1].Cells[1].Value = "Tyson";
            dataGridView1.Rows[1].Cells[2].Value = "9836563658";
            dataGridView1.Rows[1].Cells[3].Style.BackColor = Color.Red;
            dataGridView1.Rows[1].Cells[3].Value = "0";

            dataGridView1.Rows[2].Cells[0].Value = "Green Beans";
            dataGridView1.Rows[2].Cells[1].Value = "Green Giant";
            dataGridView1.Rows[2].Cells[2].Value = "087432762";
            dataGridView1.Rows[2].Cells[3].Style.BackColor = Color.Orange;
            dataGridView1.Rows[2].Cells[3].Value = "3";
        }
    }
}
