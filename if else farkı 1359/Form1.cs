﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_farkı_1359
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (rbRenk1.Checked)
            {
                this.BackColor =Color.Blue;
            }
            else if (rbRenk2.Checked)
            {
                this.BackColor = Color.Pink;

            }else if (rbRenk3.Checked)
            {
                this.BackColor=Color.Yellow;

            }else if (rbRenk4.Checked)
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
