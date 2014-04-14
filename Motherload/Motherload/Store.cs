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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

        private void medium_tank_Click(object sender, EventArgs e)
        {
            global.select_storage = global.Ship.return_storage_cap();
            select_bay_size_lbl.Text = "";
            select_bay_price_lbl.Text = "";
            label9.Text = "";
            label10.Text = "";
            select_tank_liters_lbl.Text = "15 Liters";
            select_tank_price_lbl.Text = "$ 750";
            global.select_fuel = 15;
            global.select_value = 750;
        }

        private void huge_tank_Click(object sender, EventArgs e)
        {
            global.select_storage = global.Ship.return_storage_cap();
            select_bay_size_lbl.Text = "";
            select_bay_price_lbl.Text = "";
            label9.Text = "";
            label10.Text = "";
            select_tank_liters_lbl.Text = "25 Liters";
            select_tank_price_lbl.Text = "$ 3,000";
            global.select_fuel = 25;
            global.select_value = 3000;
        }

        private void gigantic_tank_Click(object sender, EventArgs e)
        {
            global.select_storage = global.Ship.return_storage_cap();
            select_bay_size_lbl.Text = "";
            select_bay_price_lbl.Text = "";
            label9.Text = "";
            label10.Text = "";
            select_tank_liters_lbl.Text = "40 Liters";
            select_tank_price_lbl.Text = "$ 10,000";
            global.select_fuel = 40;
            global.select_value = 10000;
        }

        private void titanic_tank_Click(object sender, EventArgs e)
        {
            global.select_storage = global.Ship.return_storage_cap();
            select_bay_size_lbl.Text = "";
            select_bay_price_lbl.Text = "";
            label9.Text = "";
            label10.Text = "";
            select_tank_liters_lbl.Text = "60 Liters";
            select_tank_price_lbl.Text = "$ 75,000";
            global.select_fuel = 60;
            global.select_value = 75000;
        }

        private void leviathan_tank_Click(object sender, EventArgs e)
        {
            global.select_storage = global.Ship.return_storage_cap();
            select_bay_size_lbl.Text = "";
            select_bay_price_lbl.Text = "";
            label9.Text = "";
            label10.Text = "";
            select_tank_liters_lbl.Text = "100 Liters";
            select_tank_price_lbl.Text = "$ 250,000";
            global.select_fuel = 100;
            global.select_value = 250000;
        }
        //========== Cargo Bay ==============
        private void medium_bay_Click(object sender, EventArgs e)
        {
            global.select_fuel = global.Ship.return_total_fuel();
            select_tank_liters_lbl.Text = "";
            select_tank_price_lbl.Text = "";
            label9.Text = "";
            label10.Text = "";
            select_bay_size_lbl.Text = "15 Cu ft.";
            select_bay_price_lbl.Text = "$ 750";
            global.select_storage = 15;
            global.select_value = 750;
        }

        private void huge_bay_Click(object sender, EventArgs e)
        {
            global.select_fuel = global.Ship.return_total_fuel();
            select_tank_liters_lbl.Text = "";
            select_tank_price_lbl.Text = "";
            label9.Text = "";
            label10.Text = "";
            select_bay_size_lbl.Text = "25 Cu ft.";
            select_bay_price_lbl.Text = "$ 3,000";
            global.select_storage = 25;
            global.select_value = 3000;
        }

        private void gigantic_bay_Click(object sender, EventArgs e)
        {
            global.select_fuel = global.Ship.return_total_fuel();
            select_tank_liters_lbl.Text = "";
            select_tank_price_lbl.Text = "";
            label9.Text = "";
            label10.Text = "";
            select_bay_size_lbl.Text = "40 Cu ft.";
            select_bay_price_lbl.Text = "$ 10,000";
            global.select_storage = 40;
            global.select_value = 10000;
        }

        private void titanic_bay_Click(object sender, EventArgs e)
        {
            global.select_fuel = global.Ship.return_total_fuel();
            select_tank_liters_lbl.Text = "";
            select_tank_price_lbl.Text = "";
            label9.Text = "";
            label10.Text = "";
            select_bay_size_lbl.Text = "40 Cu ft.";
            select_bay_price_lbl.Text = "$ 75,000";
            global.select_storage = 40;
            global.select_value = 75000;
        }

        private void levianthan_bay_Click(object sender, EventArgs e)
        {
            global.select_fuel = global.Ship.return_total_fuel();
            select_tank_liters_lbl.Text = "";
            select_tank_price_lbl.Text = "";
            label9.Text = "";
            label10.Text = "";
            select_bay_size_lbl.Text = "120 Cu ft.";
            select_bay_price_lbl.Text = "$ 250,000";
            global.select_storage = 120;
            global.select_value = 250000;
        }

        private void Store_Load(object sender, EventArgs e)
        {
            global.select_storage = 0;
            global.select_fuel = 0;
            init_current_labels();
        }
        public void init_current_labels() 
        {
            label3.Text = Convert.ToString(global.Ship.return_storage_cap());
            label4.Text = Convert.ToString(global.Ship.return_total_fuel());
            label5.Text = Convert.ToString(global.Ship.return_value());
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void purchase_item_Click(object sender, EventArgs e)
        {
            if (global.select_storage == 0 && global.select_value == 0)
            { 
                Nothing_Selected form = new Nothing_Selected();
                form.ShowDialog();
                return;
            }
            if (global.Ship.return_value() < global.select_value)
            {
                Not_Enough_Cash form = new Not_Enough_Cash();
                form.ShowDialog();
                return;
            }

            if (global.select_storage <= global.Ship.return_storage_cap() && global.select_fuel == global.Ship.return_total_fuel())
            { label10.Text = ""; label9.Text = "Cannot Purchase"; return; }
            if (global.select_fuel <= global.Ship.return_total_fuel() && global.select_storage == global.Ship.return_storage_cap())
            { label10.Text = ""; label9.Text = "Cannot Purchase"; return; }

            global.Ship.change_storage_cap(global.select_storage);
            global.Ship.change_totalFuel(global.select_fuel);
            global.Ship.change_value(global.select_value);
            label10.Text = "Purchased";

            init_current_labels();

        }
    }
}
