namespace KK_teineprojekt
{
    partial class KKform2
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
            this.KK_frame1 = new System.Windows.Forms.GroupBox();
            this.KK_pildid1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KK_openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.KK_radioButton1 = new System.Windows.Forms.RadioButton();
            this.KK_radioButton2 = new System.Windows.Forms.RadioButton();
            this.KK_radioButton3 = new System.Windows.Forms.RadioButton();
            this.KK_radioButton4 = new System.Windows.Forms.RadioButton();
            this.KK_radioButton5 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KK_frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KK_pildid1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KK_frame1
            // 
            this.KK_frame1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.KK_frame1.Controls.Add(this.KK_pildid1);
            this.KK_frame1.Location = new System.Drawing.Point(257, 59);
            this.KK_frame1.Name = "KK_frame1";
            this.KK_frame1.Size = new System.Drawing.Size(747, 335);
            this.KK_frame1.TabIndex = 0;
            this.KK_frame1.TabStop = false;
            this.KK_frame1.Text = "Pildid";
            this.KK_frame1.Enter += new System.EventHandler(this.KK_frame1_Enter);
            // 
            // KK_pildid1
            // 
            this.KK_pildid1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KK_pildid1.Location = new System.Drawing.Point(64, 42);
            this.KK_pildid1.Name = "KK_pildid1";
            this.KK_pildid1.Size = new System.Drawing.Size(637, 287);
            this.KK_pildid1.TabIndex = 0;
            this.KK_pildid1.TabStop = false;
            this.KK_pildid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KK_pildid1_MouseDown);
            this.KK_pildid1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KK_pildid1_MouseMove);
            this.KK_pildid1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KK_pildid1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 39);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(96, 35);
            this.fileToolStripMenuItem.Text = "file";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // KK_openFileDialog1
            // 
            this.KK_openFileDialog1.FileName = "openFileDialog1";
            this.KK_openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.KK_openFileDialog1_FileOk);
            // 
            // KK_radioButton1
            // 
            this.KK_radioButton1.AutoSize = true;
            this.KK_radioButton1.Location = new System.Drawing.Point(39, 142);
            this.KK_radioButton1.Name = "KK_radioButton1";
            this.KK_radioButton1.Size = new System.Drawing.Size(183, 46);
            this.KK_radioButton1.TabIndex = 2;
            this.KK_radioButton1.TabStop = true;
            this.KK_radioButton1.Text = "Normal";
            this.KK_radioButton1.UseVisualStyleBackColor = true;
            this.KK_radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // KK_radioButton2
            // 
            this.KK_radioButton2.AutoSize = true;
            this.KK_radioButton2.Location = new System.Drawing.Point(39, 194);
            this.KK_radioButton2.Name = "KK_radioButton2";
            this.KK_radioButton2.Size = new System.Drawing.Size(183, 46);
            this.KK_radioButton2.TabIndex = 3;
            this.KK_radioButton2.TabStop = true;
            this.KK_radioButton2.Text = "Strech";
            this.KK_radioButton2.UseVisualStyleBackColor = true;
            this.KK_radioButton2.CheckedChanged += new System.EventHandler(this.KK_radioButton2_CheckedChanged);
            // 
            // KK_radioButton3
            // 
            this.KK_radioButton3.AutoSize = true;
            this.KK_radioButton3.Location = new System.Drawing.Point(39, 246);
            this.KK_radioButton3.Name = "KK_radioButton3";
            this.KK_radioButton3.Size = new System.Drawing.Size(231, 46);
            this.KK_radioButton3.TabIndex = 4;
            this.KK_radioButton3.TabStop = true;
            this.KK_radioButton3.Text = "Autosize";
            this.KK_radioButton3.UseVisualStyleBackColor = true;
            this.KK_radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // KK_radioButton4
            // 
            this.KK_radioButton4.AutoSize = true;
            this.KK_radioButton4.Location = new System.Drawing.Point(39, 298);
            this.KK_radioButton4.Name = "KK_radioButton4";
            this.KK_radioButton4.Size = new System.Drawing.Size(183, 46);
            this.KK_radioButton4.TabIndex = 5;
            this.KK_radioButton4.TabStop = true;
            this.KK_radioButton4.Text = "Center";
            this.KK_radioButton4.UseVisualStyleBackColor = true;
            this.KK_radioButton4.CheckedChanged += new System.EventHandler(this.KK_radioButton4_CheckedChanged);
            // 
            // KK_radioButton5
            // 
            this.KK_radioButton5.AutoSize = true;
            this.KK_radioButton5.Location = new System.Drawing.Point(39, 348);
            this.KK_radioButton5.Name = "KK_radioButton5";
            this.KK_radioButton5.Size = new System.Drawing.Size(135, 46);
            this.KK_radioButton5.TabIndex = 6;
            this.KK_radioButton5.TabStop = true;
            this.KK_radioButton5.Text = "Zoom";
            this.KK_radioButton5.UseVisualStyleBackColor = true;
            this.KK_radioButton5.CheckedChanged += new System.EventHandler(this.KK_radioButton5_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // KKform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 520);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KK_radioButton5);
            this.Controls.Add(this.KK_radioButton4);
            this.Controls.Add(this.KK_radioButton3);
            this.Controls.Add(this.KK_radioButton2);
            this.Controls.Add(this.KK_radioButton1);
            this.Controls.Add(this.KK_frame1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "KKform2";
            this.Text = "KKform2";
            this.KK_frame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KK_pildid1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox KK_frame1;
        private System.Windows.Forms.PictureBox KK_pildid1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog KK_openFileDialog1;
        private System.Windows.Forms.RadioButton KK_radioButton1;
        private System.Windows.Forms.RadioButton KK_radioButton2;
        private System.Windows.Forms.RadioButton KK_radioButton3;
        private System.Windows.Forms.RadioButton KK_radioButton4;
        private System.Windows.Forms.RadioButton KK_radioButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}