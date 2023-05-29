using System;
using System.Windows.Forms;

namespace BildSpel
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            // init 10
            InitializeComponent();
        }

        private void Ja1_Click(object sender, EventArgs e)
        {
            // ja
            this.Hide();

            new Form12().ShowDialog();
        }

        private void Nej1_Click(object sender, EventArgs e)
        {
            // nej
            this.Hide();

            new Form11().ShowDialog();
        }
    }
}
