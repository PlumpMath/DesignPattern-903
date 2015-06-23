namespace DesignPattern.AbstractFactoryPattern
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
            this.Annual = new System.Windows.Forms.RadioButton();
            this.Vegetable = new System.Windows.Forms.RadioButton();
            this.Perennial = new System.Windows.Forms.RadioButton();
            this.Center = new System.Windows.Forms.CheckBox();
            this.Border = new System.Windows.Forms.CheckBox();
            this.Shade = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new DesignPattern.AbstractFactoryPattern.GdPic();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Annual
            // 
            this.Annual.AutoSize = true;
            this.Annual.Location = new System.Drawing.Point(43, 71);
            this.Annual.Name = "Annual";
            this.Annual.Size = new System.Drawing.Size(59, 16);
            this.Annual.TabIndex = 0;
            this.Annual.TabStop = true;
            this.Annual.Text = "Annual";
            this.Annual.UseVisualStyleBackColor = true;
            this.Annual.CheckedChanged += new System.EventHandler(this.Annual_CheckedChanged);
            // 
            // Vegetable
            // 
            this.Vegetable.AutoSize = true;
            this.Vegetable.Location = new System.Drawing.Point(43, 114);
            this.Vegetable.Name = "Vegetable";
            this.Vegetable.Size = new System.Drawing.Size(77, 16);
            this.Vegetable.TabIndex = 1;
            this.Vegetable.TabStop = true;
            this.Vegetable.Text = "Vegetable";
            this.Vegetable.UseVisualStyleBackColor = true;
            this.Vegetable.CheckedChanged += new System.EventHandler(this.Vegetable_CheckedChanged);
            // 
            // Perennial
            // 
            this.Perennial.AutoSize = true;
            this.Perennial.Location = new System.Drawing.Point(43, 155);
            this.Perennial.Name = "Perennial";
            this.Perennial.Size = new System.Drawing.Size(77, 16);
            this.Perennial.TabIndex = 2;
            this.Perennial.TabStop = true;
            this.Perennial.Text = "Perennial";
            this.Perennial.UseVisualStyleBackColor = true;
            this.Perennial.CheckedChanged += new System.EventHandler(this.Perennial_CheckedChanged);
            // 
            // Center
            // 
            this.Center.AutoSize = true;
            this.Center.Location = new System.Drawing.Point(182, 233);
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(60, 16);
            this.Center.TabIndex = 4;
            this.Center.Text = "Center";
            this.Center.UseVisualStyleBackColor = true;
            this.Center.CheckedChanged += new System.EventHandler(this.Center_CheckedChanged);
            // 
            // Border
            // 
            this.Border.AutoSize = true;
            this.Border.Location = new System.Drawing.Point(248, 233);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(60, 16);
            this.Border.TabIndex = 5;
            this.Border.Text = "Border";
            this.Border.UseVisualStyleBackColor = true;
            this.Border.CheckedChanged += new System.EventHandler(this.Border_CheckedChanged);
            // 
            // Shade
            // 
            this.Shade.AutoSize = true;
            this.Shade.Location = new System.Drawing.Point(314, 233);
            this.Shade.Name = "Shade";
            this.Shade.Size = new System.Drawing.Size(54, 16);
            this.Shade.TabIndex = 6;
            this.Shade.Text = "Shade";
            this.Shade.UseVisualStyleBackColor = true;
            this.Shade.CheckedChanged += new System.EventHandler(this.Shade_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(182, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 205);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Shade);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.Center);
            this.Controls.Add(this.Perennial);
            this.Controls.Add(this.Vegetable);
            this.Controls.Add(this.Annual);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Annual;
        private System.Windows.Forms.RadioButton Vegetable;
        private System.Windows.Forms.RadioButton Perennial;
        private System.Windows.Forms.CheckBox Center;
        private System.Windows.Forms.CheckBox Border;
        private System.Windows.Forms.CheckBox Shade;
        private GdPic pictureBox1;
    }
}