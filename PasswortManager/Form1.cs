// © 2017 by .SyricZ™
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PasswortManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // remove grip style 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
        }

        private void IconToBitmap(PaintEventArgs e)
        {
            // Construct an Icon.
            Icon icon1 = new Icon(SystemIcons.Exclamation, 40, 40);

            // Call ToBitmap to convert it.
            Bitmap bmp = icon1.ToBitmap();

            // Draw the bitmap.
            e.Graphics.DrawImage(bmp, new Point(30, 30));
        }

        struct PasswordManager
        {
            public string name;
            public string login;
            public string password;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            string Pfad = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pfad = openFileDialog1.FileName;

                // Datei open
                string zeile = File.ReadAllText(Pfad);
                String[] zeilen = zeile.Split('\n');

                foreach (String c in zeilen)
                {
                    String line = c.Trim();
                    String[] spalten = line.Split(',');

                    if (spalten.Length < 3)
                    {
                        continue;
                    }

                    PasswordEintrag pe = new PasswordEintrag(this);
                    pe.SetName(spalten[0]);
                    pe.SetLogin(spalten[1]);
                    pe.SetPasswort(spalten[2]);

                    flowLayout.Controls.Add(pe);
                }
            }
        }

        private void cmd_searchButton_Click(object sender, EventArgs e)
        {
            List<Type> search = new List<Type>();

        }

        private void cmd_Copyright_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© 2017 by SyricZ™\n", "Copyright");
        }

        private void ll_Km_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.elitepvpers.com/forum/members/5841620-syricz-.html");
        }

        private void tB_Passwort_TextChanged(object sender, EventArgs e)
        {
            tB_Passwort.PasswordChar = '*';
        }

        private void cmd_Safe_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Filter = "Textdatei *.txt|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (tB_Name.Text == "" && tB_Passwort.Text == "" && tB_Login.Text == "" && cB_SowAh.Checked)
                {
                    StreamWriter datei = new StreamWriter(save.FileName, true);
                    datei.WriteLine(String.Format("{0},{1},{2}", tB_Name.Text, tB_Login.Text, tB_Passwort.Text));
                    datei.Flush();
                    datei.Close();
                }
                else
                {
                    MessageBox.Show("Bitte alle drei Einträge ausfüllen oder die Checkbox anklicken!", "Fehlermeldung");
                }
            }
        }
        
        private void cmd_Refresh_Click(object sender, EventArgs e)
        {

        }

        public FlowLayoutPanel getFlowLayout()
        {
            return flowLayout;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Pfad = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pfad = openFileDialog1.FileName;

                // Datei open
                string zeile = File.ReadAllText(Pfad);
                String[] zeilen = zeile.Split('\n');

                foreach (String c in zeilen)
                {
                    String line = c.Trim();
                    String[] spalten = line.Split(',');

                    if (spalten.Length < 3)
                    {
                        continue;
                    }

                    PasswordEintrag pe = new PasswordEintrag(this);
                    pe.SetName(spalten[0]);
                    pe.SetLogin(spalten[1]);
                    pe.SetPasswort(spalten[2]);

                    flowLayout.Controls.Add(pe);
                }
            }
        }
    }
}
