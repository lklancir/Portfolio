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
    public partial class FormDodavanjeLijekova : Form
    {


        private static BindingList<lijekovi> prijenosLijeka = new BindingList<lijekovi>();

        public FormDodavanjeLijekova()
        {
            InitializeComponent();
            prijenosLijeka.Clear();
        }

        private void PrikaziLijekove()
        {
            BindingList<lijekovi> listaLijekova = null;
            using (var db = new appotekaDBEntities())
            {
                listaLijekova = new BindingList<lijekovi>(db.lijekovi.ToList());
            }
            lijekoviBindingSource4.DataSource = listaLijekova;
        }

        
        
        

        private void FormDodavanjeLijekova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.lijekovi_has_racun' table. You can move, or remove it, as needed.
            this.lijekovi_has_racunTableAdapter.Fill(this.appotekaDBDataSet2.lijekovi_has_racun);

            PrikaziLijekove();
            
        }
        

        private void btnDodajLijek_Click(object sender, EventArgs e)
        {
            lijekovi selektiraniLijek = lijekoviBindingSource4.Current as lijekovi;

            prijenosLijeka.Add(selektiraniLijek);
            lijekoviBindingSource7.DataSource = prijenosLijeka;
            
            
        }

        private void btnZavrsiDodajLijek_Click(object sender, EventArgs e)
        {
            
            FormRacuniNovi.lijekoviRacun = prijenosLijeka;
            FormNarudzbeNovi.lijekoviNarudzba = prijenosLijeka;

            
            this.Close();
            
        }

        private void btnOdustani_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
