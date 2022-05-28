using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4.modele;

namespace TP4
{
    public partial class Form2 : Form
    {
        private List<Figure> figures;

        public Form2()
        {
            InitializeComponent();
            this.figures = new List<Figure>();
        }

        private void btnAddForme_Click(object sender, EventArgs e)
        {
            Form frm = new Form3(this.figures);
            frm.ShowDialog(this);
            //////////////////
            lstFormes.Items.Clear();
            foreach(Figure f in this.figures)
            {
                lstFormes.Items.Add(f);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
