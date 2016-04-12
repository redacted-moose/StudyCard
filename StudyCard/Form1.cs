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


        public StudyCard()
        {
            InitializeComponent();
            ls = new List<Deck>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Deck d = new Deck("test");
            // ls.Add(d);
            // textBox1.AppendText("test worked");
            // string thing = listView1.SelectedItems.ToString();
            // View the Deck!
            // new form (thing).Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudyCard_Load(object sender, EventArgs e)
        {

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
            // new NewDeckForm(this).Show();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SerializeElement();
        }

        private void SerializeElement()
        {
            // XmlSerializer ser = new XmlSerializer(typeof(Card));
            // TextWriter writer = new StreamWriter(filename);
            // ser.Serialize(writer, new Card("hey", "backstring--"));
            // writer.Close();
            // Card overview = new Card();
            Deck test = new Deck("testy");
            test.AddCard("front1", "back1");
            test.AddCard("iZombie", "Olivia");
            test.AddCard("Vmars", "Hollence");
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Deck));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//StudycardxmllOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file,test);
            file.Close();
        }

        public void ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Deck));
            System.IO.StreamReader file = new System.IO.StreamReader(
                @"C:\Users\edwardjh\Documents\StudycardxmllOverview.xml");
            Deck overview = (Deck)reader.Deserialize(file);
            file.Close();

            Console.WriteLine(overview.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReadXML();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
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
                MessageBox.Show(sr.ReadToEnd());
                
                sr.Close();
                System.Xml.Serialization.XmlSerializer reader =
                    new System.Xml.Serialization.XmlSerializer(typeof(Deck));
                System.IO.StreamReader file = new System.IO.StreamReader(
                    openFileDialog1.FileName);
                
                Deck overview = (Deck)reader.Deserialize(file);
                file.Close();

                Console.WriteLine(overview.ToString());
            }
        }
    }
}
