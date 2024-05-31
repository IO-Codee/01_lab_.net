namespace Lab_1_Ilchenko
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
            dataSizeTextBox1 = new Lab_1_Ilchenko_Control_lib.DataSizeTextBox();
            use_button = new Button();
            text_label_1 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dataSizeTextBox1
            // 
            dataSizeTextBox1.Location = new Point(12, 12);
            dataSizeTextBox1.Name = "dataSizeTextBox1";
            dataSizeTextBox1.Size = new Size(362, 23);
            dataSizeTextBox1.TabIndex = 0;
            // 
            // use_button
            // 
            use_button.Location = new Point(12, 56);
            use_button.Name = "use_button";
            use_button.Size = new Size(97, 60);
            use_button.TabIndex = 2;
            use_button.Text = "Clean";
            use_button.UseVisualStyleBackColor = true;
            use_button.Click += use_button_Click;
            // 
            // text_label_1
            // 
            text_label_1.AutoSize = true;
            text_label_1.Location = new Point(142, 56);
            text_label_1.Name = "text_label_1";
            text_label_1.Size = new Size(80, 15);
            text_label_1.TabIndex = 3;
            text_label_1.Text = "Розмір даних";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 131);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 4;
            label1.Text = "Input format: 1234 mb";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 204);
            Controls.Add(label1);
            Controls.Add(text_label_1);
            Controls.Add(use_button);
            Controls.Add(dataSizeTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Lab_1_Ilchenko_Control_lib.DataSizeTextBox dataSizeTextBox1;
        private Button use_button;
        private Label text_label_1;
        private Label label1;
    }
}
