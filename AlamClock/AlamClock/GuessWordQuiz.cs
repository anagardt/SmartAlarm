﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class GuessWordQuiz : Form
    {
        public static string[] words =
        {
            "coffee",
            "alarm",
            "sun",
            "shine",
            "work",
            "schedule"
        };

        public GuessWordQuiz()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        /*
         * 
         * Game implemented here
         * 
         */

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
