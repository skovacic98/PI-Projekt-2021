﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindergartenJoy.Forme
{
    public partial class FormBiljeskaSpremljena : Form
    {
        public FormBiljeskaSpremljena()
        {
            InitializeComponent();
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
