namespace KK_esimene_projekt
{
    partial class KK_vorm1
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
            this.KK_text1 = new System.Windows.Forms.TextBox();
            this.KK_lable1 = new System.Windows.Forms.Label();
            this.KK_button1 = new System.Windows.Forms.Button();
            this.KK_label2 = new System.Windows.Forms.Label();
            this.KK_checkBox1 = new System.Windows.Forms.CheckBox();
            this.KK_Frame1 = new System.Windows.Forms.GroupBox();
            this.KK_timer1 = new System.Windows.Forms.Timer(this.components);
            this.KK_label3 = new System.Windows.Forms.Label();
            this.KK_rdbn1 = new System.Windows.Forms.RadioButton();
            this.KK_rdbn2 = new System.Windows.Forms.RadioButton();
            this.KK_rdbn3 = new System.Windows.Forms.RadioButton();
            this.KK_checkBox2 = new System.Windows.Forms.CheckBox();
            this.KK_Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KK_text1
            // 
            this.KK_text1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.KK_text1.Location = new System.Drawing.Point(19, 34);
            this.KK_text1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.KK_text1.Name = "KK_text1";
            this.KK_text1.Size = new System.Drawing.Size(392, 44);
            this.KK_text1.TabIndex = 0;
            this.KK_text1.TextChanged += new System.EventHandler(this.KK_text1_TextChanged);
            // 
            // KK_lable1
            // 
            this.KK_lable1.BackColor = System.Drawing.Color.Violet;
            this.KK_lable1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KK_lable1.Location = new System.Drawing.Point(602, 34);
            this.KK_lable1.Name = "KK_lable1";
            this.KK_lable1.Size = new System.Drawing.Size(232, 44);
            this.KK_lable1.TabIndex = 1;
            // 
            // KK_button1
            // 
            this.KK_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.KK_button1.Location = new System.Drawing.Point(424, 34);
            this.KK_button1.Name = "KK_button1";
            this.KK_button1.Size = new System.Drawing.Size(160, 44);
            this.KK_button1.TabIndex = 2;
            this.KK_button1.Text = "--->";
            this.KK_button1.UseVisualStyleBackColor = false;
            this.KK_button1.Click += new System.EventHandler(this.KK_button1_Click);
            // 
            // KK_label2
            // 
            this.KK_label2.BackColor = System.Drawing.Color.Violet;
            this.KK_label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KK_label2.Location = new System.Drawing.Point(602, 105);
            this.KK_label2.Name = "KK_label2";
            this.KK_label2.Size = new System.Drawing.Size(232, 44);
            this.KK_label2.TabIndex = 3;
            // 
            // KK_checkBox1
            // 
            this.KK_checkBox1.AutoSize = true;
            this.KK_checkBox1.Checked = true;
            this.KK_checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KK_checkBox1.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.KK_checkBox1.Location = new System.Drawing.Point(399, 105);
            this.KK_checkBox1.Name = "KK_checkBox1";
            this.KK_checkBox1.Size = new System.Drawing.Size(185, 27);
            this.KK_checkBox1.TabIndex = 4;
            this.KK_checkBox1.Text = "Suured tähed";
            this.KK_checkBox1.UseVisualStyleBackColor = true;
            this.KK_checkBox1.CheckedChanged += new System.EventHandler(this.KK_checkBox1_CheckedChanged);
            // 
            // KK_Frame1
            // 
            this.KK_Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.KK_Frame1.Controls.Add(this.KK_checkBox2);
            this.KK_Frame1.Controls.Add(this.KK_rdbn3);
            this.KK_Frame1.Controls.Add(this.KK_rdbn2);
            this.KK_Frame1.Controls.Add(this.KK_rdbn1);
            this.KK_Frame1.Controls.Add(this.KK_label3);
            this.KK_Frame1.Location = new System.Drawing.Point(50, 195);
            this.KK_Frame1.Name = "KK_Frame1";
            this.KK_Frame1.Size = new System.Drawing.Size(747, 357);
            this.KK_Frame1.TabIndex = 5;
            this.KK_Frame1.TabStop = false;
            this.KK_Frame1.Enter += new System.EventHandler(this.KK_Frame1_Enter);
            // 
            // KK_timer1
            // 
            this.KK_timer1.Enabled = true;
            this.KK_timer1.Interval = 1000;
            this.KK_timer1.Tick += new System.EventHandler(this.KK_timer1_Tick);
            // 
            // KK_label3
            // 
            this.KK_label3.BackColor = System.Drawing.Color.HotPink;
            this.KK_label3.Location = new System.Drawing.Point(53, 60);
            this.KK_label3.Name = "KK_label3";
            this.KK_label3.Size = new System.Drawing.Size(494, 77);
            this.KK_label3.TabIndex = 0;
            // 
            // KK_rdbn1
            // 
            this.KK_rdbn1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.KK_rdbn1.AutoSize = true;
            this.KK_rdbn1.Checked = true;
            this.KK_rdbn1.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.KK_rdbn1.Location = new System.Drawing.Point(55, 159);
            this.KK_rdbn1.Name = "KK_rdbn1";
            this.KK_rdbn1.Size = new System.Drawing.Size(237, 26);
            this.KK_rdbn1.TabIndex = 1;
            this.KK_rdbn1.TabStop = true;
            this.KK_rdbn1.Text = "Kuupäev ja kellaaeg";
            this.KK_rdbn1.UseVisualStyleBackColor = true;
            // 
            // KK_rdbn2
            // 
            this.KK_rdbn2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.KK_rdbn2.AutoSize = true;
            this.KK_rdbn2.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.KK_rdbn2.Location = new System.Drawing.Point(55, 200);
            this.KK_rdbn2.Name = "KK_rdbn2";
            this.KK_rdbn2.Size = new System.Drawing.Size(105, 26);
            this.KK_rdbn2.TabIndex = 2;
            this.KK_rdbn2.Text = "Kuupäev";
            this.KK_rdbn2.UseVisualStyleBackColor = true;
            // 
            // KK_rdbn3
            // 
            this.KK_rdbn3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.KK_rdbn3.AutoSize = true;
            this.KK_rdbn3.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.KK_rdbn3.Location = new System.Drawing.Point(55, 241);
            this.KK_rdbn3.Name = "KK_rdbn3";
            this.KK_rdbn3.Size = new System.Drawing.Size(116, 26);
            this.KK_rdbn3.TabIndex = 3;
            this.KK_rdbn3.Text = "Kellaaeg";
            this.KK_rdbn3.UseVisualStyleBackColor = true;
            // 
            // KK_checkBox2
            // 
            this.KK_checkBox2.AutoSize = true;
            this.KK_checkBox2.Location = new System.Drawing.Point(553, 104);
            this.KK_checkBox2.Name = "KK_checkBox2";
            this.KK_checkBox2.Size = new System.Drawing.Size(15, 14);
            this.KK_checkBox2.TabIndex = 4;
            this.KK_checkBox2.UseVisualStyleBackColor = true;
            this.KK_checkBox2.CheckedChanged += new System.EventHandler(this.KKcheckBox2_CheckedChanged);
            // 
            // KK_vorm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1134, 626);
            this.Controls.Add(this.KK_Frame1);
            this.Controls.Add(this.KK_checkBox1);
            this.Controls.Add(this.KK_label2);
            this.Controls.Add(this.KK_button1);
            this.Controls.Add(this.KK_lable1);
            this.Controls.Add(this.KK_text1);
            this.Font = new System.Drawing.Font("Courier New", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "KK_vorm1";
            this.Text = "08.01.2026";
            this.KK_Frame1.ResumeLayout(false);
            this.KK_Frame1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KK_text1;
        private System.Windows.Forms.Label KK_lable1;
        private System.Windows.Forms.Button KK_button1;
        private System.Windows.Forms.Label KK_label2;
        private System.Windows.Forms.CheckBox KK_checkBox1;
        private System.Windows.Forms.GroupBox KK_Frame1;
        private System.Windows.Forms.Label KK_label3;
        private System.Windows.Forms.Timer KK_timer1;
        private System.Windows.Forms.RadioButton KK_rdbn3;
        private System.Windows.Forms.RadioButton KK_rdbn2;
        private System.Windows.Forms.RadioButton KK_rdbn1;
        private System.Windows.Forms.CheckBox KK_checkBox2;
    }
}

