namespace Client
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.plroom = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ltbdanhsachphonggame = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btntaophongmoi = new System.Windows.Forms.Button();
            this.pnlgame = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbidphong = new System.Windows.Forms.Label();
            this.rtbchat = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbcontentchat = new System.Windows.Forms.RichTextBox();
            this.plroom.SuspendLayout();
            this.pnlgame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // plroom
            // 
            this.plroom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plroom.BackgroundImage")));
            this.plroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plroom.Controls.Add(this.richTextBox1);
            this.plroom.Controls.Add(this.textBox1);
            this.plroom.Controls.Add(this.listView2);
            this.plroom.Controls.Add(this.label3);
            this.plroom.Controls.Add(this.label2);
            this.plroom.Controls.Add(this.button3);
            this.plroom.Controls.Add(this.richTextBox2);
            this.plroom.Controls.Add(this.label1);
            this.plroom.Controls.Add(this.ltbdanhsachphonggame);
            this.plroom.Controls.Add(this.button2);
            this.plroom.Controls.Add(this.btntaophongmoi);
            this.plroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plroom.Location = new System.Drawing.Point(0, 0);
            this.plroom.Margin = new System.Windows.Forms.Padding(4);
            this.plroom.Name = "plroom";
            this.plroom.Size = new System.Drawing.Size(1090, 666);
            this.plroom.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 277);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(279, 302);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 22);
            this.textBox1.TabIndex = 16;
            // 
            // listView2
            // 
            this.listView2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.ForeColor = System.Drawing.Color.Black;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(4, 56);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(281, 186);
            this.listView2.TabIndex = 15;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-1, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "THÀNH VIÊN ONLINE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "CHAT";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(174, 585);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 586);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(160, 40);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(403, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH PHÒNG";
            // 
            // ltbdanhsachphonggame
            // 
            this.ltbdanhsachphonggame.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbdanhsachphonggame.FormattingEnabled = true;
            this.ltbdanhsachphonggame.ItemHeight = 22;
            this.ltbdanhsachphonggame.Location = new System.Drawing.Point(375, 90);
            this.ltbdanhsachphonggame.Margin = new System.Windows.Forms.Padding(4);
            this.ltbdanhsachphonggame.Name = "ltbdanhsachphonggame";
            this.ltbdanhsachphonggame.Size = new System.Drawing.Size(336, 466);
            this.ltbdanhsachphonggame.TabIndex = 5;
            this.ltbdanhsachphonggame.SelectedIndexChanged += new System.EventHandler(this.ltbdanhsachphonggame_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(772, 129);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btntaophongmoi
            // 
            this.btntaophongmoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntaophongmoi.BackgroundImage")));
            this.btntaophongmoi.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaophongmoi.Location = new System.Drawing.Point(772, 67);
            this.btntaophongmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btntaophongmoi.Name = "btntaophongmoi";
            this.btntaophongmoi.Size = new System.Drawing.Size(216, 54);
            this.btntaophongmoi.TabIndex = 0;
            this.btntaophongmoi.Text = "tao phòng";
            this.btntaophongmoi.UseVisualStyleBackColor = true;
            this.btntaophongmoi.Click += new System.EventHandler(this.btntaophongmoi_Click);
            // 
            // pnlgame
            // 
            this.pnlgame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlgame.BackgroundImage")));
            this.pnlgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlgame.Controls.Add(this.label5);
            this.pnlgame.Controls.Add(this.room);
            this.pnlgame.Controls.Add(this.label4);
            this.pnlgame.Controls.Add(this.button1);
            this.pnlgame.Controls.Add(this.pictureBox3);
            this.pnlgame.Controls.Add(this.lbidphong);
            this.pnlgame.Controls.Add(this.rtbchat);
            this.pnlgame.Controls.Add(this.pictureBox2);
            this.pnlgame.Controls.Add(this.pictureBox1);
            this.pnlgame.Controls.Add(this.panel1);
            this.pnlgame.Controls.Add(this.rtbcontentchat);
            this.pnlgame.Location = new System.Drawing.Point(0, 0);
            this.pnlgame.Margin = new System.Windows.Forms.Padding(4);
            this.pnlgame.Name = "pnlgame";
            this.pnlgame.Size = new System.Drawing.Size(1069, 671);
            this.pnlgame.TabIndex = 9;
            this.pnlgame.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSalmon;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "time";
            // 
            // room
            // 
            this.room.AutoSize = true;
            this.room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.room.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room.Location = new System.Drawing.Point(253, 43);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(110, 26);
            this.room.TabIndex = 14;
            this.room.Text = "room of";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSalmon;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "time";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(660, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "play again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Client.Properties.Resources.thoa;
            this.pictureBox3.Location = new System.Drawing.Point(938, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 78);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lbidphong
            // 
            this.lbidphong.AutoSize = true;
            this.lbidphong.BackColor = System.Drawing.Color.Transparent;
            this.lbidphong.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidphong.ForeColor = System.Drawing.Color.Black;
            this.lbidphong.Location = new System.Drawing.Point(387, 45);
            this.lbidphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbidphong.Name = "lbidphong";
            this.lbidphong.Size = new System.Drawing.Size(25, 26);
            this.lbidphong.TabIndex = 9;
            this.lbidphong.Text = ": ";
            // 
            // rtbchat
            // 
            this.rtbchat.BackColor = System.Drawing.Color.LightCyan;
            this.rtbchat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbchat.Location = new System.Drawing.Point(844, 598);
            this.rtbchat.Margin = new System.Windows.Forms.Padding(4);
            this.rtbchat.Name = "rtbchat";
            this.rtbchat.Size = new System.Drawing.Size(220, 34);
            this.rtbchat.TabIndex = 7;
            this.rtbchat.Text = "";
            this.rtbchat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbchat_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(890, 219);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 219);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(251, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 547);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // rtbcontentchat
            // 
            this.rtbcontentchat.BackColor = System.Drawing.Color.LightCyan;
            this.rtbcontentchat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbcontentchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbcontentchat.Location = new System.Drawing.Point(844, 439);
            this.rtbcontentchat.Margin = new System.Windows.Forms.Padding(4);
            this.rtbcontentchat.Name = "rtbcontentchat";
            this.rtbcontentchat.Size = new System.Drawing.Size(221, 151);
            this.rtbcontentchat.TabIndex = 6;
            this.rtbcontentchat.Text = "";
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 666);
            this.Controls.Add(this.plroom);
            this.Controls.Add(this.pnlgame);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGame_FormClosing);
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.plroom.ResumeLayout(false);
            this.plroom.PerformLayout();
            this.pnlgame.ResumeLayout(false);
            this.pnlgame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox rtbcontentchat;
        private System.Windows.Forms.RichTextBox rtbchat;
        private System.Windows.Forms.Panel pnlgame;
        private System.Windows.Forms.Label lbidphong;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel plroom;
        private System.Windows.Forms.Button btntaophongmoi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ltbdanhsachphonggame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label room;
        private System.Windows.Forms.Label label5;
    }
}