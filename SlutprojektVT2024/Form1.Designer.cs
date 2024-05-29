namespace SlutprojektVT2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 0;
            label1.Text = "Gissa färgen!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 19);
            label2.Name = "label2";
            label2.Size = new Size(376, 57);
            label2.TabIndex = 1;
            label2.Text = "När du klickar på startknappen kommer en färg att visas. \r\nDu ska sedan välja ett av de fyra alternativen under. \r\nLycka till!";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(200, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 52);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(243, 188);
            button1.Name = "button1";
            button1.Size = new Size(113, 35);
            button1.TabIndex = 3;
            button1.Text = "Starta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(243, 241);
            button2.Name = "button2";
            button2.Size = new Size(113, 38);
            button2.TabIndex = 4;
            button2.Text = "Poängrekord!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(112, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 87);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(575, 315);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(591, 354);
            MinimumSize = new Size(591, 354);
            Name = "Form1";
            Text = " Gissa färgen!";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
    }
}