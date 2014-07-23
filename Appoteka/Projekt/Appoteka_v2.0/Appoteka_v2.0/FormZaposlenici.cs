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
    public partial class FormZaposlenici : Form
    {
        public FormZaposlenici()
        {
            InitializeComponent();
        }

        private void PrikaziZaposlenike()
        {
            BindingList<zaposlenici> listaZaposlenika = null;
            using (var db = new appotekaDBEntities())
            {
                listaZaposlenika = new BindingList<zaposlenici>(db.zaposlenici.ToList());
            }
            zaposleniciBindingSource.DataSource = listaZaposlenika;
        }

        private void FormZaposlenik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.zaposlenici' table. You can move, or remove it, as needed.
            //this.zaposleniciTableAdapter.Fill(this.appotekaDBDataSet2.zaposlenici);
            PrikaziZaposlenike();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormZaposleniciNovi ZaposleniciNoviForm = new FormZaposleniciNovi();
            ZaposleniciNoviForm.ShowDialog();
            PrikaziZaposlenike();
        }

        private void btnZaposleniciNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnZaposleniciIzmijeni_Click(object sender, EventArgs e)
        {
            zaposlenici selektiraniZaposlenik = zaposleniciBindingSource.Current as zaposlenici;
            if (selektiraniZaposlenik != null)
            {
                FormZaposleniciNovi ZaposlenikNoviForma = new FormZaposleniciNovi(selektiraniZaposlenik);
                ZaposlenikNoviForma.ShowDialog();
                PrikaziZaposlenike();
            }
        }

        private void btnZaposleniciIzbrisi_Click(object sender, EventArgs e)
        {
            zaposlenici selektiraniZaposlenik = zaposleniciBindingSource.Current as zaposlenici;
            if (selektiraniZaposlenik != null)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new appotekaDBEntities())
                    {
                        db.zaposlenici.Attach(selektiraniZaposlenik);
                        db.zaposlenici.Remove(selektiraniZaposlenik);
                        db.SaveChanges();
                    }
                    PrikaziZaposlenike();

                }
            }
        }
    }
}
