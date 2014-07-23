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
    public partial class FormRacunPrikazi : Form
    {

        private racun racunZaPrikaz;
        public FormRacunPrikazi()
        {
            InitializeComponent();
        }

        public FormRacunPrikazi(racun r)
        {
            InitializeComponent();
            racunZaPrikaz = r;
        }

        private void PrikaziRacun()
        {
            using (var db = new appotekaDBEntities())
            {
                var lijek = from t2 in db.lijekovi
                            from t1 in t2.racun.Where
         (x => x.IdrRacuna == racunZaPrikaz.IdrRacuna)
                            select new { t1.IdrRacuna, t2.naziv , t2.dopunsko };
                this.dataGridView1.DataSource = lijek.ToList();
            }
        }

        private void FormRacunPrikazi_Load(object sender, EventArgs e)
        {
            textIzdaoRacun.Text = racunZaPrikaz.OIB;
            textIznosRacun.Text = racunZaPrikaz.iznos.ToString();
            textDatum.Text = racunZaPrikaz.datum.ToString("dd.MM.yyyy");
            PrikaziRacun();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

    }
}
