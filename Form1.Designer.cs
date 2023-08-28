namespace DataStructureApp
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
            this.bttnUp = new System.Windows.Forms.Button();
            this.bttnDown = new System.Windows.Forms.Button();
            this.lstBoxStack2 = new System.Windows.Forms.ListBox();
            this.lstBoxStack1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.bttnUp);
            this.panel1.Controls.Add(this.bttnDown);
            this.panel1.Controls.Add(this.lstBoxStack2);
            this.panel1.Controls.Add(this.lstBoxStack1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 805);
            this.panel1.TabIndex = 0;
            // 
            // bttnUp
            // 
            this.bttnUp.Location = new System.Drawing.Point(341, 408);
            this.bttnUp.Name = "bttnUp";
            this.bttnUp.Size = new System.Drawing.Size(75, 60);
            this.bttnUp.TabIndex = 4;
            this.bttnUp.Text = "Arrow Up";
            this.bttnUp.UseVisualStyleBackColor = true;
            this.bttnUp.Click += new System.EventHandler(this.bttnUp_Click);
            // 
            // bttnDown
            // 
            this.bttnDown.Location = new System.Drawing.Point(151, 408);
            this.bttnDown.Name = "bttnDown";
            this.bttnDown.Size = new System.Drawing.Size(75, 60);
            this.bttnDown.TabIndex = 3;
            this.bttnDown.Text = "Arrow Down";
            this.bttnDown.UseVisualStyleBackColor = true;
            this.bttnDown.Click += new System.EventHandler(this.bttnDown_Click);
            // 
            // lstBoxStack2
            // 
            this.lstBoxStack2.FormattingEnabled = true;
            this.lstBoxStack2.Location = new System.Drawing.Point(5, 505);
            this.lstBoxStack2.Name = "lstBoxStack2";
            this.lstBoxStack2.Size = new System.Drawing.Size(616, 199);
            this.lstBoxStack2.TabIndex = 2;
            // 
            // lstBoxStack1
            // 
            this.lstBoxStack1.FormattingEnabled = true;
            this.lstBoxStack1.Location = new System.Drawing.Point(5, 181);
            this.lstBoxStack1.Name = "lstBoxStack1";
            this.lstBoxStack1.Size = new System.Drawing.Size(616, 199);
            this.lstBoxStack1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "STACK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(659, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 805);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 809);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnUp;
        private System.Windows.Forms.Button bttnDown;
        private System.Windows.Forms.ListBox lstBoxStack2;
        private System.Windows.Forms.ListBox lstBoxStack1;
    }
}

