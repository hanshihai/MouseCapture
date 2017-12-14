namespace HelloWorld
{
    partial class MouseCapture
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
            this.labelX = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.ybox = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.GetMouse = new System.Windows.Forms.Button();
            this.moveMouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(44, 46);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(91, 43);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(123, 20);
            this.xBox.TabIndex = 1;
            this.xBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ybox
            // 
            this.ybox.Location = new System.Drawing.Point(91, 82);
            this.ybox.Name = "ybox";
            this.ybox.Size = new System.Drawing.Size(123, 20);
            this.ybox.TabIndex = 2;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(44, 85);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Y";
            // 
            // GetMouse
            // 
            this.GetMouse.Location = new System.Drawing.Point(34, 141);
            this.GetMouse.Name = "GetMouse";
            this.GetMouse.Size = new System.Drawing.Size(98, 23);
            this.GetMouse.TabIndex = 3;
            this.GetMouse.Text = "Get Mouse";
            this.GetMouse.UseVisualStyleBackColor = true;
            this.GetMouse.Click += new System.EventHandler(this.GetMouse_Click);
            // 
            // moveMouse
            // 
            this.moveMouse.Location = new System.Drawing.Point(139, 141);
            this.moveMouse.Name = "moveMouse";
            this.moveMouse.Size = new System.Drawing.Size(113, 23);
            this.moveMouse.TabIndex = 4;
            this.moveMouse.Text = "Move Mouse";
            this.moveMouse.UseVisualStyleBackColor = true;
            this.moveMouse.Click += new System.EventHandler(this.MoveMouse_Click);
            // 
            // MouseCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.moveMouse);
            this.Controls.Add(this.GetMouse);
            this.Controls.Add(this.ybox);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.labelX);
            this.Name = "MouseCapture";
            this.Text = "MouseCapture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox ybox;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button GetMouse;
        private System.Windows.Forms.Button moveMouse;


    }
}

