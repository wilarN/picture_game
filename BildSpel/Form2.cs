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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form3().ShowDialog();
        }
    }
}
