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
    public partial class FormLadice : Form
    {
        public FormLadice()
        {
            InitializeComponent();
        }

        private void PrikaziLadice()
        {
            BindingList<ladice> listaLadica = null;
            using (var db = new appotekaDBEntities())
            {
                listaLadica = new BindingList<ladice>(db.ladice.ToList());
            }

            ladiceBindingSource.DataSource = listaLadica;
        }

        private void FormLadice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.ladice' table. You can move, or remove it, as needed.
            //this.ladiceTableAdapter.Fill(this.appotekaDBDataSet2.ladice);
            PrikaziLadice();

        }

        private void btnLadiceNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLadiceNovi_Click(object sender, EventArgs e)
        {
            FormLadiceNovi LadiceNoviForma = new FormLadiceNovi();
            LadiceNoviForma.ShowDialog();
            PrikaziLadice();
        }

        private void btnLadiceIzmijeni_Click(object sender, EventArgs e)
        {
            ladice selektiranaLadica = ladiceBindingSource.Current as ladice;
            if (selektiranaLadica != null)
            {
                FormLadiceNovi LadiceNoviForma = new FormLadiceNovi(selektiranaLadica);
                LadiceNoviForma.ShowDialog();
                PrikaziLadice();

            }
        }

        private void btnLadiceIzbrisi_Click(object sender, EventArgs e)
        {
            ladice selektiranaLadica = ladiceBindingSource.Current as ladice;
            if (selektiranaLadica != null)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new appotekaDBEntities())
                    {
                        db.ladice.Attach(selektiranaLadica);
                        db.ladice.Remove(selektiranaLadica);
                        db.SaveChanges();
                    }
                    PrikaziLadice();
                }
            }
        }
    }
}
