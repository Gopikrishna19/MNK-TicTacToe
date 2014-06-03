namespace TicTacToe
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imgStates = new System.Windows.Forms.ImageList(this.components);
            this.pic00 = new System.Windows.Forms.PictureBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic01 = new System.Windows.Forms.PictureBox();
            this.pic02 = new System.Windows.Forms.PictureBox();
            this.pic03 = new System.Windows.Forms.PictureBox();
            this.pic04 = new System.Windows.Forms.PictureBox();
            this.pic14 = new System.Windows.Forms.PictureBox();
            this.pic13 = new System.Windows.Forms.PictureBox();
            this.pic12 = new System.Windows.Forms.PictureBox();
            this.pic11 = new System.Windows.Forms.PictureBox();
            this.pic10 = new System.Windows.Forms.PictureBox();
            this.pic24 = new System.Windows.Forms.PictureBox();
            this.pic23 = new System.Windows.Forms.PictureBox();
            this.pic22 = new System.Windows.Forms.PictureBox();
            this.pic21 = new System.Windows.Forms.PictureBox();
            this.pic20 = new System.Windows.Forms.PictureBox();
            this.pic34 = new System.Windows.Forms.PictureBox();
            this.pic33 = new System.Windows.Forms.PictureBox();
            this.pic32 = new System.Windows.Forms.PictureBox();
            this.pic31 = new System.Windows.Forms.PictureBox();
            this.pic30 = new System.Windows.Forms.PictureBox();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblBoardMessages = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic00)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic30)).BeginInit();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgStates
            // 
            this.imgStates.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgStates.ImageStream")));
            this.imgStates.TransparentColor = System.Drawing.Color.Transparent;
            this.imgStates.Images.SetKeyName(0, "o.png");
            this.imgStates.Images.SetKeyName(1, "x.png");
            // 
            // pic00
            // 
            this.pic00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic00.Location = new System.Drawing.Point(12, 37);
            this.pic00.Name = "pic00";
            this.pic00.Size = new System.Drawing.Size(64, 64);
            this.pic00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic00.TabIndex = 0;
            this.pic00.TabStop = false;
            this.pic00.Tag = "0,0";
            this.pic00.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(368, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.statisticsToolStripMenuItem,
            this.difficultyToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.statisticsToolStripMenuItem.Text = "&Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.difficultyToolStripMenuItem.Text = "&Difficulty";
            this.difficultyToolStripMenuItem.Click += new System.EventHandler(this.difficultyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pic01
            // 
            this.pic01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic01.Location = new System.Drawing.Point(82, 37);
            this.pic01.Name = "pic01";
            this.pic01.Size = new System.Drawing.Size(64, 64);
            this.pic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic01.TabIndex = 2;
            this.pic01.TabStop = false;
            this.pic01.Tag = "0,1";
            this.pic01.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic02
            // 
            this.pic02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic02.Location = new System.Drawing.Point(152, 37);
            this.pic02.Name = "pic02";
            this.pic02.Size = new System.Drawing.Size(64, 64);
            this.pic02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic02.TabIndex = 3;
            this.pic02.TabStop = false;
            this.pic02.Tag = "0,2";
            this.pic02.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic03
            // 
            this.pic03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic03.Location = new System.Drawing.Point(222, 37);
            this.pic03.Name = "pic03";
            this.pic03.Size = new System.Drawing.Size(64, 64);
            this.pic03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic03.TabIndex = 4;
            this.pic03.TabStop = false;
            this.pic03.Tag = "0,3";
            this.pic03.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic04
            // 
            this.pic04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic04.Location = new System.Drawing.Point(292, 37);
            this.pic04.Name = "pic04";
            this.pic04.Size = new System.Drawing.Size(64, 64);
            this.pic04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic04.TabIndex = 5;
            this.pic04.TabStop = false;
            this.pic04.Tag = "0,4";
            this.pic04.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic14
            // 
            this.pic14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic14.Location = new System.Drawing.Point(292, 107);
            this.pic14.Name = "pic14";
            this.pic14.Size = new System.Drawing.Size(64, 64);
            this.pic14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic14.TabIndex = 10;
            this.pic14.TabStop = false;
            this.pic14.Tag = "1,4";
            this.pic14.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic13
            // 
            this.pic13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic13.Location = new System.Drawing.Point(222, 107);
            this.pic13.Name = "pic13";
            this.pic13.Size = new System.Drawing.Size(64, 64);
            this.pic13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic13.TabIndex = 9;
            this.pic13.TabStop = false;
            this.pic13.Tag = "1,3";
            this.pic13.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic12
            // 
            this.pic12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic12.Location = new System.Drawing.Point(152, 107);
            this.pic12.Name = "pic12";
            this.pic12.Size = new System.Drawing.Size(64, 64);
            this.pic12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic12.TabIndex = 8;
            this.pic12.TabStop = false;
            this.pic12.Tag = "1,2";
            this.pic12.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic11
            // 
            this.pic11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic11.Location = new System.Drawing.Point(82, 107);
            this.pic11.Name = "pic11";
            this.pic11.Size = new System.Drawing.Size(64, 64);
            this.pic11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic11.TabIndex = 7;
            this.pic11.TabStop = false;
            this.pic11.Tag = "1,1";
            this.pic11.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic10
            // 
            this.pic10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic10.Location = new System.Drawing.Point(12, 107);
            this.pic10.Name = "pic10";
            this.pic10.Size = new System.Drawing.Size(64, 64);
            this.pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic10.TabIndex = 6;
            this.pic10.TabStop = false;
            this.pic10.Tag = "1,0";
            this.pic10.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic24
            // 
            this.pic24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic24.Location = new System.Drawing.Point(292, 177);
            this.pic24.Name = "pic24";
            this.pic24.Size = new System.Drawing.Size(64, 64);
            this.pic24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic24.TabIndex = 15;
            this.pic24.TabStop = false;
            this.pic24.Tag = "2,4";
            this.pic24.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic23
            // 
            this.pic23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic23.Location = new System.Drawing.Point(222, 177);
            this.pic23.Name = "pic23";
            this.pic23.Size = new System.Drawing.Size(64, 64);
            this.pic23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic23.TabIndex = 14;
            this.pic23.TabStop = false;
            this.pic23.Tag = "2,3";
            this.pic23.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic22
            // 
            this.pic22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic22.Location = new System.Drawing.Point(152, 177);
            this.pic22.Name = "pic22";
            this.pic22.Size = new System.Drawing.Size(64, 64);
            this.pic22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic22.TabIndex = 13;
            this.pic22.TabStop = false;
            this.pic22.Tag = "2,2";
            this.pic22.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic21
            // 
            this.pic21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic21.Location = new System.Drawing.Point(82, 177);
            this.pic21.Name = "pic21";
            this.pic21.Size = new System.Drawing.Size(64, 64);
            this.pic21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic21.TabIndex = 12;
            this.pic21.TabStop = false;
            this.pic21.Tag = "2,1";
            this.pic21.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic20
            // 
            this.pic20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic20.Location = new System.Drawing.Point(12, 177);
            this.pic20.Name = "pic20";
            this.pic20.Size = new System.Drawing.Size(64, 64);
            this.pic20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic20.TabIndex = 11;
            this.pic20.TabStop = false;
            this.pic20.Tag = "2,0";
            this.pic20.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic34
            // 
            this.pic34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic34.Location = new System.Drawing.Point(292, 247);
            this.pic34.Name = "pic34";
            this.pic34.Size = new System.Drawing.Size(64, 64);
            this.pic34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic34.TabIndex = 20;
            this.pic34.TabStop = false;
            this.pic34.Tag = "3,4";
            this.pic34.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic33
            // 
            this.pic33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic33.Location = new System.Drawing.Point(222, 247);
            this.pic33.Name = "pic33";
            this.pic33.Size = new System.Drawing.Size(64, 64);
            this.pic33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic33.TabIndex = 19;
            this.pic33.TabStop = false;
            this.pic33.Tag = "3,3";
            this.pic33.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic32
            // 
            this.pic32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic32.Location = new System.Drawing.Point(152, 247);
            this.pic32.Name = "pic32";
            this.pic32.Size = new System.Drawing.Size(64, 64);
            this.pic32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic32.TabIndex = 18;
            this.pic32.TabStop = false;
            this.pic32.Tag = "3,2";
            this.pic32.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic31
            // 
            this.pic31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic31.Location = new System.Drawing.Point(82, 247);
            this.pic31.Name = "pic31";
            this.pic31.Size = new System.Drawing.Size(64, 64);
            this.pic31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic31.TabIndex = 17;
            this.pic31.TabStop = false;
            this.pic31.Tag = "3,1";
            this.pic31.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // pic30
            // 
            this.pic30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic30.Location = new System.Drawing.Point(12, 247);
            this.pic30.Name = "pic30";
            this.pic30.Size = new System.Drawing.Size(64, 64);
            this.pic30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic30.TabIndex = 16;
            this.pic30.TabStop = false;
            this.pic30.Tag = "3,0";
            this.pic30.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBoardMessages});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 322);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(368, 24);
            this.mainStatusStrip.TabIndex = 22;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // lblBoardMessages
            // 
            this.lblBoardMessages.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblBoardMessages.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lblBoardMessages.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.lblBoardMessages.Name = "lblBoardMessages";
            this.lblBoardMessages.Size = new System.Drawing.Size(348, 19);
            this.lblBoardMessages.Spring = true;
            this.lblBoardMessages.Text = "Board Messages";
            this.lblBoardMessages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 346);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.pic34);
            this.Controls.Add(this.pic33);
            this.Controls.Add(this.pic32);
            this.Controls.Add(this.pic31);
            this.Controls.Add(this.pic30);
            this.Controls.Add(this.pic24);
            this.Controls.Add(this.pic23);
            this.Controls.Add(this.pic22);
            this.Controls.Add(this.pic21);
            this.Controls.Add(this.pic20);
            this.Controls.Add(this.pic14);
            this.Controls.Add(this.pic13);
            this.Controls.Add(this.pic12);
            this.Controls.Add(this.pic11);
            this.Controls.Add(this.pic10);
            this.Controls.Add(this.pic04);
            this.Controls.Add(this.pic03);
            this.Controls.Add(this.pic02);
            this.Controls.Add(this.pic01);
            this.Controls.Add(this.pic00);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe - 4x5 - AI Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pic00)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic30)).EndInit();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgStates;
        private System.Windows.Forms.PictureBox pic00;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.PictureBox pic01;
        private System.Windows.Forms.PictureBox pic02;
        private System.Windows.Forms.PictureBox pic03;
        private System.Windows.Forms.PictureBox pic04;
        private System.Windows.Forms.PictureBox pic14;
        private System.Windows.Forms.PictureBox pic13;
        private System.Windows.Forms.PictureBox pic12;
        private System.Windows.Forms.PictureBox pic11;
        private System.Windows.Forms.PictureBox pic10;
        private System.Windows.Forms.PictureBox pic24;
        private System.Windows.Forms.PictureBox pic23;
        private System.Windows.Forms.PictureBox pic22;
        private System.Windows.Forms.PictureBox pic21;
        private System.Windows.Forms.PictureBox pic20;
        private System.Windows.Forms.PictureBox pic34;
        private System.Windows.Forms.PictureBox pic33;
        private System.Windows.Forms.PictureBox pic32;
        private System.Windows.Forms.PictureBox pic31;
        private System.Windows.Forms.PictureBox pic30;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblBoardMessages;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

