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
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }

        private void Bank_Load(object sender, EventArgs e)
        {
            init_labels();
            total_lbl.Text = Convert.ToString(global.Ship.calc_value());  
        }
        public void init_labels()
        {
            for (int i = 0; i <= 9; ++i)
            {
                global.arr[i] = global.Ship._elementArr[i];
            }
            current_money.Text = Convert.ToString(global.Ship.return_value());
            iron_qty.Text = Convert.ToString(global.arr[0]);
            bronze_qty.Text = Convert.ToString(global.arr[1]);
            silver_qty.Text = Convert.ToString(global.arr[2]);
            gold_qty.Text = Convert.ToString(global.arr[3]);
            platinum_qty.Text = Convert.ToString(global.arr[4]);
            einsteinium_qty.Text = Convert.ToString(global.arr[5]);
            emerald_qty.Text = Convert.ToString(global.arr[6]);
            ruby_qty.Text = Convert.ToString(global.arr[7]);
            diamond_qty.Text = Convert.ToString(global.arr[8]);
            mystery_qty.Text = Convert.ToString(global.arr[9]);
            //===============================================
            iron_total.Text = Convert.ToString(global.arr[0] * 30);
            bronze_total.Text = Convert.ToString(global.arr[1] * 60);
            silver_total.Text = Convert.ToString(global.arr[2] * 100);
            gold_total.Text = Convert.ToString(global.arr[3] * 250);
            platinum_total.Text = Convert.ToString(global.arr[4] * 750);
            einsteinium_total.Text = Convert.ToString(global.arr[5] * 2000);
            emerald_total.Text = Convert.ToString(global.arr[6] * 5000);
            ruby_total.Text = Convert.ToString(global.arr[7] * 20000);
            diamond_total.Text = Convert.ToString(global.arr[8] * 40000);
            mystery_total.Text = Convert.ToString(global.arr[9] * 100000);
        }

        private void sell_all_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void sell_all_lbl_Click(object sender, EventArgs e)
        {
            global.Ship.set_value();
            global.Ship.clear_Element_Array();
            global.Ship.clear_Storage();
            init_labels();
            total_lbl.Text = "0";
        }



    }
}
