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

            cboConcepto.SelectedIndex = 0;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal importe = Convert.ToDecimal(txtImporte.Text);

                if (importe > 0)
                {
                    StreamWriter sw = new StreamWriter("Gastos.txt", true);
                    sw.Write(dtpFecha.Text + " ,");
                    sw.Write(cboConcepto.Text + " ,");
                    sw.WriteLine(txtImporte.Text + ".");
                    sw.Close();
                    sw.Dispose();

                    cboConcepto.SelectedIndex = 0;
                    txtImporte.Text = "";
                }
                else
                {
                    MessageBox.Show("Ingrese un valor mayor a 0", "ERROR");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique los datos ingresados", "ERROR");
            }
        }
    }
}
