namespace BrickBreaker
{
    partial class GameScreen
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
            this.borderBox = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.lifeLabel = new System.Windows.Forms.Label();

            this.livesPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.borderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livesPicture)).BeginInit();

            this.timeLabel = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // borderBox
            // 
            this.borderBox.BackColor = System.Drawing.Color.Transparent;
            this.borderBox.BackgroundImage = global::BrickBreaker.Properties.Resources.gamescreenBorder;
            this.borderBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borderBox.Location = new System.Drawing.Point(0, 0);
            this.borderBox.Name = "borderBox";
            this.borderBox.Size = new System.Drawing.Size(1037, 50);
            this.borderBox.TabIndex = 2;
            this.borderBox.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.scoreLabel.Location = new System.Drawing.Point(661, 0);
            this.scoreLabel.Name = "scoreLabel";

            this.scoreLabel.Size = new System.Drawing.Size(390, 51);
            this.scoreLabel.TabIndex = 3;

            this.scoreLabel.Size = new System.Drawing.Size(373, 51);

            this.scoreLabel.Text = "SCORE:";
            // 
            // lifeLabel
            // 
            this.lifeLabel.BackColor = System.Drawing.Color.Transparent;
            this.lifeLabel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.lifeLabel.Location = new System.Drawing.Point(3, -1);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(453, 51);
            this.lifeLabel.TabIndex = 4;
            this.lifeLabel.Text = "LIVES:";
            // 

            // livesPicture
            // 
            this.livesPicture.BackColor = System.Drawing.Color.Transparent;
            this.livesPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.livesPicture.Image = global::BrickBreaker.Properties.Resources.lives3;
            this.livesPicture.Location = new System.Drawing.Point(163, 0);
            this.livesPicture.Name = "livesPicture";
            this.livesPicture.Size = new System.Drawing.Size(101, 50);
            this.livesPicture.TabIndex = 5;
            this.livesPicture.TabStop = false;

            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.timeLabel.Location = new System.Drawing.Point(375, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(163, 72);
            this.timeLabel.TabIndex = 2;

            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;

            this.Controls.Add(this.livesPicture);

            this.Controls.Add(this.timeLabel);

            this.Controls.Add(this.lifeLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.borderBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1037, 606);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.borderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livesPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox borderBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label lifeLabel;

        private System.Windows.Forms.PictureBox livesPicture;

        private System.Windows.Forms.Label timeLabel;

    }
}
