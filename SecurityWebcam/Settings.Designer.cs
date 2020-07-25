namespace ImageHashingApp
{
    partial class Settings
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
            this.label6 = new System.Windows.Forms.Label();
            this.TimeDropdown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MarginErrorDropdown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumPhotosDropdown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.directoryBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimeDropdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarginErrorDropdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPhotosDropdown)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "seconds";
            // 
            // TimeDropdown
            // 
            this.TimeDropdown.Location = new System.Drawing.Point(164, 69);
            this.TimeDropdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeDropdown.Name = "TimeDropdown";
            this.TimeDropdown.Size = new System.Drawing.Size(79, 22);
            this.TimeDropdown.TabIndex = 18;
            this.TimeDropdown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Percent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Time Duration";
            // 
            // MarginErrorDropdown
            // 
            this.MarginErrorDropdown.Location = new System.Drawing.Point(164, 27);
            this.MarginErrorDropdown.Name = "MarginErrorDropdown";
            this.MarginErrorDropdown.Size = new System.Drawing.Size(79, 22);
            this.MarginErrorDropdown.TabIndex = 15;
            this.MarginErrorDropdown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Magin Error";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "photos";
            // 
            // NumPhotosDropdown
            // 
            this.NumPhotosDropdown.Location = new System.Drawing.Point(164, 121);
            this.NumPhotosDropdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumPhotosDropdown.Name = "NumPhotosDropdown";
            this.NumPhotosDropdown.Size = new System.Drawing.Size(79, 22);
            this.NumPhotosDropdown.TabIndex = 21;
            this.NumPhotosDropdown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Number of Photos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Folder to save photos to";
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(206, 169);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(445, 22);
            this.directoryBox.TabIndex = 25;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directoryBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumPhotosDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimeDropdown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MarginErrorDropdown);
            this.Controls.Add(this.label4);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.TimeDropdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarginErrorDropdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPhotosDropdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown TimeDropdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MarginErrorDropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumPhotosDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox directoryBox;
    }
}