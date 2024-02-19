namespace WinFormsApp
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
            btnClickThis = new Button();
            pictureBox1 = new PictureBox();
            OutputTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClickThis
            // 
            btnClickThis.Location = new Point(12, 424);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(292, 30);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "Select File\r\n";
            btnClickThis.UseVisualStyleBackColor = true;
            btnClickThis.Click += SelectFileButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 406);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new Point(467, 12);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.Size = new Size(410, 406);
            OutputTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 466);
            Controls.Add(OutputTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(btnClickThis);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickThis;
        private PictureBox pictureBox1;
        private TextBox OutputTextBox;
    }
}
