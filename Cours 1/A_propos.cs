﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours_1
{
    public partial class A_propos : Form
    {
        public A_propos()
        {
            InitializeComponent();
        }

        private void Confirmer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
