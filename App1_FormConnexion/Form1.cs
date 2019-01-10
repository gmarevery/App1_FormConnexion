using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace App1_FormConnexion
{
    public partial class Form1 : Form
    {
        public List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("E:\\CPINFO\\_Net\\App1_FormConnexion\\utilisateur.txt"))
            {
                string userstring = System.IO.File.ReadAllText("E:\\CPINFO\\_Net\\App1_FormConnexion\\utilisateur.txt");
                foreach(string line in userstring.Split('|'))
                {
                    string identifiant = line.Split(';')[0];
                    string motdepasse = line.Split(';')[1];
                    Utilisateur user = new Utilisateur(identifiant, motdepasse);
                    lesUtilisateurs.Add(user);
                }
                
            }
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {

            string identifiantLogin = textBoxIdentifiant.Text;
            string motdepasseLogin = textBoxMotdepasse.Text;

            bool userOk = Connexion(identifiantLogin, motdepasseLogin, lesUtilisateurs);

            if (userOk == true)
            {
                Form2 fenetrecompte = new Form2();
                fenetrecompte.Show();
                this.Close();
            }

            else
            {
                labelErreurConnexion.Show();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        public bool Connexion(string identifiantLogin, string motdepasseLogin, List<Utilisateur> lesUtilisateurs)
        {
            bool valid = false;
            foreach (Utilisateur utilisateur in lesUtilisateurs)
            {
                if (identifiantLogin == utilisateur.identifiant & motdepasseLogin == utilisateur.motdepasse)
                {
                    valid = true;
                    return true;
                }
                else
                {
                    valid = false;
                }
            }

            return valid;
        }


    }
}
