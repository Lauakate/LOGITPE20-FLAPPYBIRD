
namespace FlappyBird
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.PipeBot1 = new System.Windows.Forms.PictureBox();
            this.PipeTop1 = new System.Windows.Forms.PictureBox();
            this.PipeTop2 = new System.Windows.Forms.PictureBox();
            this.PipeTop3 = new System.Windows.Forms.PictureBox();
            this.PipeBot2 = new System.Windows.Forms.PictureBox();
            this.PipeBot3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.replay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBot3)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("SF Collegiate Solid", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Snow;
            this.scoreLabel.Location = new System.Drawing.Point(12, 420);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(100, 23);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score: 0";
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::FlappyBird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(16, 177);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(64, 46);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::FlappyBird.Properties.Resources.yaya2;
            this.ground.Location = new System.Drawing.Point(-8, 404);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(738, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // PipeBot1
            // 
            this.PipeBot1.BackColor = System.Drawing.Color.Transparent;
            this.PipeBot1.Image = global::FlappyBird.Properties.Resources.up;
            this.PipeBot1.Location = new System.Drawing.Point(159, 317);
            this.PipeBot1.Name = "PipeBot1";
            this.PipeBot1.Size = new System.Drawing.Size(100, 137);
            this.PipeBot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBot1.TabIndex = 3;
            this.PipeBot1.TabStop = false;
            // 
            // PipeTop1
            // 
            this.PipeTop1.BackColor = System.Drawing.Color.Transparent;
            this.PipeTop1.Image = global::FlappyBird.Properties.Resources.purplepipedown;
            this.PipeTop1.Location = new System.Drawing.Point(202, 0);
            this.PipeTop1.Name = "PipeTop1";
            this.PipeTop1.Size = new System.Drawing.Size(100, 147);
            this.PipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop1.TabIndex = 6;
            this.PipeTop1.TabStop = false;
            // 
            // PipeTop2
            // 
            this.PipeTop2.BackColor = System.Drawing.Color.Transparent;
            this.PipeTop2.Image = global::FlappyBird.Properties.Resources.purplepipedown;
            this.PipeTop2.Location = new System.Drawing.Point(418, 0);
            this.PipeTop2.Name = "PipeTop2";
            this.PipeTop2.Size = new System.Drawing.Size(100, 190);
            this.PipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop2.TabIndex = 7;
            this.PipeTop2.TabStop = false;
            // 
            // PipeTop3
            // 
            this.PipeTop3.BackColor = System.Drawing.Color.Transparent;
            this.PipeTop3.Image = global::FlappyBird.Properties.Resources.purplepipedown;
            this.PipeTop3.Location = new System.Drawing.Point(589, 0);
            this.PipeTop3.Name = "PipeTop3";
            this.PipeTop3.Size = new System.Drawing.Size(100, 77);
            this.PipeTop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop3.TabIndex = 8;
            this.PipeTop3.TabStop = false;
            // 
            // PipeBot2
            // 
            this.PipeBot2.BackColor = System.Drawing.Color.Transparent;
            this.PipeBot2.Image = global::FlappyBird.Properties.Resources.up;
            this.PipeBot2.Location = new System.Drawing.Point(418, 354);
            this.PipeBot2.Name = "PipeBot2";
            this.PipeBot2.Size = new System.Drawing.Size(100, 100);
            this.PipeBot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBot2.TabIndex = 9;
            this.PipeBot2.TabStop = false;
            // 
            // PipeBot3
            // 
            this.PipeBot3.BackColor = System.Drawing.Color.Transparent;
            this.PipeBot3.Image = global::FlappyBird.Properties.Resources.up;
            this.PipeBot3.Location = new System.Drawing.Point(615, 234);
            this.PipeBot3.Name = "PipeBot3";
            this.PipeBot3.Size = new System.Drawing.Size(100, 220);
            this.PipeBot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBot3.TabIndex = 10;
            this.PipeBot3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // replay
            // 
            this.replay.BackColor = System.Drawing.Color.Transparent;
            this.replay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.replay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.replay.Font = new System.Drawing.Font("SF Collegiate Solid", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay.ForeColor = System.Drawing.Color.White;
            this.replay.Location = new System.Drawing.Point(220, 177);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(298, 108);
            this.replay.TabIndex = 11;
            this.replay.Text = "Replay?";
            this.replay.UseVisualStyleBackColor = false;
            this.replay.Visible = false;
            this.replay.Click += new System.EventHandler(this.replay_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = global::FlappyBird.Properties.Resources.bgp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 452);
            this.Controls.Add(this.replay);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.PipeBot3);
            this.Controls.Add(this.PipeBot2);
            this.Controls.Add(this.PipeTop3);
            this.Controls.Add(this.PipeTop2);
            this.Controls.Add(this.PipeTop1);
            this.Controls.Add(this.PipeBot1);
            this.Controls.Add(this.bird);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBot3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox PipeBot1;
        private System.Windows.Forms.PictureBox PipeTop1;
        private System.Windows.Forms.PictureBox PipeTop2;
        private System.Windows.Forms.PictureBox PipeTop3;
        private System.Windows.Forms.PictureBox PipeBot2;
        private System.Windows.Forms.PictureBox PipeBot3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button replay;
    }
}

