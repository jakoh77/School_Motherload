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
    public partial class you_filled_up : Form
    {
        public you_filled_up()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void you_filled_up_Load(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(global.temp);
        }


    }
}
