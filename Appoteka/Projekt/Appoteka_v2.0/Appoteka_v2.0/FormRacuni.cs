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
    public partial class FormRacuni : Form
    {
        public FormRacuni()
        {
            InitializeComponent();
        }

        private void PrikaziRacune()
        {
            BindingList<racun> listaRacuna = null;
            using (var db = new appotekaDBEntities())
            {
                listaRacuna = new BindingList<racun >(db.racun.ToList());
            }
            racunBindingSource.DataSource = listaRacuna;
        }

        private void FormRacuni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.racun' table. You can move, or remove it, as needed.
            //this.racunTableAdapter.Fill(this.appotekaDBDataSet2.racun);
            PrikaziRacune();

        }

        private void btnRacuniNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRacuniNovi_Click(object sender, EventArgs e)
        {
            FormRacuniNovi RacuniNoviForm = new FormRacuniNovi();
            RacuniNoviForm.ShowDialog();
            PrikaziRacune();
        }

        private void btnRacuniIzmijeni_Click(object sender, EventArgs e)
        {
            racun selektiraniRacun = racunBindingSource.Current as racun;
            if (selektiraniRacun != null)
            {
                FormRacunPrikazi pr = new FormRacunPrikazi(selektiraniRacun);
                pr.ShowDialog();
                PrikaziRacune();

            }
        }

        private void btnRacunIzbrisi_Click(object sender, EventArgs e)
        {
            racun selektiraniRacun = racunBindingSource.Current as racun;
            if (selektiraniRacun != null)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new appotekaDBEntities())
                    {
                        db.racun.Attach(selektiraniRacun);
                        db.racun.Remove(selektiraniRacun);
                        db.SaveChanges();
                    }
                    PrikaziRacune();

                }
            }
        }
    }
}
