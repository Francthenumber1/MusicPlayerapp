namespace MusicPlayerapp
{
    partial class MusicPlayerApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            Toppanel = new Panel();
            pictureBox1 = new PictureBox();
            lbllogo = new Label();
            listboxsongs = new ListBox();
            btnselectsongs = new Button();
            axWindowsMediaPlayermusic = new AxWMPLib.AxWindowsMediaPlayer();
            lblfooter = new Label();
            Toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayermusic).BeginInit();
            SuspendLayout();
            // 
            // Toppanel
            // 
            Toppanel.BackColor = Color.AntiqueWhite;
            Toppanel.Controls.Add(pictureBox1);
            Toppanel.Controls.Add(lbllogo);
            Toppanel.Dock = DockStyle.Top;
            Toppanel.Location = new Point(0, 0);
            Toppanel.Name = "Toppanel";
            Toppanel.Size = new Size(800, 47);
            Toppanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(729, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbllogo
            // 
            lbllogo.AutoSize = true;
            lbllogo.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllogo.Location = new Point(29, 9);
            lbllogo.Name = "lbllogo";
            lbllogo.Size = new Size(184, 22);
            lbllogo.TabIndex = 0;
            lbllogo.Text = "Music Player app";
            // 
            // listboxsongs
            // 
            listboxsongs.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listboxsongs.FormattingEnabled = true;
            listboxsongs.Location = new Point(541, 63);
            listboxsongs.Name = "listboxsongs";
            listboxsongs.Size = new Size(247, 340);
            listboxsongs.TabIndex = 1;
            listboxsongs.SelectedIndexChanged += listboxsongs_SelectedIndexChanged;
            // 
            // btnselectsongs
            // 
            btnselectsongs.BackColor = SystemColors.ActiveCaption;
            btnselectsongs.FlatStyle = FlatStyle.Flat;
            btnselectsongs.ForeColor = SystemColors.ActiveCaptionText;
            btnselectsongs.Location = new Point(540, 415);
            btnselectsongs.Name = "btnselectsongs";
            btnselectsongs.Size = new Size(248, 23);
            btnselectsongs.TabIndex = 2;
            btnselectsongs.Text = "Select songs ";
            btnselectsongs.UseVisualStyleBackColor = false;
            btnselectsongs.Click += btnselectsongs_Click;
            // 
            // axWindowsMediaPlayermusic
            // 
            axWindowsMediaPlayermusic.Enabled = true;
            axWindowsMediaPlayermusic.Location = new Point(12, 63);
            axWindowsMediaPlayermusic.Name = "axWindowsMediaPlayermusic";
            axWindowsMediaPlayermusic.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayermusic.OcxState");
            axWindowsMediaPlayermusic.Size = new Size(522, 375);
            axWindowsMediaPlayermusic.TabIndex = 3;
            // 
            // lblfooter
            // 
            lblfooter.AutoSize = true;
            lblfooter.ForeColor = SystemColors.AppWorkspace;
            lblfooter.Location = new Point(322, 475);
            lblfooter.Name = "lblfooter";
            lblfooter.Size = new Size(142, 15);
            lblfooter.TabIndex = 4;
            lblfooter.Text = "Develop by Franc Njoutsa";
            // 
            // MusicPlayerApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(lblfooter);
            Controls.Add(axWindowsMediaPlayermusic);
            Controls.Add(btnselectsongs);
            Controls.Add(listboxsongs);
            Controls.Add(Toppanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusicPlayerApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Player App";
            Toppanel.ResumeLayout(false);
            Toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayermusic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Toppanel;
        private PictureBox pictureBox1;
        private Label lbllogo;
        private ListBox listboxsongs;
        private Button btnselectsongs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayermusic;
        private Label lblfooter;
    }
}
