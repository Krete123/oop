namespace KK_teineprojekt
{
    partial class KK_formmain
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
            this.KK_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KK_button1
            // 
            this.KK_button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.KK_button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.KK_button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KK_button1.Location = new System.Drawing.Point(92, 57);
            this.KK_button1.Name = "KK_button1";
            this.KK_button1.Size = new System.Drawing.Size(388, 85);
            this.KK_button1.TabIndex = 0;
            this.KK_button1.Text = "22.01.2026";
            this.KK_button1.UseVisualStyleBackColor = false;
            this.KK_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KK_formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 392);
            this.Controls.Add(this.KK_button1);
            this.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "KK_formmain";
            this.Text = "KK_2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KK_button1;
    }
}

