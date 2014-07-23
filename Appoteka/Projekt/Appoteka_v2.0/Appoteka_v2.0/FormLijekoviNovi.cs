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
    public partial class FormLijekoviNovi : Form
    {
        public static BindingList<kategorijeLijekova> LijekoviKategorije;


        public FormLijekoviNovi()
        {
            InitializeComponent();
        }

        private void btnLijekoviNoviIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        private lijekovi LijekZaIzmjenu;

        //konstruktor koji sluzi za izmjenu podataka, prima parametar lijek koji se zeli izmijeniti
        public FormLijekoviNovi(lijekovi Lijek)
        {
            InitializeComponent();
            LijekZaIzmjenu = Lijek;
        }

        private void FormLijekoviNovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet1.kategorijeLijekova' table. You can move, or remove it, as needed.
            //this.kategorijeLijekovaTableAdapter.Fill(this.appotekaDBDataSet1.kategorijeLijekova);
            textSerijskiBroj.Focus();

            //ako se radi o izmjeni lijeka, popuni podatke sa podacima o lijeku koji se zeli izmijeniti
            if (LijekZaIzmjenu != null)
            {
                textSerijskiBroj.Text = LijekZaIzmjenu.serijskiBroj.ToString();
                textNaziv.Text = LijekZaIzmjenu.naziv;
                textProizvodac.Text = LijekZaIzmjenu.proizvodac;
                textCijenaKupovna.Text = LijekZaIzmjenu.cijenaKupovna.ToString();
                textCijenaProdajna.Text = LijekZaIzmjenu.cijenaProdajna.ToString();
                dateRokTrajanja.MaxDate = LijekZaIzmjenu.rokTrajanja;
                textKolicina.Text = LijekZaIzmjenu.kolicina.ToString();
                textDopunsko.Text = LijekZaIzmjenu.dopunsko.ToString();
            }
        }

        
        private void btnLijekoviNoviSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new appotekaDBEntities())
            {
                //ako se radi o unosu novog lijeka, kreiraj novu instancu lijekova i popuni podacima koji su uneseni
                if (LijekZaIzmjenu == null)
                {
                    lijekovi Lijek = new lijekovi
                    {
                        serijskiBroj = Convert.ToInt32(textSerijskiBroj.Text),
                        naziv = textNaziv.Text,
                        proizvodac = textProizvodac.Text,
                        cijenaKupovna = Math.Round(Convert.ToSingle(textCijenaKupovna.Text), 2),
                        cijenaProdajna = Math.Round(Convert.ToSingle(textCijenaProdajna.Text), 2),
                        rokTrajanja = dateRokTrajanja.MaxDate,
                        kolicina = Convert.ToInt32(textKolicina.Text),
                        dopunsko = Convert.ToInt32(textDopunsko.Text)
                    };

                    
                        //prilikom unosa novog lijeka potrebno ga je svrstati u kategoriju
                    //kategorija se dodaje na formi te se uzima njezin id kako bi se dodijelio lijeku
                        foreach (DataGridViewRow x in dataGridView1.Rows)
                        {
                            if (x.Cells[1].Value != null)
                            {
                                //uzmi id pridruzene kategorije
                                int k = int.Parse(x.Cells[1].Value.ToString());
                                //nadi taj id u tablici kategorijelijekova
                                var kategorija = ( from kl in db.kategorijeLijekova 
                                                   where kl.IdKategorije == k select kl).SingleOrDefault();
                                //u tablicu vise-vise (lijek-kategorije) unesi podatke o novom lijeku i njegovoj kategoriji
                                Lijek.kategorijeLijekova.Add(kategorija);

                            }
                        }

                        //dodaj lijek i spremi ga u bazu
                        db.lijekovi.Add(Lijek);
                        db.SaveChanges();
                        MessageBox.Show("Uspješno ste dodali novi lijek", "Ispravan unos");
                    }

                    //ako se radi o izmjeni lijeka, prvo ga attach na bazu podataka
                    //zatim spremi unesene podatke kao njegove atribute i spremi ga u bazu
                else
                {
                    db.lijekovi.Attach(LijekZaIzmjenu);
                    LijekZaIzmjenu.serijskiBroj = Convert.ToInt32(textSerijskiBroj.Text);
                    LijekZaIzmjenu.naziv = textNaziv.Text;
                    LijekZaIzmjenu.proizvodac = textProizvodac.Text;
                    LijekZaIzmjenu.cijenaKupovna = Convert.ToSingle(textCijenaKupovna.Text);
                    LijekZaIzmjenu.cijenaProdajna = Convert.ToSingle(textCijenaProdajna.Text);
                    LijekZaIzmjenu.rokTrajanja = Convert.ToDateTime(dateRokTrajanja.Text);
                    LijekZaIzmjenu.kolicina = Convert.ToInt32(textKolicina.Text);
                    LijekZaIzmjenu.dopunsko = Convert.ToInt32(textDopunsko.Text);
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste izmijenili podatke o lijeku", "Izmjena podataka");
                }
            }

            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //otvaranje nove forme
        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            FormDodavanjeKategorija FormaDodajKategorije = new FormDodavanjeKategorija();
            FormaDodajKategorije.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormLijekoviNovi_Activated(object sender, EventArgs e)
        {
            kategorijeLijekovaBindingSource.DataSource = LijekoviKategorije;
        }

        private void btnIzbrisiKategoriju_Click(object sender, EventArgs e)
        {
            //oznacenu kategoriju spremi u novu varijablu tipa kategorija
            kategorijeLijekova selektiranaKategorija = kategorijeLijekovaBindingSource.Current as kategorijeLijekova;
            
            //izbrisi oznacenu kategoriju iz binding liste i spremi azuriranu listu
            LijekoviKategorije.Remove(selektiranaKategorija);
            kategorijeLijekovaBindingSource.DataSource = LijekoviKategorije;
        }

        //provjera ispravnosti unosa kod kolicine 
        private void textKolicina_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textKolicina.Text) <= 0)
            {
                MessageBox.Show("Neispravan unos");
                textKolicina.Focus();
            }
        }

        //provjera ispravnosti unosa kupovne cijene (nakon maknutog fokusa)
        private void textCijenaKupovna_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textCijenaKupovna.Text) <= 0)
            {
                MessageBox.Show("Neispravan unos");
                textCijenaKupovna.Focus();
            }
        }

        //provjera ispravnosti unosa prodajne cijene (nakon maknutog fokusa)
        private void textCijenaProdajna_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textCijenaProdajna.Text) <= 0)
            {
                MessageBox.Show("Neispravan unos");
                textCijenaProdajna.Focus();
            }
        }

        //provjera ispravnosti unosa dopunskog osiguranja (nakon maknutog fokusa)
        private void textDopunsko_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textDopunsko.Text) <= 0)
            {
                MessageBox.Show("Neispravan unos");
                textDopunsko.Focus();
            }
        }

        //provjera duljine serijskog broja (nakon maknutog fokusa)
        private void textSerijskiBroj_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textSerijskiBroj.Text) != 8)
            {
                MessageBox.Show("Serijski broj mora sadržavati 8 znakova", "Neispravan unos");
                textSerijskiBroj.Focus();
            }
        }
       
    }
}
