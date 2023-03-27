namespace CarRacingGame
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picItem1 = new System.Windows.Forms.PictureBox();
            this.picItem2 = new System.Windows.Forms.PictureBox();
            this.picAward = new System.Windows.Forms.PictureBox();
            this.picExplosion = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.picAward);
            this.panel1.Controls.Add(this.picItem2);
            this.panel1.Controls.Add(this.picItem1);
            this.panel1.Controls.Add(this.picPlayer);
            this.panel1.Controls.Add(this.picExplosion);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 504);
            this.panel1.TabIndex = 0;
            // 
            // roadTrack1
            // 
            this.roadTrack1.BackColor = System.Drawing.Color.Transparent;
            this.roadTrack1.Image = global::CarRacingGame.Properties.Resources.roadTrack;
            this.roadTrack1.InitialImage = null;
            this.roadTrack1.Location = new System.Drawing.Point(-519, 0);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(475, 519);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(200, 583);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 46);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score: 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 102);
            this.label2.TabIndex = 3;
            this.label2.Text = "Press Left and Right to move the car. ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::CarRacingGame.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(473, 504);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 1;
            this.roadTrack2.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::CarRacingGame.Properties.Resources.carOrange;
            this.picPlayer.Location = new System.Drawing.Point(210, 381);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(50, 100);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer.TabIndex = 2;
            this.picPlayer.TabStop = false;
            // 
            // picItem1
            // 
            this.picItem1.Image = global::CarRacingGame.Properties.Resources.CarRed;
            this.picItem1.Location = new System.Drawing.Point(77, 31);
            this.picItem1.Name = "picItem1";
            this.picItem1.Size = new System.Drawing.Size(50, 100);
            this.picItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picItem1.TabIndex = 2;
            this.picItem1.TabStop = false;
            this.picItem1.Tag = "carLeft";
            // 
            // picItem2
            // 
            this.picItem2.Image = global::CarRacingGame.Properties.Resources.carGrey;
            this.picItem2.Location = new System.Drawing.Point(325, 3);
            this.picItem2.Name = "picItem2";
            this.picItem2.Size = new System.Drawing.Size(50, 100);
            this.picItem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picItem2.TabIndex = 2;
            this.picItem2.TabStop = false;
            this.picItem2.Tag = "carRight";
            // 
            // picAward
            // 
            this.picAward.Image = global::CarRacingGame.Properties.Resources.silver;
            this.picAward.Location = new System.Drawing.Point(125, 180);
            this.picAward.Name = "picAward";
            this.picAward.Size = new System.Drawing.Size(250, 100);
            this.picAward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAward.TabIndex = 2;
            this.picAward.TabStop = false;
            // 
            // picExplosion
            // 
            this.picExplosion.Image = global::CarRacingGame.Properties.Resources.explosion;
            this.picExplosion.Location = new System.Drawing.Point(276, 286);
            this.picExplosion.Name = "picExplosion";
            this.picExplosion.Size = new System.Drawing.Size(64, 64);
            this.picExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picExplosion.TabIndex = 2;
            this.picExplosion.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 773);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox picAward;
        private System.Windows.Forms.PictureBox picItem2;
        private System.Windows.Forms.PictureBox picItem1;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picExplosion;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.Timer gameTimer;
    }
}

