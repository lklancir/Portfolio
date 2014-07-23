using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appoteka_v2._0
{
    public partial class FormNarudzbeNovi : Form
    {
        private narudzbe narudzbaZaIzmjenu;
        public static BindingList<lijekovi> lijekoviNarudzba;
        
        public FormNarudzbeNovi()
        {
            InitializeComponent();
        }

        //konstruktor koji sluzi za izmjenu narudzbe
        //kao parametar prima narudzbu koja se zeli izmijeniti
        public FormNarudzbeNovi(narudzbe Narudzba)
        {
            InitializeComponent();
            narudzbaZaIzmjenu = Narudzba;
        }

        private void PrintanjeNarudzbe()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += printDocument_PrintPage;
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }

            
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            
            Graphics graphic = e.Graphics;

            Font font = new Font("Times New Roman", 12);
            Font font2 = new Font("Times New Roman", 12, FontStyle.Underline | FontStyle.Bold);
            Font font3 = new Font("Times New Roman", 12, FontStyle.Underline);

            SolidBrush brush = new SolidBrush(Color.Black);
            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 270 + +70;

            graphic.DrawString("Appoteka j.d.o.o", new Font("Times New Roman", 18,FontStyle.Bold), new SolidBrush(Color.Black), startX, startY);
            graphic.DrawString("42000 VARAŽDIN, Ludbreška 3 \nOIB: 22383729384 vl. Gazda Šef", font, new SolidBrush(Color.Black),startX, startY + 30);


            using (var db = new appotekaDBEntities())
            {
                int id = int.Parse(comboBoxDobavljac.SelectedValue.ToString());
                var dobavljac = (from d in db.dobavljaci where d.IdDobavljac == id select d).SingleOrDefault();

                string dobavljacNaziv = dobavljac.naziv;
                string OIB = dobavljac.OIB;
                string IBAN = dobavljac.IBAN;
                string adresa = dobavljac.adresa;
                string ispisDobavljac = adresa + "\nOIB: " + OIB + "\nIBAN: " + IBAN;
                graphic.DrawString(dobavljacNaziv, new Font("Times New Roman", 16, FontStyle.Bold), new SolidBrush(Color.Black), startX + 600, startY +80 );
                graphic.DrawString(ispisDobavljac, font, new SolidBrush(Color.Black), startX + 600, startY + 110);

            }

            string datum = "Datum: "+DateTime.Now.ToString("dd.MM.yyyy").PadRight(25);
            string vrijeme ="Vrijeme: "+DateTime.Now.ToString("hh:mm");
            string datumVrijeme = datum + vrijeme;
            graphic.DrawString(datumVrijeme, font, new SolidBrush(Color.Black),startX,startY +100 + 70);
            string izdao = "Narudžbu izdao: " + comboBoxZaposlenik.Text;
            graphic.DrawString(izdao, font, brush, startX, startY + 130 + +70);
            graphic.DrawString("NARUDŽBA broj: 33/2 ", new Font("Times New Roman", 12, FontStyle.Bold), brush, startX, startY + 160 + +70);

            string headSerijski = "Serijski broj".PadRight(25);
            string headNaziv = "Naziv".PadRight(22);
            string headProizvodac = "Proizvođač".PadRight(15);
            string headCijena = "Kupovna cijena".PadRight(25);
            string headKolicina = "Količina".PadRight(15);
            string headIznos = "Iznos__".PadRight(45);
            string glavnaLinija = headSerijski +headNaziv + headProizvodac + headCijena + headKolicina + headIznos;

            graphic.DrawString(glavnaLinija, font2, brush, startX, startY + 230 + +70);


            foreach (DataGridViewRow x in dataGridView2.Rows)
            {
                if (x.Cells[0].Value != null)
                {
                    string serijski = string.Format("{0}", x.Cells[0].Value.ToString()).PadRight(25);
                    string naziv = x.Cells[1].Value.ToString().PadRight(22);
                    string proizvodac = x.Cells[2].Value.ToString().PadRight(30);
                    string cijena = x.Cells[3].Value.ToString().PadRight(25);
                    string kolicina = x.Cells[4].Value.ToString().PadRight(15);
                    string iznos = string.Format("{0} kn",x.Cells[5].Value.ToString()).PadRight(45);
                    string linija = serijski + naziv + proizvodac + cijena + kolicina + iznos;

                    graphic.DrawString(linija, font, new SolidBrush(Color.Black), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5;

                }

              
            }
            offset = offset + 20;

            
            float PDV = float.Parse(textNarudzbeIznos.Text)*25/100;
            string PDVispis = PDV.ToString();
            float UKUPNO = float.Parse(textNarudzbeIznos.Text) + PDV;
            string UKUPNOispis = textNarudzbeIznos.Text;

            graphic.DrawString("UKUPNO: ".PadRight(32) + string.Format("{0} kn", UKUPNOispis), new Font("Times New Roman", 14, FontStyle.Bold), brush, startX, startY + offset + 50);


        
        }


        private void FormNarudzbeNovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.lijekovi' table. You can move, or remove it, as needed.
            this.lijekoviTableAdapter.Fill(this.appotekaDBDataSet2.lijekovi);
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter.Fill(this.appotekaDBDataSet2.zaposlenici);
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.dobavljaci' table. You can move, or remove it, as needed.
            this.dobavljaciTableAdapter.Fill(this.appotekaDBDataSet2.dobavljaci);
           
            textNarudzbeIznos.Focus();
            //ako se radi o izmjeni narudzbe
            //popuni polja sa podacima narudzbe koja se zeli izmijeniti
            if (narudzbaZaIzmjenu != null)
            {
                textNarudzbeIznos.Text = narudzbaZaIzmjenu.iznos.ToString();
                dateTimeNaruzbeDatum.MaxDate = narudzbaZaIzmjenu.datum;
            }

            
        }      

        private void btnNarudzbeNoviSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new appotekaDBEntities())
            {
                //ako se radi o unosu nove narudzbe, kreiraj novu instancu tipa narudzbe i popuni podacima
                if (narudzbaZaIzmjenu == null)
                {
                    narudzbe Narudzba = new narudzbe
                    {
                        iznos = Math.Round(Convert.ToSingle(textNarudzbeIznos.Text), 2),
                        datum = Convert.ToDateTime(dateTimeNaruzbeDatum.Text),
                        IdDobavljac = int.Parse(comboBoxDobavljac.SelectedValue.ToString()),
                        OIB = comboBoxZaposlenik.SelectedValue.ToString()
                    };
                    //dodaj narudzbu u bazu podataka
                    db.narudzbe.Add(Narudzba);

                    //za svaki red u datagrid-u gdje je vrijednost razlitica od null (gdje je unesena vrijednost)
                    //provjeri sb lijekova za koje se izdaje narudzba i dohvati podatke o tom lijeku
                    foreach (DataGridViewRow x in dataGridView2.Rows)
                    {
                        if (x.Cells[0].Value != null)
                        {
                            int sb = int.Parse(x.Cells[0].Value.ToString());
                            var lijek = (from l in db.lijekovi
                                         where
                                             l.serijskiBroj == sb
                                         select l).SingleOrDefault();
                            //u tablicu vise-vise spremi narudzbu i lijek koji je na njoj
                            Narudzba.lijekovi.Add(lijek);
                            db.SaveChanges();
                        }
                    }
                    //spremi promjene u bazi podataka
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste dodali novu narudžbu", "Ispravan unos");
                    PrintanjeNarudzbe();
                }
                else
                {
                    //ako se radi o izmjeni narudzbe, najprije se mora attach na bazu podataka
                    //unesene podatke spremiti kao njene atribute i spremiti promjene u bazi podataka
                    db.narudzbe.Attach(narudzbaZaIzmjenu);
                    narudzbaZaIzmjenu.iznos = Convert.ToSingle(textNarudzbeIznos.Text);
                    narudzbaZaIzmjenu.datum = Convert.ToDateTime(dateTimeNaruzbeDatum.Text);
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste izmijenili narudžbu", "Izmjena podataka");

                }


            }
            Close();
        }

        private void btnNarudzbeNoviIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDodavanjeLijekova dodaj = new FormDodavanjeLijekova();
            dodaj.ShowDialog();
            
        }

        private void FormNarudzbeNovi_Activated(object sender, EventArgs e)
        {
            lijekoviBindingSource4.DataSource = lijekoviNarudzba;
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            lijekoviBindingSource.DataSource = lijekoviNarudzba;
            float suma = 0;

            //za svaki red u datagrid-u provjeri unesene vrijednosti
            foreach (DataGridViewRow x in dataGridView2.Rows)
            {
                if (x.Cells[0].Value != null)
                {
                    try
                    {
                        //ako je unesena količina manja ili jednaka 0 - greška
                        if (int.Parse(x.Cells[4].Value.ToString()) <= 0) MessageBox.Show("Količina ne može biti negativna!");
                        else
                        {
                            //ako je unos ispravan, pomnozi kolicinu sa cijenom
                            suma += float.Parse(x.Cells[3].Value.ToString()) *
                                        float.Parse(x.Cells[4].Value.ToString());
                            //zapisi izracunati iznos 
                            x.Cells[5].Value = float.Parse(x.Cells[3].Value.ToString()) *
                                        float.Parse(x.Cells[4].Value.ToString());
                        }
                    }
                    catch
                    {
                        
                        MessageBox.Show("Niste unijeli količinu za " + x.Cells[1].Value.ToString());
                    }
                }
            }
            //zapisi izracunatu sumu u textbox
            textNarudzbeIznos.Text = suma.ToString();
        }

        
    }
}
