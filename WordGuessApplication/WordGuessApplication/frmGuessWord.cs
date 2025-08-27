using System;
using System.Text;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        private string wordToGuess = "computer";
        private StringBuilder maskedWord;

        public frmGuessWord()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedWord = new StringBuilder();

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (i == 0 || i == wordToGuess.Length - 1)
                    maskedWord.Append(wordToGuess[i]);
                else
                    maskedWord.Append('?');
            }

            lblword.Text = maskedWord.ToString();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(guess))
                return;

            if (guess == wordToGuess)
            {
                lblword.Text = wordToGuess;
                lblword.BackColor = System.Drawing.Color.Green;
                lblword.ForeColor = System.Drawing.Color.White;
                btnGuess.Enabled = false;
            }
            else
            {
                WrongGuesses.Items.Add(guess);
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }
    }
}
