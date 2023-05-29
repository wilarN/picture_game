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
    public partial class Form13 : Form
    {
        public Form13()
        {
            // init 13
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

            new Form6().ShowDialog();
        }
    }
}
