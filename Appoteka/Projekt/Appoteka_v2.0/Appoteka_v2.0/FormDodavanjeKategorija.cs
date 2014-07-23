using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appoteka_v2._0
{
    public partial class FormDodavanjeKategorija : Form
    {
        private static BindingList<kategorijeLijekova> prijenosKategorija = new BindingList<kategorijeLijekova>();

        public FormDodavanjeKategorija()
        {
            InitializeComponent();
        }

        private void PrikaziKategorije()
        {
            BindingList<kategorijeLijekova> listaKategorija = null;
            using (var db = new appotekaDBEntities())
            {
                listaKategorija = new BindingList<kategorijeLijekova>(db.kategorijeLijekova.ToList());
            }
            kategorijeLijekovaBindingSource.DataSource = listaKategorija;
        }

        private void FormDodavanjeKategorija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.kategorijeLijekova' table. You can move, or remove it, as needed.
            //this.kategorijeLijekovaTableAdapter.Fill(this.appotekaDBDataSet2.kategorijeLijekova);
            PrikaziKategorije();
            prijenosKategorija.Clear();

        }

        private void btnNatragKategorije_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnZavrsiKategorije_Click(object sender, EventArgs e)
        {
            FormLijekoviNovi.LijekoviKategorije = prijenosKategorija;

            this.Close();
        }

        private void btnDodajKategorije_Click(object sender, EventArgs e)
        {
            //trenutno selektiranu kategoriju spremi u varijablu tipa kategorija
            kategorijeLijekova selektiranaKategorija = kategorijeLijekovaBindingSource.Current as kategorijeLijekova;

            //ako binding list ne prijenosKategorija sadrži selektiranu kategoriju, stavi je u binding list
            //sprječava da se jedna kategorija unese više puta
            if (!prijenosKategorija.Contains(selektiranaKategorija))
            {
                prijenosKategorija.Add(selektiranaKategorija);
                kategorijeLijekovaBindingSource2.DataSource = prijenosKategorija;
            }
            else MessageBox.Show("Već ste unijeli ovu kategoriju", "Neispravan unos");
            
                
        }
    }
}
