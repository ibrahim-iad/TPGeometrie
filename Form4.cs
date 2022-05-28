using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4.modele;

namespace TP4
{
    public partial class Form4 : Form
    {
        private DataTable table;
        private List<Figure> figures;
    
        public Form4()
        {
            InitializeComponent();
            this.figures = new List<Figure>();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            DataColumn col0 = new DataColumn("Forme");
            DataColumn col1 = new DataColumn("Longueur/Rayon");
            DataColumn col2 = new DataColumn("Largeur");
            DataColumn col3 = new DataColumn("Surface");
            DataColumn col4 = new DataColumn("Perimetre");
            table.Columns.Add(col0);
            table.Columns.Add(col1);
            table.Columns.Add(col2);
            table.Columns.Add(col3);
            table.Columns.Add(col4);
            dgvFormes.DataSource = table;

        }

        private void btnAddForme_Click(object sender, EventArgs e)
        {
            Form frm = new Form3(this.figures);
            frm.ShowDialog(this);
            ////////////////////////////
            this.table.Rows.Clear();
            foreach (Figure f in this.figures)
            {
                DataRow dr = this.table.NewRow();
                if(f is Rectangle)
                {
                    Rectangle r = (Rectangle) f;
                    dr[0] = "Rectangle";
                    dr[1] = r.Longueur;
                    dr[2] = r.Largeur;
                }
                if(f is Cercle)
                {
                    Cercle c = (Cercle)f;
                    dr[0] = "Cercle";
                    dr[1] = c.Rayon;
                }

                dr[3] = f.Surface();
                dr[4] = f.Perimetre();
                this.table.Rows.Add(dr);
            }
        }
    }
}
