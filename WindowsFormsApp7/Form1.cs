﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            double i, ok = 1;
            int n = 0;
            n = Convert.ToInt32(textBox1.Text);
            for (i = 2; i <= n / 2; i++)

            {
                if (n % i == 0)
                    ok = 0;
            }
            if (n <= 1)
            {
                ok = 0;
            }
        
           
            if (ok == 1)
            {
                BackColor = Color.Green;
            }
            else
            {
                BackColor = Color.Red;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char x = e.KeyChar;
            if (!char.IsDigit(x) && x != 8 && x != 46)
            {
                e.Handled = true;
                MessageBox.Show("Te rog, introdu un numar!");
                
            }
                    
                

        }
    }
}
