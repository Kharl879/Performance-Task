namespace WordGuessApplication
{
    partial class frmGuessWord
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblword = new Label();
            txtGuess = new TextBox();
            btnGuess = new Button();
            WrongGuesses = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblword
            // 
            lblword.AutoSize = true;
            lblword.BackColor = Color.DarkSeaGreen;
            lblword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblword.Location = new Point(216, 69);
            lblword.Name = "lblword";
            lblword.Size = new Size(66, 21);
            lblword.TabIndex = 0;
            lblword.Text = "c??????r";
            // 
            // txtGuess
            // 
            txtGuess.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuess.Location = new Point(86, 142);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(332, 33);
            txtGuess.TabIndex = 1;
            // 
            // btnGuess
            // 
            btnGuess.BackColor = Color.DarkSeaGreen;
            btnGuess.FlatStyle = FlatStyle.Flat;
            btnGuess.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuess.ForeColor = Color.White;
            btnGuess.Location = new Point(187, 201);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(117, 53);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = false;
            btnGuess.Click += btnGuess_Click;
            // 
            // WrongGuesses
            // 
            WrongGuesses.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WrongGuesses.FormattingEnabled = true;
            WrongGuesses.ItemHeight = 20;
            WrongGuesses.Location = new Point(562, 49);
            WrongGuesses.Name = "WrongGuesses";
            WrongGuesses.Size = new Size(104, 224);
            WrongGuesses.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSeaGreen;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(562, 14);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 4;
            label1.Text = "Wrong Guess";
            // 
            // frmGuessWord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 296);
            Controls.Add(label1);
            Controls.Add(WrongGuesses);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(lblword);
            Name = "frmGuessWord";
            Text = "Guess the Word";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblword;
        private TextBox txtGuess;
        private Button btnGuess;
        private ListBox WrongGuesses;
        private Label label1;
    }
}
