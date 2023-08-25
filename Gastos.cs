using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mis_Gastos
{
    public partial class frmGastos : Form
    {
        public frmGastos()
        {
            InitializeComponent();
        }

        private void frmGastos_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Categorias.txt");
            string Linea = "";
            while(sr.EndOfStream == false)
            {
                Linea = sr.ReadLine();
                cboConcepto.Items.Add(Linea);
            }
            sr.Close();
            sr.Dispose();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Gastos.txt", true);
            sw.Write(dtpFecha.Text + " ,");
            sw.Write(cboConcepto.Text + " ,");
            sw.WriteLine(txtImporte.Text + ".");
            sw.Close();
            sw.Dispose();
        }
    }
}
