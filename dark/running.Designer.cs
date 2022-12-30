namespace dark
{
    partial class running
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
            this.gameloop = new System.Windows.Forms.Timer(this.components);
            this.fireloop = new System.Windows.Forms.Timer(this.components);
            this.jumping = new System.Windows.Forms.Timer(this.components);
            this.collide = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gameloop
            // 
            this.gameloop.Enabled = true;
            this.gameloop.Interval = 30;
            this.gameloop.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // fireloop
            // 
            this.fireloop.Enabled = true;
            this.fireloop.Interval = 30;
            this.fireloop.Tick += new System.EventHandler(this.Fireloop_Tick);
            // 
            // jumping
            // 
            this.jumping.Enabled = true;
            this.jumping.Interval = 1;
            this.jumping.Tick += new System.EventHandler(this.Jumping_Tick);
            // 
            // collide
            // 
            this.collide.Enabled = true;
            this.collide.Interval = 200;
            this.collide.Tick += new System.EventHandler(this.Collide_Tick);
            // 
            // running
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dark.Properties.Resources.b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "running";
            this.Text = "running";
            this.Load += new System.EventHandler(this.Running_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameloop;
        private System.Windows.Forms.Timer fireloop;
        private System.Windows.Forms.Timer jumping;
        private System.Windows.Forms.Timer collide;
    }
}