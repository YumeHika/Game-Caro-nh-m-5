namespace Server
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CloseServer = new System.Windows.Forms.Button();
            this.DongForm = new System.Windows.Forms.Button();
            this.OpenServer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(10, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(299, 195);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CloseServer);
            this.groupBox3.Controls.Add(this.DongForm);
            this.groupBox3.Controls.Add(this.OpenServer);
            this.groupBox3.Location = new System.Drawing.Point(2, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // CloseServer
            // 
            this.CloseServer.Location = new System.Drawing.Point(18, 13);
            this.CloseServer.Name = "CloseServer";
            this.CloseServer.Size = new System.Drawing.Size(118, 23);
            this.CloseServer.TabIndex = 2;
            this.CloseServer.Text = "Đóng Server";
            this.CloseServer.UseVisualStyleBackColor = true;
            this.CloseServer.Visible = false;
            this.CloseServer.Click += new System.EventHandler(this.CloseServer_Click);
            // 
            // DongForm
            // 
            this.DongForm.Location = new System.Drawing.Point(180, 42);
            this.DongForm.Name = "DongForm";
            this.DongForm.Size = new System.Drawing.Size(126, 23);
            this.DongForm.TabIndex = 1;
            this.DongForm.Text = "Đóng";
            this.DongForm.UseVisualStyleBackColor = true;
            this.DongForm.Click += new System.EventHandler(this.DongForm_Click);
            // 
            // OpenServer
            // 
            this.OpenServer.Location = new System.Drawing.Point(18, 42);
            this.OpenServer.Name = "OpenServer";
            this.OpenServer.Size = new System.Drawing.Size(118, 23);
            this.OpenServer.TabIndex = 0;
            this.OpenServer.Text = "Mở Server";
            this.OpenServer.UseVisualStyleBackColor = true;
            this.OpenServer.Click += new System.EventHandler(this.OpenServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(327, 311);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DongForm;
        private System.Windows.Forms.Button OpenServer;
        private System.Windows.Forms.Button CloseServer;
    }
}

