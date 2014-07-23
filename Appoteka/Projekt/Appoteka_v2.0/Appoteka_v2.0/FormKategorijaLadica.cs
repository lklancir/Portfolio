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
    public partial class FormKategorijaLadica : Form
    {


        private static BindingList<ladice> prijenosLadice = new BindingList<ladice>();
        BindingList<ladice> listaLadica = null;

        public FormKategorijaLadica()
        {
            InitializeComponent();
            prijenosLadice.Clear();
        }

        private void PrikaziLadice()
        {
            //BindingList<ladice> listaLadica = null;
            using (var db = new appotekaDBEntities())
            {
                listaLadica = new BindingList<ladice>(db.ladice.ToList());
            }
            ladiceBindingSource3.DataSource = listaLadica;
        }

        private void FormKategorijaLadica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ladice2.ladice' table. You can move, or remove it, as needed.
            //this.ladiceTableAdapter3.Fill(this.ladice2.ladice);
            // TODO: This line of code loads data into the 'ladice1.ladice' table. You can move, or remove it, as needed.
            //this.ladiceTableAdapter2.Fill(this.ladice1.ladice);

            PrikaziLadice();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        ladice selektiranaLadica = ladiceBindingSource3.Current as ladice;

        if (!prijenosLadice.Contains(selektiranaLadica))
        {
            prijenosLadice.Add(selektiranaLadica);
            ladiceBindingSource2.DataSource = prijenosLadice;

        }
        else
        {
            MessageBox.Show("Već ste unjeli ovu ladicu!", "Pogreška!");
        }
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            FormKategorijeNovi.ladicePrijenos = prijenosLadice;
            
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
