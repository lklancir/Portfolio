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
    public partial class FormNarudzbe : Form
    {
        public FormNarudzbe()
        {
            InitializeComponent();
        }

        private void PrikaziNarudzbe()
        {
            BindingList<narudzbe> listaNarudzbi = null;
            using (var db = new appotekaDBEntities())
            {
                listaNarudzbi = new BindingList<narudzbe>(db.narudzbe.ToList());
            }
            narudzbeBindingSource.DataSource = listaNarudzbi;
        }

        private void FormNarudzbe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.narudzbe' table. You can move, or remove it, as needed.
            //this.narudzbeTableAdapter.Fill(this.appotekaDBDataSet2.narudzbe);
            PrikaziNarudzbe();
        }

        private void btnNarudzbeNatrag_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnNarudzbeNovi_Click(object sender, EventArgs e)
        {
            FormNarudzbeNovi NarudzbeNoviForm = new FormNarudzbeNovi();
            NarudzbeNoviForm.ShowDialog();
            PrikaziNarudzbe();
        }

        private void btnNarudzbeIzmijeni_Click(object sender, EventArgs e)
        {

            narudzbe selektiranaNarudzba = narudzbeBindingSource.Current as narudzbe;
            if (selektiranaNarudzba != null)
            {
                FormNarudzbeNovi NarudzbaNoviForma = new FormNarudzbeNovi(selektiranaNarudzba);
                NarudzbaNoviForma.ShowDialog();
                PrikaziNarudzbe();
            }
        }

        private void btnNarudzbeIzbrisi_Click(object sender, EventArgs e)
        {
            narudzbe selektiranaNarudzba = narudzbeBindingSource.Current as narudzbe;
            if (selektiranaNarudzba != null)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new appotekaDBEntities())
                    {
                        db.narudzbe.Attach(selektiranaNarudzba);
                        db.narudzbe.Remove(selektiranaNarudzba);
                        db.SaveChanges();
                    }
                    PrikaziNarudzbe();

                }
            }
        }
    }
}
