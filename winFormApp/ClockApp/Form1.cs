﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("진자 닫을래?", "경고",
                MessageBoxDefaultButton.YESNO, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                e.cancel = false;       //취소를 안시켜서 종료
            }
            else
            {
                e.cancle = true;        //취소시키니깐 종료 안됨
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
