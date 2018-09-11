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
            this.timeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(44, 60);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(91, 57);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(123, 20);
            this.xBox.TabIndex = 9;
            this.xBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ybox
            // 
            this.ybox.Location = new System.Drawing.Point(91, 96);
            this.ybox.Name = "ybox";
            this.ybox.Size = new System.Drawing.Size(123, 20);
            this.ybox.TabIndex = 10;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(44, 99);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Y";
            // 
            // GetMouse
            // 
            this.GetMouse.Location = new System.Drawing.Point(18, 141);
            this.GetMouse.Name = "GetMouse";
            this.GetMouse.Size = new System.Drawing.Size(73, 23);
            this.GetMouse.TabIndex = 1;
            this.GetMouse.Text = "Get Mouse";
            this.GetMouse.UseVisualStyleBackColor = true;
            this.GetMouse.Click += new System.EventHandler(this.GetMouse_Click);
            // 
            // moveMouse
            // 
            this.moveMouse.Location = new System.Drawing.Point(98, 141);
            this.moveMouse.Name = "moveMouse";
            this.moveMouse.Size = new System.Drawing.Size(79, 23);
            this.moveMouse.TabIndex = 2;
            this.moveMouse.Text = "Move Mouse";
            this.moveMouse.UseVisualStyleBackColor = true;
            this.moveMouse.Click += new System.EventHandler(this.MoveMouse_Click);
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(92, 16);
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(118, 20);
            this.timeInput.TabIndex = 8;
            this.timeInput.Text = "1000";
            this.timeInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Times";
            // 
            // GO
            // 
            this.GO.Location = new System.Drawing.Point(184, 140);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(75, 23);
            this.GO.TabIndex = 3;
            this.GO.Text = "Go";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // MouseCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeInput);
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
        private System.Windows.Forms.TextBox timeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GO;
    }
}

