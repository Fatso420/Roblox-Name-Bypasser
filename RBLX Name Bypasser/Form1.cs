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

namespace RBLX_Name_Bypasser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateBypass(int l)
        {
            int a = 0;
            while (a != l)
            {
                var nouns = new List<string> { "Nljrgeir", "Kumbucket", "Fayygot", "Arse", "CIi_t", "HltI1_er", "Retar_1d", "Iesbi4en", "C4ock" };
                int index = new Random().Next(nouns.Count);
                var rnoun = nouns[index];
                nouns.RemoveAt(index);
                var adjectives = new List<string> { "Sxxexy", "Throbblng", "Stanky", "Wet", "Quaking", "Mois1t", "Juiclng", "Sweaty", "Ejacu1latlng" };
                int index2 = new Random().Next(adjectives.Count);
                var radjective = adjectives[index2];
                adjectives.RemoveAt(index2);
                var n = new Random().Next(11, 99);
                if (!listBox1.Items.Contains(radjective + rnoun + n))
                {
                    listBox1.Items.Add(radjective + rnoun + n);
                    a++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CreateBypass(Convert.ToInt32(textBox1.Text));
            }
            catch(Exception)
            {
                MessageBox.Show("Type a number1!1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(string l in listBox1.Items)
            {
                using (StreamWriter sw = File.AppendText(Application.StartupPath + @"\Saves\Bypasses.txt"))
                {
                    sw.WriteLine(l);
                }
            }
        }
    }
}
