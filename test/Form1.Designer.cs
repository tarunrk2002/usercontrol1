namespace test
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.second_button = new System.Windows.Forms.Button();
            this.first_button = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.second_button);
            this.panel1.Controls.Add(this.first_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 450);
            this.panel1.TabIndex = 0;
            // 
            // second_button
            // 
            this.second_button.Location = new System.Drawing.Point(22, 178);
            this.second_button.Name = "second_button";
            this.second_button.Size = new System.Drawing.Size(75, 23);
            this.second_button.TabIndex = 1;
            this.second_button.Text = "second";
            this.second_button.UseVisualStyleBackColor = true;
            this.second_button.Click += new System.EventHandler(this.second_button_Click);
            // 
            // first_button
            // 
            this.first_button.Location = new System.Drawing.Point(22, 76);
            this.first_button.Name = "first_button";
            this.first_button.Size = new System.Drawing.Size(75, 23);
            this.first_button.TabIndex = 0;
            this.first_button.Text = "first";
            this.first_button.UseVisualStyleBackColor = true;
            this.first_button.Click += new System.EventHandler(this.first_button_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(123, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(677, 450);
            this.MainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button second_button;
        private System.Windows.Forms.Button first_button;
        private System.Windows.Forms.Panel MainPanel;
    }
}

