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
    public partial class Fuel_Station : Form
    {
        public Fuel_Station()
        {
            InitializeComponent();
        }

        public void init_fuel_labels()
        {   
            int num1 = global.Ship.current_fuel_level();
            label3.Text = Convert.ToString(num1);
            int num2 = global.Ship.total_fuel_level();
            label4.Text = Convert.ToString(num2);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            currentFuel_label.Text = ("");
            init_fuel_labels();
            //Convert.ToString(global.Ship.current_fuel_level);
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            global.Ship.refuel(5);
            init_fuel_labels();
        }

        private void ten_button_Click(object sender, EventArgs e)
        {
            global.Ship.refuel(10);
            init_fuel_labels();
        }

        private void twentyfive_button_Click(object sender, EventArgs e)
        {
            global.Ship.refuel(25);
            init_fuel_labels();
        }

        private void fifty_button_Click(object sender, EventArgs e)
        {
            global.Ship.refuel(50);
            init_fuel_labels();
        }

        private void fill_tank_button_Click(object sender, EventArgs e)
        {
            global.Ship.fill_tank();
            init_fuel_labels();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }





    }
}
