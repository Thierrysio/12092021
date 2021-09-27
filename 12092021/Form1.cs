using _12092021.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12092021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utilisateur U1 = new Commercial(1, "disney", "riri");
            Utilisateur U2 = new Adherent(2, "disney", "fifi", "adresse1", 32);

            int nb = Utilisateur.CollClasse.Count;
            int nb1 = Commercial.CollClasse.Count;
            int nb2 = Adherent.CollClasse.Count;

            if (U1.GetType().Name == "Commercial")
            {
                MessageBox.Show(U1.parler());
            }
        }
    }
}
