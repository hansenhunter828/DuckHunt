
namespace DuckHunt
{
    partial class gameOverScreen
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
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.replayLabel = new System.Windows.Forms.Label();
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.quitLabel = new System.Windows.Forms.Label();
            this.gameOverLoop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(35, 94);
            this.gameOverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(893, 190);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(63, 283);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(835, 133);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "SCORE:";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // replayLabel
            // 
            this.replayLabel.BackColor = System.Drawing.Color.Transparent;
            this.replayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayLabel.Location = new System.Drawing.Point(63, 579);
            this.replayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.replayLabel.Name = "replayLabel";
            this.replayLabel.Size = new System.Drawing.Size(290, 133);
            this.replayLabel.TabIndex = 2;
            this.replayLabel.Text = "REPLAY";
            this.replayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.Location = new System.Drawing.Point(361, 579);
            this.mainMenuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(237, 133);
            this.mainMenuLabel.TabIndex = 3;
            this.mainMenuLabel.Text = "MAIN MENU";
            this.mainMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitLabel
            // 
            this.quitLabel.BackColor = System.Drawing.Color.Transparent;
            this.quitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitLabel.Location = new System.Drawing.Point(661, 579);
            this.quitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(237, 133);
            this.quitLabel.TabIndex = 4;
            this.quitLabel.Text = "QUIT";
            this.quitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOverLoop
            // 
            this.gameOverLoop.Enabled = true;
            this.gameOverLoop.Interval = 20;
            this.gameOverLoop.Tick += new System.EventHandler(this.gameOverLoop_Tick);
            // 
            // gameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::DuckHunt.Properties.Resources.CSFGR12_Background;
            this.Controls.Add(this.quitLabel);
            this.Controls.Add(this.mainMenuLabel);
            this.Controls.Add(this.replayLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gameOverLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gameOverScreen";
            this.Size = new System.Drawing.Size(960, 886);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gameOverScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameOverScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameOverScreen_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label replayLabel;
        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.Label quitLabel;
        private System.Windows.Forms.Timer gameOverLoop;
    }
}
