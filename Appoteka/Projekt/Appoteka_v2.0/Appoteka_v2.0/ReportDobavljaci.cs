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
    public partial class ReportDobavljaci : Form
    {
        public ReportDobavljaci()
        {
            InitializeComponent();
        }

        //prilikom učitavanja reporta, popuni reportviewer s dobavljačima
        private void ReportDobavljaci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.dobavljaci' table. You can move, or remove it, as needed.
            this.dobavljaciTableAdapter.Fill(this.appotekaDBDataSet2.dobavljaci);
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.lijekovi' table. You can move, or remove it, as needed.
            this.lijekoviTableAdapter.Fill(this.appotekaDBDataSet2.lijekovi);
            this.dobavljaciTableAdapter1.Fill(this.appotekaDBDataSet2.dobavljaci);

            this.reportViewer1.RefreshReport();
        }
    }
}
