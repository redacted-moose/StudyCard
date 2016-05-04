using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCard
{
    public partial class EditCardForm: Form
    {

        StudyCard mainForm;
        Card currentCard;

        public EditCardForm(StudyCard mainForm, Card c)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.currentCard = c;
            textBox1.Text = currentCard.frontText;
            textBox2.Text = currentCard.backText;
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.currentCard.frontText = textBox1.Text;
            this.currentCard.backText = textBox2.Text;
            this.mainForm.setTextBox1(this.currentCard.frontText);
            this.Close();
        }
    }
}
