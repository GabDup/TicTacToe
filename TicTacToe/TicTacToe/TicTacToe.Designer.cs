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
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TicTacToe_KeyPress);
            this.grbTicTacToe3x3.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

