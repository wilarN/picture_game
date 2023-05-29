using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BildSpel
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            // init 8
            InitializeComponent();
        }

        private void Nej1_Click(object sender, EventArgs e)
        {
            // nej
            this.Hide();

            new Form6().ShowDialog();
        }

        private void Ja1_Click(object sender, EventArgs e)
        {
            // ja
            this.Hide();

            new Form15().ShowDialog();
        }
    }
}
