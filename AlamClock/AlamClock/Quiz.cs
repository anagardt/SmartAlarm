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
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void wordQuess_Click(object sender, EventArgs e)
        {
            GuessWordQuiz guessWordQuiz = new GuessWordQuiz();
            DialogResult dialogResult = guessWordQuiz.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                guessWordQuiz.Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void equation_Click(object sender, EventArgs e)
        {
            SolveEquation solveEquation = new SolveEquation();
            DialogResult dialogResult = solveEquation.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                solveEquation.Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void numbrGuess_Click(object sender, EventArgs e)
        {
            GuessNumberQuiz guessNumberQuiz = new GuessNumberQuiz();
            DialogResult dialogResult = guessNumberQuiz.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                guessNumberQuiz.Close();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
