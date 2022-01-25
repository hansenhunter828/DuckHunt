
namespace DuckHunt
{
    partial class gameScreen
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreTestLabel = new System.Windows.Forms.Label();
            this.roundTestLabel = new System.Windows.Forms.Label();
            this.roundTitleLabel = new System.Windows.Forms.Label();
            this.pauseTimer = new System.Windows.Forms.Timer(this.components);
            this.overlayLabel = new System.Windows.Forms.Label();
            this.resumeLabel = new System.Windows.Forms.Label();
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.quitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreTestLabel
            // 
            this.scoreTestLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTestLabel.ForeColor = System.Drawing.Color.Orange;
            this.scoreTestLabel.Location = new System.Drawing.Point(689, 783);
            this.scoreTestLabel.Name = "scoreTestLabel";
            this.scoreTestLabel.Size = new System.Drawing.Size(335, 39);
            this.scoreTestLabel.TabIndex = 1;
            this.scoreTestLabel.Text = "SCORE:";
            // 
            // roundTestLabel
            // 
            this.roundTestLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTestLabel.ForeColor = System.Drawing.Color.Orange;
            this.roundTestLabel.Location = new System.Drawing.Point(689, 731);
            this.roundTestLabel.Name = "roundTestLabel";
            this.roundTestLabel.Size = new System.Drawing.Size(224, 52);
            this.roundTestLabel.TabIndex = 2;
            this.roundTestLabel.Text = "ROUND:";
            // 
            // roundTitleLabel
            // 
            this.roundTitleLabel.AutoSize = true;
            this.roundTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTitleLabel.Location = new System.Drawing.Point(324, 225);
            this.roundTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundTitleLabel.Name = "roundTitleLabel";
            this.roundTitleLabel.Size = new System.Drawing.Size(272, 69);
            this.roundTitleLabel.TabIndex = 3;
            this.roundTitleLabel.Text = "ROUND:";
            // 
            // pauseTimer
            // 
            this.pauseTimer.Interval = 20;
            this.pauseTimer.Tick += new System.EventHandler(this.pauseTimer_Tick);
            // 
            // overlayLabel
            // 
            this.overlayLabel.BackColor = System.Drawing.Color.Transparent;
            this.overlayLabel.Location = new System.Drawing.Point(0, 0);
            this.overlayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.overlayLabel.Name = "overlayLabel";
            this.overlayLabel.Size = new System.Drawing.Size(281, 236);
            this.overlayLabel.TabIndex = 4;
            // 
            // resumeLabel
            // 
            this.resumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.resumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeLabel.Location = new System.Drawing.Point(385, 358);
            this.resumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resumeLabel.Name = "resumeLabel";
            this.resumeLabel.Size = new System.Drawing.Size(299, 43);
            this.resumeLabel.TabIndex = 5;
            this.resumeLabel.Text = "RESUME";
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.Location = new System.Drawing.Point(363, 401);
            this.mainMenuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(321, 42);
            this.mainMenuLabel.TabIndex = 6;
            this.mainMenuLabel.Text = "MAIN MENU";
            // 
            // quitLabel
            // 
            this.quitLabel.BackColor = System.Drawing.Color.Transparent;
            this.quitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitLabel.Location = new System.Drawing.Point(416, 443);
            this.quitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(268, 41);
            this.quitLabel.TabIndex = 7;
            this.quitLabel.Text = "QUIT";
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::DuckHunt.Properties.Resources.CSFGR12_Background;
            this.Controls.Add(this.quitLabel);
            this.Controls.Add(this.mainMenuLabel);
            this.Controls.Add(this.resumeLabel);
            this.Controls.Add(this.roundTitleLabel);
            this.Controls.Add(this.roundTestLabel);
            this.Controls.Add(this.scoreTestLabel);
            this.Controls.Add(this.overlayLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gameScreen";
            this.Size = new System.Drawing.Size(960, 886);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gameScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameScreen_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreTestLabel;
        private System.Windows.Forms.Label roundTestLabel;
        private System.Windows.Forms.Label roundTitleLabel;
        private System.Windows.Forms.Timer pauseTimer;
        private System.Windows.Forms.Label overlayLabel;
        private System.Windows.Forms.Label resumeLabel;
        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.Label quitLabel;
    }
}
