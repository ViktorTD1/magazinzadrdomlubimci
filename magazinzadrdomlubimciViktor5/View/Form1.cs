﻿using magazinzadrdomlubimciViktor5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magazinzadrdomlubimciViktor5.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal exampledogs = new Animal(tboxName.Text, tboxDescription.Text, tboxAge.Text, tboxPrice);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
