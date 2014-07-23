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
    public partial class FormAppoteka : Form
    {
        public FormAppoteka()
        {
            InitializeComponent();
        }

        //klikom na odabrano otvara se nova forma 

        private void miBrowseLijekovi_MouseUp(object sender, MouseEventArgs e)
        {
            FormLijekovi LijekoviForma = new FormLijekovi();
            LijekoviForma.MdiParent = this;
            LijekoviForma.WindowState = FormWindowState.Maximized;
            LijekoviForma.Show();
        }

        private void miFileExit_MouseUp(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void miManagementKategorije_MouseUp(object sender, MouseEventArgs e)
        {
            FormKategorije KategorijeForm = new FormKategorije();
            KategorijeForm.MdiParent = this;
            KategorijeForm.WindowState = FormWindowState.Maximized;
            KategorijeForm.Show();
        }

        private void miHzzoProvjeri_Click(object sender, EventArgs e)
        {
            FormHzzoProvjeri ProvjeriForm = new FormHzzoProvjeri();
            ProvjeriForm.MdiParent = this;
            ProvjeriForm.WindowState = FormWindowState.Maximized;
            ProvjeriForm.Show();
        }

        private void miManagementLadice_MouseUp(object sender, MouseEventArgs e)
        {
            FormLadice LadiceForm = new FormLadice();
            LadiceForm.MdiParent = this;
            LadiceForm.WindowState = FormWindowState.Maximized;
            LadiceForm.Show();
        }

        private void miManagementZaposlenici_MouseUp(object sender, MouseEventArgs e)
        {
            FormZaposlenici ZaposleniciForm = new FormZaposlenici();
            ZaposleniciForm.MdiParent = this;
            ZaposleniciForm.WindowState = FormWindowState.Maximized;
            ZaposleniciForm.Show();
        }

        private void miManagementDobavljaci_MouseUp(object sender, MouseEventArgs e)
        {
            FormDobavljaci DobavljaciForm = new FormDobavljaci();
            DobavljaciForm.MdiParent = this;
            DobavljaciForm.WindowState = FormWindowState.Maximized;
            DobavljaciForm.Show();
        }

        private void managmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void miBrowseRacuni_MouseUp(object sender, MouseEventArgs e)
        {
            FormRacuni RacuniForm = new FormRacuni();
            RacuniForm.MdiParent = this;
            RacuniForm.WindowState = FormWindowState.Maximized;
            RacuniForm.Show();
        }

        private void miBrowseNarudzbe_MouseUp(object sender, MouseEventArgs e)
        {
            FormNarudzbe NarudzbeForm = new FormNarudzbe();
            NarudzbeForm.MdiParent = this;
            NarudzbeForm.WindowState = FormWindowState.Maximized;
            NarudzbeForm.Show();
        }

        private void lijekoviToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            ReportLijekovi report = new ReportLijekovi();
            report.MdiParent = this;
            report.WindowState = FormWindowState.Maximized;
            report.Show();
        }

        private void aBCKlasifikacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dobavljačiToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            ReportDobavljaci report = new ReportDobavljaci();
            report.MdiParent = this;
            report.WindowState = FormWindowState.Maximized;
            report.Show();
        }

        private void kategorijeToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            ReportKategorije report = new ReportKategorije();
            report.MdiParent = this;
            report.WindowState = FormWindowState.Maximized;
            report.Show();
        }

        private void uputeZaKoristenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\Josip\\Documents\\Help\\help.chm"); 
        }

        private void FormAppoteka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, "file://C:\\Users\\Josip\\Documents\\Help\\help.chm"); 
            }
        }

        
    }
}
