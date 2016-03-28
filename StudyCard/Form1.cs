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
    public partial class StudyCard : Form
    {
        public List<Deck> ls;

        public StudyCard()
        {
            InitializeComponent();
            ls = new List<Deck>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck d = new Deck("test");
            ls.Add(d);
            textBox1.AppendText("test worked");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudyCard_Load(object sender, EventArgs e)
        {

        }
    }
}
