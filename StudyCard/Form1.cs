using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudyCard
{
    public partial class StudyCard : Form
    {
        public List<Deck> ls;
        public Deck currentDeck;
        private bool showingFront = false;
        private int currentDeckIndex = 0;

        public StudyCard()
        {
            InitializeComponent();
            ls = new List<Deck>();
            Deck test = new Deck("testy");
            test.AddCard("Please choose a deck or make a new deck", "back1");
            test.AddCard("iZombie", "Olivia");
            test.AddCard("Vmars", "Hollence");
            ls.Add(test);
            currentDeck = test;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //leave blank
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //leave blank
        }

        private void StudyCard_Load(object sender, EventArgs e)
        {
            //leave blank
        }

        internal void AddDeck(string text)
        {
            Deck d = new Deck(text);
            ls.Add(d);
            // textBox1.AppendText(text);
            // listView1.Items.Add(text);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //leave blank
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //leave blank
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SerializeElement();
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
            if(currentDeckIndex < currentDeck.getDeck().Count-1)
            {
                showingFront = true;
                currentDeckIndex++;
                textBox1.Text = currentDeck.getDeck()[currentDeckIndex].frontText;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            //leave blank
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
            //leave blank
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
            //leave blank
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
    }
}
