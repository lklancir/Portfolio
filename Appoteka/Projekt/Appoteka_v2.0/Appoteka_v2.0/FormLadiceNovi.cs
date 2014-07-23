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
    public partial class FormLadiceNovi : Form
    {
        //ladica za izmjenu tipa ladica
        private ladice ladicaZaIzmjenu;
        public FormLadiceNovi()
        {
            InitializeComponent();
        }

        //konstruktor u slučaju izmjene ladice
        //prima parametar ladice koja se želi izmijeniti
        public FormLadiceNovi(ladice Ladica)
        {
            InitializeComponent();
            ladicaZaIzmjenu = Ladica;
        }


        private void FormLadiceNovi_Load(object sender, EventArgs e)
        {
            textLadiceNoviKapacitet.Focus();
            //ako se radi o izmjeni, ispuni tekstbox informacijom ladice koja se želi izmijeniti
            if (ladicaZaIzmjenu != null)
            {
                
                textLadiceNoviKapacitet.Text = ladicaZaIzmjenu.kapacitet.ToString();
            }
        }

        private void btnLadiceNoviSpremi_Click(object sender, EventArgs e)
        {
           
                using (var db = new appotekaDBEntities())
                {
                    //ako se dodaje nova ladica
                    if (ladicaZaIzmjenu == null)
                    {
                        //nova instanca ladice; popunjavaju se njeni atributi
                        ladice Ladica = new ladice
                        {
                            kapacitet = Convert.ToInt32(textLadiceNoviKapacitet.Text)

                        };
                        //promjene se spremaju u bazi
                        db.ladice.Add(Ladica);
                        db.SaveChanges();
                        MessageBox.Show("Uspješno ste dodali novu ladicu", "Ispravan unos");
                    }
                    else
                    {
                        //ako se radi o izmjeni, prvo se mora attach na bazu podataka i spremiti promjene
                        db.ladice.Attach(ladicaZaIzmjenu);
                        ladicaZaIzmjenu.kapacitet = Convert.ToInt32(textLadiceNoviKapacitet.Text);
                        db.SaveChanges();
                    }
                }
            
            Close();
        }

        private void btnLadiceNoviIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        //kad se makne fokus s textboxa, provjeri se je li unos ispravan (veci od 0)
        private void textLadiceNoviKapacitet_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textLadiceNoviKapacitet.Text) <= 0)
            {
                MessageBox.Show("Neispravan unos!");
                textLadiceNoviKapacitet.Focus();
            }
        }
    }
}
