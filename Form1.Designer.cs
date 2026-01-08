namespace Tic_Tac_Game
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(48, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayerTurn.Location = new System.Drawing.Point(57, 140);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(141, 33);
            this.lblPlayerTurn.TabIndex = 2;
            this.lblPlayerTurn.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(57, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(57, 251);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(193, 33);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(63, 318);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(120, 45);
            this.btnRestartGame.TabIndex = 5;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.Image = global::Tic_Tac_Game.Properties.Resources.question_mark_96;
            this.btn9.Location = new System.Drawing.Point(642, 318);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(83, 96);
            this.btn9.TabIndex = 19;
            this.btn9.Tag = "256";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.Image = global::Tic_Tac_Game.Properties.Resources.question_mark_96;
            this.btn7.Location = new System.Drawing.Point(353, 318);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(83, 96);
            this.btn7.TabIndex = 18;
            this.btn7.Tag = "64";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.Image = global::Tic_Tac_Game.Properties.Resources.question_mark_96;
            this.btn8.Location = new System.Drawing.Point(494, 318);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(83, 96);
            this.btn8.TabIndex = 17;
            this.btn8.Tag = "128";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.Image = global::Tic_Tac_Game.Properties.Resources.question_mark_96;
            this.btn6.Location = new System.Drawing.Point(642, 195);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(83, 96);
            this.btn6.TabIndex = 16;
            this.btn6.Tag = "32";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.Image = global::Tic_Tac_Game.Properties.Resources.question_mark_96;
            this.btn4.Location = new System.Drawing.Point(353, 195);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(83, 96);
            this.btn4.TabIndex = 15;
            this.btn4.Tag = "8";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.Image = global::Tic_Tac_Game.Properties.Resources.question_mark_96;
            this.btn5.Location = new System.Drawing.Point(494, 195);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(83, 96);
            this.btn5.TabIndex = 14;
            this.btn5.Tag = "16";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.Image = global::Tic_Tac_Game.Properties.Resources.question_mark_96;
            this.btn3.Location = new System.Drawing.Point(642, 77);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(83, 96);
            this.btn3.TabIndex = 13;
            this.btn3.Tag = "4";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Image = global::Tic_Tac_Game.Properties.Resources.question_mark_96;
            this.btn1.Location = new System.Drawing.Point(353, 77);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(83, 96);
            this.btn1.TabIndex = 12;
            this.btn1.Tag = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Image = global::Tic_Tac_Game.Properties.Resources.question_mark_96;
            this.btn2.Location = new System.Drawing.Point(494, 77);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(83, 96);
            this.btn2.TabIndex = 8;
            this.btn2.Tag = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
    }
}

