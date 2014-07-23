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
    public partial class FormKategorije : Form
    {
        public FormKategorije()
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
        

        private void PrikaziLijek()
        {
            kategorijeLijekova selektiranaKategorija = kategorijeLijekovaBindingSource.Current as kategorijeLijekova;
            if (selektiranaKategorija != null)
            {
                using (var db = new appotekaDBEntities())
                {
                    var lijek = from t3 in db.lijekovi 
                                from t2 in t3.kategorijeLijekova.Where(
             x => x.naziv == selektiranaKategorija.naziv)
                                select new { t3.serijskiBroj, t3.naziv};

                    this.dataGridKategorije.DataSource = lijek.ToList();
                }
            }
            
        }

        private void PrikaziLadice()
        {
            kategorijeLijekova selektiranaKategorija = kategorijeLijekovaBindingSource.Current as kategorijeLijekova;
            if (selektiranaKategorija != null)
            {
                using (var db = new appotekaDBEntities())
                {
                    var ladica = from t3 in db.ladice
                                from t2 in t3.kategorijeLijekova.Where(
             x => x.naziv == selektiranaKategorija.naziv)
                                select new { t3.kapacitet };

                    this.dataGridLadice.DataSource = ladica.ToList();
                }
            }

        }

        private void FormKategorije_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.lijekovi' table. You can move, or remove it, as needed.
            //this.lijekoviTableAdapter.Fill(this.appotekaDBDataSet2.lijekovi);
            // TODO: This line of code loads data into the 'appotekaDBDataSet1.kategorijeLijekova' table. You can move, or remove it, as needed.
            //this.kategorijeLijekovaTableAdapter.Fill(this.appotekaDBDataSet1.kategorijeLijekova);

            PrikaziKategorije();
        }

        private void btnKategorijeNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKategorijeNovi_Click(object sender, EventArgs e)
        {
            FormKategorijeNovi KategorijaNoviForma = new FormKategorijeNovi();
            KategorijaNoviForma.ShowDialog();
            PrikaziKategorije();
        }

        private void btnKategorijeIzmjeni_Click(object sender, EventArgs e)
        {
            kategorijeLijekova selektiranaKategorija = kategorijeLijekovaBindingSource.Current as kategorijeLijekova;
            if (selektiranaKategorija != null)
            {
                FormKategorijeNovi KategorijaNoviForma = new FormKategorijeNovi(selektiranaKategorija);
                KategorijaNoviForma.ShowDialog();
                PrikaziKategorije();

            }
        }

        private void btnKategorijeIzbrisi_Click(object sender, EventArgs e)
        {
            kategorijeLijekova selektiranaKategorija = kategorijeLijekovaBindingSource.Current as kategorijeLijekova;
            if (selektiranaKategorija != null)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new appotekaDBEntities())
                    {
                        db.kategorijeLijekova.Attach(selektiranaKategorija);


                        //brisanje kad postoje ladice za kategoriju ne radi, prvo treba obrisati ladice
                        //foreach (DataGridViewRow x in dataGridView1.Rows)
                        //{
                        //    if (x.Cells[1].Value != null)
                        //    {
                        //        int k = int.Parse(x.Cells[0].Value.ToString());
                        //        var ladica = (from l in db.ladice
                        //                      where l.IdLadice == k
                        //                      select l).SingleOrDefault();

                        //        //db.kategorijeLijekova.Remove(ladica);

                        //    }
                        //}

                        db.kategorijeLijekova.Remove(selektiranaKategorija);
                        db.SaveChanges();
                    }
                    PrikaziKategorije();
                }
            }
        }

        //kod promjene selektirane kategorije pozovi funkcije
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziLijek();
            PrikaziLadice();

        }


    }
}
