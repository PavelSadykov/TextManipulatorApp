namespace TextManipulatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.isPalindromeLabel = new System.Windows.Forms.Label();
            this.reversedTextLabel = new System.Windows.Forms.Label();
            this.sentenceCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(31, 34);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(543, 27);
            this.inputTextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(629, 34);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(104, 27);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "ENTER";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // isPalindromeLabel
            // 
            this.isPalindromeLabel.AutoSize = true;
            this.isPalindromeLabel.Location = new System.Drawing.Point(28, 73);
            this.isPalindromeLabel.Name = "isPalindromeLabel";
            this.isPalindromeLabel.Size = new System.Drawing.Size(19, 13);
            this.isPalindromeLabel.TabIndex = 2;
            this.isPalindromeLabel.Text = "....";
            // 
            // reversedTextLabel
            // 
            this.reversedTextLabel.AutoSize = true;
            this.reversedTextLabel.Location = new System.Drawing.Point(28, 140);
            this.reversedTextLabel.Name = "reversedTextLabel";
            this.reversedTextLabel.Size = new System.Drawing.Size(19, 13);
            this.reversedTextLabel.TabIndex = 3;
            this.reversedTextLabel.Text = "....";
            // 
            // sentenceCountLabel
            // 
            this.sentenceCountLabel.AutoSize = true;
            this.sentenceCountLabel.Location = new System.Drawing.Point(28, 102);
            this.sentenceCountLabel.Name = "sentenceCountLabel";
            this.sentenceCountLabel.Size = new System.Drawing.Size(19, 13);
            this.sentenceCountLabel.TabIndex = 4;
            this.sentenceCountLabel.Text = "....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sentenceCountLabel);
            this.Controls.Add(this.reversedTextLabel);
            this.Controls.Add(this.isPalindromeLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label isPalindromeLabel;
        private System.Windows.Forms.Label reversedTextLabel;
        private System.Windows.Forms.Label sentenceCountLabel;
    }
}

