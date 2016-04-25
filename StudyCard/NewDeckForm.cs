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
    public partial class NewDeckForm : Form
    {

        StudyCard mainForm;
        Deck newDeck;

        public NewDeckForm()
        {
            InitializeComponent();
        }

        public NewDeckForm(StudyCard mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            textBox2.Hide();
            textBox3.Hide();
            label2.Hide();
            label3.Hide();
            button2.Hide();
            button3.Hide();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != string.Empty)
            {
                newDeck = new Deck(textBox1.Text);
                label1.Hide();
                textBox1.Hide();
                button1.Hide();
                //this.Close();
                textBox2.Show();
                textBox3.Show();
                label2.Show();
                label3.Show();
                button2.Show();
                button3.Show();
            }
        }

        private void NewDeckForm_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.AddDeck(newDeck);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                newDeck.AddCard(textBox2.Text, textBox3.Text);
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
