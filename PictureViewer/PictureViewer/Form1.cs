using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class frmPictureViewer : Form
    {
        public frmPictureViewer()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnBackground_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void cbStretch_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
