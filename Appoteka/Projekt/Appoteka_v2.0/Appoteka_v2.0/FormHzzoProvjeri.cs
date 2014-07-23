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
    public partial class FormHzzoProvjeri : Form
    {
        public FormHzzoProvjeri()
        {
            InitializeComponent();
        }

        private void textSerijskiBroj_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void btnFormHzzoProvjeri_Click(object sender, EventArgs e)
        {
            string selektiraniBroj = textZdrastvena.Text;
            FormHzzoProvjeriBroj ProvjeriBrojForm = new FormHzzoProvjeriBroj(selektiraniBroj);
            ProvjeriBrojForm.ShowDialog();
        }

        private void textZdrastvena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string selektiraniBroj = textZdrastvena.Text;
                FormHzzoProvjeriBroj ProvjeriBrojForm = new FormHzzoProvjeriBroj(selektiraniBroj);
                ProvjeriBrojForm.ShowDialog();
            }
        }
    }
}
