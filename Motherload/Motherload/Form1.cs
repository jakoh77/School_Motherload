using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Motherload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void load_refuel_Click(object sender, EventArgs e)
        {
            Fuel_Station form = new Fuel_Station();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShipDude Ship = new ShipDude();
        }

        private void load_bank_Click(object sender, EventArgs e)
        {
            Bank form = new Bank();
            form.ShowDialog();
        }

        private void load_store_Click(object sender, EventArgs e)
        {
            Store form = new Store();
            form.ShowDialog();
        }
    }
}
