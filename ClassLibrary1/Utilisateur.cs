using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Utilisateur
    {
        public string identifiant;
        public string motdepasse;

        public Utilisateur()
        {

        }

        public Utilisateur(string vIdentifiant, string vMotdepasse)
        {
            identifiant = vIdentifiant;
            motdepasse = vMotdepasse;
        }

    }
}
