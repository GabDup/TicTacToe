namespace TicTacToe
{
    partial class TicTacToe
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn3x3 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.grbTicTacToe3x3 = new System.Windows.Forms.GroupBox();
            this.grbTicTacToe3x3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn3x3
            // 
            this.btn3x3.Location = new System.Drawing.Point(12, 12);
            this.btn3x3.Name = "btn3x3";
            this.btn3x3.Size = new System.Drawing.Size(149, 110);
            this.btn3x3.TabIndex = 0;
            this.btn3x3.Text = "3x3";
            this.btn3x3.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 319);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 110);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(16, 16);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 55);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "-";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.tour);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(77, 16);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 55);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "-";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.tour);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(138, 16);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 55);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "-";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.tour);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(16, 77);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 55);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "-";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.tour);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(77, 77);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 55);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "-";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.tour);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(138, 77);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 55);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "-";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.tour);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(16, 138);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 55);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "-";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.tour);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(77, 138);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 55);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "-";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.tour);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(138, 138);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 55);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "-";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.tour);
            // 
            // grbTicTacToe3x3
            // 
            this.grbTicTacToe3x3.Controls.Add(this.btn5);
            this.grbTicTacToe3x3.Controls.Add(this.btn9);
            this.grbTicTacToe3x3.Controls.Add(this.btn1);
            this.grbTicTacToe3x3.Controls.Add(this.btn8);
            this.grbTicTacToe3x3.Controls.Add(this.btn2);
            this.grbTicTacToe3x3.Controls.Add(this.btn7);
            this.grbTicTacToe3x3.Controls.Add(this.btn3);
            this.grbTicTacToe3x3.Controls.Add(this.btn6);
            this.grbTicTacToe3x3.Controls.Add(this.btn4);
            this.grbTicTacToe3x3.Location = new System.Drawing.Point(217, 119);
            this.grbTicTacToe3x3.Name = "grbTicTacToe3x3";
            this.grbTicTacToe3x3.Size = new System.Drawing.Size(200, 197);
            this.grbTicTacToe3x3.TabIndex = 12;
            this.grbTicTacToe3x3.TabStop = false;
            this.grbTicTacToe3x3.Text = "TicTacToe3x3";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 533);
            this.Controls.Add(this.grbTicTacToe3x3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn3x3);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TicTacToe_KeyPress);
            this.grbTicTacToe3x3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn3x3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.GroupBox grbTicTacToe3x3;
    }
}

