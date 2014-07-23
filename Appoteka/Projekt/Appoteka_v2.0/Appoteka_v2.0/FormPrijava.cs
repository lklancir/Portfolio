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
    public partial class FormPrijava : Form
    {
       
        public FormPrijava()
        {
            InitializeComponent();
            //lozinku zamijeni znakom *
            textPrijavaLozinka.PasswordChar = '*';
        }

        private void provjeriZaposlenika()
        {
            
            using (var db = new appotekaDBEntities())
            {
                //usporedi uneseno korisnicko ime s onima koji se nalaze u bazi
                //ako postoji, ime se sprema u varijablu
                 var korime = (from z in db.zaposlenici where z.korIme == textPrijavaKorime.Text select z).SingleOrDefault();
                 
                //ako korisnicko ime postoji u bazi (korisnik postoji)
                if (korime != null)
                {
                    //provjeri lozinku za to korisnicko ime
                   var lozinka = (from l in db.zaposlenici
                                   where l.lozinka == textPrijavaLozinka.Text
                                   select l).SingleOrDefault();

                    //ako lozinka ne odgovara (korisnickom imenu) - greska
                   if (lozinka == null) MessageBox.Show("Neispravna lozinka", "Pogrešna prijava");

                       //ako lozinka odgovara (jednaka je unesenoj), dopusti ulaz u ostatak aplikacije - forma appoteka
                   else
                   {
                       FormAppoteka NovaFormaAppoteka = new FormAppoteka();
                       NovaFormaAppoteka.Show();
                       this.Hide();
                    }

                }
                    //ako je uneseno krivo korisnicko ime, javi gresku
                else
                    MessageBox.Show("Neispravno korisničko ime", "Pogrešna prijava");

            }
    }

        //na klik gumba provjeri unos podataka
        private void button1_Click(object sender, EventArgs e)
        {
            provjeriZaposlenika();
            
        }

        private void FormPrijava_Load(object sender, EventArgs e)
        {

        }

        //ako se tipkom enter zeli obaviti aktivnost
        private void FormPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                provjeriZaposlenika();
            }
        }

        private void textPrijavaKorime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                provjeriZaposlenika();
            }
        }

        private void textPrijavaLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                provjeriZaposlenika();
            }
        }
    }
}
