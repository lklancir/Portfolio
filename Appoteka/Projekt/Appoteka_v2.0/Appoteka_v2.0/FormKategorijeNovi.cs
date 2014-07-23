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
    public partial class FormKategorijeNovi : Form
    {

        public static BindingList<ladice> ladicePrijenos;

        private kategorijeLijekova kategorijaZaIzmjenu;

        public FormKategorijeNovi()
        {
            InitializeComponent();
        }

        public FormKategorijeNovi(kategorijeLijekova kategorijaLijeka)
        {
            InitializeComponent();
            kategorijaZaIzmjenu = kategorijaLijeka;
        }

        public FormKategorijeNovi(BindingList<ladice> lR)
	    {
            InitializeComponent();
            ladicePrijenos = lR;
	    }

        private void FormKategorijeNovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ladice2.ladice' table. You can move, or remove it, as needed.
            this.ladiceTableAdapter.Fill(this.ladice2.ladice);
            textKategorijaNaziv.Focus();
            if (kategorijaZaIzmjenu != null)
            {
                textKategorijaNaziv.Text = kategorijaZaIzmjenu.naziv.ToString();
                textKategorijaOpis.Text = kategorijaZaIzmjenu.opis.ToString();
            }

            ladiceBindingSource.DataSource = ladicePrijenos;

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKategorijeNoviSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new appotekaDBEntities())
            {
                if (kategorijaZaIzmjenu == null)
                {
                    kategorijeLijekova kategorijaLijek = new kategorijeLijekova 
                    { 
                        naziv = textKategorijaNaziv.Text,
                        opis = textKategorijaOpis.Text
                    };


                    foreach (DataGridViewRow x in dataGridView1.Rows)
                    {
                        if (x.Cells[1].Value != null)
                        {
                            int k = int.Parse(x.Cells[0].Value.ToString());
                            var ladica = (from l in db.ladice
                                          where l.IdLadice == k
                                          select l).SingleOrDefault();

                            kategorijaLijek.ladice.Add(ladica);

                        }
                    }


                    db.kategorijeLijekova.Add(kategorijaLijek);
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste dodali novu kategoriju lijeka", "Ispravan unos");
                }
                else
                {
                    db.kategorijeLijekova.Attach(kategorijaZaIzmjenu);
                    kategorijaZaIzmjenu.naziv = textKategorijaNaziv.Text;
                    kategorijaZaIzmjenu.opis = textKategorijaOpis.Text;

                    

                    db.SaveChanges();
                }
            }
            Close();
        }

        private void btnDodajLadicu_Click(object sender, EventArgs e)
        {
            FormKategorijaLadica LadicaNoviForm = new FormKategorijaLadica();
            LadicaNoviForm.ShowDialog();
        }

        private void btnIzbriši_Click(object sender, EventArgs e)
        {
            ladice selektiranaLadica = ladiceBindingSource.Current as ladice;

            ladicePrijenos.Remove(selektiranaLadica);
            ladiceBindingSource.DataSource = ladicePrijenos;
        }

        private void FormKategorijeNovi_Activated(object sender, EventArgs e)
        {
            ladiceBindingSource.DataSource = ladicePrijenos;
        }

        
    }
}
