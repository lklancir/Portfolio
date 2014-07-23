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
    public partial class FormZaposleniciNovi : Form
    {
        private zaposlenici zaposlenikZaIzmjenu;
        public FormZaposleniciNovi()
        {
            InitializeComponent();
        }

        //konstruktor koji služi za izmjenu zaposlenika
        //kao parametar prima zaposlenika koji se želi izmijeniti (tipa zaposlenici)
        public FormZaposleniciNovi(zaposlenici Zaposlenik)
        {
            InitializeComponent();
            zaposlenikZaIzmjenu = Zaposlenik;
        }

        private void FormZaposleniciNovi_Load(object sender, EventArgs e)
        {
            textZaposleniciPrezime.Focus();
            //ako se radi o izmjeni zaposlenika, ispuni polja sa njegovim podacima
            if (zaposlenikZaIzmjenu != null)
            {
                textZaposleniciOIB.Text = zaposlenikZaIzmjenu.OIB;
                textZaposleniciIme.Text = zaposlenikZaIzmjenu.ime;
                textZaposleniciPrezime.Text = zaposlenikZaIzmjenu.prezime;
                textZaposleniciKorime.Text = zaposlenikZaIzmjenu.korIme;
                textZaposleniciLozinka.Text = zaposlenikZaIzmjenu.lozinka;
                textZaposleniciAdresa.Text = zaposlenikZaIzmjenu.adresa;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnZaposleniciNoviSpremi_Click(object sender, EventArgs e)
        {

            using (var db = new appotekaDBEntities())
            {
                //ako se radi o novom unosu
                if (zaposlenikZaIzmjenu == null)
                {
                    //kreiraj novu instancu zaposlenika i ispuni atribute
                    zaposlenici Zaposlenik = new zaposlenici
                    {
                        OIB = textZaposleniciOIB.Text,
                        ime = textZaposleniciIme.Text,
                        prezime = textZaposleniciPrezime.Text,
                        korIme = textZaposleniciKorime.Text,
                        lozinka = textZaposleniciLozinka.Text,
                        adresa = textZaposleniciAdresa.Text
                    };
                    
                    //dodaj novog zaposlenika i spremi podatke u bazu
                        db.zaposlenici.Add(Zaposlenik);
                        db.SaveChanges();
                        MessageBox.Show("Uspješno ste dodali novog zaposlenika", "Ispravan unos");
                    
                }
                else
                {
                    //ako se radi o izmjeni zaposlenika
                    //attach zaposlenika na bazu, spremi unesene podatke za njega i spremi podatke u bazu
                    db.zaposlenici.Attach(zaposlenikZaIzmjenu);
                    zaposlenikZaIzmjenu.ime = textZaposleniciIme.Text;
                    zaposlenikZaIzmjenu.prezime = textZaposleniciPrezime.Text;
                    zaposlenikZaIzmjenu.korIme = textZaposleniciKorime.Text;
                    zaposlenikZaIzmjenu.lozinka = textZaposleniciLozinka.Text;
                    zaposlenikZaIzmjenu.adresa = textZaposleniciAdresa.Text;
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste izmijenili podatke o zaposleniku", "Promjena podataka");


                }


            }
            Close();
        }

        private void btnZaposleniciNoviIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        //kad se makne fokus s textboxa za OIB, ispitaj je li OIB ispravno unesen
        private void textZaposleniciOIB_Leave(object sender, EventArgs e)
        {
            if (textZaposleniciOIB.TextLength != 11)
            {               
                MessageBox.Show("OIB mora sadržavati 11 znakova", "Neispravan unos");
                textZaposleniciOIB.Focus();

            }
        }

        
    }
}
