namespace KK_teineprojekt
{
    partial class KK_3
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
            this.KK_button2 = new System.Windows.Forms.Button();
            this.KK_textBox1 = new System.Windows.Forms.TextBox();
            this.KK_listBox1 = new System.Windows.Forms.ListBox();
            this.KK_checkBox2 = new System.Windows.Forms.CheckBox();
            this.KK_button4 = new System.Windows.Forms.Button();
            this.KK_button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KK_button2
            // 
            this.KK_button2.Location = new System.Drawing.Point(295, 71);
            this.KK_button2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.KK_button2.Name = "KK_button2";
            this.KK_button2.Size = new System.Drawing.Size(268, 41);
            this.KK_button2.TabIndex = 1;
            this.KK_button2.Text = "--->";
            this.KK_button2.UseVisualStyleBackColor = true;
            this.KK_button2.Click += new System.EventHandler(this.KK_button2_Click);
            // 
            // KK_textBox1
            // 
            this.KK_textBox1.Location = new System.Drawing.Point(18, 59);
            this.KK_textBox1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.KK_textBox1.Name = "KK_textBox1";
            this.KK_textBox1.Size = new System.Drawing.Size(239, 53);
            this.KK_textBox1.TabIndex = 2;
            // 
            // KK_listBox1
            // 
            this.KK_listBox1.FormattingEnabled = true;
            this.KK_listBox1.ItemHeight = 42;
            this.KK_listBox1.Location = new System.Drawing.Point(623, 17);
            this.KK_listBox1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.KK_listBox1.Name = "KK_listBox1";
            this.KK_listBox1.Size = new System.Drawing.Size(288, 256);
            this.KK_listBox1.TabIndex = 3;
            this.KK_listBox1.SelectedIndexChanged += new System.EventHandler(this.KK_listBox1_SelectedIndexChanged);
            // 
            // KK_checkBox2
            // 
            this.KK_checkBox2.AutoSize = true;
            this.KK_checkBox2.Checked = true;
            this.KK_checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KK_checkBox2.Location = new System.Drawing.Point(623, 284);
            this.KK_checkBox2.Name = "KK_checkBox2";
            this.KK_checkBox2.Size = new System.Drawing.Size(232, 46);
            this.KK_checkBox2.TabIndex = 4;
            this.KK_checkBox2.Text = "Unsorted";
            this.KK_checkBox2.UseVisualStyleBackColor = true;
            this.KK_checkBox2.CheckedChanged += new System.EventHandler(this.KK_checkBox2_CheckedChanged);
            // 
            // KK_button4
            // 
            this.KK_button4.Location = new System.Drawing.Point(295, 128);
            this.KK_button4.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.KK_button4.Name = "KK_button4";
            this.KK_button4.Size = new System.Drawing.Size(268, 41);
            this.KK_button4.TabIndex = 5;
            this.KK_button4.Text = "Delete";
            this.KK_button4.UseVisualStyleBackColor = true;
            this.KK_button4.Click += new System.EventHandler(this.KK_button4_Click);
            // 
            // KK_button5
            // 
            this.KK_button5.Location = new System.Drawing.Point(295, 185);
            this.KK_button5.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.KK_button5.Name = "KK_button5";
            this.KK_button5.Size = new System.Drawing.Size(268, 41);
            this.KK_button5.TabIndex = 6;
            this.KK_button5.Text = "Update";
            this.KK_button5.UseVisualStyleBackColor = true;
            this.KK_button5.Click += new System.EventHandler(this.KK_button5_Click);
            // 
            // KK_3
            // 
            this.AcceptButton = this.KK_button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.KK_button5);
            this.Controls.Add(this.KK_button4);
            this.Controls.Add(this.KK_checkBox2);
            this.Controls.Add(this.KK_listBox1);
            this.Controls.Add(this.KK_textBox1);
            this.Controls.Add(this.KK_button2);
            this.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "KK_3";
            this.Text = "KK_3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KK_3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button KK_button2;
        private System.Windows.Forms.TextBox KK_textBox1;
        private System.Windows.Forms.ListBox KK_listBox1;
        private System.Windows.Forms.CheckBox KK_checkBox2;
        private System.Windows.Forms.Button KK_button4;
        private System.Windows.Forms.Button KK_button5;
    }
}