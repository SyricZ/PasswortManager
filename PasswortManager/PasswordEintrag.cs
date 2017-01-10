using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswortManager
{
    public partial class PasswordEintrag : UserControl
    {
        public Form1 attribut;

        public PasswordEintrag(Form1 form)
        {
            InitializeComponent();
            attribut = form;
        }

        public void SetName(String name)
        {
            label1.Text = name;
        }

        public void SetLogin(String login)
        {
            label4.Text = login;
        }

        public void SetPasswort(String passwort)
        {
            label5.Text = passwort;
        }

        private void cmd_DeletePE_Click(object sender, EventArgs e)
        {
            attribut.getFlowLayout().Controls.Remove(this);
        }

        private void cmd_editPE_Click(object sender, EventArgs e)
        {
            
        }
    }
}
