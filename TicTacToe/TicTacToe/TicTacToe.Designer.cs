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
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.grbTicTacToe3x3 = new System.Windows.Forms.GroupBox();
            this.grbtictactoe4x4 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn4x400 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btn4x4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTicTacToe3x3.SuspendLayout();
            this.grbtictactoe4x4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn3x3
            // 
            this.btn3x3.Location = new System.Drawing.Point(12, 80);
            this.btn3x3.Name = "btn3x3";
            this.btn3x3.Size = new System.Drawing.Size(149, 110);
            this.btn3x3.TabIndex = 0;
            this.btn3x3.Text = "3x3";
            this.btn3x3.UseVisualStyleBackColor = true;
            this.btn3x3.Click += new System.EventHandler(this.Btn3x3_Click);
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
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(16, 16);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(55, 55);
            this.btn00.TabIndex = 3;
            this.btn00.Text = "-";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.tour);
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(77, 16);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(55, 55);
            this.btn01.TabIndex = 4;
            this.btn01.Text = "-";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.tour);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(138, 16);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(55, 55);
            this.btn02.TabIndex = 5;
            this.btn02.Text = "-";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.tour);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(16, 77);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(55, 55);
            this.btn10.TabIndex = 6;
            this.btn10.Text = "-";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.tour);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(77, 77);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(55, 55);
            this.btn11.TabIndex = 7;
            this.btn11.Text = "-";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.tour);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(138, 77);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(55, 55);
            this.btn12.TabIndex = 8;
            this.btn12.Text = "-";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.tour);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(16, 138);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(55, 55);
            this.btn20.TabIndex = 9;
            this.btn20.Text = "-";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.tour);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(77, 138);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(55, 55);
            this.btn21.TabIndex = 10;
            this.btn21.Text = "-";
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.tour);
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(138, 138);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(55, 55);
            this.btn22.TabIndex = 11;
            this.btn22.Text = "-";
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.tour);
            // 
            // grbTicTacToe3x3
            // 
            this.grbTicTacToe3x3.Controls.Add(this.btn11);
            this.grbTicTacToe3x3.Controls.Add(this.btn22);
            this.grbTicTacToe3x3.Controls.Add(this.btn00);
            this.grbTicTacToe3x3.Controls.Add(this.btn21);
            this.grbTicTacToe3x3.Controls.Add(this.btn01);
            this.grbTicTacToe3x3.Controls.Add(this.btn20);
            this.grbTicTacToe3x3.Controls.Add(this.btn02);
            this.grbTicTacToe3x3.Controls.Add(this.btn12);
            this.grbTicTacToe3x3.Controls.Add(this.btn10);
            this.grbTicTacToe3x3.Location = new System.Drawing.Point(275, 119);
            this.grbTicTacToe3x3.Name = "grbTicTacToe3x3";
            this.grbTicTacToe3x3.Size = new System.Drawing.Size(200, 197);
            this.grbTicTacToe3x3.TabIndex = 12;
            this.grbTicTacToe3x3.TabStop = false;
            this.grbTicTacToe3x3.Text = "TicTacToe3x3";
            // 
            // grbtictactoe4x4
            // 
            this.grbtictactoe4x4.Controls.Add(this.button15);
            this.grbtictactoe4x4.Controls.Add(this.button14);
            this.grbtictactoe4x4.Controls.Add(this.button13);
            this.grbtictactoe4x4.Controls.Add(this.button12);
            this.grbtictactoe4x4.Controls.Add(this.button11);
            this.grbtictactoe4x4.Controls.Add(this.button10);
            this.grbtictactoe4x4.Controls.Add(this.button3);
            this.grbtictactoe4x4.Controls.Add(this.button1);
            this.grbtictactoe4x4.Controls.Add(this.button2);
            this.grbtictactoe4x4.Controls.Add(this.btn4x400);
            this.grbtictactoe4x4.Controls.Add(this.button4);
            this.grbtictactoe4x4.Controls.Add(this.button5);
            this.grbtictactoe4x4.Controls.Add(this.button6);
            this.grbtictactoe4x4.Controls.Add(this.button7);
            this.grbtictactoe4x4.Controls.Add(this.button8);
            this.grbtictactoe4x4.Controls.Add(this.button9);
            this.grbtictactoe4x4.Location = new System.Drawing.Point(481, 119);
            this.grbtictactoe4x4.Name = "grbtictactoe4x4";
            this.grbtictactoe4x4.Size = new System.Drawing.Size(260, 262);
            this.grbtictactoe4x4.TabIndex = 13;
            this.grbtictactoe4x4.TabStop = false;
            this.grbtictactoe4x4.Text = "TicTacToe4x4(non fonctionnel)";
            this.grbtictactoe4x4.VisibleChanged += new System.EventHandler(this.Grbtictactoe4x4_VisibleChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 20;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn4x400
            // 
            this.btn4x400.Location = new System.Drawing.Point(8, 77);
            this.btn4x400.Name = "btn4x400";
            this.btn4x400.Size = new System.Drawing.Size(55, 55);
            this.btn4x400.TabIndex = 12;
            this.btn4x400.Text = "-";
            this.btn4x400.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(69, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 55);
            this.button4.TabIndex = 19;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(69, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 55);
            this.button5.TabIndex = 13;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 199);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 55);
            this.button6.TabIndex = 18;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(130, 77);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 55);
            this.button7.TabIndex = 14;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(130, 138);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 55);
            this.button8.TabIndex = 17;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(8, 138);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 55);
            this.button9.TabIndex = 15;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 14;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(191, 138);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 55);
            this.button10.TabIndex = 21;
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(191, 199);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 55);
            this.button11.TabIndex = 22;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(130, 16);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 55);
            this.button12.TabIndex = 23;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(191, 16);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 55);
            this.button13.TabIndex = 24;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(69, 16);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 55);
            this.button14.TabIndex = 25;
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(8, 16);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(55, 55);
            this.button15.TabIndex = 26;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // btn4x4
            // 
            this.btn4x4.Location = new System.Drawing.Point(12, 196);
            this.btn4x4.Name = "btn4x4";
            this.btn4x4.Size = new System.Drawing.Size(149, 110);
            this.btn4x4.TabIndex = 27;
            this.btn4x4.Text = "4x4";
            this.btn4x4.UseVisualStyleBackColor = true;
            this.btn4x4.Click += new System.EventHandler(this.Btn4x4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cliquez sur l\'un des bouttons pour selectionner la grosseur du tableau de jeu";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn4x4);
            this.Controls.Add(this.grbtictactoe4x4);
            this.Controls.Add(this.grbTicTacToe3x3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn3x3);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TicTacToe_KeyPress);
            this.grbTicTacToe3x3.ResumeLayout(false);
            this.grbtictactoe4x4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn3x3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.GroupBox grbTicTacToe3x3;
        private System.Windows.Forms.GroupBox grbtictactoe4x4;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn4x400;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn4x4;
        private System.Windows.Forms.Label label1;
    }
}

