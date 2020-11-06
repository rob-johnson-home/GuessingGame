namespace GuessingGames.UI
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbGamesList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbGameType = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbGuessesRemaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbGamesList
            // 
            this.lbGamesList.FormattingEnabled = true;
            this.lbGamesList.ItemHeight = 20;
            this.lbGamesList.Location = new System.Drawing.Point(73, 353);
            this.lbGamesList.Name = "lbGamesList";
            this.lbGamesList.Size = new System.Drawing.Size(182, 64);
            this.lbGamesList.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 64);
            this.button1.TabIndex = 12;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.Color.YellowGreen;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(596, 194);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(131, 37);
            this.lbResult.TabIndex = 11;
            this.lbResult.Text = "Correct!";
            // 
            // lbGameType
            // 
            this.lbGameType.AutoSize = true;
            this.lbGameType.Location = new System.Drawing.Point(313, 118);
            this.lbGameType.Name = "lbGameType";
            this.lbGameType.Size = new System.Drawing.Size(228, 20);
            this.lbGameType.TabIndex = 10;
            this.lbGameType.Text = "Guessing a number from 1 - 10";
            // 
            // tbGuess
            // 
            this.tbGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuess.Location = new System.Drawing.Point(441, 191);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(100, 44);
            this.tbGuess.TabIndex = 9;
            this.tbGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGuess_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Your Guess";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Guessing Game";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Guesses Remaining";
            // 
            // lbGuessesRemaining
            // 
            this.lbGuessesRemaining.AutoSize = true;
            this.lbGuessesRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuessesRemaining.Location = new System.Drawing.Point(445, 262);
            this.lbGuessesRemaining.Name = "lbGuessesRemaining";
            this.lbGuessesRemaining.Size = new System.Drawing.Size(35, 37);
            this.lbGuessesRemaining.TabIndex = 16;
            this.lbGuessesRemaining.Text = "0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbGuessesRemaining);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbGamesList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbGameType);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGamesList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbGameType;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbGuessesRemaining;
    }
}