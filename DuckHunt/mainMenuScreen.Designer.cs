
namespace DuckHunt
{
    partial class mainMenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playLabel = new System.Windows.Forms.Label();
            this.howToPlayLabel = new System.Windows.Forms.Label();
            this.quitLabel = new System.Windows.Forms.Label();
            this.mainMenuLoop = new System.Windows.Forms.Timer(this.components);
            this.titlelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cheatlabel = new System.Windows.Forms.Label();
            this.copyrightLogoLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playLabel
            // 
            this.playLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playLabel.ForeColor = System.Drawing.Color.White;
            this.playLabel.Location = new System.Drawing.Point(423, 358);
            this.playLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(193, 60);
            this.playLabel.TabIndex = 0;
            this.playLabel.Text = "PLAY";
            // 
            // howToPlayLabel
            // 
            this.howToPlayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayLabel.ForeColor = System.Drawing.Color.White;
            this.howToPlayLabel.Location = new System.Drawing.Point(323, 418);
            this.howToPlayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.howToPlayLabel.Name = "howToPlayLabel";
            this.howToPlayLabel.Size = new System.Drawing.Size(425, 63);
            this.howToPlayLabel.TabIndex = 1;
            this.howToPlayLabel.Text = "HOW TO PLAY";
            // 
            // quitLabel
            // 
            this.quitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitLabel.ForeColor = System.Drawing.Color.White;
            this.quitLabel.Location = new System.Drawing.Point(423, 481);
            this.quitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(257, 78);
            this.quitLabel.TabIndex = 2;
            this.quitLabel.Text = "QUIT";
            // 
            // mainMenuLoop
            // 
            this.mainMenuLoop.Enabled = true;
            this.mainMenuLoop.Interval = 20;
            this.mainMenuLoop.Tick += new System.EventHandler(this.mainMenuLoop_Tick);
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.BackColor = System.Drawing.Color.Transparent;
            this.titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.titlelabel.Location = new System.Drawing.Point(283, 180);
            this.titlelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(266, 91);
            this.titlelabel.TabIndex = 4;
            this.titlelabel.Text = "DUCK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(443, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 91);
            this.label1.TabIndex = 5;
            this.label1.Text = "HUNT";
            // 
            // cheatlabel
            // 
            this.cheatlabel.AutoSize = true;
            this.cheatlabel.BackColor = System.Drawing.Color.Transparent;
            this.cheatlabel.ForeColor = System.Drawing.Color.White;
            this.cheatlabel.Location = new System.Drawing.Point(903, 870);
            this.cheatlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cheatlabel.Name = "cheatlabel";
            this.cheatlabel.Size = new System.Drawing.Size(52, 17);
            this.cheatlabel.TabIndex = 6;
            this.cheatlabel.Text = "Cheats";
            // 
            // copyrightLogoLabel
            // 
            this.copyrightLogoLabel.AutoSize = true;
            this.copyrightLogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.copyrightLogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLogoLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.copyrightLogoLabel.Location = new System.Drawing.Point(325, 633);
            this.copyrightLogoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copyrightLogoLabel.Name = "copyrightLogoLabel";
            this.copyrightLogoLabel.Size = new System.Drawing.Size(304, 36);
            this.copyrightLogoLabel.TabIndex = 7;
            this.copyrightLogoLabel.Text = "2022 Hansen LTD ©";
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.scoreLabel.Location = new System.Drawing.Point(207, 602);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(585, 31);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "HIGHSCORE:";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(283, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 91);
            this.label2.TabIndex = 9;
            this.label2.Text = "DUCK";
            // 
            // mainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::DuckHunt.Properties.Resources.CSFGR12_Background;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.copyrightLogoLabel);
            this.Controls.Add(this.cheatlabel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitLabel);
            this.Controls.Add(this.howToPlayLabel);
            this.Controls.Add(this.playLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainMenuScreen";
            this.Size = new System.Drawing.Size(960, 886);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainMenuScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainMenuScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mainMenuScreen_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playLabel;
        private System.Windows.Forms.Label howToPlayLabel;
        private System.Windows.Forms.Label quitLabel;
        private System.Windows.Forms.Timer mainMenuLoop;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cheatlabel;
        private System.Windows.Forms.Label copyrightLogoLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label2;
    }
}
