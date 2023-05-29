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
    public partial class Form12 : Form
    {
        public Form12()
        {
            // init 12
            InitializeComponent();
        }

        private void Ja1_Click(object sender, EventArgs e)
        {
            // ja
            this.Hide();

            new Form15().ShowDialog();
        }

        private void Nej1_Click(object sender, EventArgs e)
        {
            // nej
            this.Hide();

            new Form13().ShowDialog();
        }
    }
}
