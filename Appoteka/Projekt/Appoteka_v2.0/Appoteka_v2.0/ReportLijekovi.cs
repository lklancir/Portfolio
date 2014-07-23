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
    public partial class ReportLijekovi : Form
    {
        public ReportLijekovi()
        {
            InitializeComponent();
        }
        //kod učitavanja reporta, popunjava se viewer sa lijekovima
        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appotekaDBDataSet2.lijekovi' table. You can move, or remove it, as needed.
            this.lijekoviTableAdapter.Fill(this.appotekaDBDataSet2.lijekovi);

            this.reportViewer1.RefreshReport();
        }
    }
}
