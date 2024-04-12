using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox_e_radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxAssalto1.Visible = true;
            btnAssalto1.Visible = true;
            pictureBoxAssalto2.Visible = true;
            btnAssalto2.Visible = true;
            pictureBoxAssalto3.Visible = true;
            btnAssalto3.Visible = true;
        }

        private void btnEscopetas_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxEscopeta1.Visible = true;
            btnEscopeta1.Visible = true;
            pictureBoxEscopeta2.Visible = true;
            btnEscopeta2.Visible = true;
            pictureBoxEscopeta3.Visible = true;
            btnEscopeta3.Visible = true;
        }
    }
}
