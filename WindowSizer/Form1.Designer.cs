namespace WindowSizer
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Running_lbl = new System.Windows.Forms.Label();
            this.CountOfRunning_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 180);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Apps Running";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Resize Apps Running";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Running_lbl
            // 
            this.Running_lbl.AutoSize = true;
            this.Running_lbl.Location = new System.Drawing.Point(293, 89);
            this.Running_lbl.Name = "Running_lbl";
            this.Running_lbl.Size = new System.Drawing.Size(73, 17);
            this.Running_lbl.TabIndex = 3;
            this.Running_lbl.Text = "# Running";
            // 
            // CountOfRunning_lbl
            // 
            this.CountOfRunning_lbl.AutoSize = true;
            this.CountOfRunning_lbl.Location = new System.Drawing.Point(384, 89);
            this.CountOfRunning_lbl.Name = "CountOfRunning_lbl";
            this.CountOfRunning_lbl.Size = new System.Drawing.Size(46, 17);
            this.CountOfRunning_lbl.TabIndex = 4;
            this.CountOfRunning_lbl.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 401);
            this.Controls.Add(this.CountOfRunning_lbl);
            this.Controls.Add(this.Running_lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Running_lbl;
        private System.Windows.Forms.Label CountOfRunning_lbl;
    }
}

