namespace TicTacToe
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblDraws = new System.Windows.Forms.Label();
            this.lblLoses = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total number of Games:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of wins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of loses:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of draws:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Win percentage:";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(239, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(239, 41);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear Stats";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(138, 88);
            this.lblPercentage.Margin = new System.Windows.Forms.Padding(3);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(19, 13);
            this.lblPercentage.TabIndex = 11;
            this.lblPercentage.Text = "00";
            // 
            // lblDraws
            // 
            this.lblDraws.AutoSize = true;
            this.lblDraws.Location = new System.Drawing.Point(138, 69);
            this.lblDraws.Margin = new System.Windows.Forms.Padding(3);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(19, 13);
            this.lblDraws.TabIndex = 10;
            this.lblDraws.Text = "00";
            // 
            // lblLoses
            // 
            this.lblLoses.AutoSize = true;
            this.lblLoses.Location = new System.Drawing.Point(138, 50);
            this.lblLoses.Margin = new System.Windows.Forms.Padding(3);
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(19, 13);
            this.lblLoses.TabIndex = 9;
            this.lblLoses.Text = "00";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(138, 31);
            this.lblWins.Margin = new System.Windows.Forms.Padding(3);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(19, 13);
            this.lblWins.TabIndex = 8;
            this.lblWins.Text = "00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(138, 12);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "00";
            // 
            // Statistics
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(322, 111);
            this.ControlBox = false;
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblDraws);
            this.Controls.Add(this.lblLoses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistics";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.Label lblLoses;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblTotal;
    }
}