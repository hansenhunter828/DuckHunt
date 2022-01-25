
namespace DuckHunt
{
    partial class HowToPlayScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlayScreen));
            this.titleLabel = new System.Windows.Forms.Label();
            this.controlsLabel = new System.Windows.Forms.Label();
            this.goalLabel = new System.Windows.Forms.Label();
            this.wControlLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.aControlLabel = new System.Windows.Forms.Label();
            this.dControlLabel = new System.Windows.Forms.Label();
            this.sControlLabel = new System.Windows.Forms.Label();
            this.spaceControlLabel = new System.Windows.Forms.Label();
            this.goalExplainLabel = new System.Windows.Forms.Label();
            this.howToPlayLoop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(160, 38);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(602, 91);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "HOW TO PLAY";
            // 
            // controlsLabel
            // 
            this.controlsLabel.BackColor = System.Drawing.Color.Transparent;
            this.controlsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsLabel.ForeColor = System.Drawing.Color.White;
            this.controlsLabel.Location = new System.Drawing.Point(300, 163);
            this.controlsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(404, 75);
            this.controlsLabel.TabIndex = 1;
            this.controlsLabel.Text = "CONTROLS";
            this.controlsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goalLabel
            // 
            this.goalLabel.BackColor = System.Drawing.Color.Transparent;
            this.goalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalLabel.ForeColor = System.Drawing.Color.White;
            this.goalLabel.Location = new System.Drawing.Point(376, 452);
            this.goalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(258, 61);
            this.goalLabel.TabIndex = 2;
            this.goalLabel.Text = "GOAL";
            this.goalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wControlLabel
            // 
            this.wControlLabel.BackColor = System.Drawing.Color.Transparent;
            this.wControlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wControlLabel.ForeColor = System.Drawing.Color.White;
            this.wControlLabel.Location = new System.Drawing.Point(292, 238);
            this.wControlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wControlLabel.Name = "wControlLabel";
            this.wControlLabel.Size = new System.Drawing.Size(412, 38);
            this.wControlLabel.TabIndex = 3;
            this.wControlLabel.Text = "W to move up";
            this.wControlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backLabel
            // 
            this.backLabel.BackColor = System.Drawing.Color.Transparent;
            this.backLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.ForeColor = System.Drawing.Color.White;
            this.backLabel.Location = new System.Drawing.Point(4, 858);
            this.backLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(660, 28);
            this.backLabel.TabIndex = 4;
            this.backLabel.Text = "PRESS SPACE TO GO BACK";
            // 
            // aControlLabel
            // 
            this.aControlLabel.BackColor = System.Drawing.Color.Transparent;
            this.aControlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aControlLabel.ForeColor = System.Drawing.Color.White;
            this.aControlLabel.Location = new System.Drawing.Point(300, 276);
            this.aControlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aControlLabel.Name = "aControlLabel";
            this.aControlLabel.Size = new System.Drawing.Size(404, 38);
            this.aControlLabel.TabIndex = 5;
            this.aControlLabel.Text = "A to move left";
            this.aControlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dControlLabel
            // 
            this.dControlLabel.BackColor = System.Drawing.Color.Transparent;
            this.dControlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dControlLabel.ForeColor = System.Drawing.Color.White;
            this.dControlLabel.Location = new System.Drawing.Point(300, 352);
            this.dControlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dControlLabel.Name = "dControlLabel";
            this.dControlLabel.Size = new System.Drawing.Size(404, 38);
            this.dControlLabel.TabIndex = 6;
            this.dControlLabel.Text = "D to move up";
            this.dControlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sControlLabel
            // 
            this.sControlLabel.BackColor = System.Drawing.Color.Transparent;
            this.sControlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sControlLabel.ForeColor = System.Drawing.Color.White;
            this.sControlLabel.Location = new System.Drawing.Point(300, 314);
            this.sControlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sControlLabel.Name = "sControlLabel";
            this.sControlLabel.Size = new System.Drawing.Size(404, 38);
            this.sControlLabel.TabIndex = 7;
            this.sControlLabel.Text = "S to move down";
            this.sControlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spaceControlLabel
            // 
            this.spaceControlLabel.BackColor = System.Drawing.Color.Transparent;
            this.spaceControlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceControlLabel.ForeColor = System.Drawing.Color.White;
            this.spaceControlLabel.Location = new System.Drawing.Point(300, 390);
            this.spaceControlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.spaceControlLabel.Name = "spaceControlLabel";
            this.spaceControlLabel.Size = new System.Drawing.Size(404, 38);
            this.spaceControlLabel.TabIndex = 8;
            this.spaceControlLabel.Text = "SPACE to shoot";
            this.spaceControlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goalExplainLabel
            // 
            this.goalExplainLabel.BackColor = System.Drawing.Color.Transparent;
            this.goalExplainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalExplainLabel.ForeColor = System.Drawing.Color.White;
            this.goalExplainLabel.Location = new System.Drawing.Point(32, 535);
            this.goalExplainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goalExplainLabel.Name = "goalExplainLabel";
            this.goalExplainLabel.Size = new System.Drawing.Size(892, 226);
            this.goalExplainLabel.TabIndex = 9;
            this.goalExplainLabel.Text = resources.GetString("goalExplainLabel.Text");
            this.goalExplainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.goalExplainLabel.Click += new System.EventHandler(this.goalExplainLabel_Click);
            // 
            // howToPlayLoop
            // 
            this.howToPlayLoop.Enabled = true;
            this.howToPlayLoop.Tick += new System.EventHandler(this.howToPlayLoop_Tick);
            // 
            // HowToPlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.goalExplainLabel);
            this.Controls.Add(this.spaceControlLabel);
            this.Controls.Add(this.sControlLabel);
            this.Controls.Add(this.dControlLabel);
            this.Controls.Add(this.aControlLabel);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.wControlLabel);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.controlsLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HowToPlayScreen";
            this.Size = new System.Drawing.Size(960, 886);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HowToPlayScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HowToPlayScreen_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Label wControlLabel;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label aControlLabel;
        private System.Windows.Forms.Label dControlLabel;
        private System.Windows.Forms.Label sControlLabel;
        private System.Windows.Forms.Label spaceControlLabel;
        private System.Windows.Forms.Label goalExplainLabel;
        private System.Windows.Forms.Timer howToPlayLoop;
    }
}
