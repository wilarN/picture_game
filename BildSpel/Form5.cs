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
    public partial class Form5 : Form
    {
        public Form5()
        {
            // init 5
            InitializeComponent();
        }

        private void Nej1_Click(object sender, EventArgs e)
        {
            //nej
            this.Hide();

            new Form8().ShowDialog();
        }

        private void Ja1_Click(object sender, EventArgs e)
        {
            //ja
            this.Hide();

            new Form7().ShowDialog();
        }
    }
}
