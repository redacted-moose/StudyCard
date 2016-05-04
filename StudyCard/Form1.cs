using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace StudyCard
{
    public partial class StudyCard : Form
    {
        public List<Deck> ls;
        public Deck currentDeck;
        private bool showingFront = true;
        private int currentDeckIndex = 0;

        public StudyCard()
        {
            InitializeComponent();
            ls = new List<Deck>();
            Deck test = new Deck("testy");
            test.AddCard("Welcome! Please choose a deck from which to study or make a new deck.", "back1");
            test.AddCard("iZombie", "Olivia");
            test.AddCard("Vmars", "Hollence");
            ls.Add(test);
            textBox1.Text = test.getDeck()[currentDeckIndex].frontText;
            currentDeck = test;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void StudyCard_Load(object sender, EventArgs e)
        {
        }

        internal void AddDeck(Deck d)
        {
            //ls.Add(d);
            currentDeck = d;
            currentDeckIndex = 0;
            textBox1.Text = currentDeck.getDeck()[currentDeckIndex].frontText;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open new dialog and ask for deck name
            //make new card dialog
            //end and save deck, then set that to be the current deck.
            NewDeckForm ndf = new NewDeckForm(this);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!showingFront)
            {
                textBox1.Text = currentDeck.getDeck()[currentDeckIndex].frontText;
                showingFront = true;
            }
            else
            {
                textBox1.Text = currentDeck.getDeck()[currentDeckIndex].backText;
                showingFront = false;
            }
        }

        private void SerializeElement()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Xml.Serialization.XmlSerializer writer =
                    new System.Xml.Serialization.XmlSerializer(typeof(Deck));
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                System.IO.FileStream file = System.IO.File.Create(path + openFileDialog1.FileName);
                writer.Serialize(file, currentDeck);
                Console.WriteLine("file should be there");
                file.Close();
            }
        }

        public void ReadXML()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Xml.Serialization.XmlSerializer reader =
                    new System.Xml.Serialization.XmlSerializer(typeof(Deck));
                System.IO.StreamReader file = new System.IO.StreamReader(
                    saveFileDialog1.FileName);
                Deck overview = (Deck)reader.Deserialize(file);
                file.Close();

                Console.WriteLine(overview.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentDeckIndex < currentDeck.getDeck().Count - 1)
            {
                showingFront = true;
                currentDeckIndex++;
                textBox1.Text = currentDeck.getDeck()[currentDeckIndex].frontText;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (currentDeckIndex > 0)
            {
                showingFront = true;
                currentDeckIndex--;
                textBox1.Text = currentDeck.getDeck()[currentDeckIndex].frontText;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                sr.Close();
                System.Xml.Serialization.XmlSerializer reader =
                    new System.Xml.Serialization.XmlSerializer(typeof(Deck));
                System.IO.StreamReader file = new System.IO.StreamReader(
                    openFileDialog1.FileName);
                Deck overview = (Deck)reader.Deserialize(file);
                currentDeck = overview;
                currentDeckIndex = 0;
                textBox1.Text = currentDeck.getDeck()[currentDeckIndex].frontText;
                showingFront = true;
                file.Close();
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Xml.Serialization.XmlSerializer writer =
                    new System.Xml.Serialization.XmlSerializer(typeof(Deck));
                System.IO.FileStream file = System.IO.File.Create(saveFileDialog1.FileName);
                writer.Serialize(file, currentDeck);
                file.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Deck));
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            var path = Directory.GetCurrentDirectory() + "\\" + currentDeck.name + ".xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, currentDeck);
            Console.WriteLine("file should be there" + path.ToString());
            file.Close();
        }

        private void addCardToDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDeckForm ndf = new NewDeckForm(this, currentDeck);
        }

        private void editCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCardForm ecf = new EditCardForm(this, currentDeck.getDeck()[currentDeckIndex]);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        public void setTextBox1(string ss)
        {
            this.textBox1.Text = ss;
        }
    }
}
