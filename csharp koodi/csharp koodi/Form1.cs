using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_koodi
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void nappi1_Click(object sender, EventArgs e)
        {
            string etunimi = tekstilaatikko.Text;
            viesti.Text = "hei " + etunimi + " oikein hyvää viikkoa sinulle";
    }

        private void xxx_Load(object sender, EventArgs e)
        {

        }
    }
