using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary4;

namespace TextManipulatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            string text = inputTextBox.Text;

            bool isPalindrome = TextManipulator.IsPalindrome(text);
            int sentenceCount = TextManipulator.CountSentences(text);
            string reversedText = TextManipulator.ReverseString(text);

            isPalindromeLabel.Text = $"Является ли палиндромом: {isPalindrome}";
            sentenceCountLabel.Text = $"Количество предложений: {sentenceCount}";
            reversedTextLabel.Text = $"Перевернутый текст: {reversedText}";
        }

    }
}
